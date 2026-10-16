using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;

namespace GestionClientes_archivoCSV_
{
    internal class clsClientes
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();


        private string CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Clientes.mdb";
        private string Tabla = "Lista";

        //Declaro las Variables
        private Decimal deuda; //acumulacion de todas las deudas
        private Int32 cantidad;

        private Int32 idCli;
        private String Nom;
        private Decimal deu; //deuda de cada usuario
        private Decimal lim;
        private Int32 idCui;



        //Declaro las PROPIEDADES
        public Decimal TotalDeuda
        {
            get { return deuda; }
        }
        public Int32 CantidadDeudores
        {
            get { return cantidad; }
        }
        public Decimal PromedioDeuda
        {
            get { return deuda / cantidad; }
        }



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




        public void Listar(DataGridView Grilla)
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
            adaptador.Fill(DS);

            //Mostramos los datos en la grilla (cargamos la grilla)
            Grilla.DataSource = DS.Tables[0];


            conexion.Close();
            }
            catch(Exception e) 
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
                StreamWriter AD = new StreamWriter("Reporte.csv",false,Encoding.UTF8);
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


        public void Buscar(Int32 IdCliente)
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


                idCli = 0;

                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        if (DR.GetInt32(0) == IdCliente)
                        {
                            idCli = DR.GetInt32(0);
                            Nom = DR.GetString(1);
                            deu = DR.GetDecimal(2);
                            lim = DR.GetDecimal(3);
                            idCui = DR.GetInt32(4);

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



    }
}
