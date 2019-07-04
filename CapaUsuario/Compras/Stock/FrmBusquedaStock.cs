using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaUsuario.Compras.Stock
{
    public partial class FrmBusquedaStock : Form
    {
        public FrmBusquedaStock()
        {
            InitializeComponent();
        }

        private void FrmBusquedaStock_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'capaDatosDataSet._1_categoria' Puede moverla o quitarla según sea necesario.
            _1_categoriaTableAdapter.Fill(capaDatosDataSet._1_categoria);
            // TODO: esta línea de código carga datos en la tabla 'capaDatosDataSet._1_stock' Puede moverla o quitarla según sea necesario.
            _1_stockTableAdapter.Fill(capaDatosDataSet._1_stock);

            DgvBusqueda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
