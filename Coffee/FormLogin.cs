using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee
{
    public partial class FormLogin : Form
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

        public FormLogin()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(move_window);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RPEMCJS/SQLEXPRESS;Initial Catalog=QuanLyCoffee;Integrated Security=True");

            string query = "SELECT * FROM Account WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text + "'";

            SqlDataAdapter sda = new SqlDataAdapter(query, conn);

            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                FormMain f = new FormMain(dataTable);
                f.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
            this.Hide();
        }

        private void btnHideShow_Click(object sender, EventArgs e)
        {
            if (btnHideShow.IconChar == FontAwesome.Sharp.IconChar.Eye)
            {
                txtPassword.UseSystemPasswordChar = false;
                btnHideShow.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
            else if (btnHideShow.IconChar == FontAwesome.Sharp.IconChar.EyeSlash)
            {
                txtPassword.UseSystemPasswordChar = true;
                btnHideShow.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void btnGuessUser_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
