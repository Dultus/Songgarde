namespace SONGGARDE
{
    partial class FRM_Preview
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
            this.BTN_ClosePreview = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_ClosePreview
            // 
            this.BTN_ClosePreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_ClosePreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTN_ClosePreview.FlatAppearance.BorderSize = 0;
            this.BTN_ClosePreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ClosePreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ClosePreview.ForeColor = System.Drawing.Color.White;
            this.BTN_ClosePreview.Location = new System.Drawing.Point(815, 12);
            this.BTN_ClosePreview.Name = "BTN_ClosePreview";
            this.BTN_ClosePreview.Size = new System.Drawing.Size(73, 44);
            this.BTN_ClosePreview.TabIndex = 0;
            this.BTN_ClosePreview.Text = "X";
            this.BTN_ClosePreview.UseVisualStyleBackColor = false;
            this.BTN_ClosePreview.Click += new System.EventHandler(this.BTN_ClosePreview_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::SONGGARDE.Properties.Resources.SkyrimSymbol;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(225, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 359);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FRM_Preview_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FRM_Preview_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FRM_Preview_MouseUp);
            // 
            // FRM_Preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 506);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTN_ClosePreview);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "FRM_Preview";
            this.Text = "FRM_Preview";
            this.Load += new System.EventHandler(this.FRM_Preview_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FRM_Preview_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FRM_Preview_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FRM_Preview_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_ClosePreview;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}