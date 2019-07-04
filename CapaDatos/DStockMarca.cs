using CapaDatos.CapaDatosDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                respuesta = "Producto por marca agregado correctamente. ";
            }
            catch (Exception)
            {
                respuesta = "No se pudo agregar el producto por marca. " +
                    "\nYa existe el producto seleccionado con la marca seleccionada";
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
