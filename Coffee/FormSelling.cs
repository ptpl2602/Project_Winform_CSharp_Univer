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
    public partial class FormSelling : Form
    {
        public FormSelling()
        {
            InitializeComponent();
            FillData();

            string date = DateTime.UtcNow.ToString("f");
        }

        string connectionString = @"Data Source=DESKTOP-RPEMCJS\SQLEXPRESS;Initial Catalog=QuanLyCoffee;Integrated Security=True";

        private void FillData()
        {
            dtgvMenu.Rows.Clear();
            DataTable data = GetData();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                dtgvMenu.Rows.Add(data.Rows[i][0], data.Rows[i][1], data.Rows[i][3], data.Rows[i][4]);
            }
            DataGridViewButtonColumn btnAdd = new DataGridViewButtonColumn();
            btnAdd.Text = "Thêm";
            btnAdd.Width = 125;
            btnAdd.UseColumnTextForButtonValue = true;
            dtgvMenu.Columns.Add(btnAdd);
            for (int i = 0; i <= dtgvMenu.Rows.Count - 1; i++)
            {
                dtgvMenu.Rows[i].Cells[4].Value = "0";
            }
            DataGridViewButtonColumn btnRemove = new DataGridViewButtonColumn();
            btnRemove.Text = "Xoá";
            btnRemove.Width = 125;
            btnRemove.UseColumnTextForButtonValue = true;
            dtgvMenu.Columns.Add(btnRemove);

            dtgvMenu.ClearSelection();
        }

        DataTable GetData()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "SELECT * FROM Beverage WHERE available = 1";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable data = new DataTable();
            sda.Fill(data);
            conn.Close();
            return data;
        }

        private void dtgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgvMenu.CurrentRow.Selected = true;
            if (e.ColumnIndex == 5)
            {
                int amount;
                amount = int.Parse(dtgvMenu.Rows[e.RowIndex].Cells[4].FormattedValue.ToString());
                amount++;
                dtgvMenu.Rows[e.RowIndex].Cells[4].Value = amount.ToString();
            }
            if (e.ColumnIndex == 6)
            {
                int amount;
                amount = int.Parse(dtgvMenu.Rows[e.RowIndex].Cells[4].FormattedValue.ToString());
                if (amount > 0)
                {
                    amount--;
                    dtgvMenu.Rows[e.RowIndex].Cells[4].Value = amount.ToString();
                }
            }
        }

        private void CheckCard()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "SELECT * FROM Card WHERE status = 0";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable data = new DataTable();
            sda.Fill(data);
            cbCard.Items.Clear();
            for(int i = 0; i < data.Rows.Count; i++)
            {
                cbCard.Items.Add(data.Rows[i][0].ToString());
            }
            conn.Close();
        }

        private decimal total = 0m, changeMoney = 0m, eachMoney = 0m;
        string money, change;
        private void btnAddBill_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtgvMenu.Rows.Count; i++)
            {
                eachMoney += Convert.ToDecimal(dtgvMenu.Rows[i].Cells[3].FormattedValue.ToString()) * Convert.ToDecimal(dtgvMenu.Rows[i].Cells[4].FormattedValue.ToString());
                if (dtgvMenu.Rows[i].Cells[4].FormattedValue.ToString() != "0")
                {
                    dtgvMiniMenu.Rows.Add(
                        dtgvMenu.Rows[i].Cells[0].FormattedValue.ToString(),
                        dtgvMenu.Rows[i].Cells[1].FormattedValue.ToString(),
                        dtgvMenu.Rows[i].Cells[2].FormattedValue.ToString(),
                        dtgvMenu.Rows[i].Cells[4].FormattedValue.ToString(),
                        eachMoney.ToString()
                        );
                    total += Convert.ToDecimal(dtgvMenu.Rows[i].Cells[3].FormattedValue.ToString()) * Convert.ToDecimal(dtgvMenu.Rows[i].Cells[4].FormattedValue.ToString());
                    money = TextMoney(total.ToString());
                }
                eachMoney = 0m;
            }
            lbTotalPrice.Text += money;
            dtgvMenu.ClearSelection();
            dtgvMiniMenu.ClearSelection();
            for (int i = 0; i < dtgvMenu.Rows.Count; i++)
            {
                if (dtgvMenu.Rows[i].Cells[4].FormattedValue.ToString() != "0")
                {
                    dtgvMenu.Rows[i].Cells[4].Value = "0";
                }
            }
            CheckCard();
        }

        List<Label> listLable = new List<Label>();
        private void addWaiting(string card)
        {
            Button a = new Button();
            a.Text = card;
            a.Size = new Size(180, 50);
            a.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            a.Click += new System.EventHandler(this.btnA_Click);
            a.BackColor = System.Drawing.Color.White;
            a.ForeColor = System.Drawing.Color.FromArgb(74,53,39);
            flpWaiting.Controls.Add(a);  
            
            Label b = new Label();
            b.Text = "Card " + card;
            for(int i = 0; i <= dtgvMiniMenu.Rows.Count - 1 ; i++)
            {
                b.Text += TextBill(
                    dtgvMiniMenu.Rows[i].Cells[1].FormattedValue.ToString(),
                    dtgvMiniMenu.Rows[i].Cells[2].FormattedValue.ToString(),
                    dtgvMiniMenu.Rows[i].Cells[3].FormattedValue.ToString()
                    );
            }
            b.Size = new Size(390, 315);
            b.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            b.Location = new Point(5,5);
            b.BackColor = System.Drawing.Color.White;
            b.ForeColor = System.Drawing.Color.FromArgb(74, 53, 39);
            listLable.Add(b);
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            foreach(Button btn in flpWaiting.Controls)
            {
                Button a = (Button)sender;
                if(a.BackColor == System.Drawing.Color.White)
                {
                    foreach(Button button in flpWaiting.Controls)
                    {
                        if(button != a && button.BackColor == System.Drawing.Color.FromArgb(160, 218, 219))
                        {
                            button.BackColor = System.Drawing.Color.White;
                        }
                    }
                    a.BackColor = System.Drawing.Color.FromArgb(160, 218, 219);
                    foreach (Label lb in listLable)
                    {
                        if(Convert.ToInt32(a.Text) == Convert.ToInt32(lb.Text.Substring(5,2)))
                        {
                            pnWaiting.Controls.Add(lb);
                            lb.BringToFront();
                            break;
                        }
                        else if(Convert.ToInt32(a.Text) == Convert.ToInt32(lb.Text[5].ToString()))
                        {
                            pnWaiting.Controls.Add(lb);
                            lb.BringToFront();
                            break;
                        }
                    }
                }
                else if(a.BackColor == System.Drawing.Color.FromArgb(160, 218, 219))
                {
                    if(MessageBox.Show("Complete bill", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (Label lb in listLable)
                        {
                            if (btn.Text == lb.Text.Substring(5, 2))
                            {
                                pnWaiting.Controls.Remove(lb);
                                lb.Visible = false;
                                listLable.Remove(lb);
                                UpdateCard(btn.Text);
                                break;
                            }
                            else if(btn.Text == lb.Text[5].ToString())
                            {
                                pnWaiting.Controls.Remove(lb);
                                lb.Visible = false;
                                listLable.Remove(lb);
                                UpdateCard(btn.Text);
                                break;
                            }
                        }
                        flpWaiting.Controls.Remove(a);
                    }
                }
                break;
            }
        }

        private string TextBill(string name, string size, string amount)
        {
            string textBill = "\n" + name + " " + size + " " + amount;
            return textBill;
        }

        private void txtCustomerMoney_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                changeMoney = Convert.ToDecimal(txtCustomerMoney.Text) - total;
                change = TextMoney(changeMoney.ToString());
                txtCustomerMoney.Text = TextMoney(txtCustomerMoney.Text);
                lbChangeMoney.Text += change;
            }
        }

        private string TextMoney(string text)
        {
            for (int j = text.Length - 3; j >= 1; j -= 3)
            {
                text = text.Insert(j, ",");
            }
            return text;
        }

        private int BillOrder()
        {
            int i = 0;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "SELECT * FROM Bill";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable data = new DataTable();
            sda.Fill(data);
            i = data.Rows.Count;
            conn.Close();
            return i;
        }

        private bool CheckBill()
        {
            if (dtgvMiniMenu.Rows.Count == 0)
                return false;
            else if (cbCard.SelectedItem == null)
                return false;
            else if (txtCustomerMoney.Text == null)
                return false;
            return true;
        }

        private void UpdateCard(string idCard)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "EXEC UpdateCard @idCard";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@idCard", SqlDbType = SqlDbType.Int });
            cmd.Parameters["@idCard"].Value = idCard;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "EXEC SearchBeverage @nameBeverage";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@nameBeverage", SqlDbType = SqlDbType.NVarChar });
            cmd.Parameters["@nameBeverage"].Value = txtSearch.Text;

            SqlDataAdapter dataAdapt = new SqlDataAdapter();
            dataAdapt.SelectCommand = cmd;
            DataTable data = new DataTable();
            dataAdapt.Fill(data);

            dtgvMenu.Rows.Clear();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                dtgvMenu.Rows.Add(data.Rows[i][0], data.Rows[i][1], data.Rows[i][3], data.Rows[i][4]);
            }
            DataGridViewButtonColumn btnAdd = new DataGridViewButtonColumn();
            btnAdd.Text = "Thêm";
            btnAdd.Width = 125;
            btnAdd.UseColumnTextForButtonValue = true;
            dtgvMenu.Columns.Add(btnAdd);
            for (int i = 0; i <= dtgvMenu.Rows.Count - 1; i++)
            {
                dtgvMenu.Rows[i].Cells[4].Value = "0";
            }
            DataGridViewButtonColumn btnRemove = new DataGridViewButtonColumn();
            btnRemove.Text = "Xoá";
            btnRemove.Width = 125;
            btnRemove.UseColumnTextForButtonValue = true;
            dtgvMenu.Columns.Add(btnRemove);

            dtgvMenu.ClearSelection();

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            btnSearch_Click(sender,e);
        }

        private void AddBill()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "EXEC InsertBill @idBill, @idCard, @customerMoney, @totalMoney";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@idBill", SqlDbType = SqlDbType.Int });
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@idCard", SqlDbType = SqlDbType.Int });
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@customerMoney", SqlDbType = SqlDbType.Money });
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@totalMoney", SqlDbType = SqlDbType.Money });

            cmd.Parameters["@idBill"].Value = BillOrder() + 1;
            cmd.Parameters["@idCard"].Value = cbCard.Text;
            cmd.Parameters["@customerMoney"].Value = txtCustomerMoney.Text;
            cmd.Parameters["@totalMoney"].Value = total;

            cmd.ExecuteNonQuery();

            addWaiting(cbCard.Text);
            UpdateCard(cbCard.Text);
            conn.Close();
        }

        private void AddBillInfo(string idBill, string idBeverage, string numberBeverage)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "EXEC InsertBillInfor @idBill, @idBeverage, @numberBeverage";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@idBill", SqlDbType = SqlDbType.Int });
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@idBeverage", SqlDbType = SqlDbType.VarChar });
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@numberBeverage", SqlDbType = SqlDbType.Int });

            cmd.Parameters["@idBill"].Value = idBill;
            cmd.Parameters["@idBeverage"].Value = idBeverage;
            cmd.Parameters["@numberBeverage"].Value = numberBeverage;

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void addBill_Click(object sender, EventArgs e)
        {
            if(!CheckBill())
            {
                MessageBox.Show("Lack of Information", "Confirm");
            }
            else
            {
                if (MessageBox.Show("Payment Confirmation", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    AddBill();
                    for(int i = 0 ; i < dtgvMiniMenu.Rows.Count ; i++)
                    {
                        AddBillInfo(
                            BillOrder().ToString(),
                            dtgvMiniMenu.Rows[i].Cells[0].FormattedValue.ToString(),
                            dtgvMiniMenu.Rows[i].Cells[3].FormattedValue.ToString()
                            );
                    }
                    dtgvMiniMenu.Rows.Clear();
                    txtCustomerMoney.Clear();
                    cbCard.ResetText();
                    lbTotalPrice.Text = "Total Price: ";
                    total = 0m;
                    lbChangeMoney.Text = "Change Money: ";
                    changeMoney = 0m;
                    CheckCard();
                }
            }
        }
    }
}
