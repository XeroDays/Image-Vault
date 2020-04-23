namespace Image_Vault
{
    partial class Dashboard_Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.lblSoftwareTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLockImages = new System.Windows.Forms.Button();
            this.btnMyGallary = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnAboutUs = new System.Windows.Forms.Button();
            this.PanelDashboard = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.lblSoftwareTitle);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 34);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BorderLessForm_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Image = global::Image_Vault.Properties.Resources.icons8_close_window_30__1_;
            this.btnClose.Location = new System.Drawing.Point(715, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblSoftwareTitle
            // 
            this.lblSoftwareTitle.AutoSize = true;
            this.lblSoftwareTitle.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoftwareTitle.Location = new System.Drawing.Point(32, 5);
            this.lblSoftwareTitle.Name = "lblSoftwareTitle";
            this.lblSoftwareTitle.Size = new System.Drawing.Size(106, 23);
            this.lblSoftwareTitle.TabIndex = 1;
            this.lblSoftwareTitle.Text = "Image Vault";
            this.lblSoftwareTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BorderLessForm_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Image_Vault.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BorderLessForm_MouseDown);
            // 
            // btnLockImages
            // 
            this.btnLockImages.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnLockImages.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLockImages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLockImages.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLockImages.ForeColor = System.Drawing.Color.White;
            this.btnLockImages.Location = new System.Drawing.Point(4, 40);
            this.btnLockImages.Name = "btnLockImages";
            this.btnLockImages.Size = new System.Drawing.Size(162, 47);
            this.btnLockImages.TabIndex = 1;
            this.btnLockImages.Text = "Lock Images";
            this.btnLockImages.UseVisualStyleBackColor = false;
            this.btnLockImages.Click += new System.EventHandler(this.btnLockImages_Click);
            // 
            // btnMyGallary
            // 
            this.btnMyGallary.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnMyGallary.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMyGallary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyGallary.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyGallary.ForeColor = System.Drawing.Color.White;
            this.btnMyGallary.Location = new System.Drawing.Point(4, 93);
            this.btnMyGallary.Name = "btnMyGallary";
            this.btnMyGallary.Size = new System.Drawing.Size(162, 47);
            this.btnMyGallary.TabIndex = 1;
            this.btnMyGallary.Text = "My Gallary";
            this.btnMyGallary.UseVisualStyleBackColor = false;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(4, 146);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(162, 47);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAboutUs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutUs.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboutUs.ForeColor = System.Drawing.Color.White;
            this.btnAboutUs.Location = new System.Drawing.Point(4, 199);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.Size = new System.Drawing.Size(162, 47);
            this.btnAboutUs.TabIndex = 1;
            this.btnAboutUs.Text = "About Us";
            this.btnAboutUs.UseVisualStyleBackColor = false;
            this.btnAboutUs.Click += new System.EventHandler(this.btnAboutUs_Click);
            // 
            // PanelDashboard
            // 
            this.PanelDashboard.AllowDrop = true;
            this.PanelDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelDashboard.BackColor = System.Drawing.Color.Silver;
            this.PanelDashboard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelDashboard.Location = new System.Drawing.Point(172, 40);
            this.PanelDashboard.Name = "PanelDashboard";
            this.PanelDashboard.Size = new System.Drawing.Size(569, 410);
            this.PanelDashboard.TabIndex = 2;
            // 
            // Dashboard_Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 458);
            this.Controls.Add(this.PanelDashboard);
            this.Controls.Add(this.btnAboutUs);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnMyGallary);
            this.Controls.Add(this.btnLockImages);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard_Main";
            this.Text = "Image Vault";
            this.Load += new System.EventHandler(this.Dashboard_Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSoftwareTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Button btnLockImages;
        private System.Windows.Forms.Button btnMyGallary;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnAboutUs;
        private System.Windows.Forms.Panel PanelDashboard;
    }
}