namespace Coffee
{
    partial class FormSetting
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtPasswordAdmin = new System.Windows.Forms.TextBox();
            this.txtUserAdmin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnShowPass = new FontAwesome.Sharp.IconButton();
            this.btnShowNewPass = new FontAwesome.Sharp.IconButton();
            this.btnShowConfirmPass = new FontAwesome.Sharp.IconButton();
            this.btnShowAdminPass = new FontAwesome.Sharp.IconButton();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(330, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(200, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(309, 45);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm password: ";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.btnShowAdminPass);
            this.panel.Controls.Add(this.btnEnter);
            this.panel.Controls.Add(this.txtPasswordAdmin);
            this.panel.Controls.Add(this.txtUserAdmin);
            this.panel.Controls.Add(this.label7);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.label4);
            this.panel.Location = new System.Drawing.Point(967, 140);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(700, 450);
            this.panel.TabIndex = 3;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(18)))), ((int)(((byte)(14)))));
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.ForeColor = System.Drawing.Color.White;
            this.btnEnter.Location = new System.Drawing.Point(310, 280);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(210, 77);
            this.btnEnter.TabIndex = 11;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtPasswordAdmin
            // 
            this.txtPasswordAdmin.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordAdmin.Location = new System.Drawing.Point(220, 200);
            this.txtPasswordAdmin.Name = "txtPasswordAdmin";
            this.txtPasswordAdmin.Size = new System.Drawing.Size(300, 51);
            this.txtPasswordAdmin.TabIndex = 7;
            this.txtPasswordAdmin.UseSystemPasswordChar = true;
            // 
            // txtUserAdmin
            // 
            this.txtUserAdmin.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserAdmin.Location = new System.Drawing.Point(220, 125);
            this.txtUserAdmin.Name = "txtUserAdmin";
            this.txtUserAdmin.Size = new System.Drawing.Size(300, 51);
            this.txtUserAdmin.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(639, 45);
            this.label7.TabIndex = 5;
            this.label7.Text = "Enter password to confirm you are admin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 45);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 45);
            this.label4.TabIndex = 4;
            this.label4.Text = "Username: ";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(565, 140);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(300, 51);
            this.txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(565, 215);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(300, 51);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(565, 405);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(300, 51);
            this.txtConfirmPassword.TabIndex = 7;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(255, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(256, 45);
            this.label6.TabIndex = 7;
            this.label6.Text = "New password: ";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(565, 310);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(300, 51);
            this.txtNewPassword.TabIndex = 6;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(18)))), ((int)(((byte)(14)))));
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(656, 513);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(210, 77);
            this.btnConfirm.TabIndex = 9;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(18)))), ((int)(((byte)(14)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(441, 513);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(210, 77);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnShowPass
            // 
            this.btnShowPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(18)))), ((int)(((byte)(14)))));
            this.btnShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPass.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnShowPass.IconColor = System.Drawing.Color.White;
            this.btnShowPass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnShowPass.IconSize = 40;
            this.btnShowPass.Location = new System.Drawing.Point(870, 215);
            this.btnShowPass.Name = "btnShowPass";
            this.btnShowPass.Size = new System.Drawing.Size(50, 50);
            this.btnShowPass.TabIndex = 11;
            this.btnShowPass.UseVisualStyleBackColor = false;
            this.btnShowPass.Click += new System.EventHandler(this.btnShowPass_Click);
            // 
            // btnShowNewPass
            // 
            this.btnShowNewPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(18)))), ((int)(((byte)(14)))));
            this.btnShowNewPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowNewPass.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnShowNewPass.IconColor = System.Drawing.Color.White;
            this.btnShowNewPass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnShowNewPass.IconSize = 40;
            this.btnShowNewPass.Location = new System.Drawing.Point(870, 310);
            this.btnShowNewPass.Name = "btnShowNewPass";
            this.btnShowNewPass.Size = new System.Drawing.Size(50, 50);
            this.btnShowNewPass.TabIndex = 12;
            this.btnShowNewPass.UseVisualStyleBackColor = false;
            this.btnShowNewPass.Click += new System.EventHandler(this.btnShowNewPass_Click);
            // 
            // btnShowConfirmPass
            // 
            this.btnShowConfirmPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(18)))), ((int)(((byte)(14)))));
            this.btnShowConfirmPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowConfirmPass.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnShowConfirmPass.IconColor = System.Drawing.Color.White;
            this.btnShowConfirmPass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnShowConfirmPass.IconSize = 40;
            this.btnShowConfirmPass.Location = new System.Drawing.Point(870, 405);
            this.btnShowConfirmPass.Name = "btnShowConfirmPass";
            this.btnShowConfirmPass.Size = new System.Drawing.Size(50, 50);
            this.btnShowConfirmPass.TabIndex = 13;
            this.btnShowConfirmPass.UseVisualStyleBackColor = false;
            this.btnShowConfirmPass.Click += new System.EventHandler(this.btnShowConfirmPass_Click);
            // 
            // btnShowAdminPass
            // 
            this.btnShowAdminPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(18)))), ((int)(((byte)(14)))));
            this.btnShowAdminPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAdminPass.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnShowAdminPass.IconColor = System.Drawing.Color.White;
            this.btnShowAdminPass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnShowAdminPass.IconSize = 40;
            this.btnShowAdminPass.Location = new System.Drawing.Point(525, 200);
            this.btnShowAdminPass.Name = "btnShowAdminPass";
            this.btnShowAdminPass.Size = new System.Drawing.Size(50, 50);
            this.btnShowAdminPass.TabIndex = 14;
            this.btnShowAdminPass.UseVisualStyleBackColor = false;
            this.btnShowAdminPass.Click += new System.EventHandler(this.btnShowAdminPass_Click);
            // 
            // FormSetting
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1920, 980);
            this.Controls.Add(this.btnShowConfirmPass);
            this.Controls.Add(this.btnShowNewPass);
            this.Controls.Add(this.btnShowPass);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSetting";
            this.Text = "FormSetting";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPasswordAdmin;
        private System.Windows.Forms.TextBox txtUserAdmin;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEnter;
        private FontAwesome.Sharp.IconButton btnShowPass;
        private FontAwesome.Sharp.IconButton btnShowNewPass;
        private FontAwesome.Sharp.IconButton btnShowConfirmPass;
        private FontAwesome.Sharp.IconButton btnShowAdminPass;
    }
}