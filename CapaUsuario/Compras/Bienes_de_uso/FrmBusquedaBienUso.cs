using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaUsuario.Compras.Bienes_de_uso
{
    public partial class FrmBusquedaBienUso : Form
    {
        private int idBienUso;

        public int IDBienUso { get => idBienUso; }

        public FrmBusquedaBienUso()
        {
            InitializeComponent();
        }

        private void FrmBusquedaBienUso_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'capaUsuarioDataSet._1_bien_uso' Puede moverla o quitarla según sea necesario.
            _1_bien_usoTableAdapter.Fill(capaUsuarioDataSet._1_bien_uso);
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
                _1_bien_usoTableAdapter.FillBy1(capaUsuarioDataSet._1_bien_uso, nombre);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            idBienUso = 0;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //se pasará al form bienes de uso un idBienUso dependiendo de lo seleccionado por el usuario,
            //habiendo tres posibles casos:
            //1. Que el grid este vacio
            //2. Que se haya seleccionado una fila, de la cual se obtendra el idBienUso
            //3. Si no se selecciona nada. se pasa el idBienUso del primer registro


            if (DgvBusqueda.Rows.Count == 0)
            {
                //1
                idBienUso = 0;
            }

            else if (DgvBusqueda.SelectedRows.Count != 0)
            {
                //2
                idBienUso = (int)DgvBusqueda.SelectedRows[0].Cells[0].Value;
            }
            else
            {
                //3
                idBienUso = (int)DgvBusqueda.Rows[0].Cells[0].Value;
            }


            Close();
        }

        private void quitarFiltrosButton_Click(object sender, EventArgs e)
        {
            fillBy1ToolStripButton_Click(sender, e);
        }
    }
}
