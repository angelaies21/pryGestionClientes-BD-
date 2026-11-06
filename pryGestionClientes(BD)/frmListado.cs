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
    public partial class frmListado : Form
    {
        public frmListado()
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

            // 6 - btn IMPRIMIR

            prtVentana.ShowDialog(); //creamos la ventana para seleccionar la impresora
            prtDocumento.PrinterSettings = prtVentana.PrinterSettings; //le asignamos a la impresora que seleccionamos en la ventana
            prtDocumento.Print();  //imprimimos
            MessageBox.Show("Reporte Impreso Correctamente");

        }


        private void prtDocumento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //  Ejemplo de escritura directa
            //  Font TipoLetra = new Font("Arial", 12);
            //  e.Graphics.DrawString("Hola", TipoLetra, Brushes.Blue, 200, 200);

            //Ahora si llamamos al procedimiento


            // 7 - PRNT DOCUMENTO
            clsClientes x = new clsClientes();
            x.Imprimir(e);
        }

        private void frmDatos_Load(object sender, EventArgs e)
        {

        }
    }
}
