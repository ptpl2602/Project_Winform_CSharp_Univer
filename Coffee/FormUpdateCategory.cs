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
    public partial class FormUpdateCategory : Form
    {
        public FormUpdateCategory()
        {
            InitializeComponent();
        }

        public static string connectionString = "Data Source=DUSTYFATE;Initial Catalog=QuanLyCoffee;Integrated Security=True";

        public static string idCategory;
        public static string nameCategory;

        public void SetData()
        {
            idCategory = txtIDCategory.Text;
            nameCategory = txtCategory.Text;
        }

        public static void ClearData()
        {
            idCategory = "";
            nameCategory = "";
        }

        public static void ReceiveData(string idCategory_, string nameCategory_)
        {
            idCategory = idCategory_;
            nameCategory = nameCategory_;
        }

        public void SendData()
        {
            txtIDCategory.Text = idCategory;
            txtCategory.Text = nameCategory;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SetData();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "UpdateCategory";
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SendData();
        }
    }
}
