using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryFernandezIES
{
    public partial class frmUsuarios : Form
    {
        clsBaseDatosUsuarios objBaseDatosUsuarios;
        clsBaseDatosLogs objBaseDatosLogs;
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            objBaseDatosUsuarios = new clsBaseDatosUsuarios();
            objBaseDatosUsuarios.ConectarBD();

            objBaseDatosLogs = new clsBaseDatosLogs();
            objBaseDatosLogs.ConectarBD();

            lblEstadoConexion.BackColor = Color.Green;

            objBaseDatosUsuarios.TraerDatos(dgvUsuarios);
            objBaseDatosLogs.TraerDatos(dgvLogs);
        }



        private void frmUsuarios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                e.Handled = true;
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == string.Empty || txtContraseña.Text == string.Empty
                || lstCategoria.SelectedItem == null)
            {
                MessageBox.Show("Completar todos los campos");
                return;
            }

            objBaseDatosUsuarios.registrar(
                txtNombre.Text,
                txtContraseña.Text,
                Convert.ToString(lstCategoria.SelectedItem));

            dgvUsuarios.Rows.Clear();
            dgvUsuarios.Columns.Clear();
            objBaseDatosUsuarios.TraerDatos(dgvUsuarios);

            txtNombre.Clear();
            txtContraseña.Clear();
            lstCategoria.SelectedIndex = -1; // ✅ Resetea selección, NO borra los items

            MessageBox.Show("Usuario Registrado con Éxito");
        }
    }
}
