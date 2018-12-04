using System.Windows.Forms;

namespace ProjectDreieck
{
    public partial class Triangulator : Form
    {
        public Triangulator()
        {
            InitializeComponent();
        }

        private void acceptOnlyNumbers(object sender, KeyPressEventArgs e)
        {
            int keyVal = e.KeyChar;
            
            bool hasDecimal = ((TextBox)sender).Text.Contains(".");
            if ((keyVal < 46 || keyVal > 57 || keyVal == 47 || (keyVal == 46 && hasDecimal)) && keyVal != 8) // Check for number bar keys
            {
                e.Handled = true;
            }
        }
    }
}
