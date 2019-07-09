using System;
using System.Collections.Generic;
using CapaDatos.CapaDatosDataSetTableAdapters;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DProveedores
    {
        private static _1_buso_proveedorTableAdapter adapterBienUso = new _1_buso_proveedorTableAdapter();

        private static _1_stock_proveedorTableAdapter adapterStock = new _1_stock_proveedorTableAdapter();

        public string InsertStockProveedor(int cod_proveedor, int cod_pro_stock)
        {
            string respuesta;

            try
            {
                adapterStock.InsertStockProveedor(cod_proveedor, cod_pro_stock);
                respuesta = "Se agregó el producto al proveedor correctamente.";
            }
            catch (Exception)
            {
                respuesta = "No se pudo agregar el producto al proveedor. " + Environment.NewLine +
                    "Ya existe el producto seleccionado con el proveedor seleccionado";
            }


            return respuesta;
        }

        public string InsertBienUsoProveedor(int cod_proveedor, int cod_pro_buso)
        {
            string respuesta;

            try
            {
                adapterBienUso.InsertBienUsoProveedor(cod_proveedor, cod_pro_buso);
                respuesta = "Se agregó el bien de uso al proveedor correctamente.";
            }
            catch (Exception)
            {
                respuesta = "No se pudo agregar el bien de uso al proveedor. " + Environment.NewLine +
                    "Ya existe el bien de uso seleccionado con el proveedor seleccionado";
            }


            return respuesta;
        }

    }
}
