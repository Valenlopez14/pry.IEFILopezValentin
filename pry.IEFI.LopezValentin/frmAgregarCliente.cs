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
    public partial class frmAgregarCliente : Form
    {
        //Conectar a la BD
        private OleDbConnection conexion = new OleDbConnection();
        //Enviar orden a la BD
        private OleDbCommand comando = new OleDbCommand();
        //Objeto para adaptar los datos de la BD al visual
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();
        //Ruta de Base de Datos
        private string CadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = BaseDeDatos.IEFI.accdb";
        //Nombre de tabla a llamar
        private string Tabla = "AdeDClientes";

        public frmAgregarCliente()
        {
            InitializeComponent();
        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            clsClientes Agregar = new clsClientes();


            Agregar.Documento = Convert.ToInt32(mskDNI.Text);
            Agregar.NombreYApellido = txtNombreyApe.Text;
            Agregar.ActividadCliente = lstActividad.SelectedIndex;
            Agregar.Sucursales = lstSucursal.SelectedIndex;
            // Agregar.FechaNacimiento = DTPFechaNac.Text;
            Agregar.Saldos = Convert.ToInt32(txtSaldo.Text);

            Agregar.Registrar();
            Limpiar();


        }

        private void frmAgregarCliente_Load(object sender, EventArgs e)
        {
            clsSucursales Actividad = new clsSucursales();
            Actividad.LlenarLstActividad(lstActividad);

            clsSucursales Sucursales = new clsSucursales();
            Sucursales.LlenarLst(lstSucursal);
            Limpiar();
        }
        private void Limpiar()
        {
            mskDNI.Text = "";
            txtNombreyApe.Text = "";
            lstSucursal.SelectedIndex = -1;
            lstActividad.SelectedIndex = -1;
            txtSaldo.Text = "";

        }
        private void BuenasPracticas()
        {
            if (txtNombreyApe.Text != "" && txtSaldo.Text != "" && mskDNI.Text != "" && lstActividad.SelectedIndex >= 0 && lstSucursal.SelectedIndex >= 0)
            {
                cmdRegistrar.Enabled = true;
            }
            else
            {
                cmdRegistrar.Enabled=false;
            }
        }

        private void txtNombreyApe_TextChanged(object sender, EventArgs e)
        {
            BuenasPracticas();
        }

        private void mskDNI_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            BuenasPracticas();
        }

        private void lstActividad_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuenasPracticas();
        }

        private void lstSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuenasPracticas();
        }

        private void txtSaldo_TextChanged(object sender, EventArgs e)
        {
            BuenasPracticas();
        }
    }
}
