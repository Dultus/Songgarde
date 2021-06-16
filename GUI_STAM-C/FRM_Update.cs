using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_STAM_C
{
    public partial class FRM_Update : Form
    {
        public string sVersion, sOnlineVersion;
        public FRM_Update()
        {
            InitializeComponent();
        }

        private void FRM_Update_Load(object sender, EventArgs e)
        {
            LBL_Update.Text = String.Format(LBL_Update.Text, sVersion, sOnlineVersion);
            FRM_Main.m_Settings.NoReminder = CB_NeverAsk.Checked;
        }

        private void BTN_No_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CB_NeverAsk_CheckedChanged(object sender, EventArgs e)
        {
            FRM_Main.bCloseAfterYes = false;
            FRM_Main.m_Settings.NoReminder = CB_NeverAsk.Checked;
            FRM_Main.m_Settings.NoReminderVersion = sVersion;
        }

        private void BTN_Yes_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.nexusmods.com/skyrimspecialedition/mods/41782");
            FRM_Main.bCloseAfterYes = true;
            this.Close();
        }
    }
}
