using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionClientes_archivoCSV_
{
    internal class clsCiudad
    {

        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Clientes.mdb";
        private string Tabla = "Ciudad";


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
                Grilla.DataSource = DS.Tables[Tabla];


                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }


        public void Listar(ComboBox combo)
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

                combo.DataSource = DS.Tables[0];
                combo.DisplayMember = "Nombre";
                combo.ValueMember = "idCiudad";

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }



        public String Buscar(Int32 IdCliente)
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
                String Resultado = "";

                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        if (DR.GetInt32(0) == IdCliente)
                        {
                            Resultado= DR.GetString(0);
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
}
