using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassCreater
{
    public class ErrorHandler
    {
        public bool hasBlankTb(Control c)
        {
            //Get all Textboxes
            IEnumerable<TextBox> textBoxes = c.Controls.OfType<TextBox>();

            //Loop through textBoxes
            foreach(TextBox tb in textBoxes)
            {
                if(tb.Text == "")
                {
                    return true;
                }
            }

            return false;
        }
        public bool hasBlankTb(Panel pnl)
        {
            //Get all Textboxes
            IEnumerable<TextBox> textBoxes = pnl.Controls.OfType<TextBox>();

            //Loop through textBoxes
            foreach (TextBox tb in textBoxes)
            {
                if (tb.Text == "")
                {
                    return true;
                }
            }

            return false;
        }

        public void createTbError(string message)
        {
            MessageBox.Show(message, "EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
