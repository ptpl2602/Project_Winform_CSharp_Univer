using System;
using System.IO;
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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();

            FillData();
            GetDataCategory();

            panel.Visible = false;

        }

        public static string connectionString = "Data Source=DESKTOP-RPEMCJS/SQLEXPRESS;Initial Catalog=QuanLyCoffee;Integrated Security=True";

        public void FillData()
        {
            dtgvMenu.Rows.Clear();
            DataTable data = GetData();
            for(int i = 0 ; i < data.Rows.Count ; i++)
            {
                dtgvMenu.Rows.Add
                    (
                        data.Rows[i][0],
                        data.Rows[i][1],
                        data.Rows[i][2],
                        data.Rows[i][3],
                        data.Rows[i][4],
                        (bool)data.Rows[i][5] ? imageList.Images[1] : imageList.Images[2]
                    );
            }
            dtgvMenu.ClearSelection();
        }

        DataTable GetData()
        {
            DataTable data = new DataTable();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "SELECT * FROM Beverage";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            sda.Fill(data);
            conn.Close();
            return data;
        }

        private void GetDataCategory()
        {
            dtgvCategory.Rows.Clear();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "SELECT * FROM CategoryBeverage";
            SqlCommand cmd = new SqlCommand(query, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dtgvCategory.Rows.Add
                    (
                        dt.Rows[i][0],
                        dt.Rows[i][1]
                    );
            }
            cmd.ExecuteNonQuery();
            dtgvCategory.ClearSelection();
            conn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            timerSubMenu.Start();
            panel.Visible = true;
        }

        private void btnAddBeverage_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormAddBeverage());
            timerSubMenu.Start();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormAddCategory());
            timerSubMenu.Start();
        }

        private bool subMenu = true;
        private void timerSubMenu_Tick(object sender, EventArgs e)
        {
            if(subMenu)
            {
                pnAdd.Location = new Point(pnAdd.Location.X, pnAdd.Location.Y + 10);
                if (pnAdd.Location.Y == 50)
                {
                    subMenu = false;
                    timerSubMenu.Stop();
                }
            }
            else
            {
                pnAdd.Location = new Point(pnAdd.Location.X, pnAdd.Location.Y - 10);
                if (pnAdd.Location.Y == -50)
                {
                    subMenu = true;
                    timerSubMenu.Stop();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            timerSubMenu2.Start();
            panel.Visible = true;
        }

        private void btnUpdateBeverage_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormUpdateBeverage());
            timerSubMenu2.Start();
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormUpdateCategory());
            timerSubMenu2.Start();
        }

        private bool subMenu2 = true;
        private void timerSubMenu2_Tick(object sender, EventArgs e)
        {
            if (subMenu2)
            {
                pnUpdate.Location = new Point(pnUpdate.Location.X, pnUpdate.Location.Y + 10);
                if (pnUpdate.Location.Y == 50)
                {
                    subMenu2 = false;
                    timerSubMenu2.Stop();
                }
            }
            else
            {
                pnUpdate.Location = new Point(pnUpdate.Location.X, pnUpdate.Location.Y - 10);
                if (pnUpdate.Location.Y == -50)
                {
                    subMenu2 = true;
                    timerSubMenu2.Stop();
                }
            }
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
                dtgvMenu.Rows.Add(
                    data.Rows[i][0],
                    data.Rows[i][1],
                    data.Rows[i][2],
                    data.Rows[i][3],
                    data.Rows[i][4],
                    (bool)data.Rows[i][5] ? imageList.Images[1] : imageList.Images[2]);
            }

            dtgvMenu.ClearSelection();

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            btnSearch_Click(sender, e);
        }

        private void dtgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FormUpdateCategory.ReceiveData(
                dtgvCategory.Rows[e.RowIndex].Cells[0].FormattedValue.ToString(),
                dtgvCategory.Rows[e.RowIndex].Cells[1].FormattedValue.ToString()
                );
            if(e.ColumnIndex == 2)
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                string query = "RemoveCategory";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", dtgvCategory.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                cmd.ExecuteNonQuery();
                conn.Close();
                GetDataCategory();
            }
        }

        private void dtgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dataTable = GetData();
            FormUpdateBeverage.ReceiveData(
                dataTable.Rows[e.RowIndex][0].ToString(),
                dataTable.Rows[e.RowIndex][1].ToString(),
                dataTable.Rows[e.RowIndex][2].ToString(),
                dataTable.Rows[e.RowIndex][3].ToString(),
                dataTable.Rows[e.RowIndex][4].ToString(),
                (bool)dataTable.Rows[e.RowIndex][5]
                );
            if(e.ColumnIndex == 6)
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                string query = "RemoveBeverage";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", dtgvMenu.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                cmd.ExecuteNonQuery();
                conn.Close();
                FillData();
            }
        }

        private void btnClearData_Click(object sender, EventArgs e)
        {
            timerSubMenu3.Start();
            panel.Visible = false;
            if(dtgvMenu.Columns.Count == 7)
            {
                dtgvMenu.Columns.RemoveAt(6);
                dtgvMenu.Size = new Size(840, 840);
            }
            if(dtgvCategory.Columns.Count == 3)
            {
                dtgvCategory.Columns.RemoveAt(2);
                dtgvCategory.Size = new Size(405, 320);
            }
        }

        private void btnClearBeverage_Click(object sender, EventArgs e)
        {
            dtgvMenu.Size = new Size(940,840);
            DataGridViewButtonColumn btnRemove = new DataGridViewButtonColumn();
            btnRemove.Text = "Xoá";
            btnRemove.Width = 100;
            btnRemove.UseColumnTextForButtonValue = true;
            dtgvMenu.Columns.Add(btnRemove);
        }

        private void btnClearCategory_Click(object sender, EventArgs e)
        {
            dtgvCategory.Size = new Size(505, 320);
            DataGridViewButtonColumn btnRemove = new DataGridViewButtonColumn();
            btnRemove.Text = "Xoá";
            btnRemove.Width = 100;
            btnRemove.UseColumnTextForButtonValue = true;
            dtgvCategory.Columns.Add(btnRemove);
        }

        private bool subMenu3 = true;
        private void timerSubMenu3_Tick(object sender, EventArgs e)
        {
            if (subMenu3)
            {
                panel1.Location = new Point(panel1.Location.X, panel1.Location.Y + 10);
                if (panel1.Location.Y == 50)
                {
                    subMenu3 = false;
                    timerSubMenu3.Stop();
                }
            }
            else
            {
                panel1.Location = new Point(panel1.Location.X, panel1.Location.Y - 10);
                if (panel1.Location.Y == -50)
                {
                    subMenu3 = true;
                    timerSubMenu3.Stop();
                }
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
            this.panel.Controls.Add(childForm);
            this.panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnSeachCategory_Click(object sender, EventArgs e)
        {
            GetDataCategory();
        }
    }
}
