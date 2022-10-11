﻿using System;
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
    public partial class FormAddBeverage : Form
    {
        public FormAddBeverage()
        {
            InitializeComponent();
        }

        public static string connectionString = "Data Source=DESKTOP-RPEMCJS/SQLEXPRESS;Initial Catalog=QuanLyCoffee;Integrated Security=True";

        public static string id;
        public static string name;
        public static string idCategory;
        public static string size;
        public static string price;
        public static bool available;

        public void SetData()
        {
            id = txtID.Text;
            name = txtName.Text;
            idCategory = txtIDCategory.Text;
            size = cbSize.Text;
            price = txtPrice.Text;
            available = cbAvailable.Checked;
        }

        public static void ClearData()
        {
            id = "";
            name = "";
            idCategory = "";
            size = "";
            price = "";
            available = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SetData();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "AddBeverage";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@idBeverage", id);
            cmd.Parameters.AddWithValue("@nameBeverage", name);
            cmd.Parameters.AddWithValue("@idCategory", idCategory);
            cmd.Parameters.AddWithValue("@size", size);
            cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(price));
            cmd.Parameters.AddWithValue("@available", Convert.ToInt32(available));
            cmd.ExecuteNonQuery();
            conn.Close();
            ClearData();
            btnClear_Click(sender, e);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            txtIDCategory.Text = "";
            cbSize.SelectedIndex = -1;
            txtPrice.Text = "";
            cbAvailable.Checked = false;
        }
    }
}
