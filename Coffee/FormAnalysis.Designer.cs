namespace Coffee
{
    partial class FormAnalysis
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgvBill = new System.Windows.Forms.DataGridView();
            this.idBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCheckIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvBillInfo = new System.Windows.Forms.DataGridView();
            this.idBeverage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameBeverage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbSelectTime = new System.Windows.Forms.ComboBox();
            this.lbTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBillInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvBill
            // 
            this.dtgvBill.AllowUserToAddRows = false;
            this.dtgvBill.AllowUserToDeleteRows = false;
            this.dtgvBill.AllowUserToResizeColumns = false;
            this.dtgvBill.AllowUserToResizeRows = false;
            this.dtgvBill.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(18)))), ((int)(((byte)(14)))));
            this.dtgvBill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dtgvBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvBill.ColumnHeadersHeight = 50;
            this.dtgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBill,
            this.idCard,
            this.dateCheckIn,
            this.customerMoney,
            this.totalMoney});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvBill.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvBill.EnableHeadersVisualStyles = false;
            this.dtgvBill.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(53)))), ((int)(((byte)(39)))));
            this.dtgvBill.Location = new System.Drawing.Point(50, 50);
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.ReadOnly = true;
            this.dtgvBill.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvBill.RowHeadersVisible = false;
            this.dtgvBill.RowHeadersWidth = 70;
            this.dtgvBill.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvBill.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvBill.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(23)))));
            this.dtgvBill.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvBill.RowTemplate.Height = 30;
            this.dtgvBill.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvBill.Size = new System.Drawing.Size(955, 880);
            this.dtgvBill.TabIndex = 2;
            this.dtgvBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvBill_CellClick);
            // 
            // idBill
            // 
            this.idBill.HeaderText = "ID Bill";
            this.idBill.MinimumWidth = 6;
            this.idBill.Name = "idBill";
            this.idBill.ReadOnly = true;
            this.idBill.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idBill.Width = 125;
            // 
            // idCard
            // 
            this.idCard.HeaderText = "ID Card";
            this.idCard.MinimumWidth = 6;
            this.idCard.Name = "idCard";
            this.idCard.ReadOnly = true;
            this.idCard.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idCard.Width = 125;
            // 
            // dateCheckIn
            // 
            this.dateCheckIn.HeaderText = "Date";
            this.dateCheckIn.MinimumWidth = 6;
            this.dateCheckIn.Name = "dateCheckIn";
            this.dateCheckIn.ReadOnly = true;
            this.dateCheckIn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dateCheckIn.Width = 300;
            // 
            // customerMoney
            // 
            this.customerMoney.HeaderText = "Customer Money";
            this.customerMoney.MinimumWidth = 6;
            this.customerMoney.Name = "customerMoney";
            this.customerMoney.ReadOnly = true;
            this.customerMoney.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.customerMoney.Width = 200;
            // 
            // totalMoney
            // 
            this.totalMoney.HeaderText = "Total Money";
            this.totalMoney.MinimumWidth = 6;
            this.totalMoney.Name = "totalMoney";
            this.totalMoney.ReadOnly = true;
            this.totalMoney.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.totalMoney.Width = 200;
            // 
            // dtgvBillInfo
            // 
            this.dtgvBillInfo.AllowUserToAddRows = false;
            this.dtgvBillInfo.AllowUserToDeleteRows = false;
            this.dtgvBillInfo.AllowUserToResizeColumns = false;
            this.dtgvBillInfo.AllowUserToResizeRows = false;
            this.dtgvBillInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(18)))), ((int)(((byte)(14)))));
            this.dtgvBillInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dtgvBillInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvBillInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvBillInfo.ColumnHeadersHeight = 50;
            this.dtgvBillInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvBillInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBeverage,
            this.nameBeverage,
            this.price,
            this.number});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvBillInfo.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvBillInfo.EnableHeadersVisualStyles = false;
            this.dtgvBillInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(53)))), ((int)(((byte)(39)))));
            this.dtgvBillInfo.Location = new System.Drawing.Point(1040, 330);
            this.dtgvBillInfo.Name = "dtgvBillInfo";
            this.dtgvBillInfo.ReadOnly = true;
            this.dtgvBillInfo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvBillInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgvBillInfo.RowHeadersVisible = false;
            this.dtgvBillInfo.RowHeadersWidth = 70;
            this.dtgvBillInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvBillInfo.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgvBillInfo.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(23)))));
            this.dtgvBillInfo.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvBillInfo.RowTemplate.Height = 30;
            this.dtgvBillInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvBillInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvBillInfo.Size = new System.Drawing.Size(780, 600);
            this.dtgvBillInfo.TabIndex = 3;
            this.dtgvBillInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvBillInfo_CellContentClick);
            // 
            // idBeverage
            // 
            this.idBeverage.HeaderText = "ID Beverage";
            this.idBeverage.MinimumWidth = 6;
            this.idBeverage.Name = "idBeverage";
            this.idBeverage.ReadOnly = true;
            this.idBeverage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idBeverage.Width = 200;
            // 
            // nameBeverage
            // 
            this.nameBeverage.HeaderText = "Name Beverage";
            this.nameBeverage.MinimumWidth = 6;
            this.nameBeverage.Name = "nameBeverage";
            this.nameBeverage.ReadOnly = true;
            this.nameBeverage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nameBeverage.Width = 300;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.price.Width = 150;
            // 
            // number
            // 
            this.number.HeaderText = "Number";
            this.number.MinimumWidth = 6;
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.number.Width = 125;
            // 
            // cbSelectTime
            // 
            this.cbSelectTime.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelectTime.FormattingEnabled = true;
            this.cbSelectTime.Items.AddRange(new object[] {
            "1 ngày",
            "7 ngày",
            "30 ngày"});
            this.cbSelectTime.Location = new System.Drawing.Point(1040, 50);
            this.cbSelectTime.Name = "cbSelectTime";
            this.cbSelectTime.Size = new System.Drawing.Size(180, 53);
            this.cbSelectTime.TabIndex = 4;
            this.cbSelectTime.SelectedIndexChanged += new System.EventHandler(this.cbSelectTime_SelectedIndexChanged);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(1032, 127);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(265, 54);
            this.lbTotal.TabIndex = 5;
            this.lbTotal.Text = "Total money: ";
            // 
            // FormAnalysis
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1920, 980);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.cbSelectTime);
            this.Controls.Add(this.dtgvBillInfo);
            this.Controls.Add(this.dtgvBill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAnalysis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAnalysis";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBillInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCheckIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMoney;
        private System.Windows.Forms.DataGridView dtgvBillInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBeverage;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameBeverage;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.ComboBox cbSelectTime;
        private System.Windows.Forms.Label lbTotal;
    }
}