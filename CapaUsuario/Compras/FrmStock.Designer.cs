namespace CapaUsuario.Compras
{
    partial class FrmStock
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
            System.Windows.Forms.Label cod_pro_stockLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label stk_optLabel;
            System.Windows.Forms.Label stk_criLabel;
            System.Windows.Forms.Label cod_catLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStock));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.MedidaComboBox = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.marcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.capaDatosDataSet = new CapaUsuario.CapaDatosDataSet();
            this.cod_catComboBox = new System.Windows.Forms.ComboBox();
            this._1_stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stk_criTextBox = new System.Windows.Forms.TextBox();
            this.stk_optTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.cod_pro_stockTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._1_stockBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this._1_stockBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this._1_stockDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codprostockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.codmarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.stockmarcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._1_stockTableAdapter = new CapaUsuario.CapaDatosDataSetTableAdapters._1_stockTableAdapter();
            this.tableAdapterManager = new CapaUsuario.CapaDatosDataSetTableAdapters.TableAdapterManager();
            this._1_categoriaTableAdapter = new CapaUsuario.CapaDatosDataSetTableAdapters._1_categoriaTableAdapter();
            this._1_stock_marcaTableAdapter = new CapaUsuario.CapaDatosDataSetTableAdapters._1_stock_marcaTableAdapter();
            this._1_marcaTableAdapter = new CapaUsuario.CapaDatosDataSetTableAdapters._1_marcaTableAdapter();
            this.medidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._1_medidaTableAdapter = new CapaUsuario.CapaDatosDataSetTableAdapters._1_medidaTableAdapter();
            cod_pro_stockLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            stk_optLabel = new System.Windows.Forms.Label();
            stk_criLabel = new System.Windows.Forms.Label();
            cod_catLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capaDatosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._1_stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._1_stockBindingNavigator)).BeginInit();
            this._1_stockBindingNavigator.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._1_stockDataGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockmarcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medidaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cod_pro_stockLabel
            // 
            cod_pro_stockLabel.AutoSize = true;
            cod_pro_stockLabel.Location = new System.Drawing.Point(82, 88);
            cod_pro_stockLabel.Name = "cod_pro_stockLabel";
            cod_pro_stockLabel.Size = new System.Drawing.Size(146, 20);
            cod_pro_stockLabel.TabIndex = 17;
            cod_pro_stockLabel.Text = "Código de producto:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(161, 159);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(67, 20);
            nombreLabel.TabIndex = 18;
            nombreLabel.Text = "Nombre:";
            // 
            // stk_optLabel
            // 
            stk_optLabel.AutoSize = true;
            stk_optLabel.Location = new System.Drawing.Point(128, 297);
            stk_optLabel.Name = "stk_optLabel";
            stk_optLabel.Size = new System.Drawing.Size(100, 20);
            stk_optLabel.TabIndex = 19;
            stk_optLabel.Text = "Stock óptimo:";
            // 
            // stk_criLabel
            // 
            stk_criLabel.AutoSize = true;
            stk_criLabel.Location = new System.Drawing.Point(137, 365);
            stk_criLabel.Name = "stk_criLabel";
            stk_criLabel.Size = new System.Drawing.Size(91, 20);
            stk_criLabel.TabIndex = 20;
            stk_criLabel.Text = "Stock crítico:";
            // 
            // cod_catLabel
            // 
            cod_catLabel.AutoSize = true;
            cod_catLabel.Location = new System.Drawing.Point(508, 160);
            cod_catLabel.Name = "cod_catLabel";
            cod_catLabel.Size = new System.Drawing.Size(76, 20);
            cod_catLabel.TabIndex = 21;
            cod_catLabel.Text = "Categoría:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1020, 534);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.MedidaComboBox);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(cod_catLabel);
            this.tabPage1.Controls.Add(this.cod_catComboBox);
            this.tabPage1.Controls.Add(stk_criLabel);
            this.tabPage1.Controls.Add(this.stk_criTextBox);
            this.tabPage1.Controls.Add(stk_optLabel);
            this.tabPage1.Controls.Add(this.stk_optTextBox);
            this.tabPage1.Controls.Add(nombreLabel);
            this.tabPage1.Controls.Add(this.nombreTextBox);
            this.tabPage1.Controls.Add(cod_pro_stockLabel);
            this.tabPage1.Controls.Add(this.cod_pro_stockTextBox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this._1_stockBindingNavigator);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1012, 504);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mantenimiento";
            // 
            // MedidaComboBox
            // 
            this.MedidaComboBox.DataSource = this.medidaBindingSource;
            this.MedidaComboBox.DisplayMember = "nombre";
            this.MedidaComboBox.FormattingEnabled = true;
            this.MedidaComboBox.Location = new System.Drawing.Point(590, 224);
            this.MedidaComboBox.Name = "MedidaComboBox";
            this.MedidaComboBox.Size = new System.Drawing.Size(236, 28);
            this.MedidaComboBox.TabIndex = 24;
            this.MedidaComboBox.ValueMember = "cod_med";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.marcaBindingSource;
            this.comboBox1.DisplayMember = "nombre";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(234, 224);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(202, 28);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.ValueMember = "cod_mar";
            // 
            // marcaBindingSource
            // 
            this.marcaBindingSource.DataMember = "1_marca";
            this.marcaBindingSource.DataSource = this.capaDatosDataSet;
            // 
            // capaDatosDataSet
            // 
            this.capaDatosDataSet.DataSetName = "CapaDatosDataSet";
            this.capaDatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cod_catComboBox
            // 
            this.cod_catComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this._1_stockBindingSource, "cod_cat", true));
            this.cod_catComboBox.DataSource = this.categoriaBindingSource;
            this.cod_catComboBox.DisplayMember = "nombre";
            this.cod_catComboBox.FormattingEnabled = true;
            this.cod_catComboBox.Location = new System.Drawing.Point(590, 156);
            this.cod_catComboBox.Name = "cod_catComboBox";
            this.cod_catComboBox.Size = new System.Drawing.Size(236, 28);
            this.cod_catComboBox.TabIndex = 22;
            this.cod_catComboBox.ValueMember = "cod_cat";
            this.cod_catComboBox.SelectedValueChanged += new System.EventHandler(this.cod_catComboBox_SelectedValueChanged);
            // 
            // _1_stockBindingSource
            // 
            this._1_stockBindingSource.DataMember = "1_stock";
            this._1_stockBindingSource.DataSource = this.capaDatosDataSet;
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "1_categoria";
            this.categoriaBindingSource.DataSource = this.capaDatosDataSet;
            // 
            // stk_criTextBox
            // 
            this.stk_criTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._1_stockBindingSource, "stk_cri", true));
            this.stk_criTextBox.Location = new System.Drawing.Point(234, 362);
            this.stk_criTextBox.MaxLength = 4;
            this.stk_criTextBox.Name = "stk_criTextBox";
            this.stk_criTextBox.ReadOnly = true;
            this.stk_criTextBox.Size = new System.Drawing.Size(202, 27);
            this.stk_criTextBox.TabIndex = 21;
            // 
            // stk_optTextBox
            // 
            this.stk_optTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._1_stockBindingSource, "stk_opt", true));
            this.stk_optTextBox.Location = new System.Drawing.Point(234, 294);
            this.stk_optTextBox.MaxLength = 4;
            this.stk_optTextBox.Name = "stk_optTextBox";
            this.stk_optTextBox.ReadOnly = true;
            this.stk_optTextBox.Size = new System.Drawing.Size(202, 27);
            this.stk_optTextBox.TabIndex = 20;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._1_stockBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(234, 156);
            this.nombreTextBox.MaxLength = 50;
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.ReadOnly = true;
            this.nombreTextBox.Size = new System.Drawing.Size(202, 27);
            this.nombreTextBox.TabIndex = 19;
            // 
            // cod_pro_stockTextBox
            // 
            this.cod_pro_stockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._1_stockBindingSource, "cod_pro_stock", true));
            this.cod_pro_stockTextBox.Location = new System.Drawing.Point(234, 88);
            this.cod_pro_stockTextBox.Name = "cod_pro_stockTextBox";
            this.cod_pro_stockTextBox.ReadOnly = true;
            this.cod_pro_stockTextBox.Size = new System.Drawing.Size(202, 27);
            this.cod_pro_stockTextBox.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Marca:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(522, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Medida:";
            // 
            // _1_stockBindingNavigator
            // 
            this._1_stockBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this._1_stockBindingNavigator.BindingSource = this._1_stockBindingSource;
            this._1_stockBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this._1_stockBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this._1_stockBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this._1_stockBindingNavigatorSaveItem});
            this._1_stockBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this._1_stockBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this._1_stockBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this._1_stockBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this._1_stockBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this._1_stockBindingNavigator.Name = "_1_stockBindingNavigator";
            this._1_stockBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this._1_stockBindingNavigator.Size = new System.Drawing.Size(1006, 25);
            this._1_stockBindingNavigator.TabIndex = 2;
            this._1_stockBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // _1_stockBindingNavigatorSaveItem
            // 
            this._1_stockBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._1_stockBindingNavigatorSaveItem.Enabled = false;
            this._1_stockBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("_1_stockBindingNavigatorSaveItem.Image")));
            this._1_stockBindingNavigatorSaveItem.Name = "_1_stockBindingNavigatorSaveItem";
            this._1_stockBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this._1_stockBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this._1_stockDataGridView);
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1012, 504);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Listado";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // _1_stockDataGridView
            // 
            this._1_stockDataGridView.AllowUserToAddRows = false;
            this._1_stockDataGridView.AllowUserToDeleteRows = false;
            this._1_stockDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._1_stockDataGridView.AutoGenerateColumns = false;
            this._1_stockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._1_stockDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this._1_stockDataGridView.DataSource = this._1_stockBindingSource;
            this._1_stockDataGridView.Location = new System.Drawing.Point(8, 55);
            this._1_stockDataGridView.MultiSelect = false;
            this._1_stockDataGridView.Name = "_1_stockDataGridView";
            this._1_stockDataGridView.ReadOnly = true;
            this._1_stockDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._1_stockDataGridView.Size = new System.Drawing.Size(996, 441);
            this._1_stockDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cod_pro_stock";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código de Producto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "stk_act";
            this.dataGridViewTextBoxColumn3.HeaderText = "Stock actual";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "stk_opt";
            this.dataGridViewTextBoxColumn4.HeaderText = "Stock óptimo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "stk_cri";
            this.dataGridViewTextBoxColumn5.HeaderText = "Stock crítico";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "cod_cat";
            this.dataGridViewTextBoxColumn6.DataSource = this.categoriaBindingSource;
            this.dataGridViewTextBoxColumn6.DisplayMember = "nombre";
            this.dataGridViewTextBoxColumn6.HeaderText = "Categoría";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn6.ValueMember = "cod_cat";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1012, 504);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Productos por marca";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codprostockDataGridViewTextBoxColumn,
            this.codmarDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stockmarcaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(8, 82);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(446, 416);
            this.dataGridView1.TabIndex = 0;
            // 
            // codprostockDataGridViewTextBoxColumn
            // 
            this.codprostockDataGridViewTextBoxColumn.DataPropertyName = "cod_pro_stock";
            this.codprostockDataGridViewTextBoxColumn.DataSource = this._1_stockBindingSource;
            this.codprostockDataGridViewTextBoxColumn.DisplayMember = "nombre";
            this.codprostockDataGridViewTextBoxColumn.HeaderText = "Producto";
            this.codprostockDataGridViewTextBoxColumn.Name = "codprostockDataGridViewTextBoxColumn";
            this.codprostockDataGridViewTextBoxColumn.ReadOnly = true;
            this.codprostockDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.codprostockDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.codprostockDataGridViewTextBoxColumn.ValueMember = "cod_pro_stock";
            this.codprostockDataGridViewTextBoxColumn.Width = 200;
            // 
            // codmarDataGridViewTextBoxColumn
            // 
            this.codmarDataGridViewTextBoxColumn.DataPropertyName = "cod_mar";
            this.codmarDataGridViewTextBoxColumn.DataSource = this.marcaBindingSource;
            this.codmarDataGridViewTextBoxColumn.DisplayMember = "nombre";
            this.codmarDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.codmarDataGridViewTextBoxColumn.Name = "codmarDataGridViewTextBoxColumn";
            this.codmarDataGridViewTextBoxColumn.ReadOnly = true;
            this.codmarDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.codmarDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.codmarDataGridViewTextBoxColumn.ValueMember = "cod_mar";
            this.codmarDataGridViewTextBoxColumn.Width = 200;
            // 
            // stockmarcaBindingSource
            // 
            this.stockmarcaBindingSource.DataMember = "1_stock_marca";
            this.stockmarcaBindingSource.DataSource = this.capaDatosDataSet;
            // 
            // _1_stockTableAdapter
            // 
            this._1_stockTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager._1_banco_proveedorTableAdapter = null;
            this.tableAdapterManager._1_bien_usoTableAdapter = null;
            this.tableAdapterManager._1_buso_proveedorTableAdapter = null;
            this.tableAdapterManager._1_buso_scTableAdapter = null;
            this.tableAdapterManager._1_categoriaTableAdapter = this._1_categoriaTableAdapter;
            this.tableAdapterManager._1_cotizacion_pedido_reaprovisionamientoTableAdapter = null;
            this.tableAdapterManager._1_cotizacion_solicitud_compraTableAdapter = null;
            this.tableAdapterManager._1_cotizacionTableAdapter = null;
            this.tableAdapterManager._1_cuenta_corriente_proveedorTableAdapter = null;
            this.tableAdapterManager._1_empleadoTableAdapter = null;
            this.tableAdapterManager._1_factura_proveedorTableAdapter = null;
            this.tableAdapterManager._1_informe_recepcionTableAdapter = null;
            this.tableAdapterManager._1_marca_busoTableAdapter = null;
            this.tableAdapterManager._1_marcaTableAdapter = null;
            this.tableAdapterManager._1_medidaTableAdapter = null;
            this.tableAdapterManager._1_nota_creditoTableAdapter = null;
            this.tableAdapterManager._1_orden_compraTableAdapter = null;
            this.tableAdapterManager._1_pedido_devolucionTableAdapter = null;
            this.tableAdapterManager._1_pedido_reaprovisionamientoTableAdapter = null;
            this.tableAdapterManager._1_producto_recibidoTableAdapter = null;
            this.tableAdapterManager._1_proveedorTableAdapter = null;
            this.tableAdapterManager._1_registracionTableAdapter = null;
            this.tableAdapterManager._1_remito_proveedorTableAdapter = null;
            this.tableAdapterManager._1_rolTableAdapter = null;
            this.tableAdapterManager._1_solicitud_compraTableAdapter = null;
            this.tableAdapterManager._1_stock_marcaTableAdapter = null;
            this.tableAdapterManager._1_stock_medidaTableAdapter = null;
            this.tableAdapterManager._1_stock_proveedorTableAdapter = null;
            this.tableAdapterManager._1_stock_prTableAdapter = null;
            this.tableAdapterManager._1_stockTableAdapter = this._1_stockTableAdapter;
            this.tableAdapterManager._1_usuario_rolTableAdapter = null;
            this.tableAdapterManager._1_usuarioTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = CapaUsuario.CapaDatosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // _1_categoriaTableAdapter
            // 
            this._1_categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // _1_stock_marcaTableAdapter
            // 
            this._1_stock_marcaTableAdapter.ClearBeforeFill = true;
            // 
            // _1_marcaTableAdapter
            // 
            this._1_marcaTableAdapter.ClearBeforeFill = true;
            // 
            // medidaBindingSource
            // 
            this.medidaBindingSource.DataMember = "1_medida";
            this.medidaBindingSource.DataSource = this.capaDatosDataSet;
            // 
            // _1_medidaTableAdapter
            // 
            this._1_medidaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 534);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.FrmStock_Load);
            this.SizeChanged += new System.EventHandler(this.FrmStock_SizeChanged);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capaDatosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._1_stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._1_stockBindingNavigator)).EndInit();
            this._1_stockBindingNavigator.ResumeLayout(false);
            this._1_stockBindingNavigator.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._1_stockDataGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockmarcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medidaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private CapaDatosDataSet capaDatosDataSet;
        private System.Windows.Forms.BindingSource _1_stockBindingSource;
        private CapaDatosDataSetTableAdapters._1_stockTableAdapter _1_stockTableAdapter;
        private CapaDatosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView _1_stockDataGridView;
        private System.Windows.Forms.BindingNavigator _1_stockBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton _1_stockBindingNavigatorSaveItem;
        private CapaDatosDataSetTableAdapters._1_categoriaTableAdapter _1_categoriaTableAdapter;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource stockmarcaBindingSource;
        private CapaDatosDataSetTableAdapters._1_stock_marcaTableAdapter _1_stock_marcaTableAdapter;
        private System.Windows.Forms.BindingSource marcaBindingSource;
        private CapaDatosDataSetTableAdapters._1_marcaTableAdapter _1_marcaTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn codprostockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn codmarDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cod_catComboBox;
        private System.Windows.Forms.TextBox stk_criTextBox;
        private System.Windows.Forms.TextBox stk_optTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox cod_pro_stockTextBox;
        private System.Windows.Forms.ComboBox MedidaComboBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource medidaBindingSource;
        private CapaDatosDataSetTableAdapters._1_medidaTableAdapter _1_medidaTableAdapter;
    }
}