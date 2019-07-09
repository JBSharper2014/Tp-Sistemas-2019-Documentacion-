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
        private int idProducto;

        public int IDProducto { get => idProducto; }

        public FrmBusquedaStock()
        {
            InitializeComponent();
        }

        private void FrmBusquedaStock_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'capaUsuarioDataSet._1_categoria' Puede moverla o quitarla según sea necesario.
            _1_categoriaTableAdapter.Fill(capaUsuarioDataSet._1_categoria);
            // TODO: esta línea de código carga datos en la tabla 'capaUsuarioDataSet._1_stock' Puede moverla o quitarla según sea necesario.
            _1_stockTableAdapter.Fill(capaUsuarioDataSet._1_stock);
            DgvBusqueda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {

            string nombre;


            if (contengaRadioButton.Checked == true)
            {
                nombre = "%" + nombreToolStripTextBox.Text + "%";



            }
            else if (empieceRadioButton.Checked == true)
            {
                nombre = nombreToolStripTextBox.Text + "%";

            }
            else if (termineRadioButton.Checked == true)
            {
                nombre = "%" + nombreToolStripTextBox.Text;

            }
            else
            {
                nombre = nombreToolStripTextBox.Text;

            }

            try
            {
                _1_stockTableAdapter.FillBy1(capaUsuarioDataSet._1_stock, nombre);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            idProducto = 0;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //se pasará al form stock un idProducto dependiendo de lo seleccionado por el usuario,
            //habiendo tres posibles casos:
            //1. Que el grid este vacio
            //2. Que se haya seleccionado una fila, de la cual se obtendra el idProducto
            //3. Si no se selecciona nada. se pasa el idProducto del primer registro


            if (DgvBusqueda.Rows.Count == 0)
            {
                //1
                idProducto = 0;
            }

            else if (DgvBusqueda.SelectedRows.Count != 0)
            {
                //2
                idProducto = (int)DgvBusqueda.SelectedRows[0].Cells[0].Value;
            }
            else
            {
                //3
                idProducto = (int)DgvBusqueda.Rows[0].Cells[0].Value;
            }


            Close();
        }

        private void quitarFiltrosButton_Click(object sender, EventArgs e)
        {
            fillBy1ToolStripButton_Click(sender, e);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
