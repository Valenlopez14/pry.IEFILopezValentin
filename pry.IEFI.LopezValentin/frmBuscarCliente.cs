using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pry.IEFI.LopezValentin
{
    public partial class frmBuscarCliente : Form
    {
        public frmBuscarCliente()
        {
            InitializeComponent();
        }

        private void frmBuscarCliente_Load(object sender, EventArgs e)
        {
            clsSucursales objSucursal = new clsSucursales();
            objSucursal.LlenarLst(lstSucursal);

            clsSucursales objActividad = new clsSucursales();
            objActividad.LlenarLstActividad(lstActividad);
        }

        private void lblSucursal_Click(object sender, EventArgs e)
        {

        }

        private void lblSaldo_Click(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {

            Int32 DNI_Cliente = Convert.ToInt32(txtDNI.Text);
            clsClientes objCliente = new clsClientes();
            objCliente.Buscar(DNI_Cliente);

            if (DNI_Cliente != objCliente.Documento)
            {
                MessageBox.Show("Documento no encontrado");
            }
            else
            {
                txtDNI.Text = objCliente.Documento.ToString();
                txtDocumento.Text = objCliente.Documento.ToString();
                txtNombreyApell.Text = objCliente.NombreYApellido.ToString();
                txtSaldo.Text = objCliente.Saldos.ToString();
                lstActividad.Text = objCliente.ActividadCliente.ToString();
                lstSucursal.Text = objCliente.Sucursales.ToString();


            }

        }
        private void BuenasPracticas()
        {
            if (txtDNI.Text != "")
            {
                cmdBuscar.Enabled = true;
            }
            else
            {
                cmdBuscar.Enabled = false;
            }
        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {
            BuenasPracticas();
        }
    }
}
