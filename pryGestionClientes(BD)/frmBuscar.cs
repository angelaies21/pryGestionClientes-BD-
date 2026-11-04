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
    public partial class frmBuscar : Form
    {
        public frmBuscar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            clsClientes x = new clsClientes();

            Int32 cliente = Convert.ToInt32(txtCodigo.Text); //creamos el objeto x que trae el archivo (la clase) clsClientes que es donde tenemos todos los procedimientos
            x.Buscar(cliente);  //declaramos una variable para poder poner el txtCodigo en x.Buscar(ACA)

            if (x.IdCliente != 0) //para eso en la clase pusimos idCli = 0 si cambia se muestran los datos aca
            {
                lblNombre.Text = x.Nombre;
                lblDeuda.Text = x.Deuda.ToString();
                txtLimite.Text = x.limite.ToString();
            }
             
            else
            {                
                lblNombre.Text = "";
                lblDeuda.Text = "";
                txtLimite.Text = "";
                MessageBox.Show("Cliente no encontrado");
            }

            txtLimite.Enabled = true; //btn q se bloquee
            btnEliminar.Enabled = true;
            btnEditar.Enabled = true;
            btnGuardar.Enabled = false;
        }

        private void txtLimite_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false; //btn q se bloquee
            btnEditar.Enabled = false; 
            btnGuardar.Enabled = true;
            txtLimite.ReadOnly = false; //para q se pueda edutaer
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Int32 id = Convert.ToInt32(txtCodigo.Text);
            clsClientes x = new clsClientes();
            x.limite = Convert.ToDecimal(txtLimite.Text); //se lo manda al txt Modificar desde la clase
            x.Modificar(id);          
            MessageBox.Show("Los datos se guardaron correctamente");

            limpiar();
        }

        private void frmBuscar_Load(object sender, EventArgs e)
        {
            btnBuscar.Enabled = false;
            btnEliminar.Enabled = false; //btn q se bloquee
            btnEditar.Enabled = false;
            btnGuardar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Int32 id = Convert.ToInt32(txtCodigo.Text);
            clsClientes x = new clsClientes();
            x.Eliminar(id);
            MessageBox.Show("Dato eliminado exitosamente");

            limpiar(); ;
        }

       
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                btnBuscar.Enabled = true;
            }
            else
            {
                btnBuscar.Enabled = false;
            }
        }


        private void limpiar()
        {
            txtLimite.Text = "";
            lblNombre.Text = "";
            lblDeuda.Text = "";
            txtLimite.ReadOnly = true;
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            btnGuardar.Enabled = false;
        }

    }
}
