using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace pry.IEFI.LopezValentin
{
    public partial class frmPrincipal : Form
    {
        //Conectar a la Base de Datos
        private OleDbConnection conexion = new OleDbConnection();
        //Enviar orden a la BD
        private OleDbCommand comando = new OleDbCommand();
        //Objeto para adaptar los datos de la BD al Visual (.net)
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();
        //Variable con la ruta de la BD 
        private string RutaBD = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" + "BaseDeDatos.IEFI.accdb";


        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void agregarNuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarCliente frmAgregarCliente = new frmAgregarCliente();
            frmAgregarCliente.ShowDialog();
        }

        private void buscarUnClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarCliente frmBuscarCliente = new frmBuscarCliente();
            frmBuscarCliente.ShowDialog();
        }

        private void modificaUnClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModificarCliente modificaUnCliente = new frmModificarCliente();
            modificaUnCliente.ShowDialog();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario frmUsuario = new frmUsuario();
            frmUsuario.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listadoDeSucursalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoSucursales frmListadoSucursales = new frmListadoSucursales();
            frmListadoSucursales.ShowDialog();
        }

        private void listadoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoClientes frmListadoClientes = new frmListadoClientes();
            frmListadoClientes.ShowDialog();
        }

        private void StatusBase_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                lblFecha.Text = DateTime.Now.ToString();
                conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + RutaBD);
                conexion.Open();
                lblEstado.Text = "Conectado";
                StatusBase.BackColor = Color.GreenYellow;

            }
            catch (Exception mensaje)
            {
                lblEstado.Text = mensaje.Message;
                StatusBase.BackColor = Color.Red;
                //throw;
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void listadoPorActividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarPorActividad frmListarPorActividad = new frmListarPorActividad();
            frmListarPorActividad.ShowDialog();
        }
    }
}
