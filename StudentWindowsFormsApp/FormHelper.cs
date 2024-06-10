using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentWindowsFormsApp
{
    internal class FormHelper
    {
        public static void CenterForm(Form form)
        {
            Rectangle screenBounds = Screen.PrimaryScreen.WorkingArea;

            int x = (screenBounds.Width - form.Width) / 2;
            int y = (screenBounds.Height - form.Height) / 2;

            form.Location = new Point(x, y);
        }
    }
}
