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
                lblNom.Text = x.Nombre;
                lblDeudas.Text = x.Deuda.ToString();
                lblListasCred.Text = x.limite.ToString();
            }
             
            else
            {                
                lblNom.Text = "";
                lblDeudas.Text = "";
                lblListasCred.Text = "";
                MessageBox.Show("Cliente no encontrado");
            }


            
        }
    }
}
