using System.ComponentModel;
using System.Windows.Forms;
using DreieckController;
using ProjectDreieck.Extensions;

namespace ProjectDreieck
{
    public partial class Triangulator : Form
    {
        private BackgroundWorker updateDescriptionBackgroundWorker;

        public Triangulator()
        {
            InitializeComponent();
            InitializeDescriptionBackgroundWorker();
        }

        private void InitializeDescriptionBackgroundWorker()
        {
            updateDescriptionBackgroundWorker.DoWork +=
                new DoWorkEventHandler(UpdateDescriptionBackgroundWorker_DoWork);
            updateDescriptionBackgroundWorker.RunWorkerCompleted +=
                new RunWorkerCompletedEventHandler(UpdateDescriptionBackgroundWorker_RunWorkerComplete);
        }

        private void AcceptOnlyNumbers(object sender, KeyPressEventArgs e)
        {
            int keyVal = e.KeyChar;
            
            bool hasDecimal = ((TextBox)sender).Text.Contains(".");
            if ((keyVal < 46 || keyVal > 57 || keyVal == 47 || (keyVal == 46 && hasDecimal)) && keyVal != 8) // Check for number bar keys
            {
                e.Handled = true;
            }
        }

        private string GetTriangleDescription(int[] sides)
        {
            Client dreieckController = new Client();

            return dreieckController.GetTriangleDescription(sides);
        }

        private void UpdateDescriptionBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int[] sides = (int[])e.Argument;

            e.Result = GetTriangleDescription(sides);
        }

        private void UpdateDescriptionBackgroundWorker_RunWorkerComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            description.Text = "These side lengths produce " + (string)e.Result;
        }

        private void OnTextChanged(object sender, System.EventArgs e)
        {
            if (sideABox.ContainsNumber() && sideBBox.ContainsNumber() && sideCBox.ContainsNumber() && !updateDescriptionBackgroundWorker.IsBusy)
                updateDescriptionBackgroundWorker.RunWorkerAsync(argument: new int[] {
                    int.Parse(sideABox.Text),
                    int.Parse(sideBBox.Text),
                    int.Parse(sideCBox.Text)
                });

            else description.Text = "Please submit lengths for the sides of a triangle.";
        }
    }
}
