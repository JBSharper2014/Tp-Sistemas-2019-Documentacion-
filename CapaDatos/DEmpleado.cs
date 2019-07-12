using System;
using CapaDatos.CapaDatosDataSetTableAdapters;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DEmpleado
    {
        private static _1_empleadoTableAdapter adapter = new _1_empleadoTableAdapter();


        public string Nombre { get; set; }
        public string Apellido { get; set; }

        
        public static DEmpleado GetNombreCompletoEmpleadoByCodEmpleado(int cod_emp)
        {
            DEmpleado miEmpleado = null;

            //se llena un dataTable con el usuario pasado por parámetro al adapter
            CapaDatosDataSet._1_empleadoDataTable miTabla = adapter.GetNombreCompletoEmpleadoByCodEmpleado(cod_emp);

            if (miTabla.Rows.Count == 0) return miEmpleado;

            //se obtienen los campos de dicho usuario y se los coloca en un registro, igualándolos después
            //con las propiedades del objeto CADUsuario
            CapaDatosDataSet._1_empleadoRow miRegistro = (CapaDatosDataSet._1_empleadoRow)miTabla.Rows[0];

            miEmpleado = new DEmpleado
            {
                Nombre = miRegistro.nom_emp,
                Apellido = miRegistro.ape_emp
            };

            return miEmpleado;
        }


    }
}
