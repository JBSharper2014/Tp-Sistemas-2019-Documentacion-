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
            System.Windows.Forms.Label stk_actLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStock));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ActualizarButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codprostockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.capaUsuarioDataSet = new CapaUsuario.CapaUsuarioDataSet();
            this.codmarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.marcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockmarcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ActualizarStockButton = new MaterialSkin.Controls.MaterialFlatButton();
            this._1_stockDataGridView = new System.Windows.Forms.DataGridView();
            this.codprostockDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stkactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stkoptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stkcriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codcatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CancelarMarcaMedida = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label4 = new System.Windows.Forms.Label();
            this.GuardarMarcaMedidaButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label5 = new System.Windows.Forms.Label();
            this.MarcaComboBox = new System.Windows.Forms.ComboBox();
            this.MedidaComboBox = new System.Windows.Forms.ComboBox();
            this.medidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AgregarMarcaMedidaButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.stk_actTextBox = new System.Windows.Forms.TextBox();
            this.StockCriticoTextBox = new System.Windows.Forms.TextBox();
            this.StockOptimoTextBox = new System.Windows.Forms.TextBox();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.cod_pro_stockTextBox = new System.Windows.Forms.TextBox();
            this.CategoriaComboBox = new System.Windows.Forms.ComboBox();
            this._1_stockBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorEditItem = new System.Windows.Forms.ToolStripButton();
            this.StockBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCancel = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSearchItem = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this._1_categoriaTableAdapter = new CapaUsuario.CapaUsuarioDataSetTableAdapters._1_categoriaTableAdapter();
            this._1_stock_marcaTableAdapter = new CapaUsuario.CapaUsuarioDataSetTableAdapters._1_stock_marcaTableAdapter();
            this._1_stockTableAdapter = new CapaUsuario.CapaUsuarioDataSetTableAdapters._1_stockTableAdapter();
            this._1_marcaTableAdapter = new CapaUsuario.CapaUsuarioDataSetTableAdapters._1_marcaTableAdapter();
            this._1_medidaTableAdapter = new CapaUsuario.CapaUsuarioDataSetTableAdapters._1_medidaTableAdapter();
            this.tableAdapterManager1 = new CapaUsuario.CapaUsuarioDataSetTableAdapters.TableAdapterManager();
            cod_pro_stockLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            stk_optLabel = new System.Windows.Forms.Label();
            stk_criLabel = new System.Windows.Forms.Label();
            cod_catLabel = new System.Windows.Forms.Label();
            stk_actLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capaUsuarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockmarcaBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._1_stockDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medidaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._1_stockBindingNavigator)).BeginInit();
            this._1_stockBindingNavigator.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cod_pro_stockLabel
            // 
            cod_pro_stockLabel.AutoSize = true;
            cod_pro_stockLabel.Location = new System.Drawing.Point(82, 88);
            cod_pro_stockLabel.Name = "cod_pro_stockLabel";
            cod_pro_stockLabel.Size = new System.Drawing.Size(146, 20);
            cod_pro_stockLabel.TabIndex = 0;
            cod_pro_stockLabel.Text = "Código de producto:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(161, 159);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(67, 20);
            nombreLabel.TabIndex = 2;
            nombreLabel.Text = "Nombre:";
            // 
            // stk_optLabel
            // 
            stk_optLabel.AutoSize = true;
            stk_optLabel.Location = new System.Drawing.Point(128, 228);
            stk_optLabel.Name = "stk_optLabel";
            stk_optLabel.Size = new System.Drawing.Size(100, 20);
            stk_optLabel.TabIndex = 10;
            stk_optLabel.Text = "Stock óptimo:";
            // 
            // stk_criLabel
            // 
            stk_criLabel.AutoSize = true;
            stk_criLabel.Location = new System.Drawing.Point(137, 298);
            stk_criLabel.Name = "stk_criLabel";
            stk_criLabel.Size = new System.Drawing.Size(91, 20);
            stk_criLabel.TabIndex = 12;
            stk_criLabel.Text = "Stock crítico:";
            // 
            // cod_catLabel
            // 
            cod_catLabel.AutoSize = true;
            cod_catLabel.Location = new System.Drawing.Point(508, 160);
            cod_catLabel.Name = "cod_catLabel";
            cod_catLabel.Size = new System.Drawing.Size(76, 20);
            cod_catLabel.TabIndex = 4;
            cod_catLabel.Text = "Categoría:";
            // 
            // stk_actLabel
            // 
            stk_actLabel.AutoSize = true;
            stk_actLabel.Location = new System.Drawing.Point(493, 228);
            stk_actLabel.Name = "stk_actLabel";
            stk_actLabel.Size = new System.Drawing.Size(91, 20);
            stk_actLabel.TabIndex = 16;
            stk_actLabel.Text = "Stock actual:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.ActualizarButton);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1012, 620);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Productos por marca";
            // 
            // ActualizarButton
            // 
            this.ActualizarButton.AutoSize = true;
            this.ActualizarButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ActualizarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ActualizarButton.Depth = 0;
            this.ActualizarButton.Location = new System.Drawing.Point(42, 23);
            this.ActualizarButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ActualizarButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ActualizarButton.Name = "ActualizarButton";
            this.ActualizarButton.Primary = false;
            this.ActualizarButton.Size = new System.Drawing.Size(94, 36);
            this.ActualizarButton.TabIndex = 3;
            this.ActualizarButton.Text = "Actualizar";
            this.ActualizarButton.UseVisualStyleBackColor = true;
            this.ActualizarButton.Click += new System.EventHandler(this.ActualizarButton_Click);
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
            this.dataGridView1.Size = new System.Drawing.Size(495, 416);
            this.dataGridView1.TabIndex = 0;
            // 
            // codprostockDataGridViewTextBoxColumn
            // 
            this.codprostockDataGridViewTextBoxColumn.DataPropertyName = "cod_pro_stock";
            this.codprostockDataGridViewTextBoxColumn.DataSource = this.stockBindingSource;
            this.codprostockDataGridViewTextBoxColumn.DisplayMember = "nombre";
            this.codprostockDataGridViewTextBoxColumn.HeaderText = "Producto";
            this.codprostockDataGridViewTextBoxColumn.Name = "codprostockDataGridViewTextBoxColumn";
            this.codprostockDataGridViewTextBoxColumn.ReadOnly = true;
            this.codprostockDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.codprostockDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.codprostockDataGridViewTextBoxColumn.ValueMember = "cod_pro_stock";
            this.codprostockDataGridViewTextBoxColumn.Width = 200;
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "1_stock";
            this.stockBindingSource.DataSource = this.capaUsuarioDataSet;
            // 
            // capaUsuarioDataSet
            // 
            this.capaUsuarioDataSet.DataSetName = "CapaUsuarioDataSet";
            this.capaUsuarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.codmarDataGridViewTextBoxColumn.Width = 250;
            // 
            // marcaBindingSource
            // 
            this.marcaBindingSource.DataMember = "1_marca";
            this.marcaBindingSource.DataSource = this.capaUsuarioDataSet;
            // 
            // stockmarcaBindingSource
            // 
            this.stockmarcaBindingSource.DataMember = "1_stock_marca";
            this.stockmarcaBindingSource.DataSource = this.capaUsuarioDataSet;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.ActualizarStockButton);
            this.tabPage2.Controls.Add(this._1_stockDataGridView);
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1012, 620);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Listado";
            // 
            // ActualizarStockButton
            // 
            this.ActualizarStockButton.AutoSize = true;
            this.ActualizarStockButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ActualizarStockButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ActualizarStockButton.Depth = 0;
            this.ActualizarStockButton.Location = new System.Drawing.Point(36, 25);
            this.ActualizarStockButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ActualizarStockButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ActualizarStockButton.Name = "ActualizarStockButton";
            this.ActualizarStockButton.Primary = false;
            this.ActualizarStockButton.Size = new System.Drawing.Size(94, 36);
            this.ActualizarStockButton.TabIndex = 2;
            this.ActualizarStockButton.Text = "Actualizar";
            this.ActualizarStockButton.UseVisualStyleBackColor = true;
            this.ActualizarStockButton.Click += new System.EventHandler(this.ActualizarStockButton_Click);
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
            this.codprostockDataGridViewTextBoxColumn1,
            this.nombreDataGridViewTextBoxColumn,
            this.stkactDataGridViewTextBoxColumn,
            this.stkoptDataGridViewTextBoxColumn,
            this.stkcriDataGridViewTextBoxColumn,
            this.codcatDataGridViewTextBoxColumn});
            this._1_stockDataGridView.DataSource = this.stockBindingSource;
            this._1_stockDataGridView.Location = new System.Drawing.Point(8, 70);
            this._1_stockDataGridView.MultiSelect = false;
            this._1_stockDataGridView.Name = "_1_stockDataGridView";
            this._1_stockDataGridView.ReadOnly = true;
            this._1_stockDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._1_stockDataGridView.Size = new System.Drawing.Size(996, 426);
            this._1_stockDataGridView.TabIndex = 0;
            // 
            // codprostockDataGridViewTextBoxColumn1
            // 
            this.codprostockDataGridViewTextBoxColumn1.DataPropertyName = "cod_pro_stock";
            this.codprostockDataGridViewTextBoxColumn1.HeaderText = "Código de producto";
            this.codprostockDataGridViewTextBoxColumn1.Name = "codprostockDataGridViewTextBoxColumn1";
            this.codprostockDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stkactDataGridViewTextBoxColumn
            // 
            this.stkactDataGridViewTextBoxColumn.DataPropertyName = "stk_act";
            this.stkactDataGridViewTextBoxColumn.HeaderText = "Stock actual";
            this.stkactDataGridViewTextBoxColumn.Name = "stkactDataGridViewTextBoxColumn";
            this.stkactDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stkoptDataGridViewTextBoxColumn
            // 
            this.stkoptDataGridViewTextBoxColumn.DataPropertyName = "stk_opt";
            this.stkoptDataGridViewTextBoxColumn.HeaderText = "Stock óptimo";
            this.stkoptDataGridViewTextBoxColumn.Name = "stkoptDataGridViewTextBoxColumn";
            this.stkoptDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stkcriDataGridViewTextBoxColumn
            // 
            this.stkcriDataGridViewTextBoxColumn.DataPropertyName = "stk_cri";
            this.stkcriDataGridViewTextBoxColumn.HeaderText = "Stock crítico";
            this.stkcriDataGridViewTextBoxColumn.Name = "stkcriDataGridViewTextBoxColumn";
            this.stkcriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codcatDataGridViewTextBoxColumn
            // 
            this.codcatDataGridViewTextBoxColumn.DataPropertyName = "cod_cat";
            this.codcatDataGridViewTextBoxColumn.DataSource = this.categoriaBindingSource;
            this.codcatDataGridViewTextBoxColumn.DisplayMember = "nombre";
            this.codcatDataGridViewTextBoxColumn.HeaderText = "Categoría";
            this.codcatDataGridViewTextBoxColumn.Name = "codcatDataGridViewTextBoxColumn";
            this.codcatDataGridViewTextBoxColumn.ReadOnly = true;
            this.codcatDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.codcatDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.codcatDataGridViewTextBoxColumn.ValueMember = "cod_cat";
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "1_categoria";
            this.categoriaBindingSource.DataSource = this.capaUsuarioDataSet;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(stk_actLabel);
            this.tabPage1.Controls.Add(this.stk_actTextBox);
            this.tabPage1.Controls.Add(this.StockCriticoTextBox);
            this.tabPage1.Controls.Add(this.StockOptimoTextBox);
            this.tabPage1.Controls.Add(this.NombreTextBox);
            this.tabPage1.Controls.Add(this.cod_pro_stockTextBox);
            this.tabPage1.Controls.Add(cod_catLabel);
            this.tabPage1.Controls.Add(this.CategoriaComboBox);
            this.tabPage1.Controls.Add(stk_criLabel);
            this.tabPage1.Controls.Add(stk_optLabel);
            this.tabPage1.Controls.Add(nombreLabel);
            this.tabPage1.Controls.Add(cod_pro_stockLabel);
            this.tabPage1.Controls.Add(this._1_stockBindingNavigator);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1012, 620);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mantenimiento";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CancelarMarcaMedida);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.GuardarMarcaMedidaButton);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.MarcaComboBox);
            this.groupBox1.Controls.Add(this.MedidaComboBox);
            this.groupBox1.Controls.Add(this.AgregarMarcaMedidaButton);
            this.groupBox1.Location = new System.Drawing.Point(86, 364);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(893, 169);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marca y medida";
            // 
            // CancelarMarcaMedida
            // 
            this.CancelarMarcaMedida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelarMarcaMedida.Depth = 0;
            this.CancelarMarcaMedida.Enabled = false;
            this.CancelarMarcaMedida.Location = new System.Drawing.Point(670, 44);
            this.CancelarMarcaMedida.MouseState = MaterialSkin.MouseState.HOVER;
            this.CancelarMarcaMedida.Name = "CancelarMarcaMedida";
            this.CancelarMarcaMedida.Primary = true;
            this.CancelarMarcaMedida.Size = new System.Drawing.Size(130, 36);
            this.CancelarMarcaMedida.TabIndex = 19;
            this.CancelarMarcaMedida.Text = "Cancelar";
            this.CancelarMarcaMedida.UseVisualStyleBackColor = true;
            this.CancelarMarcaMedida.Click += new System.EventHandler(this.CancelarMarcaMedida_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Medida:";
            // 
            // GuardarMarcaMedidaButton
            // 
            this.GuardarMarcaMedidaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GuardarMarcaMedidaButton.Depth = 0;
            this.GuardarMarcaMedidaButton.Enabled = false;
            this.GuardarMarcaMedidaButton.Location = new System.Drawing.Point(504, 44);
            this.GuardarMarcaMedidaButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.GuardarMarcaMedidaButton.Name = "GuardarMarcaMedidaButton";
            this.GuardarMarcaMedidaButton.Primary = true;
            this.GuardarMarcaMedidaButton.Size = new System.Drawing.Size(130, 36);
            this.GuardarMarcaMedidaButton.TabIndex = 18;
            this.GuardarMarcaMedidaButton.Text = "Guardar";
            this.GuardarMarcaMedidaButton.UseVisualStyleBackColor = true;
            this.GuardarMarcaMedidaButton.Click += new System.EventHandler(this.GuardarMarcaMedidaButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Marca:";
            // 
            // MarcaComboBox
            // 
            this.MarcaComboBox.DataSource = this.marcaBindingSource;
            this.MarcaComboBox.DisplayMember = "nombre";
            this.MarcaComboBox.Enabled = false;
            this.MarcaComboBox.FormattingEnabled = true;
            this.MarcaComboBox.Location = new System.Drawing.Point(148, 112);
            this.MarcaComboBox.Name = "MarcaComboBox";
            this.MarcaComboBox.Size = new System.Drawing.Size(230, 28);
            this.MarcaComboBox.TabIndex = 7;
            this.MarcaComboBox.ValueMember = "cod_mar";
            // 
            // MedidaComboBox
            // 
            this.MedidaComboBox.DataSource = this.medidaBindingSource;
            this.MedidaComboBox.DisplayMember = "nombre";
            this.MedidaComboBox.Enabled = false;
            this.MedidaComboBox.FormattingEnabled = true;
            this.MedidaComboBox.Location = new System.Drawing.Point(504, 112);
            this.MedidaComboBox.Name = "MedidaComboBox";
            this.MedidaComboBox.Size = new System.Drawing.Size(250, 28);
            this.MedidaComboBox.TabIndex = 9;
            this.MedidaComboBox.ValueMember = "cod_med";
            // 
            // medidaBindingSource
            // 
            this.medidaBindingSource.DataMember = "1_medida";
            this.medidaBindingSource.DataSource = this.capaUsuarioDataSet;
            // 
            // AgregarMarcaMedidaButton
            // 
            this.AgregarMarcaMedidaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AgregarMarcaMedidaButton.Depth = 0;
            this.AgregarMarcaMedidaButton.Location = new System.Drawing.Point(148, 44);
            this.AgregarMarcaMedidaButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AgregarMarcaMedidaButton.Name = "AgregarMarcaMedidaButton";
            this.AgregarMarcaMedidaButton.Primary = true;
            this.AgregarMarcaMedidaButton.Size = new System.Drawing.Size(230, 36);
            this.AgregarMarcaMedidaButton.TabIndex = 15;
            this.AgregarMarcaMedidaButton.Text = "Agregar una marca y medida";
            this.AgregarMarcaMedidaButton.UseVisualStyleBackColor = true;
            this.AgregarMarcaMedidaButton.Click += new System.EventHandler(this.AgregarMarcaMedidaButton_Click);
            // 
            // stk_actTextBox
            // 
            this.stk_actTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "stk_act", true));
            this.stk_actTextBox.Location = new System.Drawing.Point(590, 225);
            this.stk_actTextBox.Name = "stk_actTextBox";
            this.stk_actTextBox.ReadOnly = true;
            this.stk_actTextBox.Size = new System.Drawing.Size(236, 27);
            this.stk_actTextBox.TabIndex = 17;
            // 
            // StockCriticoTextBox
            // 
            this.StockCriticoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "stk_cri", true));
            this.StockCriticoTextBox.Location = new System.Drawing.Point(234, 295);
            this.StockCriticoTextBox.MaxLength = 4;
            this.StockCriticoTextBox.Name = "StockCriticoTextBox";
            this.StockCriticoTextBox.ReadOnly = true;
            this.StockCriticoTextBox.Size = new System.Drawing.Size(202, 27);
            this.StockCriticoTextBox.TabIndex = 13;
            // 
            // StockOptimoTextBox
            // 
            this.StockOptimoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "stk_opt", true));
            this.StockOptimoTextBox.Location = new System.Drawing.Point(234, 225);
            this.StockOptimoTextBox.MaxLength = 4;
            this.StockOptimoTextBox.Name = "StockOptimoTextBox";
            this.StockOptimoTextBox.ReadOnly = true;
            this.StockOptimoTextBox.Size = new System.Drawing.Size(202, 27);
            this.StockOptimoTextBox.TabIndex = 11;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "nombre", true));
            this.NombreTextBox.Location = new System.Drawing.Point(234, 157);
            this.NombreTextBox.MaxLength = 50;
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.ReadOnly = true;
            this.NombreTextBox.Size = new System.Drawing.Size(202, 27);
            this.NombreTextBox.TabIndex = 3;
            // 
            // cod_pro_stockTextBox
            // 
            this.cod_pro_stockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "cod_pro_stock", true));
            this.cod_pro_stockTextBox.Location = new System.Drawing.Point(234, 88);
            this.cod_pro_stockTextBox.Name = "cod_pro_stockTextBox";
            this.cod_pro_stockTextBox.ReadOnly = true;
            this.cod_pro_stockTextBox.Size = new System.Drawing.Size(202, 27);
            this.cod_pro_stockTextBox.TabIndex = 1;
            // 
            // CategoriaComboBox
            // 
            this.CategoriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.stockBindingSource, "cod_cat", true));
            this.CategoriaComboBox.DataSource = this.categoriaBindingSource;
            this.CategoriaComboBox.DisplayMember = "nombre";
            this.CategoriaComboBox.Enabled = false;
            this.CategoriaComboBox.FormattingEnabled = true;
            this.CategoriaComboBox.Location = new System.Drawing.Point(590, 156);
            this.CategoriaComboBox.Name = "CategoriaComboBox";
            this.CategoriaComboBox.Size = new System.Drawing.Size(236, 28);
            this.CategoriaComboBox.TabIndex = 5;
            this.CategoriaComboBox.ValueMember = "cod_cat";
            this.CategoriaComboBox.SelectedValueChanged += new System.EventHandler(this.cod_catComboBox_SelectedValueChanged);
            // 
            // _1_stockBindingNavigator
            // 
            this._1_stockBindingNavigator.AddNewItem = null;
            this._1_stockBindingNavigator.BindingSource = this.stockBindingSource;
            this._1_stockBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this._1_stockBindingNavigator.DeleteItem = null;
            this._1_stockBindingNavigator.ImageScalingSize = new System.Drawing.Size(28, 28);
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
            this.bindingNavigatorEditItem,
            this.StockBindingNavigatorSaveItem,
            this.bindingNavigatorCancel,
            this.bindingNavigatorSearchItem});
            this._1_stockBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this._1_stockBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this._1_stockBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this._1_stockBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this._1_stockBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this._1_stockBindingNavigator.Name = "_1_stockBindingNavigator";
            this._1_stockBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this._1_stockBindingNavigator.Size = new System.Drawing.Size(1006, 35);
            this._1_stockBindingNavigator.TabIndex = 2;
            this._1_stockBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 32);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = global::CapaUsuario.Properties.Resources.first;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(32, 32);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = global::CapaUsuario.Properties.Resources.previous1;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(32, 32);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 35);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = global::CapaUsuario.Properties.Resources.next;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(32, 32);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = global::CapaUsuario.Properties.Resources.last;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(32, 32);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = global::CapaUsuario.Properties.Resources.Nuevo;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(32, 32);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = global::CapaUsuario.Properties.Resources.Borrar2;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(32, 32);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorEditItem
            // 
            this.bindingNavigatorEditItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorEditItem.Image = global::CapaUsuario.Properties.Resources.editWhite32;
            this.bindingNavigatorEditItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorEditItem.Name = "bindingNavigatorEditItem";
            this.bindingNavigatorEditItem.Size = new System.Drawing.Size(32, 32);
            this.bindingNavigatorEditItem.Text = "Editar";
            this.bindingNavigatorEditItem.Click += new System.EventHandler(this.bindingNavigatorEditItem_Click);
            // 
            // StockBindingNavigatorSaveItem
            // 
            this.StockBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StockBindingNavigatorSaveItem.Enabled = false;
            this.StockBindingNavigatorSaveItem.Image = global::CapaUsuario.Properties.Resources.save3;
            this.StockBindingNavigatorSaveItem.Name = "StockBindingNavigatorSaveItem";
            this.StockBindingNavigatorSaveItem.Size = new System.Drawing.Size(32, 32);
            this.StockBindingNavigatorSaveItem.Text = "Guardar datos";
            this.StockBindingNavigatorSaveItem.Click += new System.EventHandler(this.StockBindingNavigatorSaveItem_Click);
            // 
            // bindingNavigatorCancel
            // 
            this.bindingNavigatorCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorCancel.Enabled = false;
            this.bindingNavigatorCancel.Image = global::CapaUsuario.Properties.Resources.cancel2;
            this.bindingNavigatorCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorCancel.Name = "bindingNavigatorCancel";
            this.bindingNavigatorCancel.Size = new System.Drawing.Size(32, 32);
            this.bindingNavigatorCancel.Text = "Cancelar operación";
            this.bindingNavigatorCancel.Click += new System.EventHandler(this.bindingNavigatorCancel_Click);
            // 
            // bindingNavigatorSearchItem
            // 
            this.bindingNavigatorSearchItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorSearchItem.Image = global::CapaUsuario.Properties.Resources.cool_seach32;
            this.bindingNavigatorSearchItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorSearchItem.Name = "bindingNavigatorSearchItem";
            this.bindingNavigatorSearchItem.Size = new System.Drawing.Size(32, 32);
            this.bindingNavigatorSearchItem.Text = "Buscar...";
            this.bindingNavigatorSearchItem.Click += new System.EventHandler(this.bindingNavigatorSearchItem_Click);
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
            this.tabControl1.Size = new System.Drawing.Size(1020, 650);
            this.tabControl1.TabIndex = 0;
            // 
            // _1_categoriaTableAdapter
            // 
            this._1_categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // _1_stock_marcaTableAdapter
            // 
            this._1_stock_marcaTableAdapter.ClearBeforeFill = true;
            // 
            // _1_stockTableAdapter
            // 
            this._1_stockTableAdapter.ClearBeforeFill = true;
            // 
            // _1_marcaTableAdapter
            // 
            this._1_marcaTableAdapter.ClearBeforeFill = true;
            // 
            // _1_medidaTableAdapter
            // 
            this._1_medidaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1._1_banco_proveedorTableAdapter = null;
            this.tableAdapterManager1._1_bien_usoTableAdapter = null;
            this.tableAdapterManager1._1_buso_proveedorTableAdapter = null;
            this.tableAdapterManager1._1_buso_scTableAdapter = null;
            this.tableAdapterManager1._1_categoriaTableAdapter = this._1_categoriaTableAdapter;
            this.tableAdapterManager1._1_cotizacion_pedido_reaprovisionamientoTableAdapter = null;
            this.tableAdapterManager1._1_cotizacion_solicitud_compraTableAdapter = null;
            this.tableAdapterManager1._1_cotizacionTableAdapter = null;
            this.tableAdapterManager1._1_cuenta_corriente_proveedorTableAdapter = null;
            this.tableAdapterManager1._1_empleadoTableAdapter = null;
            this.tableAdapterManager1._1_factura_proveedorTableAdapter = null;
            this.tableAdapterManager1._1_informe_recepcionTableAdapter = null;
            this.tableAdapterManager1._1_marca_busoTableAdapter = null;
            this.tableAdapterManager1._1_marcaTableAdapter = this._1_marcaTableAdapter;
            this.tableAdapterManager1._1_medidaTableAdapter = this._1_medidaTableAdapter;
            this.tableAdapterManager1._1_nota_creditoTableAdapter = null;
            this.tableAdapterManager1._1_orden_compraTableAdapter = null;
            this.tableAdapterManager1._1_pedido_devolucionTableAdapter = null;
            this.tableAdapterManager1._1_pedido_reaprovisionamientoTableAdapter = null;
            this.tableAdapterManager1._1_producto_recibidoTableAdapter = null;
            this.tableAdapterManager1._1_proveedorTableAdapter = null;
            this.tableAdapterManager1._1_registracionTableAdapter = null;
            this.tableAdapterManager1._1_remito_proveedorTableAdapter = null;
            this.tableAdapterManager1._1_rolTableAdapter = null;
            this.tableAdapterManager1._1_solicitud_compraTableAdapter = null;
            this.tableAdapterManager1._1_stock_marcaTableAdapter = this._1_stock_marcaTableAdapter;
            this.tableAdapterManager1._1_stock_medidaTableAdapter = null;
            this.tableAdapterManager1._1_stock_proveedorTableAdapter = null;
            this.tableAdapterManager1._1_stock_prTableAdapter = null;
            this.tableAdapterManager1._1_stockTableAdapter = this._1_stockTableAdapter;
            this.tableAdapterManager1._1_usuario_rolTableAdapter = null;
            this.tableAdapterManager1._1_usuarioTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = CapaUsuario.CapaUsuarioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FrmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 650);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.FrmStock_Load);
            this.SizeChanged += new System.EventHandler(this.FrmStock_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capaUsuarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockmarcaBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._1_stockDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medidaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._1_stockBindingNavigator)).EndInit();
            this._1_stockBindingNavigator.ResumeLayout(false);
            this._1_stockBindingNavigator.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialRaisedButton CancelarMarcaMedida;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialRaisedButton GuardarMarcaMedidaButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox MarcaComboBox;
        private System.Windows.Forms.ComboBox MedidaComboBox;
        private MaterialSkin.Controls.MaterialRaisedButton AgregarMarcaMedidaButton;
        private System.Windows.Forms.TextBox stk_actTextBox;
        private System.Windows.Forms.TextBox StockCriticoTextBox;
        private System.Windows.Forms.TextBox StockOptimoTextBox;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.TextBox cod_pro_stockTextBox;
        private System.Windows.Forms.ComboBox CategoriaComboBox;
        private System.Windows.Forms.BindingNavigator _1_stockBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorEditItem;
        private System.Windows.Forms.ToolStripButton StockBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorCancel;
        private System.Windows.Forms.ToolStripButton bindingNavigatorSearchItem;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialFlatButton ActualizarStockButton;
        private System.Windows.Forms.DataGridView _1_stockDataGridView;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialFlatButton ActualizarButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CapaUsuarioDataSet capaUsuarioDataSet;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private CapaUsuarioDataSetTableAdapters._1_categoriaTableAdapter _1_categoriaTableAdapter;
        private System.Windows.Forms.BindingSource stockmarcaBindingSource;
        private CapaUsuarioDataSetTableAdapters._1_stock_marcaTableAdapter _1_stock_marcaTableAdapter;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private CapaUsuarioDataSetTableAdapters._1_stockTableAdapter _1_stockTableAdapter;
        private System.Windows.Forms.BindingSource marcaBindingSource;
        private CapaUsuarioDataSetTableAdapters._1_marcaTableAdapter _1_marcaTableAdapter;
        private System.Windows.Forms.BindingSource medidaBindingSource;
        private CapaUsuarioDataSetTableAdapters._1_medidaTableAdapter _1_medidaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codprostockDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stkactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stkoptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stkcriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn codcatDataGridViewTextBoxColumn;
        private CapaUsuarioDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridViewComboBoxColumn codprostockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn codmarDataGridViewTextBoxColumn;
    }
}