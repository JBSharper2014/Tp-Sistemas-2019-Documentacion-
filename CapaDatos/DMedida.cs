using CapaDatos.CapaDatosDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DMedida
    {
        private static _1_medidaTableAdapter adapter = new _1_medidaTableAdapter();

        public DataTable SelectCodAndNombreMedidaByCodCategoria(int cod_cat)
        {
            DataTable miTabla = null;

            miTabla = adapter.SelectCodAndNombreMedidaByCodCategoria(cod_cat);

            return miTabla;
        }
    }
}
