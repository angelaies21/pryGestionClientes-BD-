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
            x.Deudores(dgvClientes);
            lblCantidad.Text = x.CantidadDeudores.ToString();
            lblTotal.Text = x.TotalDeuda.ToString();
            lblPromedio.Text = x.PromedioDeuda.ToString("0.00");
        }
    }
}
