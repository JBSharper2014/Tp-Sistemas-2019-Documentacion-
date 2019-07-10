using CapaDatos;
using CapaUsuario.Compras.Stock;
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
        private DUsuario usuarioLogueado;
        public DUsuario UsuarioLogueado { get => usuarioLogueado; set => usuarioLogueado = value; }

        private bool nuevo;

        public FrmStock()
        {
            InitializeComponent();
        }


        private void FrmStock_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'capaUsuarioDataSet._1_medida' Puede moverla o quitarla según sea necesario.
            _1_medidaTableAdapter.Fill(capaUsuarioDataSet._1_medida);
            // TODO: esta línea de código carga datos en la tabla 'capaUsuarioDataSet._1_marca' Puede moverla o quitarla según sea necesario.
            _1_marcaTableAdapter.Fill(capaUsuarioDataSet._1_marca);
            // TODO: esta línea de código carga datos en la tabla 'capaUsuarioDataSet._1_stock' Puede moverla o quitarla según sea necesario.
            _1_stockTableAdapter.Fill(capaUsuarioDataSet._1_stock);
            // TODO: esta línea de código carga datos en la tabla 'capaUsuarioDataSet._1_stock_marca' Puede moverla o quitarla según sea necesario.
            _1_stock_marcaTableAdapter.Fill(capaUsuarioDataSet._1_stock_marca);
            // TODO: esta línea de código carga datos en la tabla 'capaUsuarioDataSet._1_categoria' Puede moverla o quitarla según sea necesario.
            _1_categoriaTableAdapter.Fill(capaUsuarioDataSet._1_categoria);
            
            MarcaComboBox.SelectedIndex = -1;
            FrmStock_SizeChanged(sender, e);
        }


        private void _1_stockBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
        }

        private void FrmStock_SizeChanged(object sender, EventArgs e)
        {
            _1_stockDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void HabilitarCampos()
        {

            NombreTextBox.ReadOnly = false;
            stk_optNumericUpDown.Enabled = true;
            stk_criNumericUpDown.Enabled = true;

            MarcaComboBox.SelectedIndex = -1;

            CategoriaComboBox.Enabled = true;
            //MedidaComboBox.DataSource = null;


            AgregarMarcaMedidaButton.Enabled = false;

            bindingNavigatorCancel.Enabled = true;
            StockBindingNavigatorSaveItem.Enabled = true;

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
            stk_optNumericUpDown.Enabled = false;
            stk_criNumericUpDown.Enabled = false;

            CategoriaComboBox.Enabled = false;
            MarcaComboBox.Enabled = false;
            MedidaComboBox.Enabled = false;

            bindingNavigatorCancel.Enabled = false;
            StockBindingNavigatorSaveItem.Enabled = false;


            AgregarMarcaMedidaButton.Enabled = true;

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

        private void cod_catComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            var medida = new DMedida();
            if (CategoriaComboBox.SelectedValue == null)
            {
                return;
            }
            else
            {
                int codCategoria = (int)CategoriaComboBox.SelectedValue;

                MedidaComboBox.DataSource = null;
                MedidaComboBox.DataSource = medida.SelectCodAndNombreMedidaByCodCategoria(codCategoria);
                MedidaComboBox.DisplayMember = "nombre";
                MedidaComboBox.ValueMember = "cod_med";
            }

        }

        private void bindingNavigatorCancel_Click(object sender, EventArgs e)
        {
            stockBindingSource.CancelEdit();
            errorProvider1.Dispose();
            DeshabilitarCampos();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            nuevo = true;
            HabilitarCampos();
            stockBindingSource.AddNew();
            stk_actTextBox.Text = "0";
            NombreTextBox.Focus();
        }

        private bool ValidarCampos()
        {
            //Nombre
            if (NombreTextBox.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(NombreTextBox, "Debe ingresar un nombre");
                NombreTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            //Categoria
            if (CategoriaComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(CategoriaComboBox, "Debe seleccionar una categoría");
                CategoriaComboBox.Focus();
                return false;
            }
            errorProvider1.Clear();



            //Stock óptimo

            decimal stockOptimo = stk_optNumericUpDown.Value;
            if (stockOptimo <= 0)
            {
                errorProvider1.SetError(stk_optNumericUpDown, "Debe seleccionar un valor mayor a cero (0)");
                stk_optNumericUpDown.Focus();
                return false;
            }
            errorProvider1.Clear();


            //Stock crítico

            decimal stockCritico = stk_criNumericUpDown.Value;
            if (stockCritico <= 0)
            {
                errorProvider1.SetError(stk_criNumericUpDown, "Debe sleccionar un valor mayor a cero (0)");
                stk_optNumericUpDown.Focus();
                return false;
            }
            errorProvider1.Clear();


            return true;
        }

        private void StockBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            if (!ValidarCampos()) return;

            Validate();
            stockBindingSource.EndEdit();
            tableAdapterManager1.UpdateAll(capaUsuarioDataSet);

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
            cod_catComboBox_SelectedValueChanged(sender, e);
        }

        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            MarcaComboBox.Enabled = false;
            MedidaComboBox.Enabled = false;
            nuevo = false;
        }

        private void AgregarMarcaMedidaButton_Click(object sender, EventArgs e)
        {
            AgregarMarcaMedidaButton.Enabled = false;
            GuardarMarcaMedidaButton.Enabled = true;
            CancelarMarcaMedida.Enabled = true;
            MarcaComboBox.Enabled = true;
            MedidaComboBox.Enabled = true;
            _1_stockBindingNavigator.Enabled = false;
        }

        private void CancelarMarcaMedida_Click(object sender, EventArgs e)
        {
            MarcaComboBox.SelectedIndex = -1;
            errorProvider1.Dispose();
            AgregarMarcaMedidaButton.Enabled = true;
            GuardarMarcaMedidaButton.Enabled = false;
            CancelarMarcaMedida.Enabled = false;
            MarcaComboBox.Enabled = false;
            MedidaComboBox.Enabled = false;
            _1_stockBindingNavigator.Enabled = true;
        }

        private void GuardarMarcaMedidaButton_Click(object sender, EventArgs e)
        {

            if (!ValidarMarcaMedida()) return;

            var stockMedida = new DStockMedida();
            var stockMarca = new DStockMarca();

            int codProducto = Convert.ToInt32(cod_pro_stockTextBox.Text);



            string msg = stockMarca.InsertStockMarca((int)MarcaComboBox.SelectedValue, codProducto);
            string msg2 = stockMedida.InsertStockMedida((int)MedidaComboBox.SelectedValue, codProducto);

            MessageBox.Show(msg, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);


            MessageBox.Show(msg2, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CancelarMarcaMedida_Click(sender, e);
            ActualizarButton_Click(sender, e);

        }

        private bool ValidarMarcaMedida()
        {
            ////Marca
            if (MarcaComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(MarcaComboBox, "Debe seleccionar una marca");
                MarcaComboBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            //Medida
            if (MedidaComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(MedidaComboBox, "Debe seleccionar una medida");
                MedidaComboBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            return true;
        }

        private void ActualizarStockButton_Click(object sender, EventArgs e)
        {
            try
            {
                _1_stockTableAdapter.Fill(capaUsuarioDataSet._1_stock);
                MessageBox.Show("Lista de productos actualizada", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo actualizar la lista de productos:" + Environment.NewLine + ex.Message, "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        private void ActualizarButton_Click(object sender, EventArgs e)
        {

            try
            {
                _1_stock_marcaTableAdapter.Fill(capaUsuarioDataSet._1_stock_marca);
                MessageBox.Show("Lista de productos por marca actualizada", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo actualizar la lista de productos por marca:" + Environment.NewLine + ex.Message, 
                    "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Está seguro de borrar el registro?" +
                Environment.NewLine + "Si continúa, borrará las referencias del producto con marca(s) y/o medida(s)", "Confirmación",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;


            //En el futuro, se deberán agregar comprobaciones de interferencia en transacciones para evitar el borrado

            //Comprobamos que ningún proveedor provea el producto
            var dproveedores = new DProveedores();

            int codProducto = Convert.ToInt32(cod_pro_stockTextBox.Text);
            if (dproveedores.ExisteStockProveedor(codProducto))
            {
                MessageBox.Show("El producto tiene proveedores asociados, no puede eliminarse",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //Borramos primero las referencia en stock_marca y stock_medida
            string msg, msg2;
            var stockMarca = new DStockMarca();
            var stockMedida = new DStockMedida();


            msg = stockMarca.DeleteStockMarca(codProducto);
            msg2 = stockMedida.DeleteStockMedida(codProducto);

            MessageBox.Show(msg, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);


            MessageBox.Show(msg2, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            try
            {
                stockBindingSource.RemoveAt(stockBindingSource.Position);
                tableAdapterManager1.UpdateAll(capaUsuarioDataSet);
                MessageBox.Show("Registro eliminado con éxito", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message + Environment.NewLine +
                    "Cierre el formulario para recargar la información", "Mensaje", MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                return;
            }

            ActualizarButton_Click(sender, e);
        }

        private void bindingNavigatorSearchItem_Click(object sender, EventArgs e)
        {
            var miBusqueda = new FrmBusquedaStock();

            miBusqueda.ShowDialog();

            //si el usuario cancela la búsqueda, con este if hacemos que el registro mostrado se 
            //quede en el que estaba previo a la búsqueda
            if (miBusqueda.IDProducto == 0) return;

            //se guarda en la variable position el id producto que devuelve la busqueda
            //desde el binding source de proveedores y se lo iguala a la posicion del binding source (el grid)
            int position = stockBindingSource.Find("cod_pro_stock", miBusqueda.IDProducto);
            stockBindingSource.Position = position;
        }

        private void CancelarMarcaMedida_Click_1(object sender, EventArgs e)
        {
            CancelarMarcaMedida_Click(sender, e);
        }
    }
}
