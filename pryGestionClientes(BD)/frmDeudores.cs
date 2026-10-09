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
    public partial class frmDeudores : Form
    {
        public frmDeudores()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            clsClientes x = new clsClientes();
            x.Deudores(dgvGrilla);

            lblCantidad.Text = x.CantDeudores.ToString();
            lblTotal.Text = x.TotalDeuda.ToString();
            lblPromedio.Text = x.PromDeuda.ToString("0.00"); //solo muestra 2num dsp de la coma
        }
    }
}
