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
    public partial class frmListadoClientes : Form
    {
        public frmListadoClientes()
        {
            InitializeComponent();
        }

        private void DgvGrilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmdListarClientes_Click(object sender, EventArgs e)
        {
            DgvGrilla.DataSource = null;
            DgvGrilla.Rows.Clear();
            clsClientes clsClientes = new clsClientes();
            clsClientes.Listar(DgvGrilla);
            lblTotalResultado.Text = clsClientes.CalculoSaldo.ToString();
            lblCantidadResultado.Text = clsClientes.CalculoCantidad.ToString();
            lblPromedioResultado.Text = clsClientes.CalculoPromedio.ToString();
        }
    }
}
