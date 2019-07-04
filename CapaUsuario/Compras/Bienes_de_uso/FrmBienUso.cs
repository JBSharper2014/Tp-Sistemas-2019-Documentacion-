using CapaUsuario.Compras.Bienes_de_uso;
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
        private bool nuevo;

        public FrmBienUso()
        {
            InitializeComponent();
        }
        private void _1_bien_usoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            Validate();
            _1_bien_usoBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(capaDatosDataSet);

            if (nuevo)
            {
                MessageBox.Show("Registro agregado con éxito", "Mensaje",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Registro modificado con éxito", "Mensaje",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            DeshabilitarCampos();
            errorProvider1.Dispose();
        }

        private bool ValidarCampos()
        {
            //Nombre
            if (NombreTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(NombreTextBox, "Debe ingresar un nombre");
                NombreTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            //Stock óptimo
            if (StockTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(StockTextBox, "Debe ingresar un stock");
                StockTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (StockTextBox.Text != string.Empty)
            {
                int f;
                if (!int.TryParse(StockTextBox.Text, out f))
                {
                    errorProvider1.SetError(StockTextBox, "Debe ingresar un valor numérico entero");
                    StockTextBox.Focus();
                    return false;
                }
            }
            errorProvider1.Clear();


            int stock = Convert.ToInt32(StockTextBox.Text);
            if (stock <= 0)
            {
                errorProvider1.SetError(StockTextBox, "Debe ingesar un valor mayor a cero (0)");
                StockTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            return true;
        }

        private void FrmBienUso_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'capaDatosDataSet._1_bien_uso' Puede moverla o quitarla según sea necesario.
            _1_bien_usoTableAdapter.Fill(capaDatosDataSet._1_bien_uso);
            FrmBienUso_SizeChanged(sender, e);
        }

        private void FrmBienUso_SizeChanged(object sender, EventArgs e)
        {
            _1_bien_usoDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void HabilitarCampos()
        {

            NombreTextBox.ReadOnly = false;
            StockTextBox.ReadOnly = false;
            DescripcionTextBox.ReadOnly = false;
            ObservacionTextBox.ReadOnly = false;


            bindingNavigatorCancel.Enabled = true;
            BindingNavigatorSaveItem.Enabled = true;

            bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
            bindingNavigatorEditItem.Enabled = false;
            bindingNavigatorMoveFirstItem.Enabled = false;
            bindingNavigatorMovePreviousItem.Enabled = false;
            bindingNavigatorMoveNextItem.Enabled = false;
            bindingNavigatorMoveLastItem.Enabled = false;
            bindingNavigatorPositionItem.Enabled = false;
            bindingNavigatorSearchItem.Enabled = false;
            bindingNavigatorCountItem.Enabled = false;

            NombreTextBox.Focus();
        }

        private void DeshabilitarCampos()
        {
            NombreTextBox.ReadOnly = true;
            StockTextBox.ReadOnly = true;
            DescripcionTextBox.ReadOnly = true;
            ObservacionTextBox.ReadOnly = true;

            bindingNavigatorCancel.Enabled = false;
            BindingNavigatorSaveItem.Enabled = false;


            bindingNavigatorAddNewItem.Enabled = true;
            bindingNavigatorDeleteItem.Enabled = true;
            bindingNavigatorEditItem.Enabled = true;
            bindingNavigatorMoveFirstItem.Enabled = true;
            bindingNavigatorMovePreviousItem.Enabled = true;
            bindingNavigatorMoveNextItem.Enabled = true;
            bindingNavigatorMoveLastItem.Enabled = true;
            bindingNavigatorPositionItem.Enabled = true;
            bindingNavigatorSearchItem.Enabled = true;
            bindingNavigatorCountItem.Enabled = true;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            nuevo = true;
            HabilitarCampos();
            _1_bien_usoBindingSource.AddNew();
            NombreTextBox.Focus();
        }

        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            nuevo = false;
            HabilitarCampos();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Está seguro de borrar el registro?", "Confirmación",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;


            try
            {
                _1_bien_usoBindingSource.RemoveAt(_1_bien_usoBindingSource.Position);
                tableAdapterManager.UpdateAll(capaDatosDataSet);
                MessageBox.Show("Registro eliminado con éxito", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message + "\nCierre el formulario para recargar la información", "Mensaje", MessageBoxButtons.OK,
                                   MessageBoxIcon.Exclamation);

            }
        }

        private void bindingNavigatorCancel_Click(object sender, EventArgs e)
        {
            _1_bien_usoBindingSource.CancelEdit();
            errorProvider1.Dispose();
            DeshabilitarCampos();
        }

        private void bindingNavigatorSearchItem_Click(object sender, EventArgs e)
        {
            var miBusqueda = new FrmBusquedaBienUso();
            miBusqueda.ShowDialog();

            //si el usuario cancela la búsqueda, con este if hacemos que el registro mostrado se 
            //quede en el que estaba previo a la búsqueda
            if (miBusqueda.IDBienUso == 0) return;

            //se guarda en la variable position el id proveedor que devuelve la busqueda
            //desde el binding source de proveedores y se lo iguala a la posicion del binding source (el grid)
            int position = _1_bien_usoBindingSource.Find("cod_pro_buso", miBusqueda.IDBienUso);
            _1_bien_usoBindingSource.Position = position;
        }
    }
}
