namespace pryFernandezIES
{
    partial class frmPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));

            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnBuscarProveedor = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnCargarProveedores = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.pnlSeparador = new System.Windows.Forms.Panel();
            this.pnlFormHijo = new System.Windows.Forms.Panel();
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.horaFecha = new System.Windows.Forms.Timer(this.components);
            this.lblTituloBarra = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();

            this.pnlMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.pnlFormHijo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();

            // ════════════════════════════════════════════
            // BARRA SUPERIOR
            // ════════════════════════════════════════════

            // lblTituloBarra
            this.lblTituloBarra.BackColor = System.Drawing.Color.FromArgb(18, 18, 30);
            this.lblTituloBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTituloBarra.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTituloBarra.ForeColor = System.Drawing.Color.FromArgb(30, 144, 255);
            this.lblTituloBarra.Location = new System.Drawing.Point(0, 0);
            this.lblTituloBarra.Name = "lblTituloBarra";
            this.lblTituloBarra.Size = new System.Drawing.Size(950, 36);
            this.lblTituloBarra.TabIndex = 3;
            this.lblTituloBarra.Text = "Sistema de Gestión — El Club";
            this.lblTituloBarra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // btnMinimizar
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(18, 18, 30);
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 65);
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Location = new System.Drawing.Point(874, 6);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(28, 24);
            this.btnMinimizar.TabIndex = 4;
            this.btnMinimizar.Text = "—";
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);

            // btnCerrar
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(18, 18, 30);
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(180, 30, 30);
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(913, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(28, 24);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "✕";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);

            // ════════════════════════════════════════════
            // MENÚ LATERAL
            // ════════════════════════════════════════════

            // pnlLogo
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(22, 22, 38);
            this.pnlLogo.Controls.Add(this.pctLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(200, 100);
            this.pnlLogo.TabIndex = 0;

            // pctLogo
            this.pctLogo.BackColor = System.Drawing.Color.FromArgb(22, 22, 38);
            this.pctLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctLogo.Location = new System.Drawing.Point(0, 0);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(200, 100);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabStop = false;
            this.pctLogo.Click += new System.EventHandler(this.pctLogo_Click);

            // pnlSeparador (línea azul bajo el logo)
            this.pnlSeparador.BackColor = System.Drawing.Color.FromArgb(30, 144, 255);
            this.pnlSeparador.Location = new System.Drawing.Point(16, 100);
            this.pnlSeparador.Name = "pnlSeparador";
            this.pnlSeparador.Size = new System.Drawing.Size(168, 1);

            // Botones del menú — helper local
            System.Action<System.Windows.Forms.Button, string, int> estiloBoton =
                (btn, texto, y) =>
                {
                    btn.BackColor = System.Drawing.Color.Transparent;
                    btn.Cursor = System.Windows.Forms.Cursors.Hand;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(30, 144, 255);
                    btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(0, 110, 220);
                    btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
                    btn.ForeColor = System.Drawing.Color.FromArgb(180, 200, 255);
                    btn.Location = new System.Drawing.Point(0, y);
                    btn.Size = new System.Drawing.Size(200, 44);
                    btn.Text = texto;
                    btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    btn.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
                    btn.UseVisualStyleBackColor = false;
                };

            estiloBoton(this.btnClientes, "  ▸  Clientes", 110);
            estiloBoton(this.btnCargarProveedores, "  ▸  Cargar Proveedor", 154);
            estiloBoton(this.btnBuscarProveedor, "  ▸  Buscar Proveedor", 198);
            estiloBoton(this.btnUsuarios, "  ▸  Usuarios", 242);
            estiloBoton(this.btnAyuda, "  ▸  Ayuda", 512);

            this.btnClientes.TabIndex = 1;
            this.btnCargarProveedores.TabIndex = 2;
            this.btnBuscarProveedor.TabIndex = 3;
            this.btnUsuarios.TabIndex = 5;
            this.btnAyuda.TabIndex = 2;

            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            this.btnCargarProveedores.Click += new System.EventHandler(this.btnCargarProveedores_Click);
            this.btnBuscarProveedor.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);

            // lblVersion (abajo del menú)
            this.lblVersion.AutoSize = false;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(60, 80, 120);
            this.lblVersion.Location = new System.Drawing.Point(0, 556);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(200, 20);
            this.lblVersion.Text = "  v1.0";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // pnlMenu
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(18, 18, 30);
            this.pnlMenu.Controls.Add(this.btnUsuarios);
            this.pnlMenu.Controls.Add(this.btnBuscarProveedor);
            this.pnlMenu.Controls.Add(this.btnAyuda);
            this.pnlMenu.Controls.Add(this.btnCargarProveedores);
            this.pnlMenu.Controls.Add(this.btnClientes);
            this.pnlMenu.Controls.Add(this.pnlSeparador);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Controls.Add(this.lblVersion);
            this.pnlMenu.Location = new System.Drawing.Point(0, 35);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 565);
            this.pnlMenu.TabIndex = 0;

            // ════════════════════════════════════════════
            // ÁREA DE CONTENIDO
            // ════════════════════════════════════════════

            // pictureBox1 (bienvenida)
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Location = new System.Drawing.Point(164, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(427, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabStop = false;

            // lblFechaHora
            this.lblFechaHora.BackColor = System.Drawing.Color.FromArgb(14, 14, 24);
            this.lblFechaHora.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFechaHora.ForeColor = System.Drawing.Color.FromArgb(180, 200, 255);
            this.lblFechaHora.Location = new System.Drawing.Point(-1, 528);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(753, 36);
            this.lblFechaHora.TabIndex = 2;
            this.lblFechaHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // pnlFormHijo
            this.pnlFormHijo.BackColor = System.Drawing.Color.FromArgb(22, 22, 38);
            this.pnlFormHijo.Controls.Add(this.lblFechaHora);
            this.pnlFormHijo.Controls.Add(this.pictureBox1);
            this.pnlFormHijo.Location = new System.Drawing.Point(200, 35);
            this.pnlFormHijo.Name = "pnlFormHijo";
            this.pnlFormHijo.Size = new System.Drawing.Size(750, 565);
            this.pnlFormHijo.TabIndex = 1;

            // horaFecha
            this.horaFecha.Enabled = true;
            this.horaFecha.Tick += new System.EventHandler(this.horaFecha_Tick);

            // ── frmPrincipal ────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(18, 18, 30);
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblTituloBarra);
            this.Controls.Add(this.pnlFormHijo);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPrincipal_KeyDown);

            this.pnlMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.pnlFormHijo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnCargarProveedores;
        private System.Windows.Forms.Panel pnlFormHijo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBuscarProveedor;
        private System.Windows.Forms.Label lblFechaHora;
        private System.Windows.Forms.Timer horaFecha;
        private System.Windows.Forms.Label lblTituloBarra;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Panel pnlSeparador;
        private System.Windows.Forms.Label lblVersion;
    }
}