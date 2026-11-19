using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionClientes_archivoCSV_
{
    public partial class frmGestorClientesArcivosCSV : Form
    {
        public frmGestorClientesArcivosCSV()
        {
            InitializeComponent();
        }

        private void agregarNuevosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new frmAgregar();
            formulario.Show();
        }

        private void listadoDeTodosLosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new frmListado();
            formulario.Show();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listadoDeClientesDeudoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new frmDeudores();
            formulario.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void buscarCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new frmBuscar();
            formulario.Show();
        }

        private void frmGestorClientesArcivosCSV_Load(object sender, EventArgs e)
        {

        }





        //FORM 1 PEGAR

/* 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFianl
{
public partial class Form1 : Form
{
public Form1()
{
    InitializeComponent();
}

private OleDbConnection conexion = new OleDbConnection();
private OleDbCommand comando = new OleDbCommand();
private OleDbDataAdapter adaptador = new OleDbDataAdapter();
private OleDbDataReader reader = null;

private string CadenaConexion =
    "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
    + Application.StartupPath + @"\Movimientos.mdb";

private void Form1_Load(object sender, EventArgs e)
{
    try
    {
        conexion.ConnectionString = CadenaConexion;
        conexion.Open();

        comando.Connection = conexion;
        comando.CommandType = CommandType.TableDirect;
        comando.CommandText = "Movimientos";

        adaptador.SelectCommand = comando;

        DataTable dt = new DataTable();
        adaptador.Fill(dt);

        dgvMov.DataSource = dt;

        conexion.Close();
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.ToString());
    }
}

private void btnAgregar_Click(object sender, EventArgs e)
{
    try
    {
        decimal monto;

        if (!decimal.TryParse(txtMonto.Text, out monto))
        {
            MessageBox.Show("Ingresá un monto válido.");
            txtMonto.Focus();
            return;
        }

        if (string.IsNullOrWhiteSpace(txtNombre.Text))
        {
            MessageBox.Show("Ingresá un nombre.");
            txtNombre.Focus();
            return;
        }

        using (OleDbConnection cn =
            new OleDbConnection(CadenaConexion))
        {
            cn.Open();

            string sql = "";
            sql = "INSERT INTO [Movimientos] ";
            sql = sql + "([Monto], [Nombre], [Tipo]) ";
            sql = sql + "VALUES (?, ?, ?)";

            using (OleDbCommand cmd = new OleDbCommand())
            {
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;

                cmd.Parameters.Add("?", OleDbType.Currency)
                    .Value = monto;

                cmd.Parameters.Add("?", OleDbType.VarWChar)
                    .Value = txtNombre.Text.Trim();

                cmd.Parameters.Add("?", OleDbType.Boolean)
                    .Value = optIngreso.Checked;

                cmd.ExecuteNonQuery();
            }
        }

        MessageBox.Show("Movimiento agregado correctamente.");

        txtMonto.Clear();
        txtNombre.Clear();

        // Volvemos a cargar la grilla.
        try
        {
            using (OleDbConnection cn =
                new OleDbConnection(CadenaConexion))
            {
                cn.Open();

                string consulta =
                    "SELECT * FROM [Movimientos]";

                using (OleDbDataAdapter adaptador =
                    new OleDbDataAdapter(consulta, cn))
                {
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    dgvMov.AutoGenerateColumns = true;
                    dgvMov.DataSource = tabla;
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                "Se guardó, pero no se pudo actualizar la grilla: "
                + ex.Message);
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("Error al agregar: " + ex.Message);
    }
}

private void btnBuscarMov_Click(object sender, EventArgs e)
{
    try
    {
        using (OleDbConnection cn =
            new OleDbConnection(CadenaConexion))
        {
            cn.Open();

            string sql = "SELECT * FROM [Movimientos]";

            using (OleDbDataAdapter adaptador =
                new OleDbDataAdapter(sql, cn))
            {
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                if (optEgresoFiltro.Checked)
                {
                    DataView vista = new DataView(tabla);
                    vista.RowFilter = "Tipo = false";
                    dgvMov.DataSource = vista;
                }
                else
                {
                    DataView vista = new DataView(tabla);
                    vista.RowFilter = "Tipo = true";
                    dgvMov.DataSource = vista;
                }
            }
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("Error al listar: " + ex.Message);
    }
}

private void btnVerTodos_Click(object sender, EventArgs e)
{
    try
    {
        using (OleDbConnection cn =
            new OleDbConnection(CadenaConexion))
        {
            cn.Open();

            string sql = "SELECT * FROM [Movimientos]";

            using (OleDbDataAdapter adaptador =
                new OleDbDataAdapter(sql, cn))
            {
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                dgvMov.DataSource = tabla;

                if (optEgresoFiltro.Checked)
                {
                    DataView vista = new DataView(tabla);
                    vista.RowFilter = "Tipo = false";
                    dgvMov.DataSource = vista;
                }
                else
                {
                    dgvMov.DataSource = tabla;
                }
            }
        }

        optEgreso.Checked = false;
        optEgresoFiltro.Checked = false;
    }
    catch (Exception ex)
    {
        MessageBox.Show("Error al listar: " + ex.Message);
    }
}
}
}
*/














}
}
