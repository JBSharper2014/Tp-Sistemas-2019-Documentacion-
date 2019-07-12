using CapaDatos.CapaDatosDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DUsuario
    {
        private static usuarioTableAdapter adapter = new usuarioTableAdapter();

        public int IDUsuario { get; set; }
        public int CodEmpleado { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
        public bool CuentaActiva { get; set; }

        public static bool ValidarUsuario(string IDUsuario, string Clave)
        {
            if (adapter.ValidarUsuario(IDUsuario, Clave) == null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }


        public static DUsuario GetUsuario(string IDUsuario)
        {
            DUsuario miUsuario = null;

            //se llena un dataTable con el usuario pasado por parámetro al adapter
            CapaDatosDataSet._1_usuarioDataTable miTabla = adapter.GetUsuario(IDUsuario);

            if (miTabla.Rows.Count == 0) return miUsuario;

            //se obtienen los campos de dicho usuario y se los coloca en un registro, igualándolos después
            //con las propiedades del objeto CADUsuario
            CapaDatosDataSet._1_usuarioRow miRegistro = (CapaDatosDataSet._1_usuarioRow)miTabla.Rows[0];
            miUsuario = new DUsuario
            {
                IDUsuario = miRegistro.cod_usu,
                CodEmpleado = miRegistro.cod_emp,
                NombreUsuario = miRegistro.nom_usu,
                Clave = miRegistro.psw_usu,
                CuentaActiva = miRegistro.cuenta_activa_usu
            };

            return miUsuario;
        }
    }
}
