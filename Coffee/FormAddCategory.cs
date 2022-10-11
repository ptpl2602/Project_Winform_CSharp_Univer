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
    public partial class FormAddCategory : Form
    {
        public FormAddCategory()
        {
            InitializeComponent();
        }

        public static string connectionString = "Data Source=DESKTOP-RPEMCJS/SQLEXPRESS;Initial Catalog=QuanLyCoffee;Integrated Security=True";

        public static string idCategory;
        public static string nameCategory;

        public void SetData()
        {
            idCategory = txtIDCategory.Text;
            nameCategory = txtCategory.Text;
        }

        public void ClearData()
        {
            idCategory = "";
            nameCategory = "";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SetData();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "AddCategory";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", idCategory);
            cmd.Parameters.AddWithValue("@name", nameCategory);
            cmd.ExecuteNonQuery();
            conn.Close();
            ClearData();
            btnClear_Click(sender, e);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtIDCategory.Text = "";
            txtCategory.Text = "";
        }
    }
}
