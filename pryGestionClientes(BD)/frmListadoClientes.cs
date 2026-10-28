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
    public partial class frmListadoClientes : Form
    {
        public frmListadoClientes()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            clsClientes objClientes = new clsClientes();
            objClientes.ListarClientes(dgvGrilla);
        }

        private void btn_Reporte_Click(object sender, EventArgs e)
        {
            clsClientes objClientes = new clsClientes();
            objClientes.ReporteClientes();
            MessageBox.Show("Reporte Generado Correctamente");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            clsClientes objClientes = new clsClientes();
            objClientes.ListarDataSet(dgvGrilla2);
        }

        private void dgvGrilla2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
