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
    public partial class frmListadoSucursales : Form
    {
        public frmListadoSucursales()
        {
            InitializeComponent();
        }

        private void cmdListarSucursales_Click(object sender, EventArgs e)
        {
            dgvListadoSucursales.DataSource = null;
            dgvListadoSucursales.Rows.Clear();
            clsSucursales clsSucursales = new clsSucursales();
            clsSucursales.ListarSucursales(dgvListadoSucursales);
        }
    }
}
