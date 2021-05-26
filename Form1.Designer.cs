namespace ManksEncrypter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitle = new System.Windows.Forms.Label();
            this.chkboxEncrypt = new System.Windows.Forms.CheckBox();
            this.chkboxDecrypt = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblFileLocation = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPanelPassword = new System.Windows.Forms.Button();
            this.btnPanelEncrypter = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPanelWebsite = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(493, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(171, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "File Encrypter";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // chkboxEncrypt
            // 
            this.chkboxEncrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.chkboxEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkboxEncrypt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxEncrypt.ForeColor = System.Drawing.Color.White;
            this.chkboxEncrypt.Image = ((System.Drawing.Image)(resources.GetObject("chkboxEncrypt.Image")));
            this.chkboxEncrypt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkboxEncrypt.Location = new System.Drawing.Point(430, 63);
            this.chkboxEncrypt.Name = "chkboxEncrypt";
            this.chkboxEncrypt.Size = new System.Drawing.Size(164, 38);
            this.chkboxEncrypt.TabIndex = 1;
            this.chkboxEncrypt.Text = "Encrypt";
            this.chkboxEncrypt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkboxEncrypt.UseVisualStyleBackColor = false;
            // 
            // chkboxDecrypt
            // 
            this.chkboxDecrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.chkboxDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkboxDecrypt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxDecrypt.ForeColor = System.Drawing.Color.White;
            this.chkboxDecrypt.Image = ((System.Drawing.Image)(resources.GetObject("chkboxDecrypt.Image")));
            this.chkboxDecrypt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkboxDecrypt.Location = new System.Drawing.Point(600, 63);
            this.chkboxDecrypt.Name = "chkboxDecrypt";
            this.chkboxDecrypt.Size = new System.Drawing.Size(164, 38);
            this.chkboxDecrypt.TabIndex = 2;
            this.chkboxDecrypt.Text = "Decrypt";
            this.chkboxDecrypt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkboxDecrypt.UseVisualStyleBackColor = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(510, 230);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(121, 36);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(498, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "Browse Files";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblFileLocation
            // 
            this.lblFileLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFileLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.lblFileLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFileLocation.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileLocation.ForeColor = System.Drawing.Color.White;
            this.lblFileLocation.Image = ((System.Drawing.Image)(resources.GetObject("lblFileLocation.Image")));
            this.lblFileLocation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFileLocation.Location = new System.Drawing.Point(494, 170);
            this.lblFileLocation.Name = "lblFileLocation";
            this.lblFileLocation.Size = new System.Drawing.Size(464, 33);
            this.lblFileLocation.TabIndex = 8;
            this.lblFileLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.panel1.Controls.Add(this.btnPanelPassword);
            this.panel1.Controls.Add(this.btnPanelEncrypter);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 537);
            this.panel1.TabIndex = 9;
            // 
            // btnPanelPassword
            // 
            this.btnPanelPassword.FlatAppearance.BorderSize = 0;
            this.btnPanelPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPanelPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPanelPassword.ForeColor = System.Drawing.Color.White;
            this.btnPanelPassword.Image = ((System.Drawing.Image)(resources.GetObject("btnPanelPassword.Image")));
            this.btnPanelPassword.Location = new System.Drawing.Point(0, 174);
            this.btnPanelPassword.Name = "btnPanelPassword";
            this.btnPanelPassword.Size = new System.Drawing.Size(181, 76);
            this.btnPanelPassword.TabIndex = 12;
            this.btnPanelPassword.Text = "Passwords";
            this.btnPanelPassword.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPanelPassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPanelPassword.UseVisualStyleBackColor = true;
            this.btnPanelPassword.Click += new System.EventHandler(this.btnPanelPassword_Click);
            // 
            // btnPanelEncrypter
            // 
            this.btnPanelEncrypter.FlatAppearance.BorderSize = 0;
            this.btnPanelEncrypter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPanelEncrypter.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPanelEncrypter.ForeColor = System.Drawing.Color.White;
            this.btnPanelEncrypter.Image = ((System.Drawing.Image)(resources.GetObject("btnPanelEncrypter.Image")));
            this.btnPanelEncrypter.Location = new System.Drawing.Point(0, 88);
            this.btnPanelEncrypter.Name = "btnPanelEncrypter";
            this.btnPanelEncrypter.Size = new System.Drawing.Size(181, 79);
            this.btnPanelEncrypter.TabIndex = 11;
            this.btnPanelEncrypter.Text = "Encrypter";
            this.btnPanelEncrypter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPanelEncrypter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPanelEncrypter.UseVisualStyleBackColor = true;
            this.btnPanelEncrypter.Click += new System.EventHandler(this.btnPanelEncrypter_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.panel2.Controls.Add(this.btnPanelWebsite);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(181, 86);
            this.panel2.TabIndex = 10;
            // 
            // btnPanelWebsite
            // 
            this.btnPanelWebsite.FlatAppearance.BorderSize = 0;
            this.btnPanelWebsite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPanelWebsite.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPanelWebsite.ForeColor = System.Drawing.Color.White;
            this.btnPanelWebsite.Image = ((System.Drawing.Image)(resources.GetObject("btnPanelWebsite.Image")));
            this.btnPanelWebsite.Location = new System.Drawing.Point(3, 3);
            this.btnPanelWebsite.Name = "btnPanelWebsite";
            this.btnPanelWebsite.Size = new System.Drawing.Size(178, 83);
            this.btnPanelWebsite.TabIndex = 13;
            this.btnPanelWebsite.Text = "Mank.Club";
            this.btnPanelWebsite.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPanelWebsite.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPanelWebsite.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1090, 537);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblFileLocation);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.chkboxDecrypt);
            this.Controls.Add(this.chkboxEncrypt);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Name = "Form1";
            this.Text = "Mank\'s Security";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.CheckBox chkboxEncrypt;
        private System.Windows.Forms.CheckBox chkboxDecrypt;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblFileLocation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPanelPassword;
        private System.Windows.Forms.Button btnPanelEncrypter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPanelWebsite;
    }
}

