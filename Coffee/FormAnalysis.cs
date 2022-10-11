using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee
{
    public partial class FormAnalysis : Form
    {
        public FormAnalysis()
        {
            InitializeComponent();
            GetData();
            dtgvBill.ClearSelection();
            cbSelectTime.Visible = false;
            if(FormMain.status)
            {
                cbSelectTime.Visible = true;
            }
        }

        string connectionString = "Data Source=DESKTOP-RPEMCJS/SQLEXPRESS;Initial Catalog=QuanLyCoffee;Integrated Security=True";

        decimal total = 0m;
        private void GetData()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "BillToday";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            string day = DateTime.Now.ToString("yyyy-MM-dd");
            cmd.Parameters.AddWithValue("@day", day);
            var dataReader = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dataReader);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dtgvBill.Rows.Add(
                    dt.Rows[i][0],
                    dt.Rows[i][1],
                    dt.Rows[i][2].ToString(),
                    TextMoney(MoneyFormat(dt.Rows[i][3].ToString())),
                    TextMoney(MoneyFormat(dt.Rows[i][4].ToString()))
                    );
                total += Convert.ToDecimal(MoneyFormat(dt.Rows[i][4].ToString()));
            }
            lbTotal.Text += TextMoney(total.ToString());
            total = 0m;
            conn.Close();
        }

        private string TextMoney(string text)
        {
            for (int j = text.Length - 3; j >= 1; j -= 3)
            {
                text = text.Insert(j, ",");
            }
            return text;
        }

        private string MoneyFormat(string text)
        {
            char[] chars = text.ToCharArray();
            string money = "";
            for(int i=0; i<=text.Length - 6; i++)
            {
                money += chars[i];
            }
            return money;
        }

        private void dtgvBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgvBillInfo.Rows.Clear();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "ShowBillInfo";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            int id = Convert.ToInt32(dtgvBill.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
            cmd.Parameters.AddWithValue("@id", id);
            var dataReader = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dataReader);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dtgvBillInfo.Rows.Add(
                    dt.Rows[i][0],
                    dt.Rows[i][1],
                    TextMoney(MoneyFormat(dt.Rows[i][2].ToString())),
                    dt.Rows[i][3]
                    );
            }
            conn.Close();
            dtgvBillInfo.ClearSelection();
        }

        private void cbSelectTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            int time = 0;
            if (cbSelectTime.SelectedIndex == 0)
                time = 0;
            else if (cbSelectTime.SelectedIndex == 1)
                time = -6;
            else if (cbSelectTime.SelectedIndex == 2)
                time = -29;

            dtgvBill.Rows.Clear();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "BillInTime";
            string day = DateTime.Now.ToString("yyyy-MM-dd");
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@time", time);
            cmd.Parameters.AddWithValue("@date", day);
            var dataReader = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dataReader);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dtgvBill.Rows.Add(
                    dt.Rows[i][0],
                    dt.Rows[i][1],
                    dt.Rows[i][2].ToString(),
                    TextMoney(MoneyFormat(dt.Rows[i][3].ToString())),
                    TextMoney(MoneyFormat(dt.Rows[i][4].ToString()))
                    );
                total += Convert.ToDecimal(MoneyFormat(dt.Rows[i][4].ToString()));
            }
            lbTotal.Text = "Total money: ";
            lbTotal.Text += TextMoney(total.ToString());
            total = 0;
            conn.Close();
        }

        private void dtgvBillInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
