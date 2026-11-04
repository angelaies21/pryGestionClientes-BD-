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
    public partial class frmDatos : Form
    {
        public frmDatos()
        {
            InitializeComponent();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            SaveFileDialog objArchivo = new SaveFileDialog();

            objArchivo.Title = "Seleccione carpeta y escriba el nombre del archivo";
            objArchivo.RestoreDirectory = true;
            objArchivo.Filter = "Archivos separado por coma (*.csv)|*.csv|Archivos de texto (*.txt)|*.txt";

            if (objArchivo.ShowDialog() == DialogResult.OK)
            {
                clsClientes objClientes = new clsClientes();
                objClientes.ReporteClientesCuadroDialogo(objArchivo.FileName);
            }
        }

        private void btnListarDatos_Click(object sender, EventArgs e)
        {
            clsClientes objClientes = new clsClientes();
            objClientes.ListarCliente(Dgvgrilladatos);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            clsClientes objClientes = new clsClientes();
            objClientes.ListarDataSet(dgvtable);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            prtVentana.Document = prtDocumento;

            if (prtVentana.ShowDialog() == DialogResult.OK)
            {
                prtDocumento.PrinterSettings = prtVentana.PrinterSettings;

                prtDocumento.Print();

                MessageBox.Show("Reporte Impreso Correctamente");
            }
        }

        private void prtDocumento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            System.Drawing.Printing.PageSettings pg = new System.Drawing.Printing.PageSettings();
            {

                //Font fuente = new Font("Arial", 12, FontStyle.Bold);
                //e.Graphics.DrawString("Hola, Mundo!", fuente, Brushes.Blue,200,200);

                clsClientes x = new clsClientes();
                x.Imprimir(e);
            }
        }
    }
}
