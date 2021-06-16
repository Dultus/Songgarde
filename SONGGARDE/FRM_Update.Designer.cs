namespace SONGGARDE
{
    partial class FRM_Update
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTN_No = new System.Windows.Forms.Button();
            this.BTN_Yes = new System.Windows.Forms.Button();
            this.CB_NeverAsk = new System.Windows.Forms.CheckBox();
            this.LBL_Update = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_No
            // 
            this.BTN_No.Location = new System.Drawing.Point(341, 146);
            this.BTN_No.Name = "BTN_No";
            this.BTN_No.Size = new System.Drawing.Size(75, 23);
            this.BTN_No.TabIndex = 0;
            this.BTN_No.Text = "No";
            this.BTN_No.UseVisualStyleBackColor = true;
            this.BTN_No.Click += new System.EventHandler(this.BTN_No_Click);
            // 
            // BTN_Yes
            // 
            this.BTN_Yes.Location = new System.Drawing.Point(260, 146);
            this.BTN_Yes.Name = "BTN_Yes";
            this.BTN_Yes.Size = new System.Drawing.Size(75, 23);
            this.BTN_Yes.TabIndex = 1;
            this.BTN_Yes.Text = "Yes";
            this.BTN_Yes.UseVisualStyleBackColor = true;
            this.BTN_Yes.Click += new System.EventHandler(this.BTN_Yes_Click);
            // 
            // CB_NeverAsk
            // 
            this.CB_NeverAsk.AutoSize = true;
            this.CB_NeverAsk.Location = new System.Drawing.Point(12, 117);
            this.CB_NeverAsk.Name = "CB_NeverAsk";
            this.CB_NeverAsk.Size = new System.Drawing.Size(117, 17);
            this.CB_NeverAsk.TabIndex = 2;
            this.CB_NeverAsk.Text = "Don\'t ask me again";
            this.CB_NeverAsk.UseVisualStyleBackColor = true;
            this.CB_NeverAsk.CheckedChanged += new System.EventHandler(this.CB_NeverAsk_CheckedChanged);
            // 
            // LBL_Update
            // 
            this.LBL_Update.AutoSize = true;
            this.LBL_Update.Location = new System.Drawing.Point(12, 9);
            this.LBL_Update.Name = "LBL_Update";
            this.LBL_Update.Size = new System.Drawing.Size(343, 65);
            this.LBL_Update.TabIndex = 3;
            this.LBL_Update.Text = "The version check revealed that you are still running on {0}, the current\r\nversio" +
    "n is {1}.\r\nWould you like to update?\r\n\r\n(Clicking yes opens the browser and open" +
    "s the mod page)";
            this.LBL_Update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FRM_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 178);
            this.Controls.Add(this.LBL_Update);
            this.Controls.Add(this.CB_NeverAsk);
            this.Controls.Add(this.BTN_Yes);
            this.Controls.Add(this.BTN_No);
            this.Name = "FRM_Update";
            this.Text = "FRM_Update";
            this.Load += new System.EventHandler(this.FRM_Update_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_No;
        private System.Windows.Forms.Button BTN_Yes;
        private System.Windows.Forms.CheckBox CB_NeverAsk;
        private System.Windows.Forms.Label LBL_Update;
    }
}