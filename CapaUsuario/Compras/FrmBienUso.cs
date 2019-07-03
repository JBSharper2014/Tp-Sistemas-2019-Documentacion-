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
    public partial class FrmBienUso : Form
    {
        public FrmBienUso()
        {
            InitializeComponent();
        }
        private void _1_bien_usoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this._1_bien_usoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.capaDatosDataSet);

        }

        private void FrmBienUso_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'capaDatosDataSet._1_bien_uso' Puede moverla o quitarla según sea necesario.
            this._1_bien_usoTableAdapter.Fill(this.capaDatosDataSet._1_bien_uso);
            FrmBienUso_SizeChanged(sender, e);
        }

        private void FrmBienUso_SizeChanged(object sender, EventArgs e)
        {
            _1_bien_usoDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
