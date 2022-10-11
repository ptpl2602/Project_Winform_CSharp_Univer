namespace Coffee
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnMinized = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.btnClear = new FontAwesome.Sharp.IconButton();
            this.btnLogin = new FontAwesome.Sharp.IconButton();
            this.btnHideShow = new FontAwesome.Sharp.IconButton();
            this.pbPasswordIcon = new System.Windows.Forms.PictureBox();
            this.pbUsernameIcon = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPasswordIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsernameIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(190, 460);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(250, 60);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(190, 400);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(250, 60);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMinized
            // 
            this.btnMinized.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            this.btnMinized.IconColor = System.Drawing.Color.Black;
            this.btnMinized.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinized.IconSize = 35;
            this.btnMinized.Location = new System.Drawing.Point(520, 0);
            this.btnMinized.Name = "btnMinized";
            this.btnMinized.Size = new System.Drawing.Size(40, 40);
            this.btnMinized.TabIndex = 6;
            this.btnMinized.UseVisualStyleBackColor = true;
            this.btnMinized.Click += new System.EventHandler(this.btnMinized_Click);
            // 
            // btnClose
            // 
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 35;
            this.btnClose.Location = new System.Drawing.Point(560, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 7;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            this.btnClear.IconColor = System.Drawing.Color.Black;
            this.btnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClear.IconSize = 40;
            this.btnClear.Location = new System.Drawing.Point(335, 520);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(50, 50);
            this.btnClear.TabIndex = 3;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.btnLogin.IconColor = System.Drawing.Color.Black;
            this.btnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogin.IconSize = 40;
            this.btnLogin.Location = new System.Drawing.Point(390, 520);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(50, 50);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnHideShow
            // 
            this.btnHideShow.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnHideShow.IconColor = System.Drawing.Color.Black;
            this.btnHideShow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHideShow.IconSize = 40;
            this.btnHideShow.Location = new System.Drawing.Point(446, 470);
            this.btnHideShow.Name = "btnHideShow";
            this.btnHideShow.Size = new System.Drawing.Size(50, 50);
            this.btnHideShow.TabIndex = 5;
            this.btnHideShow.UseVisualStyleBackColor = true;
            this.btnHideShow.Click += new System.EventHandler(this.btnHideShow_Click);
            // 
            // pbPasswordIcon
            // 
            this.pbPasswordIcon.Image = global::Coffee.Properties.Resources.password;
            this.pbPasswordIcon.Location = new System.Drawing.Point(130, 460);
            this.pbPasswordIcon.Name = "pbPasswordIcon";
            this.pbPasswordIcon.Size = new System.Drawing.Size(50, 50);
            this.pbPasswordIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPasswordIcon.TabIndex = 4;
            this.pbPasswordIcon.TabStop = false;
            // 
            // pbUsernameIcon
            // 
            this.pbUsernameIcon.Image = global::Coffee.Properties.Resources.user;
            this.pbUsernameIcon.Location = new System.Drawing.Point(130, 400);
            this.pbUsernameIcon.Name = "pbUsernameIcon";
            this.pbUsernameIcon.Size = new System.Drawing.Size(50, 50);
            this.pbUsernameIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUsernameIcon.TabIndex = 3;
            this.pbUsernameIcon.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::Coffee.Properties.Resources.coffee;
            this.pbLogo.Location = new System.Drawing.Point(200, 180);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(200, 200);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(18)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(600, 800);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnMinized);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnHideShow);
            this.Controls.Add(this.pbPasswordIcon);
            this.Controls.Add(this.pbUsernameIcon);
            this.Controls.Add(this.pbLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pbPasswordIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsernameIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox pbUsernameIcon;
        private System.Windows.Forms.PictureBox pbPasswordIcon;
        private FontAwesome.Sharp.IconButton btnHideShow;
        private FontAwesome.Sharp.IconButton btnLogin;
        private FontAwesome.Sharp.IconButton btnClear;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnMinized;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
    }
}

