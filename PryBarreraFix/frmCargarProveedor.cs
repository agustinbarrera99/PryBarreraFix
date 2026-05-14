using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryFernandezIES
{
    public partial class frmCargarProveedor : Form
    {
        public frmCargarProveedor()
        {
            InitializeComponent();
            btnGuardar.Enabled = false;
            string rutaProveedores = System.IO.Path.GetFullPath(
                System.IO.Path.Combine(Application.StartupPath, @"..\..\Resources\Proveedores"));
            fbdSeleccionCarpeta.SelectedPath = rutaProveedores;
        }

        private void btnSeleccionCarpeta_Click(object sender, EventArgs e)
        {
            DialogResult resultado = fbdSeleccionCarpeta.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                lblDireccion.Text = fbdSeleccionCarpeta.SelectedPath;
                btnGuardar.Enabled = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string ruta = fbdSeleccionCarpeta.SelectedPath;
            string nombreArchivo = txtNombreArchivo.Text + ".csv";
            ruta += @"\" + nombreArchivo;         

            StreamWriter ManejoArchivo = new StreamWriter(ruta, false);
         
            ManejoArchivo.Write("N° ;");
            ManejoArchivo.Write("Entidad ;");
            ManejoArchivo.Write("APERTURA ;");
            ManejoArchivo.Write("N° EXPTE. ;");
            ManejoArchivo.Write("JUZG. ;");
            ManejoArchivo.Write("JURISD. ;");
            ManejoArchivo.Write("DIRECCION ;");
            ManejoArchivo.WriteLine("LIQUIDADOR RESPONSABLE");
            ManejoArchivo.Close();
            ManejoArchivo.Dispose();
            MessageBox.Show("Archivo Creado");
            lblDireccion.Text = "";
            txtNombreArchivo.Clear();
        }

        private void frmCargarProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                e.Handled = true;
                Application.Exit();
            }
        }
    }
}
