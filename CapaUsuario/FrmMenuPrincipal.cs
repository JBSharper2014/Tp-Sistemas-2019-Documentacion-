
using CapaDatos;
using CapaUsuario.Compras;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaUsuario
{
    public partial class FrmMenuPrincipal : Form
    {
        private DUsuario usuarioLogueado;

        private DEmpleado empleado;

        public DUsuario UsuarioLogueado { get => usuarioLogueado; set => usuarioLogueado = value; }

        Timer t1 = new Timer();

        private FrmBienUso clientes;
        private FrmStock stock;

        public FrmMenuPrincipal()
        {
            InitializeComponent();
           

            Opacity = 0;      //first the opacity is 0
           
            t1.Interval = 10;  //we'll increase the opacity every 10ms
            t1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            t1.Start();
        }

        private void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                t1.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.05;
        }

        private void FrmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (stock == null || stock.IsDisposed)
            {
                stock = new FrmStock
                {
                    MdiParent = this,
                    //UsuarioLogueado = usuarioLogueado
                };
                stock.Show();
            }
            else
            {
                MessageBox.Show("El formulario ya se encuentra abierto", "Atención",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {

            empleado = DEmpleado.GetNombreCompletoEmpleadoByCodEmpleado(usuarioLogueado.CodEmpleado);


            //mostramos en la barra de status el usuario actual usando la aplicación
            NombresUsuarioToolStripStatusLabel.Text = "Usuario actual: " +
                empleado.Nombre + " " + empleado.Apellido;
        }

        private void bienesDeUsoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clientes == null || clientes.IsDisposed)
            {
                clientes = new FrmBienUso
                {
                    MdiParent = this,
                    //UsuarioLogueado = usuarioLogueado
                };
                clientes.Show();
            }
            else
            {
                MessageBox.Show("El formulario ya se encuentra abierto", "Atención",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Salir del programa?", "Confirmación",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;
            else
            {
                Close();
            }
        }
    }
}
