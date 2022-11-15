using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace pry.IEFI.LopezValentin
{
    internal class clsSucursales
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
        private string Tabla = "AdeDSucursales";
        public void ListarSucursales(DataGridView dgvListadoSucursales)
        {
            try
            {
                //Conectar la BD
                conexion.ConnectionString = CadenaConexion;
                //Abrir BD
                conexion.Open();
                //Conectar el comando a la BD
                comando.Connection = conexion;
                //Traer la tabla desde Acces
                comando.CommandType = CommandType.TableDirect;
                //Seleccionar la tabla
                comando.CommandText = "AdeDSucursales"; //Nombre de la tabla
                //Adaptador se conecta a la BD, trae los datos y lo sube a la tabla virtual de nuestro sistema
                adaptador = new OleDbDataAdapter(comando);
                //Tabla Virtual
                DataSet TablaVirtual = new DataSet();
                adaptador.Fill(TablaVirtual);
                //llenar la grilla
                dgvListadoSucursales.DataSource = TablaVirtual.Tables[0];

                //Traer la tabla clientes de la BD a la ram (tabla virtual)
                OleDbDataReader TraerTabla = comando.ExecuteReader();

                conexion.Close();

            }
            catch (Exception mensaje)
            {
                MessageBox.Show(mensaje.Message);
                //throw;
            }
        }

        public void LlenarLstActividad(ComboBox Combo)
        {
            try
            {
                //Conectar la BD
                conexion.ConnectionString = CadenaConexion;
                //Abrir BD
                conexion.Open();
                //Conectar el comando a la BD
                comando.Connection = conexion;
                //Traer la tabla desde Acces
                comando.CommandType = CommandType.TableDirect;
                //Seleccionar la tabla
                comando.CommandText = "AdeDActividad"; //Nombre de la tabla
                //Adaptador se conecta a la BD, trae los datos y lo sube a la tabla virtual de nuestro sistema
                adaptador = new OleDbDataAdapter(comando);
                //Tabla Virtual
                DataSet TablaVirtual = new DataSet();
                adaptador.Fill(TablaVirtual);
                //llenar la grilla
                Combo.DataSource = TablaVirtual.Tables[0];
                //El nombre que tiene la columna con los datos que queremos que se vean 
                Combo.DisplayMember = "Detalle";
                Combo.ValueMember = "Cod_Actividad";

                //Traer la tabla clientes de la BD a la ram (tabla virtual)
                OleDbDataReader TraerTabla = comando.ExecuteReader();

                conexion.Close();

            }
            catch (Exception mensaje)
            {
                MessageBox.Show(mensaje.Message);
                //throw;
            }
        }

        public void LlenarLst(ComboBox Combo)
        {
            try
            {
                //Conectar la BD
                conexion.ConnectionString = CadenaConexion;
                //Abrir BD
                conexion.Open();
                //Conectar el comando a la BD
                comando.Connection = conexion;
                //Traer la tabla desde Acces
                comando.CommandType = CommandType.TableDirect;
                //Seleccionar la tabla
                comando.CommandText = "AdeDSucursales"; //Nombre de la tabla
                //Adaptador se conecta a la BD, trae los datos y lo sube a la tabla virtual de nuestro sistema
                adaptador = new OleDbDataAdapter(comando);
                //Tabla Virtual
                DataSet TablaVirtual = new DataSet();
                adaptador.Fill(TablaVirtual);
                //llenar la grilla
                Combo.DataSource = TablaVirtual.Tables[0];
                //El nombre que tiene la columna con los datos que queremos que se vean 
                Combo.DisplayMember = "Detalle";
                Combo.ValueMember = "Cod_Sucursal";

                //Traer la tabla clientes de la BD a la ram (tabla virtual)
                OleDbDataReader TraerTabla = comando.ExecuteReader();

                conexion.Close();

            }
            catch (Exception mensaje)
            {
                MessageBox.Show(mensaje.Message);
                //throw;
            }

        }


    }

}
