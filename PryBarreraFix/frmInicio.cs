using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryFernandezIES
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();

            // Bordes redondeados del botón
            btnIniciar.Region = new System.Drawing.Region(
                RoundedRect(new System.Drawing.Rectangle(0, 0, btnIniciar.Width, btnIniciar.Height), 12));

            CentrarBoton();
            this.Resize += (s, e) => CentrarBoton();
        }

        private System.Drawing.Drawing2D.GraphicsPath RoundedRect(
            System.Drawing.Rectangle bounds, int radius)
        {
            int d = radius * 2;
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, d, d, 180, 90);
            path.AddArc(bounds.Right - d, bounds.Y, d, d, 270, 90);
            path.AddArc(bounds.Right - d, bounds.Bottom - d, d, d, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void CentrarBoton()
        {
            btnIniciar.Left = (pctInicio.Width - btnIniciar.Width) / 2;
            btnIniciar.Top = (pctInicio.Height - btnIniciar.Height) / 2 + 80;
        }
        private void btnIniciar_Click(object sender, EventArgs e)
        {          
            frmInicioSesion principal = new frmInicioSesion();
            principal.Show();
            this.Hide();               
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmInicio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                e.Handled = true;
                Application.Exit();
            }
        }
    }
}
