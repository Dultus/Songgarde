using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SONGGARDE
{
    public static class CFormBuilder
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );





        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        static extern bool ReleaseCapture();
        public static void move(Control form, MouseEventArgs mouseButton)
        {
            if (mouseButton.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(form.Handle, CFormBuilder.WM_NCLBUTTONDOWN, CFormBuilder.HT_CAPTION, 0);
            }
        }
        public static void round(Form form)
        {
            form.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, form.Width, form.Height, 20, 20));
        }

    }
}
