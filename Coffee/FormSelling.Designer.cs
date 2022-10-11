namespace Coffee
{
    partial class FormSelling
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgvMenu = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountTest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.btnAddBill = new FontAwesome.Sharp.IconButton();
            this.dtgvMiniMenu = new System.Windows.Forms.DataGridView();
            this.idMiniMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameMiniMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeMiniMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceMiniMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flpWaiting = new System.Windows.Forms.FlowLayoutPanel();
            this.addBill = new FontAwesome.Sharp.IconButton();
            this.cbCard = new System.Windows.Forms.ComboBox();
            this.txtCustomerMoney = new System.Windows.Forms.TextBox();
            this.lbChangeMoney = new System.Windows.Forms.Label();
            this.pnWaiting = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMiniMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvMenu
            // 
            this.dtgvMenu.AllowUserToAddRows = false;
            this.dtgvMenu.AllowUserToDeleteRows = false;
            this.dtgvMenu.AllowUserToResizeColumns = false;
            this.dtgvMenu.AllowUserToResizeRows = false;
            this.dtgvMenu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(18)))), ((int)(((byte)(14)))));
            this.dtgvMenu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dtgvMenu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvMenu.ColumnHeadersHeight = 30;
            this.dtgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.size,
            this.price,
            this.amountTest});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvMenu.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvMenu.EnableHeadersVisualStyles = false;
            this.dtgvMenu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(53)))), ((int)(((byte)(39)))));
            this.dtgvMenu.Location = new System.Drawing.Point(5, 96);
            this.dtgvMenu.Name = "dtgvMenu";
            this.dtgvMenu.ReadOnly = true;
            this.dtgvMenu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvMenu.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgvMenu.RowHeadersVisible = false;
            this.dtgvMenu.RowHeadersWidth = 50;
            this.dtgvMenu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvMenu.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgvMenu.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(23)))));
            this.dtgvMenu.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvMenu.RowTemplate.Height = 30;
            this.dtgvMenu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvMenu.Size = new System.Drawing.Size(925, 880);
            this.dtgvMenu.TabIndex = 1;
            this.dtgvMenu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvMenu_CellClick);
            // 
            // id
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.id.DefaultCellStyle = dataGridViewCellStyle2;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id.Width = 125;
            // 
            // name
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.name.DefaultCellStyle = dataGridViewCellStyle3;
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.name.Width = 225;
            // 
            // size
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.size.DefaultCellStyle = dataGridViewCellStyle4;
            this.size.HeaderText = "Size";
            this.size.MinimumWidth = 6;
            this.size.Name = "size";
            this.size.ReadOnly = true;
            this.size.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.size.Width = 125;
            // 
            // price
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            this.price.DefaultCellStyle = dataGridViewCellStyle5;
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 125;
            // 
            // amountTest
            // 
            this.amountTest.HeaderText = "Amount";
            this.amountTest.MinimumWidth = 6;
            this.amountTest.Name = "amountTest";
            this.amountTest.ReadOnly = true;
            this.amountTest.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.amountTest.Width = 70;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(130, 40);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(350, 50);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearch.IconColor = System.Drawing.Color.Black;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.Location = new System.Drawing.Point(485, 40);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(50, 50);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPrice.Location = new System.Drawing.Point(1200, 500);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(162, 38);
            this.lbTotalPrice.TabIndex = 9;
            this.lbTotalPrice.Text = "Total Price: ";
            this.lbTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAddBill
            // 
            this.btnAddBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(53)))), ((int)(((byte)(39)))));
            this.btnAddBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBill.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBill.ForeColor = System.Drawing.Color.White;
            this.btnAddBill.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAddBill.IconColor = System.Drawing.Color.Black;
            this.btnAddBill.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddBill.Location = new System.Drawing.Point(700, 40);
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.Size = new System.Drawing.Size(230, 50);
            this.btnAddBill.TabIndex = 11;
            this.btnAddBill.Text = "Thêm hoá đơn";
            this.btnAddBill.UseVisualStyleBackColor = false;
            this.btnAddBill.Click += new System.EventHandler(this.btnAddBill_Click);
            // 
            // dtgvMiniMenu
            // 
            this.dtgvMiniMenu.AllowUserToAddRows = false;
            this.dtgvMiniMenu.AllowUserToDeleteRows = false;
            this.dtgvMiniMenu.AllowUserToResizeColumns = false;
            this.dtgvMiniMenu.AllowUserToResizeRows = false;
            this.dtgvMiniMenu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(18)))), ((int)(((byte)(14)))));
            this.dtgvMiniMenu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dtgvMiniMenu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvMiniMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgvMiniMenu.ColumnHeadersHeight = 30;
            this.dtgvMiniMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvMiniMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMiniMenu,
            this.nameMiniMenu,
            this.sizeMiniMenu,
            this.amount,
            this.priceMiniMenu});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvMiniMenu.DefaultCellStyle = dataGridViewCellStyle10;
            this.dtgvMiniMenu.EnableHeadersVisualStyles = false;
            this.dtgvMiniMenu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(53)))), ((int)(((byte)(39)))));
            this.dtgvMiniMenu.Location = new System.Drawing.Point(935, 95);
            this.dtgvMiniMenu.Name = "dtgvMiniMenu";
            this.dtgvMiniMenu.ReadOnly = true;
            this.dtgvMiniMenu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvMiniMenu.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dtgvMiniMenu.RowHeadersVisible = false;
            this.dtgvMiniMenu.RowHeadersWidth = 30;
            this.dtgvMiniMenu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvMiniMenu.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dtgvMiniMenu.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(23)))));
            this.dtgvMiniMenu.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvMiniMenu.RowTemplate.Height = 30;
            this.dtgvMiniMenu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvMiniMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvMiniMenu.Size = new System.Drawing.Size(575, 400);
            this.dtgvMiniMenu.TabIndex = 12;
            // 
            // idMiniMenu
            // 
            this.idMiniMenu.HeaderText = "ID";
            this.idMiniMenu.MinimumWidth = 6;
            this.idMiniMenu.Name = "idMiniMenu";
            this.idMiniMenu.ReadOnly = true;
            this.idMiniMenu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idMiniMenu.Width = 125;
            // 
            // nameMiniMenu
            // 
            this.nameMiniMenu.HeaderText = "Name";
            this.nameMiniMenu.MinimumWidth = 6;
            this.nameMiniMenu.Name = "nameMiniMenu";
            this.nameMiniMenu.ReadOnly = true;
            this.nameMiniMenu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nameMiniMenu.Width = 125;
            // 
            // sizeMiniMenu
            // 
            this.sizeMiniMenu.HeaderText = "Size";
            this.sizeMiniMenu.MinimumWidth = 6;
            this.sizeMiniMenu.Name = "sizeMiniMenu";
            this.sizeMiniMenu.ReadOnly = true;
            this.sizeMiniMenu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.sizeMiniMenu.Width = 125;
            // 
            // amount
            // 
            this.amount.HeaderText = "Amount";
            this.amount.MinimumWidth = 6;
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            this.amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.amount.Width = 70;
            // 
            // priceMiniMenu
            // 
            this.priceMiniMenu.HeaderText = "Price";
            this.priceMiniMenu.MinimumWidth = 6;
            this.priceMiniMenu.Name = "priceMiniMenu";
            this.priceMiniMenu.ReadOnly = true;
            this.priceMiniMenu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.priceMiniMenu.Width = 125;
            // 
            // flpWaiting
            // 
            this.flpWaiting.AutoScroll = true;
            this.flpWaiting.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpWaiting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(18)))), ((int)(((byte)(14)))));
            this.flpWaiting.Location = new System.Drawing.Point(1515, 465);
            this.flpWaiting.Name = "flpWaiting";
            this.flpWaiting.Size = new System.Drawing.Size(400, 510);
            this.flpWaiting.TabIndex = 15;
            // 
            // addBill
            // 
            this.addBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(53)))), ((int)(((byte)(39)))));
            this.addBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBill.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBill.ForeColor = System.Drawing.Color.White;
            this.addBill.IconChar = FontAwesome.Sharp.IconChar.None;
            this.addBill.IconColor = System.Drawing.Color.Black;
            this.addBill.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addBill.Location = new System.Drawing.Point(935, 41);
            this.addBill.Name = "addBill";
            this.addBill.Size = new System.Drawing.Size(230, 50);
            this.addBill.TabIndex = 16;
            this.addBill.Text = "Thanh toán";
            this.addBill.UseVisualStyleBackColor = false;
            this.addBill.Click += new System.EventHandler(this.addBill_Click);
            // 
            // cbCard
            // 
            this.cbCard.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCard.FormattingEnabled = true;
            this.cbCard.Location = new System.Drawing.Point(1115, 500);
            this.cbCard.Name = "cbCard";
            this.cbCard.Size = new System.Drawing.Size(80, 62);
            this.cbCard.TabIndex = 17;
            // 
            // txtCustomerMoney
            // 
            this.txtCustomerMoney.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerMoney.Location = new System.Drawing.Point(1162, 590);
            this.txtCustomerMoney.Multiline = true;
            this.txtCustomerMoney.Name = "txtCustomerMoney";
            this.txtCustomerMoney.Size = new System.Drawing.Size(200, 50);
            this.txtCustomerMoney.TabIndex = 18;
            this.txtCustomerMoney.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustomerMoney_KeyDown);
            // 
            // lbChangeMoney
            // 
            this.lbChangeMoney.AutoSize = true;
            this.lbChangeMoney.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChangeMoney.Location = new System.Drawing.Point(1200, 540);
            this.lbChangeMoney.Name = "lbChangeMoney";
            this.lbChangeMoney.Size = new System.Drawing.Size(224, 38);
            this.lbChangeMoney.TabIndex = 19;
            this.lbChangeMoney.Text = "Change Money: ";
            this.lbChangeMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnWaiting
            // 
            this.pnWaiting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(18)))), ((int)(((byte)(14)))));
            this.pnWaiting.Location = new System.Drawing.Point(1515, 5);
            this.pnWaiting.Name = "pnWaiting";
            this.pnWaiting.Size = new System.Drawing.Size(400, 455);
            this.pnWaiting.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(935, 510);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 38);
            this.label1.TabIndex = 21;
            this.label1.Text = "Card Number: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(930, 590);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 38);
            this.label2.TabIndex = 22;
            this.label2.Text = "Customer Money: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormSelling
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1920, 980);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnWaiting);
            this.Controls.Add(this.lbChangeMoney);
            this.Controls.Add(this.txtCustomerMoney);
            this.Controls.Add(this.cbCard);
            this.Controls.Add(this.addBill);
            this.Controls.Add(this.flpWaiting);
            this.Controls.Add(this.dtgvMenu);
            this.Controls.Add(this.dtgvMiniMenu);
            this.Controls.Add(this.btnAddBill);
            this.Controls.Add(this.lbTotalPrice);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSelling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSelling";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMiniMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvMenu;
        private System.Windows.Forms.TextBox txtSearch;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.Label lbTotalPrice;
        private FontAwesome.Sharp.IconButton btnAddBill;
        private System.Windows.Forms.DataGridView dtgvMiniMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMiniMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameMiniMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeMiniMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceMiniMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountTest;
        private System.Windows.Forms.FlowLayoutPanel flpWaiting;
        private FontAwesome.Sharp.IconButton addBill;
        private System.Windows.Forms.ComboBox cbCard;
        private System.Windows.Forms.TextBox txtCustomerMoney;
        private System.Windows.Forms.Label lbChangeMoney;
        private System.Windows.Forms.Panel pnWaiting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}