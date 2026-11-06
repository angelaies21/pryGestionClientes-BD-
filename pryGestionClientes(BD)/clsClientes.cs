using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionClientes_archivoCSV_
{
    internal class clsClientes
    {

        // 1 - ESTO LO CONECTA CON ACCES, PARA PODER USAR LA BASE DE DATOS, SE USA EL NAMESPACE System.Data.OleDb
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();


        private string CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Clientes.mdb";
        private string Tabla = "Lista";

        //2 - Declaro las Variables
        private Decimal deuda; //acumulacion de todas las deudas
        private Int32 cantidad;

        private Int32 idCli;
        private String Nom;
        private Decimal deu; //deuda de cada usuario
        private Decimal lim;
        private Int32 idCui;

        

        // 3 - Declaro las PROPIEDADES
        public Decimal TotalDeuda
        {
            get { return deuda; }
        }
        public Int32 CantidadDeudores
        {
            get { return cantidad; }
        }
        public Decimal PromedioDeuda //no hace falta ponerlo
        {
            get { return deuda / cantidad; }
        }

       //  public Int32 Cantidad  AGREGAR
        // {
        //   get { return cantidad; }
        // }

        public Int32 IdCliente
        {
            get { return idCli; }
            set { idCli = value; }
        }

        public String Nombre
        {
            get { return Nom; }
            set { Nom = value; }
        }

        public Decimal Deuda
        {
            get { return deu; }
            set { deu = value; }
        }

        public Decimal limite
        {
            get { return lim; }
            set { lim = value; }
        }

        public Int32 IdCiudad
        {
            get { return idCui; }
            set { idCui = value; }
        }


        // 5 - LISTAR TODOS LOS CLIENTES EN LA GRILLA solo poner el while y lo anterior
        public void Listar(DataGridView Grilla)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                Grilla.DataSource = null;
                Grilla.AutoGenerateColumns = false;
                Grilla.Rows.Clear();

                OleDbDataReader DR = comando.ExecuteReader();

                cantidad = 0;
                deuda = 0;

                while (DR.Read())
                {
                    Grilla.Rows.Add( 
                        DR.GetInt32(0),
                        DR.GetString(1),
                        "Ciudad", //sacar y poner    DR.GetInt32(4)     debajo 
                        DR.GetDecimal(2),
                        DR.GetDecimal(3)
                    );

                    cantidad++;
                    deuda += DR.GetDecimal(2);
                }

                DR.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                conexion.Close();
            }
        }


        public void ReporteClientes()
        {
            try
            {
                //Hacemos la conexión a la Base de Datos
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                //Ejecutamos la conexión, le decimos que timpo de tabla usamos y cual tabla usamos
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                OleDbDataReader DR = comando.ExecuteReader();
                StreamWriter AD = new StreamWriter("Reporte.csv", false, Encoding.UTF8);
                AD.WriteLine("Listado de Clientes\n");
                AD.WriteLine("Código;Nombre;Deuda");

                cantidad = 0;
                deuda = 0;

                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        AD.Write(DR.GetInt32(0));
                        AD.Write(";");
                        AD.Write(DR.GetString(1));
                        AD.Write(";");
                        AD.WriteLine(DR.GetDecimal(2));

                        cantidad++;
                        deuda = deuda + DR.GetDecimal(2);

                    }
                    AD.Write("\nCantidad de clientes:;;");
                    AD.WriteLine(cantidad);
                    AD.Write("Deuda de los clientes:;;");
                    AD.WriteLine(deuda);
                }

                conexion.Close();
                AD.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }


        public void Deudores(DataGridView Grilla)
        {
            try
            {
                //Hacemos la conexión a la Base de Datos
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                //Ejecutamos la conexión, le decimos que timpo de tabla usamos y cual tabla usamos
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                OleDbDataReader DR = comando.ExecuteReader();
                Grilla.Rows.Clear();

                cantidad = 0;
                deuda = 0;

                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        if (DR.GetDecimal(2) > 0)
                        {
                            Grilla.Rows.Add(DR.GetInt32(0), DR.GetString(1), DR.GetDecimal(2));
                            cantidad++;
                            deuda = deuda + DR.GetDecimal(2);
                        }

                    }

                }

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }


        public void Agregar()
        {
            try
            {
                //Hacemos la conexión a la Base de Datos
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                //Ejecutamos la conexión, le decimos que timpo de tabla usamos y cual tabla usamos
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                //Adaptamos los datos de toda la tabla y se los cargamos a DS
                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, Tabla);

                DataTable tabla = DS.Tables[Tabla];
                DataRow fila = tabla.NewRow();


                //llamamos a la fila
                fila["Nombre"] = Nom; //asigna los valores a las variables
                fila["Deuda"] = 0;
                fila["Limite"] = lim;
                fila["idCiudad"] = idCui;


                tabla.Rows.Add(fila);
                OleDbCommandBuilder conciliaCmbios = new OleDbCommandBuilder(adaptador);//coincilia los campo
                adaptador.Update(DS, Tabla); //hago efectivo el cambio antes



                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        // 4 - boton listar, que trae todos los clientes y los muestra en la grilla
        public void ListarCliente(DataGridView Grilla)
        {
           
            try
            {
            //Hacemos la conexión a la Base de Datos
            conexion.ConnectionString = CadenaConexion;
            conexion.Open();

            //Ejecutamos la conexión, le decimos que timpo de tabla usamos y cual tabla usamos
            comando.Connection = conexion;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = Tabla;

             OleDbDataReader DR = comando.ExecuteReader();
             Grilla.Rows.Clear();
             clsCiudad ciu = new clsCiudad();
             String NomCiu = "";

             if (DR.HasRows)
             {
                 while (DR.Read())
                  {
                        NomCiu = ciu.Buscar(DR.GetInt32(4));
                        Grilla.Rows.Add(DR.GetInt32(0), DR.GetString(1), NomCiu, DR.GetDecimal(2), DR.GetDecimal(3));
                 }
             }

                conexion.Close();
            }

            //catch(Exception e) 
            //{
            //MessageBox.Show(e.ToString());
            // }

            //catch (Exception e)
            //{
            // MessageBox.Show(e.ToString());
            //}
            catch (FormatException)  //cualquier error q hay pasa x aca 
            {
                MessageBox.Show("No se puede convertir el tipo de dato");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("No se puede dividir por cero");
            }
            catch (ArgumentException) //arg no puede se4r null
            {
                MessageBox.Show("El valor del argumento no puede ser nulo");
            }
            catch (IndexOutOfRangeException) //vectores
            {
                MessageBox.Show("Indice fuera de la matriz"); // se usa para los vectores
            }
            finally //lo q se pone aca se va a ejecutar en ambos casos SE EJECUTA SIEMPRE
            {
                //lo que va aca se ejecuta siempre, tanto por try como por catch por ejemplo resetar variables, cerrar conexión, etc...
            }
        }


        public string Buscar(Int32 IdCliente)
        {
            {
                try
                {
                    conexion.ConnectionString = CadenaConexion;
                    conexion.Open();

                    comando.Connection = conexion;
                    comando.CommandType = CommandType.TableDirect;
                    comando.CommandText = Tabla;

                    OleDbDataReader DR = comando.ExecuteReader();
                    String Resultado = "";
                    idCli = 0;

                    if (DR.HasRows)
                    {
                        while (DR.Read())
                        {
                            if (DR.GetInt32(0) == IdCliente)
                            {
                                Resultado = DR.GetString(1);
                                idCli = DR.GetInt32(0);
                                Nom = DR.GetString(1);
                                deu = DR.GetDecimal(2);
                                lim = DR.GetDecimal(3);
                                idCui = DR.GetInt32(4);
                            }
                        }
                    }

                    conexion.Close();

                    return Resultado;
                }
                catch (Exception e)
                {
                    return e.ToString();
                }
            }
        }


        public void Estructura(Int32 idCliente) //Esta es la estructura de la instrucción SQL para Modificar, Eliminar y Agregar
        {
            try
            {
                string Sql = "";

                //Hacemos la conexión a la Base de Datos
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                //Ejecutamos la conexión, le decimos que timpo de tabla usamos y cual tabla usamos
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = Sql;

                comando.ExecuteNonQuery(); //ejecuta toda la instrucciones

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }


        public void Modificar(Int32 idCliente)
        {
            try
            {
                string Sql = "UPDATE Lista SET Limite = " + lim.ToString() + " WHERE idCliente = " + idCliente.ToString();

                //Hacemos la conexión a la Base de Datos
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                //Ejecutamos la conexión, le decimos que timpo de tabla usamos y cual tabla usamos
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = Sql;

                comando.ExecuteNonQuery(); //ejecuta toda la instrucciones

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }


        public void Eliminar(Int32 idCliente)
        {
            try
            {
                string Sql = " DELETE * FROM Lista WHERE idCliente = " + idCliente.ToString(); //borra los clientes

                //Hacemos la conexión a la Base de Datos
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                //Ejecutamos la conexión, le decimos que timpo de tabla usamos y cual tabla usamos
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = Sql;

                comando.ExecuteNonQuery(); //ejecuta toda la instrucciones

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }


        public void AgregarSQL()
        {
            try
            {
                String sql = "";
                sql = "INSERT INTO Lista (Nombre,Deuda,Limite,idCiudad)";
                sql = sql + "VALUES ('" + Nom + "',0," + lim.ToString() + "," + idCui.ToString() + ")";

                //Hacemos la conexión a la Base de Datos
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                //Ejecutamos la conexión, le decimos que timpo de tabla usamos y cual tabla usamos
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;

                comando.ExecuteNonQuery(); //ejecuta toda la instrucciones

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }


        public void ListarDataSet(DataGridView Grilla)
        {
            try
            {
                //Hacemos la conexión a la Base de Datos
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                //Ejecutamos la conexión, le decimos que timpo de tabla usamos y cual tabla usamos
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                adaptador = new OleDbDataAdapter(comando);

                DataSet DS = new DataSet();
                adaptador.Fill(DS, Tabla); //TRAE LA TABLA COMPLETA Y LO CARGA en la grilla

                Grilla.Rows.Clear();

                clsCiudad ciu = new clsCiudad();
                String NomCiu = "";

                if (DS.Tables[Tabla].Rows.Count > 0) //si ese dataSet tiene filas
                {
                    foreach (DataRow x in DS.Tables[Tabla].Rows)  //recore el objeto (ds) dataRow o sea fila de datos.variBLE X in es en, luego
                    {
                        NomCiu = ciu.Buscar(
                            Convert.ToInt32(x["idCiudad"])  //en el dataset llama por nombre del campo" no la ubi como el dataReau
                        );

                        Grilla.Rows.Add(
                            x["idCliente"],
                            x["Nombre"],
                            NomCiu,
                            x["Deuda"],
                            x["Limite"]
                        );
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                conexion.Close();
            }
        }


        public void ReporteClientesCuadroDialogo(string NombreArchivo)
        {
            try
            {
                // Hacemos la conexión a la Base de Datos
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                // Ejecutamos la conexión
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                OleDbDataReader DR = comando.ExecuteReader();

                StreamWriter AD = new StreamWriter(NombreArchivo, false, Encoding.UTF8);

                AD.WriteLine("Listado de Clientes\n");
                AD.WriteLine("Código;Nombre;Deuda");

                cantidad = 0;
                deuda = 0;

                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        AD.Write(DR.GetInt32(0));
                        AD.Write(";");
                        AD.Write(DR.GetString(1));
                        AD.Write(";");
                        AD.WriteLine(DR.GetDecimal(2));

                        cantidad++;
                        deuda = deuda + DR.GetDecimal(2);
                    }

                    AD.Write("\nCantidad de clientes:;;");
                    AD.WriteLine(cantidad);
                    AD.Write("Deuda de los clientes:;;");
                    AD.WriteLine(deuda);
                }

                DR.Close();
                AD.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                conexion.Close();
            }
        }

        // 7 - IMPRIMIR part2
        public void Imprimir(PrintPageEventArgs reporte)
        {
            try
            {
                Font LetraTitulo1 = new Font("Arial", 20);
                Font LetraTitulo2 = new Font("Arial", 12);
                Font LetraTexto = new Font("Arial", 8);

                Int32 f = 200;

                reporte.Graphics.DrawString("Listado de Clientes",
                    LetraTitulo1, Brushes.Red, 100, 100);

                reporte.Graphics.DrawString("Código",
                    LetraTitulo2, Brushes.Blue, 100, 180);

                reporte.Graphics.DrawString("Nombre del cliente",
                    LetraTitulo2, Brushes.Blue, 300, 180);

                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                adaptador = new OleDbDataAdapter(comando);

                DataSet DS = new DataSet();
                adaptador.Fill(DS, Tabla);

                if (DS.Tables[Tabla].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {
                        reporte.Graphics.DrawString(
                            fila["idCliente"].ToString(),
                            LetraTexto, Brushes.Black, 100, f);

                        reporte.Graphics.DrawString(
                            fila["Nombre"].ToString(),
                            LetraTexto, Brushes.Black, 300, f);

                        f = f + 15;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                conexion.Close();
            }
        }

    }
}
