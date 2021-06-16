using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SONGGARDE
{
    public partial class FRM_Preview : Form
    {
        public enum eResolution
        {
            Normal = 0,
            Wide = 1
        };
        public eResolution m_eResolution;
        private bool mouseDown;
        private Point lastLocation;
        public FRM_Preview()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            //this.TopMost = true;
        }

        private void BTN_ClosePreview_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_Preview_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void FRM_Preview_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void FRM_Preview_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void FRM_Preview_Load(object sender, EventArgs e)
        {
            if (m_eResolution == eResolution.Normal)
            {
                this.Width = 900;
                this.Height = 506;
            }
            else if (m_eResolution == eResolution.Wide)
            {
                this.Width = 1181;
                this.Height = 506;
            }
        }
    }
}
