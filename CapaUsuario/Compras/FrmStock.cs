using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaUsuario.Compras
{
    public partial class FrmStock : Form
    {
        public FrmStock()
        {
            InitializeComponent();
        }

    

        private void FrmStock_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'capaDatosDataSet._1_medida' Puede moverla o quitarla según sea necesario.
            this._1_medidaTableAdapter.Fill(this.capaDatosDataSet._1_medida);
            // TODO: esta línea de código carga datos en la tabla 'capaDatosDataSet._1_marca' Puede moverla o quitarla según sea necesario.
            this._1_marcaTableAdapter.Fill(this.capaDatosDataSet._1_marca);
            // TODO: esta línea de código carga datos en la tabla 'capaDatosDataSet._1_stock_marca' Puede moverla o quitarla según sea necesario.
            this._1_stock_marcaTableAdapter.Fill(this.capaDatosDataSet._1_stock_marca);
            // TODO: esta línea de código carga datos en la tabla 'capaDatosDataSet._1_categoria' Puede moverla o quitarla según sea necesario.
            this._1_categoriaTableAdapter.Fill(this.capaDatosDataSet._1_categoria);
            // TODO: esta línea de código carga datos en la tabla 'capaDatosDataSet._1_stock' Puede moverla o quitarla según sea necesario.
            this._1_stockTableAdapter.Fill(this.capaDatosDataSet._1_stock);
            FrmStock_SizeChanged(sender, e);

        }
        

        private void _1_stockBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this._1_stockBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.capaDatosDataSet);
            

        }

        private void FrmStock_SizeChanged(object sender, EventArgs e)
        {
            _1_stockDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        

        private void cod_catComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            var medida = new DMedida();
            if (cod_catComboBox.SelectedValue == null)
            {
                return;
            }
            else
            {
                int codCategoria = (int)cod_catComboBox.SelectedValue;

                MedidaComboBox.DataSource = null;
                MedidaComboBox.DataSource = medida.SelectCodAndNombreMedidaByCodCategoria(codCategoria);
                MedidaComboBox.DisplayMember = "nombre";
                MedidaComboBox.ValueMember = "cod_med";
            }
            
        }
    }
}
