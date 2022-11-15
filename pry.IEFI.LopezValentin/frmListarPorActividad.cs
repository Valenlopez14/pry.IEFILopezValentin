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
    public partial class frmListarPorActividad : Form
    {
        public frmListarPorActividad()
        {
            InitializeComponent();
        }

        private void frmListarPorActividad_Load(object sender, EventArgs e)
        {
            clsSucursales objSucursales = new clsSucursales();
            objSucursales.LlenarLstActividad(lstActividad);



        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            Int32 IdActividad = Convert.ToInt32(lstActividad.SelectedValue);
            clsClientes objListarPorActividad = new clsClientes();
            objListarPorActividad.ListarPorActividad(dgvListarActividad, IdActividad);
        }

        private void cmdExportar_Click(object sender, EventArgs e)
        {
            Int32 IdActividad = Convert.ToInt32(lstActividad.SelectedValue);
            clsClientes Reporte = new clsClientes();
            Reporte.Exportar(IdActividad);
            MessageBox.Show("Reporte generado en Excel.");
        }

        private void cmdImprimir_Click(object sender, EventArgs e)
        {
            //Abre la interfaz de ususario para elegir la impresora
            prtVentana.ShowDialog();
            //Asigna la impresora elegida por el usuario 
            prtDocumento.PrinterSettings = prtVentana.PrinterSettings;
            //Ejecuta el Print
            prtDocumento.Print();
            MessageBox.Show("Reporte impreso exitosamente.");
        }

        private void prtDocumento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            clsClientes Reporte = new clsClientes();
            Reporte.ImprimirPDF(e);
        }
    }
}
