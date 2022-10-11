namespace Coffee
{
    partial class FormMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.dtgvMenu = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avalable = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnAdd = new System.Windows.Forms.Panel();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnAddBeverage = new System.Windows.Forms.Button();
            this.timerSubMenu = new System.Windows.Forms.Timer(this.components);
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pnUpdate = new System.Windows.Forms.Panel();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.btnUpdateBeverage = new System.Windows.Forms.Button();
            this.timerSubMenu2 = new System.Windows.Forms.Timer(this.components);
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.panel = new System.Windows.Forms.Panel();
            this.dtgvCategory = new System.Windows.Forms.DataGridView();
            this.idCategory_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClearData = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClearCategory = new System.Windows.Forms.Button();
            this.btnClearBeverage = new System.Windows.Forms.Button();
            this.timerSubMenu3 = new System.Windows.Forms.Timer(this.components);
            this.btnSeachCategory = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMenu)).BeginInit();
            this.pnAdd.SuspendLayout();
            this.pnUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategory)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "coffee-beans.png");
            this.imageList.Images.SetKeyName(1, "accept.png");
            this.imageList.Images.SetKeyName(2, "cross.png");
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
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dtgvMenu.ColumnHeadersHeight = 50;
            this.dtgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.idCategory,
            this.size,
            this.price,
            this.avalable});
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvMenu.DefaultCellStyle = dataGridViewCellStyle21;
            this.dtgvMenu.EnableHeadersVisualStyles = false;
            this.dtgvMenu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(53)))), ((int)(((byte)(39)))));
            this.dtgvMenu.Location = new System.Drawing.Point(30, 100);
            this.dtgvMenu.Name = "dtgvMenu";
            this.dtgvMenu.ReadOnly = true;
            this.dtgvMenu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvMenu.RowHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dtgvMenu.RowHeadersVisible = false;
            this.dtgvMenu.RowHeadersWidth = 50;
            this.dtgvMenu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvMenu.RowsDefaultCellStyle = dataGridViewCellStyle23;
            this.dtgvMenu.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(23)))));
            this.dtgvMenu.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvMenu.RowTemplate.Height = 30;
            this.dtgvMenu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvMenu.Size = new System.Drawing.Size(840, 840);
            this.dtgvMenu.TabIndex = 0;
            this.dtgvMenu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvMenu_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id.Width = 125;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.name.Width = 180;
            // 
            // idCategory
            // 
            this.idCategory.HeaderText = "ID Category";
            this.idCategory.MinimumWidth = 6;
            this.idCategory.Name = "idCategory";
            this.idCategory.ReadOnly = true;
            this.idCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idCategory.Width = 130;
            // 
            // size
            // 
            this.size.HeaderText = "Size";
            this.size.MinimumWidth = 6;
            this.size.Name = "size";
            this.size.ReadOnly = true;
            this.size.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.size.Width = 130;
            // 
            // price
            // 
            dataGridViewCellStyle20.Format = "N0";
            dataGridViewCellStyle20.NullValue = null;
            this.price.DefaultCellStyle = dataGridViewCellStyle20;
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 140;
            // 
            // avalable
            // 
            this.avalable.HeaderText = "Avalable";
            this.avalable.MinimumWidth = 6;
            this.avalable.Name = "avalable";
            this.avalable.ReadOnly = true;
            this.avalable.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.avalable.Width = 130;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(18)))), ((int)(((byte)(14)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(875, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 50);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnAdd
            // 
            this.pnAdd.Controls.Add(this.btnAddCategory);
            this.pnAdd.Controls.Add(this.btnAddBeverage);
            this.pnAdd.Location = new System.Drawing.Point(875, -50);
            this.pnAdd.Name = "pnAdd";
            this.pnAdd.Size = new System.Drawing.Size(130, 100);
            this.pnAdd.TabIndex = 2;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(18)))), ((int)(((byte)(14)))));
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.ForeColor = System.Drawing.Color.White;
            this.btnAddCategory.Location = new System.Drawing.Point(0, 50);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(130, 50);
            this.btnAddCategory.TabIndex = 4;
            this.btnAddCategory.Text = "Thêm loại";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnAddBeverage
            // 
            this.btnAddBeverage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(18)))), ((int)(((byte)(14)))));
            this.btnAddBeverage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBeverage.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBeverage.ForeColor = System.Drawing.Color.White;
            this.btnAddBeverage.Location = new System.Drawing.Point(0, 0);
            this.btnAddBeverage.Name = "btnAddBeverage";
            this.btnAddBeverage.Size = new System.Drawing.Size(130, 50);
            this.btnAddBeverage.TabIndex = 3;
            this.btnAddBeverage.Text = "Thêm món";
            this.btnAddBeverage.UseVisualStyleBackColor = false;
            this.btnAddBeverage.Click += new System.EventHandler(this.btnAddBeverage_Click);
            // 
            // timerSubMenu
            // 
            this.timerSubMenu.Interval = 10;
            this.timerSubMenu.Tick += new System.EventHandler(this.timerSubMenu_Tick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(18)))), ((int)(((byte)(14)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(1005, 0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 50);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnUpdate
            // 
            this.pnUpdate.Controls.Add(this.btnUpdateCategory);
            this.pnUpdate.Controls.Add(this.btnUpdateBeverage);
            this.pnUpdate.Location = new System.Drawing.Point(1005, -50);
            this.pnUpdate.Name = "pnUpdate";
            this.pnUpdate.Size = new System.Drawing.Size(130, 100);
            this.pnUpdate.TabIndex = 4;
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(18)))), ((int)(((byte)(14)))));
            this.btnUpdateCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCategory.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCategory.Location = new System.Drawing.Point(0, 50);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(130, 50);
            this.btnUpdateCategory.TabIndex = 6;
            this.btnUpdateCategory.Text = "Sửa loại";
            this.btnUpdateCategory.UseVisualStyleBackColor = false;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // btnUpdateBeverage
            // 
            this.btnUpdateBeverage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(18)))), ((int)(((byte)(14)))));
            this.btnUpdateBeverage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateBeverage.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateBeverage.ForeColor = System.Drawing.Color.White;
            this.btnUpdateBeverage.Location = new System.Drawing.Point(0, 0);
            this.btnUpdateBeverage.Name = "btnUpdateBeverage";
            this.btnUpdateBeverage.Size = new System.Drawing.Size(130, 50);
            this.btnUpdateBeverage.TabIndex = 5;
            this.btnUpdateBeverage.Text = "Sửa món";
            this.btnUpdateBeverage.UseVisualStyleBackColor = false;
            this.btnUpdateBeverage.Click += new System.EventHandler(this.btnUpdateBeverage_Click);
            // 
            // timerSubMenu2
            // 
            this.timerSubMenu2.Interval = 10;
            this.timerSubMenu2.Tick += new System.EventHandler(this.timerSubMenu2_Tick);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(200, 25);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 50);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearch.IconColor = System.Drawing.Color.Black;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.Location = new System.Drawing.Point(506, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(50, 50);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(900, 150);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(900, 460);
            this.panel.TabIndex = 7;
            // 
            // dtgvCategory
            // 
            this.dtgvCategory.AllowUserToAddRows = false;
            this.dtgvCategory.AllowUserToDeleteRows = false;
            this.dtgvCategory.AllowUserToResizeColumns = false;
            this.dtgvCategory.AllowUserToResizeRows = false;
            this.dtgvCategory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(18)))), ((int)(((byte)(14)))));
            this.dtgvCategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dtgvCategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dtgvCategory.ColumnHeadersHeight = 50;
            this.dtgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCategory_2,
            this.nameCategory});
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvCategory.DefaultCellStyle = dataGridViewCellStyle25;
            this.dtgvCategory.EnableHeadersVisualStyles = false;
            this.dtgvCategory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(53)))), ((int)(((byte)(39)))));
            this.dtgvCategory.Location = new System.Drawing.Point(1100, 615);
            this.dtgvCategory.Name = "dtgvCategory";
            this.dtgvCategory.ReadOnly = true;
            this.dtgvCategory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvCategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dtgvCategory.RowHeadersVisible = false;
            this.dtgvCategory.RowHeadersWidth = 50;
            this.dtgvCategory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvCategory.RowsDefaultCellStyle = dataGridViewCellStyle27;
            this.dtgvCategory.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(23)))));
            this.dtgvCategory.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvCategory.RowTemplate.Height = 30;
            this.dtgvCategory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvCategory.Size = new System.Drawing.Size(405, 320);
            this.dtgvCategory.TabIndex = 8;
            this.dtgvCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCategory_CellClick);
            // 
            // idCategory_2
            // 
            this.idCategory_2.HeaderText = "ID Category";
            this.idCategory_2.MinimumWidth = 6;
            this.idCategory_2.Name = "idCategory_2";
            this.idCategory_2.ReadOnly = true;
            this.idCategory_2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idCategory_2.Width = 150;
            // 
            // nameCategory
            // 
            this.nameCategory.HeaderText = "Name Category";
            this.nameCategory.MinimumWidth = 6;
            this.nameCategory.Name = "nameCategory";
            this.nameCategory.ReadOnly = true;
            this.nameCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nameCategory.Width = 250;
            // 
            // btnClearData
            // 
            this.btnClearData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(18)))), ((int)(((byte)(14)))));
            this.btnClearData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearData.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearData.ForeColor = System.Drawing.Color.White;
            this.btnClearData.Location = new System.Drawing.Point(1135, 0);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(130, 50);
            this.btnClearData.TabIndex = 9;
            this.btnClearData.Text = "Xoá";
            this.btnClearData.UseVisualStyleBackColor = false;
            this.btnClearData.Click += new System.EventHandler(this.btnClearData_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClearCategory);
            this.panel1.Controls.Add(this.btnClearBeverage);
            this.panel1.Location = new System.Drawing.Point(1135, -50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 100);
            this.panel1.TabIndex = 10;
            // 
            // btnClearCategory
            // 
            this.btnClearCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(18)))), ((int)(((byte)(14)))));
            this.btnClearCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearCategory.ForeColor = System.Drawing.Color.White;
            this.btnClearCategory.Location = new System.Drawing.Point(0, 50);
            this.btnClearCategory.Name = "btnClearCategory";
            this.btnClearCategory.Size = new System.Drawing.Size(130, 50);
            this.btnClearCategory.TabIndex = 11;
            this.btnClearCategory.Text = "Xoá loại";
            this.btnClearCategory.UseVisualStyleBackColor = false;
            this.btnClearCategory.Click += new System.EventHandler(this.btnClearCategory_Click);
            // 
            // btnClearBeverage
            // 
            this.btnClearBeverage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(18)))), ((int)(((byte)(14)))));
            this.btnClearBeverage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearBeverage.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearBeverage.ForeColor = System.Drawing.Color.White;
            this.btnClearBeverage.Location = new System.Drawing.Point(0, 0);
            this.btnClearBeverage.Name = "btnClearBeverage";
            this.btnClearBeverage.Size = new System.Drawing.Size(130, 50);
            this.btnClearBeverage.TabIndex = 11;
            this.btnClearBeverage.Text = "Xoá món";
            this.btnClearBeverage.UseVisualStyleBackColor = false;
            this.btnClearBeverage.Click += new System.EventHandler(this.btnClearBeverage_Click);
            // 
            // timerSubMenu3
            // 
            this.timerSubMenu3.Interval = 10;
            this.timerSubMenu3.Tick += new System.EventHandler(this.timerSubMenu3_Tick);
            // 
            // btnSeachCategory
            // 
            this.btnSeachCategory.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSeachCategory.IconColor = System.Drawing.Color.Black;
            this.btnSeachCategory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSeachCategory.Location = new System.Drawing.Point(1044, 616);
            this.btnSeachCategory.Name = "btnSeachCategory";
            this.btnSeachCategory.Size = new System.Drawing.Size(50, 50);
            this.btnSeachCategory.TabIndex = 11;
            this.btnSeachCategory.UseVisualStyleBackColor = true;
            this.btnSeachCategory.Click += new System.EventHandler(this.btnSeachCategory_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1920, 980);
            this.Controls.Add(this.btnSeachCategory);
            this.Controls.Add(this.btnClearData);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgvCategory);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.pnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pnAdd);
            this.Controls.Add(this.dtgvMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenu";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMenu)).EndInit();
            this.pnAdd.ResumeLayout(false);
            this.pnUpdate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategory)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnAdd;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnAddBeverage;
        private System.Windows.Forms.Timer timerSubMenu;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel pnUpdate;
        private System.Windows.Forms.Button btnUpdateBeverage;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.Timer timerSubMenu2;
        private System.Windows.Forms.TextBox txtSearch;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.DataGridView dtgvCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategory_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewImageColumn avalable;
        private System.Windows.Forms.Button btnClearData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClearBeverage;
        private System.Windows.Forms.Button btnClearCategory;
        private System.Windows.Forms.Timer timerSubMenu3;
        public System.Windows.Forms.DataGridView dtgvMenu;
        private FontAwesome.Sharp.IconButton btnSeachCategory;
    }
}