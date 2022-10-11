using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee
{
    public partial class FormSetting : Form
    {
        public FormSetting()
        {
            InitializeComponent();

            panel.Visible = false;
        }

        string connectionString = "Data Source=DESKTOP-RPEMCJS/SQLEXPRESS;Initial Catalog=QuanLyCoffee;Integrated Security=True";

        private bool CheckInfo()
        {
            if (txtUsername.Text == "")
                return false;
            else if (txtPassword.Text == "")
                return false;
            else if (txtNewPassword.Text == "")
                return false;
            else if (txtConfirmPassword.Text == "")
                return false;
            return true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(CheckInfo())
            {
                if(txtConfirmPassword.Text != txtNewPassword.Text)
                {
                    MessageBox.Show("New password and Confirm password are not the same", "Note", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    panel.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Lack of information", "Note", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtNewPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtUserAdmin.Text = "";
            txtPasswordAdmin.Text = "";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "AdminConfirm";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@username", txtUserAdmin.Text);
            cmd.Parameters.AddWithValue("@password", txtPasswordAdmin.Text);
            var dataReader = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dataReader);
            if(dt.Rows.Count > 0)
            {
                ChangePassword();
            }
            else
            {
                MessageBox.Show("You're not admin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            conn.Close();

            btnClear_Click(sender, e);
        }

        private void ChangePassword()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "ChangePassword";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@username", txtUsername.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
            cmd.Parameters.AddWithValue("@newPassword", txtNewPassword.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            ShowHidePassword(sender, e, txtPassword);
        }

        private void btnShowNewPass_Click(object sender, EventArgs e)
        {
            ShowHidePassword(sender, e, txtNewPassword);
        }

        private void btnShowConfirmPass_Click(object sender, EventArgs e)
        {
            ShowHidePassword(sender, e, txtConfirmPassword);
        }

        private void btnShowAdminPass_Click(object sender, EventArgs e)
        {
            ShowHidePassword(sender, e, txtPasswordAdmin);
        }

        private void ShowHidePassword(object sender, EventArgs e, TextBox tb)
        {
            IconButton a = (IconButton)sender;
            if(a.IconChar == IconChar.Eye)
            {
                a.IconChar = IconChar.EyeSlash;
                tb.UseSystemPasswordChar = false;
            }
            else if(a.IconChar == IconChar.EyeSlash)
            {
                a.IconChar = IconChar.Eye;
                tb.UseSystemPasswordChar = true;
            }
        }
    }
}
