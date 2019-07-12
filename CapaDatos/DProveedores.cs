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

        public bool ExisteStockProveedor(int cod_pro_stock)
        {
            if (adapterStock.ExisteStockProveedor(cod_pro_stock) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }

        public bool ExisteBienUsoProveedor(int cod_pro_buso)
        {
            if (adapterBienUso.ExisteBienUsoProveedor(cod_pro_buso) == null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public string DeleteStockProveedor(int cod_proveedor)
        {
            string respuesta;

            try
            {
                adapterStock.DeleteStockProveedor(cod_proveedor);
                respuesta = "Se eliminó la asociación del proveedor con los productos que proveía";
            }
            catch (Exception ex)
            {
                respuesta = "No se pudo eliminar la asociación del proveedor con los productos que provee:" +
                    Environment.NewLine + ex.Message;
            }

            return respuesta;
        }

        public string DeleteBienesUsoProveedor(int cod_proveedor)
        {
            string respuesta;

            try
            {
                adapterBienUso.DeleteBienesUsoProveedor(cod_proveedor);
                respuesta = "Se eliminó la asociación del proveedor con los bienes de uso que proveía";
            }
            catch (Exception ex)
            {
                respuesta = "No se pudo eliminar la asociación del proveedor con los bienes de uso que provee:" +
                    Environment.NewLine + ex.Message;
            }

            return respuesta;
        }

    }
}
