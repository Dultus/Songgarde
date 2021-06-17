namespace SONGGARDE
{
    partial class FRM_Setup
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
            this.components = new System.ComponentModel.Container();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.PNL_TopWindow = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.LBL_Titlebar = new System.Windows.Forms.Label();
            this.PB_Icon = new System.Windows.Forms.PictureBox();
            this.BTN_Close = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PNL_TopWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            // 
            // PNL_TopWindow
            // 
            this.PNL_TopWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.PNL_TopWindow.Controls.Add(this.guna2Button1);
            this.PNL_TopWindow.Controls.Add(this.LBL_Titlebar);
            this.PNL_TopWindow.Controls.Add(this.PB_Icon);
            this.PNL_TopWindow.Controls.Add(this.BTN_Close);
            this.PNL_TopWindow.Controls.Add(this.pictureBox2);
            this.PNL_TopWindow.Dock = System.Windows.Forms.DockStyle.Top;
            this.PNL_TopWindow.Location = new System.Drawing.Point(0, 0);
            this.PNL_TopWindow.Name = "PNL_TopWindow";
            this.PNL_TopWindow.Size = new System.Drawing.Size(800, 34);
            this.PNL_TopWindow.TabIndex = 38;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 13;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.Blue;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(733, 3);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(29, 29);
            this.guna2Button1.TabIndex = 34;
            this.guna2Button1.Text = "?";
            this.guna2Button1.UseTransparentBackground = true;
            // 
            // LBL_Titlebar
            // 
            this.LBL_Titlebar.AutoSize = true;
            this.LBL_Titlebar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Titlebar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.LBL_Titlebar.Location = new System.Drawing.Point(33, 8);
            this.LBL_Titlebar.Name = "LBL_Titlebar";
            this.LBL_Titlebar.Size = new System.Drawing.Size(115, 20);
            this.LBL_Titlebar.TabIndex = 33;
            this.LBL_Titlebar.Text = "SONGGARDE";
            // 
            // PB_Icon
            // 
            this.PB_Icon.BackColor = System.Drawing.Color.Transparent;
            this.PB_Icon.BackgroundImage = global::SONGGARDE.Properties.Resources.SONGGARDE;
            this.PB_Icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PB_Icon.Location = new System.Drawing.Point(2, 2);
            this.PB_Icon.Margin = new System.Windows.Forms.Padding(10);
            this.PB_Icon.Name = "PB_Icon";
            this.PB_Icon.Padding = new System.Windows.Forms.Padding(10);
            this.PB_Icon.Size = new System.Drawing.Size(30, 30);
            this.PB_Icon.TabIndex = 32;
            this.PB_Icon.TabStop = false;
            // 
            // BTN_Close
            // 
            this.BTN_Close.Animated = true;
            this.BTN_Close.AutoRoundedCorners = true;
            this.BTN_Close.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Close.BorderRadius = 13;
            this.BTN_Close.CheckedState.Parent = this.BTN_Close;
            this.BTN_Close.CustomImages.Parent = this.BTN_Close;
            this.BTN_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Close.DisabledState.Parent = this.BTN_Close;
            this.BTN_Close.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.BTN_Close.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTN_Close.HoverState.Parent = this.BTN_Close;
            this.BTN_Close.Location = new System.Drawing.Point(768, 3);
            this.BTN_Close.Name = "BTN_Close";
            this.BTN_Close.ShadowDecoration.Parent = this.BTN_Close;
            this.BTN_Close.Size = new System.Drawing.Size(29, 29);
            this.BTN_Close.TabIndex = 31;
            this.BTN_Close.Text = "X";
            this.BTN_Close.UseTransparentBackground = true;
            this.BTN_Close.Click += new System.EventHandler(this.BTN_Close_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::SONGGARDE.Properties.Resources.SONGGARDE_Image_SchwungObenLang;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(190, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(610, 34);
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(25)))));
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 10);
            this.panel1.TabIndex = 39;
            // 
            // FRM_Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_Close;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PNL_TopWindow);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Setup";
            this.Text = "FRM_Setup";
            this.Load += new System.EventHandler(this.FRM_Setup_Load);
            this.PNL_TopWindow.ResumeLayout(false);
            this.PNL_TopWindow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Panel PNL_TopWindow;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label LBL_Titlebar;
        private System.Windows.Forms.PictureBox PB_Icon;
        private Guna.UI2.WinForms.Guna2Button BTN_Close;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
    }
}