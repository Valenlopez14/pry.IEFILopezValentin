using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;
//Para enviar a imprimir y definir el tipo de letra
using System.Drawing;
using System.Drawing.Printing;



namespace pry.IEFI.LopezValentin
{
    class clsClientes
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

        //Declarar variables globales

        public int CalculoSaldo = 0;
        public int CalculoCantidad = 0;
        public decimal CalculoPromedio = 0;
        private int Saldo;
        private string NombreyApe;
        private string Direccion;
        private int DNI;
        private int Actividad;
        private string FechaNac;
        private int Sucursal;






        //Propiedades de solo lectura //Get retorna lo de las variables , set: toma el valor y lo almacena

        public string NombreYApellido
        {
            get { return NombreyApe; }
            set { NombreyApe = value; }
        }
        public string DireccionCliente
        {
            get { return Direccion; }
            set { Direccion = value; }
        }

        public Int32 Documento
        {
            get { return DNI; }
            set { DNI = value; }
        }

        public int ActividadCliente
        {
            get { return Actividad; }
            set { Actividad = value; }
        }

        public string FechaNacimiento
        {
            get { return FechaNac; }
            set { FechaNac = value; }

        }

        public int Sucursales
        {
            get { return Sucursal; }
            set { Sucursal = value; }
        }

        public decimal SaldoCliente
        {
            get { return CalculoSaldo; }

        }

        public Int32 cantidaClientes
        {
            get { return CalculoCantidad; }
        }
        public decimal PromedioClientes
        {
            get { return CalculoSaldo / CalculoCantidad; }

        }
        public string Nombres
        {
            get { return NombreyApe; }
            set { NombreyApe = value; }
        }

        public int Saldos
        {
            get { return Saldo; }
            set { Saldo = value; }
        }



        public void Listar(DataGridView DgvGrilla)
        {
            try
            {
                //Conectar a la BD
                conexion.ConnectionString = CadenaConexion;
                //Abrir BD
                conexion.Open();
                //Conectar el comando a la BD
                comando.Connection = conexion;
                //Traer la tabla desde Acces
                comando.CommandType = CommandType.TableDirect;
                //Selecciona la tabla
                comando.CommandText = "AdeDClientes";//Nombre tabla



                //Toda la tabla clientes en BD esta en la ram (tabla virtual)
                OleDbDataReader Lector = comando.ExecuteReader();


                //Mientras lea (mientras no sea fin de archivo
                if (Lector.HasRows)
                {
                    while (Lector.Read())
                    {
                        //Agregar datos a la grilla
                        DgvGrilla.Rows.Add(Lector.GetString(0), Lector.GetInt32(1), Lector.GetInt32(5));
                        CalculoCantidad++;
                        CalculoSaldo = CalculoSaldo + Lector.GetInt32(5);
                        CalculoPromedio = CalculoSaldo / CalculoCantidad;
                        
                    }

                }




                conexion.Close();

            }
            catch (Exception mensaje)
            {
                MessageBox.Show(mensaje.Message);
                //throw;
            }

        }
        public void Registrar()
        {
            try
            {
                String SQL = "";
                SQL = "INSERT INTO AdeDClientes ([Nombre Cliente], [DNI], [Actividad], [Sucursal], [Saldo])";
                SQL = SQL + " VALUES ('" + NombreyApe + "'," + DNI + "," + Actividad + "," + Sucursal + "," + Saldo + ")";
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = SQL;
                comando.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Cliente registrado con éxito");

            }
            catch (Exception mensaje)
            {
                MessageBox.Show("Documento ya registrado, utilice otro.");
                //throw;
            }

        }

        public void EliminarCliente(Int32 DniCliente)
        {
            try
            {
                string SQL = "DELETE FROM AdeDClientes WHERE (" + DniCliente + "=[DNI])";

                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType= CommandType.Text;
                comando.CommandText= SQL;
                comando.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Cliente eliminado con éxito.");
            }
            catch (Exception mensaje)
            {
                MessageBox.Show("Cliente no fue eliminado." + mensaje.Message);
                //throw;
            }
        }
        
        public void Buscar(Int32 DNIcliente)
        {
            //Variable DNIcliente tiene el valor que tiene la caja de texto en interfaz

            try
            {
                //Conectar a la BD
                conexion.ConnectionString = CadenaConexion;
                //Abrir la BD
                conexion.Open();
                //Conectar el comando a la BD
                comando.Connection = conexion;
                //Traer la Tabla desde acces
                comando.CommandType = CommandType.TableDirect;
                //Selecciona la tabla que quiero trar
                comando.CommandText = "AdeDClientes";
                //Crea una tabla virtual en la RAM 
                OleDbDataReader Lector = comando.ExecuteReader();

                //Si lee

                if (Lector.HasRows)
                {
                    //Mientras no sea fin de archivo
                    while (Lector.Read())
                    {
                        //si lo que lee es igual a lo que viene de la interfaz
                        if (Lector.GetInt32(1) == DNIcliente)
                        {
                            NombreyApe = Lector.GetString(0);
                            DNI = Lector.GetInt32(1);
                            Actividad = Lector.GetInt32(2);
                            Sucursal = Lector.GetInt32(4);
                            Saldo = Lector.GetInt32(5);
                        }
                    }
                }
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void ListarPorActividad(DataGridView dgvListarActividad , Int32 Id_Actividad)
        {
            try
            {
                //Conectar a la BD
                conexion.ConnectionString = CadenaConexion;
                //Abrir la BD
                conexion.Open();
                //Conectar el comando a la BD
                comando.Connection= conexion;
                //Traer la tabla desde Acces
                comando.CommandType = CommandType.TableDirect;
                //Selecciona la tabla a traer 
                comando.CommandText = Tabla;
                //Crea una tabla virtual en la memoria ram 
                OleDbDataReader Lector = comando.ExecuteReader();
                //Asegurarnos de que la tabla este limpia al momento de iniciar el procedimiento
                dgvListarActividad.Rows.Clear();
                //Si el Lector lee filas
                if (Lector.HasRows)
                {
                    //Mientras el lector lea
                    while (Lector.Read())
                    {
                        //Si lo que tiene lector es = a la variable
                        if (Lector.GetInt32(4) == Id_Actividad)  
                        {
                            //cargar grilla con los datos
                            dgvListarActividad.Rows.Add(Lector.GetString(0), Lector.GetInt32(1), Lector.GetInt32(4), Lector.GetInt32(5));
                        }

                    }
                }
            }
            catch (Exception mensaje)
            {
                MessageBox.Show(mensaje.Message);
                //throw;
            }
        }

        public void Exportar(Int32 Id_Actividad)
        {
            //Conectar la base de datos
            conexion.ConnectionString= CadenaConexion;
            //Abrir la BD
            conexion.Open();
            //Conectar el comando a la BD
            comando.Connection = conexion;
            //Traer la tabla desde acces
            comando.CommandType = CommandType.TableDirect;
            //Selecciona la tabla que queremos traer
            comando.CommandText= Tabla;
            //Crea una tabla virtual en la memoria ram 
            OleDbDataReader Lector = comando.ExecuteReader();
            //Crea el archivo en excel
            StreamWriter archivo = new StreamWriter("ReporteClientesPorActividad.csv", false);
            //Escribe el archivo en excel
            archivo.WriteLine("Listado de clientes de una Actvidiad");
            archivo.WriteLine();
            archivo.WriteLine("Nombre;Actividad;Saldo");

            
            if (Lector.HasRows)
            {
                while (Lector.Read())
                {
                    if (Lector.GetInt32(4) == Id_Actividad)
                    {
                        archivo.Write(Lector.GetString(0));
                        archivo.Write(";");
                        archivo.Write(Lector.GetInt32(4));
                        archivo.Write(";");
                        archivo.Write(Lector.GetInt32(5));
                        CalculoCantidad = CalculoCantidad + 1;
                        Saldo = Saldo + Lector.GetInt32(5);
                        archivo.Write("\n");
                    }

                    
                }
                archivo.Write("Cantidad de Clientes: ");
                archivo.WriteLine(CalculoCantidad);
                archivo.Write("Total de Saldo: ");
                archivo.WriteLine(Saldo);
                archivo.Write("Promedio: ");
                archivo.WriteLine(Saldo / CalculoCantidad);
            }
            conexion.Close();
            archivo.Close();
        }

        public void ModificarCliente(Int32 dni)
        {
            try
            {

                string SQL = "UPDATE AdeDClientes SET [Nombre Cliente] = '" + NombreyApe + "', [DNI] = " + DNI +
                    ", [Actividad] = " + Actividad + ", [Sucursal] = " + Sucursal + ", [Saldo] = " + Saldo + " WHERE [DNI] = " + dni + "";


                //conectar la BD
                conexion.ConnectionString = CadenaConexion;
                //Abrir la BD
                conexion.Open();
                //conectar el comando a la BD
                comando.Connection = conexion;
                //Crea una tabla virtual 
                comando.CommandType = CommandType.Text;
                //Agregamos la variable al comanod
                comando.CommandText = SQL;
                //Orden al comando para ejecutar la instruccion SQL
                comando.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Cliente modificado con éxito.");

            }
            catch (Exception mensaje)
            {
                MessageBox.Show(mensaje.Message);

                //throw;
            }
        }

        public void ImprimirPDF (PrintPageEventArgs reporte)
        {
            try
            {
                
                Font LetraTitulo1 = new Font("Arial", 20);
                Font LetraTitulo2 = new Font("Arial", 12);
                Font TipoLetra = new Font("Arial", 8);

                Int32 linea = 200;
                //Imprime el encabezado del PDF
                reporte.Graphics.DrawString("Listado de Clientes", LetraTitulo1,Brushes.Black,100,100);
                //Imprime nombres de las columnas del PDF
               
                reporte.Graphics.DrawString("Nombre", LetraTitulo2, Brushes.Black, 100, 150);
                reporte.Graphics.DrawString("Documento", LetraTitulo2, Brushes.Black, 200, 150);
                reporte.Graphics.DrawString("Actividad", LetraTitulo2, Brushes.Black, 300, 150);
                reporte.Graphics.DrawString("Sucursal", LetraTitulo2, Brushes.Black, 400, 150);
                reporte.Graphics.DrawString("Saldo", LetraTitulo2, Brushes.Black, 500, 150);

                //conectar la BD
                conexion.ConnectionString= CadenaConexion;
                //Abrir la BD
                conexion.Open();
                //conectar el comando a la BD
                comando.Connection= conexion;
                //Crea una tabla en la memoria RAM 
                comando.CommandType = CommandType.TableDirect;
                //Selecciona la tabla que queremos utilizar
                comando.CommandText = "AdeDClientes";

                adaptador = new OleDbDataAdapter(comando);
                DataSet Lector = new DataSet();
                adaptador.Fill(Lector, Tabla);
                //Si el lector contiene filas
                if (Lector.Tables[Tabla].Rows.Count > 0)
                {

                    foreach (DataRow fila in Lector.Tables[Tabla].Rows)
                    {
                        
                        reporte.Graphics.DrawString(fila["Nombre Cliente"].ToString(),TipoLetra,Brushes.Black,100,linea);
                        reporte.Graphics.DrawString(fila["DNI"].ToString(), TipoLetra, Brushes.Black, 200, linea);
                        reporte.Graphics.DrawString(fila["Actividad"].ToString(), TipoLetra, Brushes.Black, 300, linea);
                        reporte.Graphics.DrawString(fila["Sucursal"].ToString(), TipoLetra, Brushes.Black, 400, linea);
                        reporte.Graphics.DrawString(fila["Saldo"].ToString(), TipoLetra, Brushes.Black, 500, linea);
                        linea = (linea + 20);
                        CalculoCantidad++;
                        
                    }
                    reporte.Graphics.DrawString("Cantidad Clientes" + "" + CalculoCantidad, LetraTitulo2, Brushes.Black, 100, linea+20);
                    


                }
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
