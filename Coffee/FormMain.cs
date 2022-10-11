using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee
{
    public partial class FormMain : Form
    {
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int LPAR);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;

        private void move_window(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public FormMain(DataTable infor)
        {
            InitializeComponent();

            this.MouseDown += new MouseEventHandler(move_window);

            lbAccount.Text += infor.Rows[0][3];
            if (!(bool)infor.Rows[0][2])
            {
                btnMenu.Visible = false;
            }
            status = (bool)infor.Rows[0][2];
        }

        public static bool status;

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        bool menuWidthExpand = true;
        private void timerMenu_Tick(object sender, EventArgs e)
        {
            if (menuWidthExpand)
            {
                panelMenu.Width -= 15;
                panelMenu.Height -= 98;
                lbAccount.Location = new Point(lbAccount.Location.X - 15, lbAccount.Location.Y);
                btnLogOut.Location = new Point(btnLogOut.Location.X - 15, btnLogOut.Location.Y);
                if (panelMenu.Width == 50 && panelMenu.Height == 50)
                {
                    menuWidthExpand = false;
                    timerMenu.Stop();
                }
                btnHideShowMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(40, 30, 23);
            }
            else
            {
                panelMenu.Width += 15;
                panelMenu.Height += 98;
                lbAccount.Location = new Point(lbAccount.Location.X + 15, lbAccount.Location.Y);
                btnLogOut.Location = new Point(btnLogOut.Location.X + 15, btnLogOut.Location.Y);
                if (panelMenu.Width == 200 && panelMenu.Height == 1030)
                {
                    menuWidthExpand = true;
                    timerMenu.Stop();
                }
                btnHideShowMenu.FlatAppearance.BorderColor = Color.White; 
            }
        }

        private void btnHideShowMenu_Click(object sender, EventArgs e)
        {
            timerMenu.Start();
        }

        private IconButton currentButton;
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (IconButton)btnSender)
                {
                    DisableButton();
                    currentButton = (IconButton)btnSender;
                    currentButton.ForeColor = Color.OrangeRed;
                    currentButton.IconColor = Color.OrangeRed;
                    currentButton.FlatAppearance.BorderColor = Color.OrangeRed;
                    currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                }
            }
        }

        private void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.ForeColor = Color.White;
                currentButton.IconColor = Color.White;
                currentButton.FlatAppearance.BorderColor = Color.White;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            }
        }

        private Form activeForm;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnSelling_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FormSelling());
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FormMenu());
        }

        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FormAnalysis());
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FormSetting());
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }
    }
}
