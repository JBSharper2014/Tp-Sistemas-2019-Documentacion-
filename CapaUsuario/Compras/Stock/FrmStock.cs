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
            MarcaComboBox.SelectedIndex = -1;

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
            StockOptimoTextBox.ReadOnly = false;
            StockCriticoTextBox.ReadOnly = false;

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
            StockOptimoTextBox.ReadOnly = true;
            StockCriticoTextBox.ReadOnly = true;

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
            _1_stockBindingSource.CancelEdit();
            errorProvider1.Dispose();
            DeshabilitarCampos();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            nuevo = true;
            HabilitarCampos();
            _1_stockBindingSource.AddNew();
            stk_actTextBox.Text = "0";
            NombreTextBox.Focus();
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

            //Categoria
            if (CategoriaComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(CategoriaComboBox, "Debe seleccionar una categoría");
                CategoriaComboBox.Focus();
                return false;
            }
            errorProvider1.Clear();



            //Stock óptimo
            if (StockOptimoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(StockOptimoTextBox, "Debe ingresar un stock óptimo");
                StockOptimoTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (StockOptimoTextBox.Text != string.Empty)
            {
                int f;
                if (!int.TryParse(StockOptimoTextBox.Text, out f))
                {
                    errorProvider1.SetError(StockOptimoTextBox, "Debe ingresar un valor numérico entero");
                    StockOptimoTextBox.Focus();
                    return false;
                }
            }
            errorProvider1.Clear();


            int stockOptimo = Convert.ToInt32(StockOptimoTextBox.Text);
            if (stockOptimo <= 0)
            {
                errorProvider1.SetError(StockOptimoTextBox, "Debe ingesar un valor mayor a cero (0)");
                StockOptimoTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();


            //Stock crítico

            if (StockCriticoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(StockCriticoTextBox, "Debe ingresar un stock óptimo");
                StockCriticoTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (StockCriticoTextBox.Text != string.Empty)
            {
                int f;
                if (!int.TryParse(StockCriticoTextBox.Text, out f))
                {
                    errorProvider1.SetError(StockCriticoTextBox, "Debe ingresar un valor numérico entero");
                    StockCriticoTextBox.Focus();
                    return false;
                }
            }
            errorProvider1.Clear();

            int stockCritico = Convert.ToInt32(StockCriticoTextBox.Text);
            if (stockCritico <= 0)
            {
                errorProvider1.SetError(StockCriticoTextBox, "Debe ingesar un valor mayor a cero (0)");
                StockCriticoTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();


            return true;
        }

        private void StockBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            if (!ValidarCampos()) return;

            Validate();
            _1_stockBindingSource.EndEdit();
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
            _1_stockTableAdapter.Fill(capaDatosDataSet._1_stock);
        }

        private void ActualizarButton_Click(object sender, EventArgs e)
        {
            _1_stock_marcaTableAdapter.Fill(capaDatosDataSet._1_stock_marca);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Está seguro de borrar el registro?", "Confirmación",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;

            //despues tengo que agregar la comprobación de que el producto
            //no tenga referencia en otras tabals (Pedidos de reaporv, ordenes de compra, etc)

            //Borramos primero las referencia en stock_marca y stock_medida
            string msg, msg2;
            var stockMarca = new DStockMarca();
            var stockMedida = new DStockMedida();

            int codProducto = Convert.ToInt32(cod_pro_stockTextBox.Text);

            msg = stockMarca.DeleteStockMarca(codProducto);
            msg2 = stockMedida.DeleteStockMedida(codProducto);

            MessageBox.Show(msg, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);


            MessageBox.Show(msg2, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            try
            {
                _1_stockBindingSource.RemoveAt(_1_stockBindingSource.Position);
                tableAdapterManager.UpdateAll(capaDatosDataSet);
                MessageBox.Show("Registro eliminado con éxito", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message + "\nCierre el formulario para recargar la información", "Mensaje", MessageBoxButtons.OK,
                                   MessageBoxIcon.Exclamation);
                return;
            }

            ActualizarButton_Click(sender, e);
        }

        private void bindingNavigatorSearchItem_Click(object sender, EventArgs e)
        {
            var miBusqueda = new FrmBusquedaStock();
            miBusqueda.ShowDialog();
        }
    }
}
