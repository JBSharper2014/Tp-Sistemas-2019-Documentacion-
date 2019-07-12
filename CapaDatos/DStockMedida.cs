using CapaDatos.CapaDatosDataSetTableAdapters;
using System;

namespace CapaDatos
{
    public class DStockMedida
    {
        private static _1_stock_medidaTableAdapter adapter = new _1_stock_medidaTableAdapter();


        public string InsertStockMedida(int cod_med, int cod_pro_stock)
        {
            string respuesta;


            try
            {
                adapter.InsertStockMedida(cod_med,cod_pro_stock);
                respuesta = "Producto por medida agregado correctamente.";
            }
            catch (Exception)
            {
                respuesta = "No se pudo agregar el producto por medida." + Environment.NewLine +
                    "Ya existe el producto seleccionado con la medida seleccionada";
            }


            return respuesta;
        }

        public string DeleteStockMedida(int cod_pro_stock)
        {
            string respuesta;

            try
            {
                adapter.DeleteStockMedida(cod_pro_stock);
                respuesta = "Producto por medida eliminado correctamente";
            }
            catch (Exception ex)
            {

                respuesta = "Error al eliminar producto por medida: " + ex.Message;
            }

            return respuesta;
        }
    }
}
