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

            Int32 cliente = Convert.ToInt32(txtCodigo.Text);
            x.Buscar(cliente);

            if (x.IdCliente != 0)
            {
                lblNombre.Text = x.Nombre;
                lblDeudas.Text = x.Deuda.ToString();
                txtLimite.Text = x.limite.ToString();
            }
             
            else
            {                
                lblNombre.Text = "";
                lblDeudas.Text = "";
                txtLimite.Text = "";
                MessageBox.Show("Cliente no encontrado");
            }

            btnEliminar.Enabled = true; //btn q se bloquee
            btnEditar.Enabled = true;

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
            clsClientes x = new clsClientes();
            x.limite = Convert.ToDecimal(txtLimite.Text); //se lo manda al txt Modificar desde la clase
            x.Modificar(Convert.ToInt32(txtCodigo.Text)); 
            btnGuardar.Enabled=false;
            MessageBox.Show("Los datos se guardaron correctamente");
        }

        private void frmBuscar_Load(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false; //btn q se bloquee
            btnEditar.Enabled = false;
            btnGuardar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            clsClientes x = new clsClientes();

            x.Eliminar(Convert.ToInt32(txtCodigo.Text));
            MessageBox.Show("El cliente se elimino correctamente");
        }
    }
}
