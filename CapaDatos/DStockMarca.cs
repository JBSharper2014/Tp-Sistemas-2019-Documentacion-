using CapaDatos.CapaDatosDataSetTableAdapters;
using System;

namespace CapaDatos
{
    public class DStockMarca
    {
        private static _1_stock_marcaTableAdapter adapter = new _1_stock_marcaTableAdapter();


        public string InsertStockMarca(int cod_mar, int cod_pro_stock)
        {
            string respuesta;

           
            try
            {
                adapter.InsertStockMarca(cod_mar, cod_pro_stock);
                respuesta = "Producto por marca agregado correctamente.";
            }
            catch (Exception)
            {
                respuesta = "No se pudo agregar el producto por marca." + Environment.NewLine +
                    "Ya existe el producto seleccionado con la marca seleccionada.";
            }


            return respuesta;
        }

        public string DeleteStockMarca(int cod_pro_stock)
        {
            string respuesta;

            try
            {
                adapter.DeleteStockMarca(cod_pro_stock);
                respuesta = "Producto por marca eliminado correctamente";
            }
            catch (Exception ex)
            {

                respuesta = "Error al eliminar producto por marca: " + ex.Message;
            }

            return respuesta;
        }

    }
}
