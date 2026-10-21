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
    public partial class frmAgregar : Form
    {
        public frmAgregar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsClientes x = new clsClientes();
            x.Nombre = txtNom.Text;
            x.limite = Convert.ToDecimal(txtLim.Text);
            x.IdCiudad = Convert.ToInt32(cmbCiudad.SelectedValue);
            x.Agregar();

            MessageBox.Show("Datos agregados correctamente");

            txtNom.Text = "";
            txtLim.Text = "";
            cmbCiudad.SelectedIndex = 0;

        }

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            clsCiudad ciu = new clsCiudad();
            ciu.Listar(cmbCiudad);
        }

        private void btnCargarSQL_Click(object sender, EventArgs e)
        {
            clsClientes x = new clsClientes();
            x.Nombre = txtNom.Text;
            x.limite = Convert.ToDecimal(txtLim.Text);
            x.IdCiudad = Convert.ToInt32(cmbCiudad.SelectedValue);
            x.AgregarSQL();

            MessageBox.Show("Datos agregados correctamente");

            txtNom.Text = "";
            txtLim.Text = "";
            cmbCiudad.SelectedIndex = 0;
        }
    }
}
