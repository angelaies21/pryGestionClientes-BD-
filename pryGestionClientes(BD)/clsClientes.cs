using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace GestionClientes_archivoCSV_
{
    internal class clsClientes
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();
        private OleDbDataReader reader = null;


        private string CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Clientes.mdb";
        private string Tabla = "Lista";


        //variables
        private Decimal deuda;
        private Int32 cantidad;

        //PROPIEDADES
        public Decimal TotalDeuda
        {
            get { return deuda; }
        }

        public Int32 CantDeudores
        {
            get { return cantidad; }
        }

        public Decimal PromDeuda
        {
            get { return deuda / cantidad; }
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
                DataSet DS = new DataSet();             //data set llama a todos
                adaptador.Fill(DS);

                //Mostramos los datos en la grilla (cargamos la grilla)
                Grilla.DataSource = DS.Tables[0];


                conexion.Close();
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

                if (DR.HasRows) //el hasRows pregunta si tiene datos o fila ejecuta lo otro
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



    }
}
