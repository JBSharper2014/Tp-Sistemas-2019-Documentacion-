namespace CapaUsuario.Compras.Bienes_de_uso
{
    partial class FrmBienUso
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
            System.Windows.Forms.Label cod_pro_busoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label stockLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label observacionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBienUso));
            this.capaUsuarioDataSet = new CapaUsuario.CapaUsuarioDataSet();
            this._1_bien_usoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._1_bien_usoTableAdapter = new CapaUsuario.CapaUsuarioDataSetTableAdapters._1_bien_usoTableAdapter();
            this.tableAdapterManager = new CapaUsuario.CapaUsuarioDataSetTableAdapters.TableAdapterManager();
            this._1_bien_usoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this._1_bien_usoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_pro_busoTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.stockTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.observacionTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            cod_pro_busoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            stockLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            observacionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.capaUsuarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._1_bien_usoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._1_bien_usoBindingNavigator)).BeginInit();
            this._1_bien_usoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._1_bien_usoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cod_pro_busoLabel
            // 
            cod_pro_busoLabel.AutoSize = true;
            cod_pro_busoLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cod_pro_busoLabel.Location = new System.Drawing.Point(256, 77);
            cod_pro_busoLabel.Name = "cod_pro_busoLabel";
            cod_pro_busoLabel.Size = new System.Drawing.Size(161, 20);
            cod_pro_busoLabel.TabIndex = 2;
            cod_pro_busoLabel.Text = "Código de bien de uso:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(350, 131);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(67, 20);
            nombreLabel.TabIndex = 4;
            nombreLabel.Text = "Nombre:";
            // 
            // stockLabel
            // 
            stockLabel.AutoSize = true;
            stockLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stockLabel.Location = new System.Drawing.Point(368, 185);
            stockLabel.Name = "stockLabel";
            stockLabel.Size = new System.Drawing.Size(49, 20);
            stockLabel.TabIndex = 6;
            stockLabel.Text = "Stock:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descripcionLabel.Location = new System.Drawing.Point(330, 239);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(87, 20);
            descripcionLabel.TabIndex = 8;
            descripcionLabel.Text = "Descripción:";
            // 
            // observacionLabel
            // 
            observacionLabel.AutoSize = true;
            observacionLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            observacionLabel.Location = new System.Drawing.Point(309, 293);
            observacionLabel.Name = "observacionLabel";
            observacionLabel.Size = new System.Drawing.Size(108, 20);
            observacionLabel.TabIndex = 10;
            observacionLabel.Text = "Observaciones:";
            // 
            // capaUsuarioDataSet
            // 
            this.capaUsuarioDataSet.DataSetName = "CapaUsuarioDataSet";
            this.capaUsuarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // _1_bien_usoBindingSource
            // 
            this._1_bien_usoBindingSource.DataMember = "1_bien_uso";
            this._1_bien_usoBindingSource.DataSource = this.capaUsuarioDataSet;
            // 
            // _1_bien_usoTableAdapter
            // 
            this._1_bien_usoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager._1_banco_proveedorTableAdapter = null;
            this.tableAdapterManager._1_bien_usoTableAdapter = this._1_bien_usoTableAdapter;
            this.tableAdapterManager._1_buso_proveedorTableAdapter = null;
            this.tableAdapterManager._1_buso_scTableAdapter = null;
            this.tableAdapterManager._1_categoriaTableAdapter = null;
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
            this.tableAdapterManager._1_stockTableAdapter = null;
            this.tableAdapterManager._1_usuario_rolTableAdapter = null;
            this.tableAdapterManager._1_usuarioTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = CapaUsuario.CapaUsuarioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // _1_bien_usoBindingNavigator
            // 
            this._1_bien_usoBindingNavigator.AddNewItem = null;
            this._1_bien_usoBindingNavigator.BindingSource = this._1_bien_usoBindingSource;
            this._1_bien_usoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this._1_bien_usoBindingNavigator.DeleteItem = null;
            this._1_bien_usoBindingNavigator.ImageScalingSize = new System.Drawing.Size(28, 28);
            this._1_bien_usoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this._1_bien_usoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this._1_bien_usoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this._1_bien_usoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this._1_bien_usoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this._1_bien_usoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this._1_bien_usoBindingNavigator.Name = "_1_bien_usoBindingNavigator";
            this._1_bien_usoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this._1_bien_usoBindingNavigator.Size = new System.Drawing.Size(1152, 35);
            this._1_bien_usoBindingNavigator.TabIndex = 0;
            this._1_bien_usoBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(58, 23);
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
            this.StockBindingNavigatorSaveItem.Click += new System.EventHandler(this._1_bien_usoBindingNavigatorSaveItem_Click);
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
            // _1_bien_usoDataGridView
            // 
            this._1_bien_usoDataGridView.AllowUserToAddRows = false;
            this._1_bien_usoDataGridView.AllowUserToDeleteRows = false;
            this._1_bien_usoDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._1_bien_usoDataGridView.AutoGenerateColumns = false;
            this._1_bien_usoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._1_bien_usoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this._1_bien_usoDataGridView.DataSource = this._1_bien_usoBindingSource;
            this._1_bien_usoDataGridView.Location = new System.Drawing.Point(14, 423);
            this._1_bien_usoDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._1_bien_usoDataGridView.MultiSelect = false;
            this._1_bien_usoDataGridView.Name = "_1_bien_usoDataGridView";
            this._1_bien_usoDataGridView.ReadOnly = true;
            this._1_bien_usoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._1_bien_usoDataGridView.Size = new System.Drawing.Size(1124, 278);
            this._1_bien_usoDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cod_pro_buso";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código de bien de uso";
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "stock";
            this.dataGridViewTextBoxColumn3.HeaderText = "Stock";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "descripcion";
            this.dataGridViewTextBoxColumn4.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "observacion";
            this.dataGridViewTextBoxColumn5.HeaderText = "Observaciones";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // cod_pro_busoTextBox
            // 
            this.cod_pro_busoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._1_bien_usoBindingSource, "cod_pro_buso", true));
            this.cod_pro_busoTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cod_pro_busoTextBox.Location = new System.Drawing.Point(434, 74);
            this.cod_pro_busoTextBox.Name = "cod_pro_busoTextBox";
            this.cod_pro_busoTextBox.ReadOnly = true;
            this.cod_pro_busoTextBox.Size = new System.Drawing.Size(268, 27);
            this.cod_pro_busoTextBox.TabIndex = 3;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._1_bien_usoBindingSource, "nombre", true));
            this.nombreTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(434, 128);
            this.nombreTextBox.MaxLength = 50;
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.ReadOnly = true;
            this.nombreTextBox.Size = new System.Drawing.Size(268, 27);
            this.nombreTextBox.TabIndex = 5;
            // 
            // stockTextBox
            // 
            this.stockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._1_bien_usoBindingSource, "stock", true));
            this.stockTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockTextBox.Location = new System.Drawing.Point(434, 182);
            this.stockTextBox.MaxLength = 4;
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.ReadOnly = true;
            this.stockTextBox.Size = new System.Drawing.Size(268, 27);
            this.stockTextBox.TabIndex = 7;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._1_bien_usoBindingSource, "descripcion", true));
            this.descripcionTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionTextBox.Location = new System.Drawing.Point(434, 236);
            this.descripcionTextBox.MaxLength = 50;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.ReadOnly = true;
            this.descripcionTextBox.Size = new System.Drawing.Size(268, 27);
            this.descripcionTextBox.TabIndex = 9;
            // 
            // observacionTextBox
            // 
            this.observacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._1_bien_usoBindingSource, "observacion", true));
            this.observacionTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.observacionTextBox.Location = new System.Drawing.Point(434, 290);
            this.observacionTextBox.MaxLength = 200;
            this.observacionTextBox.Multiline = true;
            this.observacionTextBox.Name = "observacionTextBox";
            this.observacionTextBox.ReadOnly = true;
            this.observacionTextBox.Size = new System.Drawing.Size(404, 104);
            this.observacionTextBox.TabIndex = 11;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // FrmBienUso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 741);
            this.Controls.Add(observacionLabel);
            this.Controls.Add(this.observacionTextBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(stockLabel);
            this.Controls.Add(this.stockTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(cod_pro_busoLabel);
            this.Controls.Add(this.cod_pro_busoTextBox);
            this.Controls.Add(this._1_bien_usoDataGridView);
            this.Controls.Add(this._1_bien_usoBindingNavigator);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmBienUso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienes de Uso";
            this.Load += new System.EventHandler(this.FrmBienUso_Load);
            this.SizeChanged += new System.EventHandler(this.FrmBienUso_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.capaUsuarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._1_bien_usoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._1_bien_usoBindingNavigator)).EndInit();
            this._1_bien_usoBindingNavigator.ResumeLayout(false);
            this._1_bien_usoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._1_bien_usoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CapaUsuarioDataSet capaUsuarioDataSet;
        private System.Windows.Forms.BindingSource _1_bien_usoBindingSource;
        private CapaUsuarioDataSetTableAdapters._1_bien_usoTableAdapter _1_bien_usoTableAdapter;
        private CapaUsuarioDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator _1_bien_usoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton StockBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView _1_bien_usoDataGridView;
        private System.Windows.Forms.ToolStripButton bindingNavigatorEditItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorCancel;
        private System.Windows.Forms.ToolStripButton bindingNavigatorSearchItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox cod_pro_busoTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox stockTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox observacionTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}