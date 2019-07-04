namespace CapaUsuario.Compras.Stock
{
    partial class FrmBusquedaStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBusquedaStock));
            this.DgvBusqueda = new System.Windows.Forms.DataGridView();
            this.capaDatosDataSet = new CapaUsuario.CapaDatosDataSet();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._1_stockTableAdapter = new CapaUsuario.CapaDatosDataSetTableAdapters._1_stockTableAdapter();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._1_categoriaTableAdapter = new CapaUsuario.CapaDatosDataSetTableAdapters._1_categoriaTableAdapter();
            this.codprostockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stkactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stkoptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stkcriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codcatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBusqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capaDatosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvBusqueda
            // 
            this.DgvBusqueda.AllowUserToAddRows = false;
            this.DgvBusqueda.AllowUserToDeleteRows = false;
            this.DgvBusqueda.AutoGenerateColumns = false;
            this.DgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBusqueda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codprostockDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.stkactDataGridViewTextBoxColumn,
            this.stkoptDataGridViewTextBoxColumn,
            this.stkcriDataGridViewTextBoxColumn,
            this.codcatDataGridViewTextBoxColumn});
            this.DgvBusqueda.DataSource = this.stockBindingSource;
            this.DgvBusqueda.Location = new System.Drawing.Point(14, 293);
            this.DgvBusqueda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DgvBusqueda.Name = "DgvBusqueda";
            this.DgvBusqueda.ReadOnly = true;
            this.DgvBusqueda.Size = new System.Drawing.Size(1006, 299);
            this.DgvBusqueda.TabIndex = 0;
            // 
            // capaDatosDataSet
            // 
            this.capaDatosDataSet.DataSetName = "CapaDatosDataSet";
            this.capaDatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "1_stock";
            this.stockBindingSource.DataSource = this.capaDatosDataSet;
            // 
            // _1_stockTableAdapter
            // 
            this._1_stockTableAdapter.ClearBeforeFill = true;
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "1_categoria";
            this.categoriaBindingSource.DataSource = this.capaDatosDataSet;
            // 
            // _1_categoriaTableAdapter
            // 
            this._1_categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // codprostockDataGridViewTextBoxColumn
            // 
            this.codprostockDataGridViewTextBoxColumn.DataPropertyName = "cod_pro_stock";
            this.codprostockDataGridViewTextBoxColumn.HeaderText = "Código de Producto";
            this.codprostockDataGridViewTextBoxColumn.Name = "codprostockDataGridViewTextBoxColumn";
            this.codprostockDataGridViewTextBoxColumn.ReadOnly = true;
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
            // FrmBusquedaStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 608);
            this.Controls.Add(this.DgvBusqueda);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBusquedaStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda de Producto";
            this.Load += new System.EventHandler(this.FrmBusquedaStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBusqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capaDatosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvBusqueda;
        private CapaDatosDataSet capaDatosDataSet;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private CapaDatosDataSetTableAdapters._1_stockTableAdapter _1_stockTableAdapter;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private CapaDatosDataSetTableAdapters._1_categoriaTableAdapter _1_categoriaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codprostockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stkactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stkoptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stkcriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn codcatDataGridViewTextBoxColumn;
    }
}