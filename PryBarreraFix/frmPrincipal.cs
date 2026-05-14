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
    public partial class frmPrincipal : Form
    {
        clsBaseDatosLogs objBaseDatosLogs;
        string varUsuario;
        string varCategoria;
        
        public frmPrincipal(string usuario, string categoria)
        {
            InitializeComponent();

            varUsuario = usuario;
            varCategoria = categoria;

            objBaseDatosLogs = new clsBaseDatosLogs();
            objBaseDatosLogs.ConectarBD();

            if (varCategoria == "Admin")
            {
                btnUsuarios.Visible = true;
                btnUsuarios.Enabled = true;
            }
            if (varCategoria == "User")
            {
                btnUsuarios.Visible = false;
                btnUsuarios.Enabled = false;
            }

            pctLogo.Paint += pctLogo_Paint;
            ActualizarFlecha();
        }

        //  MENU
        private void pctLogo_Click(object sender, EventArgs e)
        {
            if (formActivo != null)
            {
                formActivo.Close();
            }          
        }

        private void pctLogo_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            if (formActivo == null) return;

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Fondo semitransparente sobre el logo
            using (var overlay = new SolidBrush(System.Drawing.Color.FromArgb(160, 18, 18, 30)))
                g.FillRectangle(overlay, pctLogo.ClientRectangle);

            // Flecha ←
            var puntos = new System.Drawing.Point[]
            {
        new System.Drawing.Point(55, 50),   
        new System.Drawing.Point(85, 30),   
        new System.Drawing.Point(85, 42),   
        new System.Drawing.Point(130, 42),  
        new System.Drawing.Point(130, 58),  
        new System.Drawing.Point(85, 58),  
        new System.Drawing.Point(85, 70),  
            };

            using (var brush = new SolidBrush(System.Drawing.Color.FromArgb(30, 144, 255)))
                g.FillPolygon(brush, puntos);
            using (var font = new Font("Segoe UI", 8f, FontStyle.Bold))
            using (var brush = new SolidBrush(System.Drawing.Color.FromArgb(180, 200, 255)))
            {
                var rect = new RectangleF(0, 72, pctLogo.Width, 20);
                var fmt = new StringFormat { Alignment = StringAlignment.Center };
                g.DrawString("Volver", font, brush, rect, fmt);
            }
        }
        private void ActualizarFlecha()
        {
            pctLogo.Invalidate(); 
        }

        private void btnCargarProveedores_Click(object sender, EventArgs e)
        {
            DateTime fechaHora = DateTime.Now;
            string detalle = "Ingreso a Carga Proveedores";
            objBaseDatosLogs.Logs(varUsuario, fechaHora, detalle);
            
            abrirFormHijo(new frmCargarProveedor());
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            DateTime fechaHora = DateTime.Now;
            string detalle = "Ingreso a Buscar Proveedores";
            objBaseDatosLogs.Logs(varUsuario, fechaHora, detalle);

            abrirFormHijo(new frmBuscarProveedor());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            DateTime fechaHora = DateTime.Now;
            string detalle = "Ingreso a Clientes";
            objBaseDatosLogs.Logs(varUsuario, fechaHora, detalle);

            abrirFormHijo(new frmClientes());
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            DateTime fechaHora = DateTime.Now;
            string detalle = "Ingreso a Ayuda";
            objBaseDatosLogs.Logs(varUsuario, fechaHora, detalle);

            abrirFormHijo(new frmAyuda());
        }
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            
            DateTime fechaHora = DateTime.Now;
            string detalle = "Ingreso a Usuarios";
            objBaseDatosLogs.Logs(varUsuario, fechaHora, detalle);

            abrirFormHijo(new frmUsuarios());
        }

        private Form formActivo = null;

        private void abrirFormHijo(Form formHijo)
        {
            if (formActivo != null)
                formActivo.Close();
            formActivo = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            pnlFormHijo.Controls.Add(formHijo);
            pnlFormHijo.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            string hora = DateTime.Now.ToLongTimeString();
            string fecha = DateTime.Now.ToLongDateString();

            lblFechaHora.Text = hora + "   " + fecha; 
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DateTime fechaHora = DateTime.Now;
            string detalle = "Cierre de Sistema";
            objBaseDatosLogs.Logs(varUsuario, fechaHora, detalle);

            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                e.Handled = true;
                Application.Exit();
            }
        }
    }
}
