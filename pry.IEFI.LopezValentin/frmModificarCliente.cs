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
    public partial class frmModificarCliente : Form
    {
        public frmModificarCliente()
        {
            InitializeComponent();
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            Int32 DniCliente = Convert.ToInt32(txtDNI.Text);
            clsClientes Eliminar = new clsClientes();
            Eliminar.EliminarCliente(DniCliente);

            Limpiar();
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
                txtNombre.Text = objCliente.NombreYApellido.ToString();
                txtSaldo.Text = objCliente.Saldos.ToString();
                lstActividad.Text = objCliente.ActividadCliente.ToString();
                lstSucursal.Text = objCliente.Sucursales.ToString();

            }

        }
        private void Limpiar()
        {
            txtDNI.Text = "";
            txtDocumento.Text = "";
            txtNombre.Text = "";
            txtSaldo.Text = "";
            lstActividad.SelectedIndex = -1;
            lstSucursal.SelectedIndex = -1;
        }

        private void frmModificarCliente_Load(object sender, EventArgs e)
        {
            clsSucursales objLlenarLst = new clsSucursales();
            objLlenarLst.LlenarLst(lstSucursal);

            clsSucursales objCargarSucursal = new clsSucursales();
            objCargarSucursal.LlenarLstActividad(lstActividad);
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            Int32 dni = (Convert.ToInt32(txtDNI.Text));
            Int32 dni2 = (Convert.ToInt32(txtDocumento.Text));
            string Nombre = txtNombre.Text;
            Int32 Sucursal = (Convert.ToInt32(lstSucursal.SelectedValue));
            Int32 Actividad = (Convert.ToInt32(lstActividad.SelectedValue));
            Int32 Saldo = (Convert.ToInt32(txtSaldo.Text));

            clsClientes ModificarCliente = new clsClientes();

            ModificarCliente.Documento = dni2;
            ModificarCliente.NombreYApellido = Nombre;
            ModificarCliente.Sucursales = Sucursal;
            ModificarCliente.ActividadCliente = Actividad;
            ModificarCliente.Saldos = Saldo;

            ModificarCliente.ModificarCliente(dni);

            Limpiar();
        }
    }
}
