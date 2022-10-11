namespace Coffee
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSetting = new FontAwesome.Sharp.IconButton();
            this.btnAnalysis = new FontAwesome.Sharp.IconButton();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.btnSelling = new FontAwesome.Sharp.IconButton();
            this.btnHideShowMenu = new FontAwesome.Sharp.IconButton();
            this.timerMenu = new System.Windows.Forms.Timer(this.components);
            this.lbAccount = new System.Windows.Forms.Label();
            this.btnLogOut = new FontAwesome.Sharp.IconButton();
            this.btnMinized = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(23)))));
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Location = new System.Drawing.Point(0, 50);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1920, 980);
            this.panelDesktop.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Coffee.Properties.Resources.coffee_shop;
            this.pictureBox1.Location = new System.Drawing.Point(720, 367);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 245);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(23)))));
            this.panelMenu.Controls.Add(this.btnSetting);
            this.panelMenu.Controls.Add(this.btnAnalysis);
            this.panelMenu.Controls.Add(this.pbLogo);
            this.panelMenu.Controls.Add(this.btnMenu);
            this.panelMenu.Controls.Add(this.btnSelling);
            this.panelMenu.Controls.Add(this.btnHideShowMenu);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 1030);
            this.panelMenu.TabIndex = 14;
            // 
            // btnSetting
            // 
            this.btnSetting.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.btnSetting.IconColor = System.Drawing.Color.White;
            this.btnSetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSetting.IconSize = 40;
            this.btnSetting.Location = new System.Drawing.Point(0, 970);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(200, 60);
            this.btnSetting.TabIndex = 5;
            this.btnSetting.Text = "Setting";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnAnalysis
            // 
            this.btnAnalysis.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAnalysis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalysis.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalysis.ForeColor = System.Drawing.Color.White;
            this.btnAnalysis.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.btnAnalysis.IconColor = System.Drawing.Color.White;
            this.btnAnalysis.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAnalysis.IconSize = 40;
            this.btnAnalysis.Location = new System.Drawing.Point(0, 260);
            this.btnAnalysis.Name = "btnAnalysis";
            this.btnAnalysis.Size = new System.Drawing.Size(200, 60);
            this.btnAnalysis.TabIndex = 4;
            this.btnAnalysis.Text = "Analysis";
            this.btnAnalysis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnalysis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnalysis.UseVisualStyleBackColor = true;
            this.btnAnalysis.Click += new System.EventHandler(this.btnAnalysis_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::Coffee.Properties.Resources.coffee;
            this.pbLogo.Location = new System.Drawing.Point(50, 70);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(100, 100);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.ListCheck;
            this.btnMenu.IconColor = System.Drawing.Color.White;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.IconSize = 40;
            this.btnMenu.Location = new System.Drawing.Point(0, 320);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(200, 60);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "Menu";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnSelling
            // 
            this.btnSelling.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSelling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelling.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelling.ForeColor = System.Drawing.Color.White;
            this.btnSelling.IconChar = FontAwesome.Sharp.IconChar.Coffee;
            this.btnSelling.IconColor = System.Drawing.Color.White;
            this.btnSelling.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSelling.IconSize = 40;
            this.btnSelling.Location = new System.Drawing.Point(0, 200);
            this.btnSelling.Name = "btnSelling";
            this.btnSelling.Size = new System.Drawing.Size(200, 60);
            this.btnSelling.TabIndex = 1;
            this.btnSelling.Text = "Selling";
            this.btnSelling.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelling.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelling.UseVisualStyleBackColor = true;
            this.btnSelling.Click += new System.EventHandler(this.btnSelling_Click);
            // 
            // btnHideShowMenu
            // 
            this.btnHideShowMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHideShowMenu.FlatAppearance.BorderSize = 3;
            this.btnHideShowMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHideShowMenu.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            this.btnHideShowMenu.IconColor = System.Drawing.Color.White;
            this.btnHideShowMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHideShowMenu.IconSize = 40;
            this.btnHideShowMenu.Location = new System.Drawing.Point(0, 0);
            this.btnHideShowMenu.Name = "btnHideShowMenu";
            this.btnHideShowMenu.Size = new System.Drawing.Size(50, 50);
            this.btnHideShowMenu.TabIndex = 0;
            this.btnHideShowMenu.UseVisualStyleBackColor = true;
            this.btnHideShowMenu.Click += new System.EventHandler(this.btnHideShowMenu_Click);
            // 
            // timerMenu
            // 
            this.timerMenu.Interval = 1;
            this.timerMenu.Tick += new System.EventHandler(this.timerMenu_Tick);
            // 
            // lbAccount
            // 
            this.lbAccount.AutoSize = true;
            this.lbAccount.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccount.ForeColor = System.Drawing.Color.White;
            this.lbAccount.Location = new System.Drawing.Point(200, 15);
            this.lbAccount.Name = "lbAccount";
            this.lbAccount.Size = new System.Drawing.Size(103, 30);
            this.lbAccount.TabIndex = 15;
            this.lbAccount.Text = "Account: ";
            // 
            // btnLogOut
            // 
            this.btnLogOut.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.btnLogOut.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(23)))));
            this.btnLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogOut.IconSize = 40;
            this.btnLogOut.Location = new System.Drawing.Point(388, 0);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(50, 50);
            this.btnLogOut.TabIndex = 16;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnMinized
            // 
            this.btnMinized.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            this.btnMinized.IconColor = System.Drawing.Color.Black;
            this.btnMinized.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinized.IconSize = 40;
            this.btnMinized.Location = new System.Drawing.Point(1820, 0);
            this.btnMinized.Name = "btnMinized";
            this.btnMinized.Size = new System.Drawing.Size(50, 50);
            this.btnMinized.TabIndex = 12;
            this.btnMinized.UseVisualStyleBackColor = true;
            this.btnMinized.Click += new System.EventHandler(this.btnMinized_Click);
            // 
            // btnClose
            // 
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 40;
            this.btnClose.Location = new System.Drawing.Point(1870, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 11;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1920, 1030);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lbAccount);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.btnMinized);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnMinized;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btnHideShowMenu;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnSelling;
        private FontAwesome.Sharp.IconButton btnMenu;
        private System.Windows.Forms.Timer timerMenu;
        private System.Windows.Forms.PictureBox pbLogo;
        private FontAwesome.Sharp.IconButton btnAnalysis;
        private FontAwesome.Sharp.IconButton btnSetting;
        private System.Windows.Forms.Label lbAccount;
        private FontAwesome.Sharp.IconButton btnLogOut;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}