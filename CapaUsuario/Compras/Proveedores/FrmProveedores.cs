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

namespace CapaUsuario.Compras.Proveedores
{
    public partial class FrmProveedores : Form
    {
        private DUsuario usuarioLogueado;
        public DUsuario UsuarioLogueado { get => usuarioLogueado; set => usuarioLogueado = value; }

        private bool nuevo;

        public FrmProveedores()
        {
            InitializeComponent();
        }

        private void _1_proveedorBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            Validate();
            _1_proveedorBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(capaUsuarioDataSet);

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
            if (nombreTextBox.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(nombreTextBox, "Debe ingresar un nombre");
                nombreTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            //Telefono
            if (numero_telefonoTextBox.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(numero_telefonoTextBox, "Debe ingresar un teléfono");
                numero_telefonoTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();


            if (numero_telefonoTextBox.Text.Trim() != string.Empty)
            {
                if (!decimal.TryParse(numero_telefonoTextBox.Text.Trim(), out decimal precio))
                {

                    errorProvider1.SetError(numero_telefonoTextBox, "Debe ingresar un valor numérico");
                    numero_telefonoTextBox.Focus();
                    return false;
                }
            }
            errorProvider1.Clear();

            decimal telefono = Convert.ToDecimal(numero_telefonoTextBox.Text.Trim());
            if (telefono <= 0)
            {
                errorProvider1.SetError(numero_telefonoTextBox, "Debe ingesar un valor mayor a cero (0)");
                numero_telefonoTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            //Direccion
            if (direccion_fisicaTextBox.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(direccion_fisicaTextBox, "Debe ingresar una dirección");
                nombreTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            //Cod postal
            if (cod_postalTextBox.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(cod_postalTextBox, "Debe ingresar un código postal");
                cod_postalTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();


            if (cod_postalTextBox.Text.Trim() != string.Empty)
            {
                if (!decimal.TryParse(cod_postalTextBox.Text.Trim(), out decimal precio))
                {

                    errorProvider1.SetError(cod_postalTextBox, "Debe ingresar un valor numérico");
                    cod_postalTextBox.Focus();
                    return false;
                }
            }
            errorProvider1.Clear();

            decimal codPostal = Convert.ToDecimal(cod_postalTextBox.Text.Trim());
            if (codPostal <= 0)
            {
                errorProvider1.SetError(cod_postalTextBox, "Debe ingesar un valor mayor a cero (0)");
                cod_postalTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            //Direccion
            if (direccion_fisicaTextBox.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(direccion_fisicaTextBox, "Debe ingresar una dirección");
                nombreTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            //Email
            if (emailTextBox.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(emailTextBox, "Debe ingresar una dirección");
                emailTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (emailTextBox.Text.Trim() != string.Empty)
            {
                var regexUtilities = new RegexUtilities();

                // con el método IsValidEmail la clase regex utilities comprueba que el correo ingresado
                // tenga el formato correcto

                if (!regexUtilities.IsValidEmail(emailTextBox.Text.Trim()))
                {
                    errorProvider1.SetError(emailTextBox, "Debe ingresar un email válido");
                    emailTextBox.Focus();
                    return false;
                }
                errorProvider1.Clear();
            }


            //Razón social
            if (razon_socialTextBox.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(razon_socialTextBox, "Debe ingresar una razón social");
                razon_socialTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            //Tipo producto
            if (tipo_productoComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(tipo_productoComboBox, "Debe seleccionar un tipo de producto");
                tipo_productoComboBox.Focus();
                return false;
            }
            errorProvider1.Clear();


            return true;
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'capaUsuarioDataSet._1_proveedor' Puede moverla o quitarla según sea necesario.
            _1_proveedorTableAdapter.Fill(capaUsuarioDataSet._1_proveedor);
            FrmProveedores_SizeChanged(sender, e);
        }

        private void FrmProveedores_SizeChanged(object sender, EventArgs e)
        {
            _1_proveedorDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            nuevo = true;
            HabilitarCampos();
            _1_proveedorBindingSource.AddNew();
            nombreTextBox.Focus();
        }

        private void HabilitarCampos()
        {

            nombreTextBox.ReadOnly = false;
            numero_telefonoTextBox.ReadOnly = false;
            direccion_fisicaTextBox.ReadOnly = false;
            numero_telefonoTextBox.ReadOnly = false;
            cod_postalTextBox.ReadOnly = false;
            emailTextBox.ReadOnly = false;
            razon_socialTextBox.ReadOnly = false;
            tipo_productoComboBox.Enabled = true;

            tipo_productoComboBox.SelectedIndex = -1;
            
            bindingNavigatorCancel.Enabled = true;
            _1_proveedorBindingNavigatorSaveItem.Enabled = true;

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

            nombreTextBox.Focus();
        }

        private void DeshabilitarCampos()
        {

            nombreTextBox.ReadOnly = true;
            numero_telefonoTextBox.ReadOnly = true;
            direccion_fisicaTextBox.ReadOnly = true;
            numero_telefonoTextBox.ReadOnly = true;
            cod_postalTextBox.ReadOnly = true;
            emailTextBox.ReadOnly = true;
            razon_socialTextBox.ReadOnly = true;
            tipo_productoComboBox.Enabled = false;
            

            bindingNavigatorCancel.Enabled = false;
            _1_proveedorBindingNavigatorSaveItem.Enabled = false;

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

            nombreTextBox.Focus();
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
                _1_proveedorBindingSource.RemoveAt(_1_proveedorBindingSource.Position);
                tableAdapterManager.UpdateAll(capaUsuarioDataSet);
                MessageBox.Show("Registro eliminado con éxito", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message + Environment.NewLine +
                    "Cierre el formulario para recargar la información", "Mensaje", MessageBoxButtons.OK,
                                   MessageBoxIcon.Exclamation);
                return;
            }
        }
    }
}
