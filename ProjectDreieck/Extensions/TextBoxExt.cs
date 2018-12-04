using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDreieck.Extensions
{
    public static class TextBoxExt
    {
        /// <summary>
        /// This verifies that there are more than just 0's and .'s in the text box,
        /// then attempts to parse what is left.
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns>true if a number is found</returns>
        public static bool ContainsNumber(this TextBox textBox)
        {
            string temp = textBox.Text;
            int result = 0;
            temp = temp.Replace(".", string.Empty);
            temp = temp.Replace("0", string.Empty);


            bool succeeded = int.TryParse(temp, out result);

            return (succeeded && result > 0);
        }
    }
}
