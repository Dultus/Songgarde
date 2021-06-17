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
    public partial class FRM_Setup : Form
    {
        public FRM_Setup()
        {
            InitializeComponent();
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            CFormBuilder.move(this, e);
        }

        private void BTN_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_Setup_Load(object sender, EventArgs e)
        {
            CFormBuilder.round(this);
        }
    }
}
