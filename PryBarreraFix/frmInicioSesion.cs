using System;
using System.Drawing;
using System.Windows.Forms;

namespace pryFernandezIES
{
    public partial class frmInicioSesion : Form
    {
        clsBaseDatosUsuarios objBaseDatosUsuario;

        public frmInicioSesion()
        {
            InitializeComponent();
            objBaseDatosUsuario = new clsBaseDatosUsuarios();
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            if (btnInicioSesion.Text == "Siguiente →")
            {
                if (txtUsuario.Text == string.Empty)
                {
                    lblErrorUsuario.Visible = true;
                    lblErrorUsuario.Text = "El campo Usuario está vacío";
                    pnlLineaUsuario.BackColor = Color.FromArgb(255, 80, 80);
                    return;
                }

                lblCopiaUsuario.Text = txtUsuario.Text;
                btnInicioSesion.Text = "Acceder →";
                controlTimer = false; 
                timer1.Start();
            }
            else if (btnInicioSesion.Text == "Acceder →")
            {
                if (txtContraseña.Text == string.Empty)
                {
                    lblErrorContraseña.Visible = true;
                    lblErrorContraseña.Text = "El campo Contraseña está vacío";
                    pnlLineaContraseña.BackColor = Color.FromArgb(255, 80, 80);
                    return;
                }

                objBaseDatosUsuario.Login(txtUsuario.Text, txtContraseña.Text, this);
            }
        }

        public bool controlTimer = false;

        private void timer1_Tick(object sender, EventArgs e)
        {
            const int velocidad = 18;   
            const int posInicio = 17;   
            const int anchoPanel = 342;  

            if (!controlTimer)
            {
                pnlUsuario.Left -= velocidad;
                pnlContraseña.Left -= velocidad;

                if (pnlContraseña.Left <= posInicio)
                {
                    pnlUsuario.Left = posInicio - anchoPanel - 20;
                    pnlContraseña.Left = posInicio;
                    timer1.Stop();
                    txtContraseña.Focus();
                }
            }
            else
            {
                pnlUsuario.Left += velocidad;
                pnlContraseña.Left += velocidad;

                if (pnlUsuario.Left >= posInicio)
                {
                    pnlUsuario.Left = posInicio;
                    pnlContraseña.Left = posInicio + anchoPanel + 20;
                    timer1.Stop();
                    txtUsuario.Focus();
                    btnInicioSesion.Text = "Siguiente →";
                    controlTimer = false;
                    txtContraseña.Text = string.Empty;
                    lblErrorContraseña.Visible = false;
                }
            }
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            controlTimer = true;   // dirección: volver a usuario
            timer1.Start();
        }
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            pnlLineaUsuario.BackColor = Color.FromArgb(30, 144, 255);
            lblErrorUsuario.Visible = false;
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            pnlLineaUsuario.BackColor = Color.FromArgb(60, 60, 90);
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            pnlLineaContraseña.BackColor = Color.FromArgb(30, 144, 255);
            lblErrorContraseña.Visible = false;
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            pnlLineaContraseña.BackColor = Color.FromArgb(60, 60, 90);
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
                btnInicioSesion_Click(sender, EventArgs.Empty);
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
                btnInicioSesion_Click(sender, EventArgs.Empty);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e) => Application.Exit();
        private void btnMinimizar_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

        private void frmInicioSesion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { e.Handled = true; Application.Exit(); }
        }
    }
}