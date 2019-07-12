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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.quitarFiltrosButton = new System.Windows.Forms.Button();
            this.igualRadioButton = new System.Windows.Forms.RadioButton();
            this.termineRadioButton = new System.Windows.Forms.RadioButton();
            this.empieceRadioButton = new System.Windows.Forms.RadioButton();
            this.contengaRadioButton = new System.Windows.Forms.RadioButton();
            this.fillBy1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.nombreToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nombreToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillBy1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.codprostockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stkactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stkoptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stkcriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codcatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.capaUsuarioDataSet = new CapaUsuario.CapaUsuarioDataSet();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._1_stockTableAdapter = new CapaUsuario.CapaUsuarioDataSetTableAdapters._1_stockTableAdapter();
            this._1_categoriaTableAdapter = new CapaUsuario.CapaUsuarioDataSetTableAdapters._1_categoriaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBusqueda)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.fillBy1ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capaUsuarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
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
            this.DgvBusqueda.Location = new System.Drawing.Point(13, 202);
            this.DgvBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.DgvBusqueda.MultiSelect = false;
            this.DgvBusqueda.Name = "DgvBusqueda";
            this.DgvBusqueda.ReadOnly = true;
            this.DgvBusqueda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvBusqueda.Size = new System.Drawing.Size(869, 271);
            this.DgvBusqueda.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::CapaUsuario.Properties.Resources.cancel2;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(747, 99);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(113, 43);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Image = global::CapaUsuario.Properties.Resources.aceptar;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(618, 99);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(104, 43);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.quitarFiltrosButton);
            this.groupBox1.Controls.Add(this.igualRadioButton);
            this.groupBox1.Controls.Add(this.termineRadioButton);
            this.groupBox1.Controls.Add(this.empieceRadioButton);
            this.groupBox1.Controls.Add(this.contengaRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 65);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // quitarFiltrosButton
            // 
            this.quitarFiltrosButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quitarFiltrosButton.Location = new System.Drawing.Point(437, 20);
            this.quitarFiltrosButton.Name = "quitarFiltrosButton";
            this.quitarFiltrosButton.Size = new System.Drawing.Size(101, 31);
            this.quitarFiltrosButton.TabIndex = 4;
            this.quitarFiltrosButton.Text = "Quitar filtros";
            this.quitarFiltrosButton.UseVisualStyleBackColor = true;
            this.quitarFiltrosButton.Click += new System.EventHandler(this.quitarFiltrosButton_Click);
            // 
            // igualRadioButton
            // 
            this.igualRadioButton.AutoSize = true;
            this.igualRadioButton.Location = new System.Drawing.Point(344, 23);
            this.igualRadioButton.Name = "igualRadioButton";
            this.igualRadioButton.Size = new System.Drawing.Size(73, 21);
            this.igualRadioButton.TabIndex = 3;
            this.igualRadioButton.Text = "Igual a...";
            this.igualRadioButton.UseVisualStyleBackColor = true;
            // 
            // termineRadioButton
            // 
            this.termineRadioButton.AutoSize = true;
            this.termineRadioButton.Location = new System.Drawing.Point(237, 23);
            this.termineRadioButton.Name = "termineRadioButton";
            this.termineRadioButton.Size = new System.Drawing.Size(98, 21);
            this.termineRadioButton.TabIndex = 2;
            this.termineRadioButton.Text = "Termine en...";
            this.termineRadioButton.UseVisualStyleBackColor = true;
            // 
            // empieceRadioButton
            // 
            this.empieceRadioButton.AutoSize = true;
            this.empieceRadioButton.Location = new System.Drawing.Point(130, 23);
            this.empieceRadioButton.Name = "empieceRadioButton";
            this.empieceRadioButton.Size = new System.Drawing.Size(104, 21);
            this.empieceRadioButton.TabIndex = 1;
            this.empieceRadioButton.Text = "Empiece por...";
            this.empieceRadioButton.UseVisualStyleBackColor = true;
            // 
            // contengaRadioButton
            // 
            this.contengaRadioButton.AutoSize = true;
            this.contengaRadioButton.Checked = true;
            this.contengaRadioButton.Location = new System.Drawing.Point(23, 23);
            this.contengaRadioButton.Name = "contengaRadioButton";
            this.contengaRadioButton.Size = new System.Drawing.Size(80, 21);
            this.contengaRadioButton.TabIndex = 0;
            this.contengaRadioButton.TabStop = true;
            this.contengaRadioButton.Text = "Contenga";
            this.contengaRadioButton.UseVisualStyleBackColor = true;
            // 
            // fillBy1ToolStrip
            // 
            this.fillBy1ToolStrip.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.fillBy1ToolStrip.ImageScalingSize = new System.Drawing.Size(26, 26);
            this.fillBy1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nombreToolStripLabel,
            this.nombreToolStripTextBox,
            this.fillBy1ToolStripButton});
            this.fillBy1ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy1ToolStrip.Name = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Size = new System.Drawing.Size(902, 33);
            this.fillBy1ToolStrip.TabIndex = 9;
            this.fillBy1ToolStrip.Text = "fillBy1ToolStrip";
            // 
            // nombreToolStripLabel
            // 
            this.nombreToolStripLabel.Name = "nombreToolStripLabel";
            this.nombreToolStripLabel.Size = new System.Drawing.Size(67, 30);
            this.nombreToolStripLabel.Text = "Nombre:";
            // 
            // nombreToolStripTextBox
            // 
            this.nombreToolStripTextBox.Name = "nombreToolStripTextBox";
            this.nombreToolStripTextBox.Size = new System.Drawing.Size(100, 33);
            // 
            // fillBy1ToolStripButton
            // 
            this.fillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fillBy1ToolStripButton.Image = global::CapaUsuario.Properties.Resources.cool_seach32;
            this.fillBy1ToolStripButton.Name = "fillBy1ToolStripButton";
            this.fillBy1ToolStripButton.Size = new System.Drawing.Size(30, 30);
            this.fillBy1ToolStripButton.Text = "FillBy1";
            this.fillBy1ToolStripButton.ToolTipText = "Buscar";
            this.fillBy1ToolStripButton.Click += new System.EventHandler(this.fillBy1ToolStripButton_Click);
            // 
            // codprostockDataGridViewTextBoxColumn
            // 
            this.codprostockDataGridViewTextBoxColumn.DataPropertyName = "cod_pro_stock";
            this.codprostockDataGridViewTextBoxColumn.HeaderText = "Código de producto";
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
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "1_categoria";
            this.categoriaBindingSource.DataSource = this.capaUsuarioDataSet;
            // 
            // capaUsuarioDataSet
            // 
            this.capaUsuarioDataSet.DataSetName = "CapaUsuarioDataSet";
            this.capaUsuarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "1_stock";
            this.stockBindingSource.DataSource = this.capaUsuarioDataSet;
            // 
            // _1_stockTableAdapter
            // 
            this._1_stockTableAdapter.ClearBeforeFill = true;
            // 
            // _1_categoriaTableAdapter
            // 
            this._1_categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmBusquedaStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 493);
            this.Controls.Add(this.fillBy1ToolStrip);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgvBusqueda);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBusquedaStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda de Producto";
            this.Load += new System.EventHandler(this.FrmBusquedaStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBusqueda)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.fillBy1ToolStrip.ResumeLayout(false);
            this.fillBy1ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capaUsuarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvBusqueda;
        private CapaUsuarioDataSet capaUsuarioDataSet;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private CapaUsuarioDataSetTableAdapters._1_stockTableAdapter _1_stockTableAdapter;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private CapaUsuarioDataSetTableAdapters._1_categoriaTableAdapter _1_categoriaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codprostockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stkactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stkoptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stkcriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn codcatDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button quitarFiltrosButton;
        private System.Windows.Forms.RadioButton igualRadioButton;
        private System.Windows.Forms.RadioButton termineRadioButton;
        private System.Windows.Forms.RadioButton empieceRadioButton;
        private System.Windows.Forms.RadioButton contengaRadioButton;
        private System.Windows.Forms.ToolStrip fillBy1ToolStrip;
        private System.Windows.Forms.ToolStripLabel nombreToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nombreToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillBy1ToolStripButton;
    }
}