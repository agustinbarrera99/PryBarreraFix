namespace pryFernandezIES
{
    partial class frmInicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicioSesion));

            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnInicioSesion = new System.Windows.Forms.Button();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.pnlLineaUsuario = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblErrorUsuario = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.pnlContraseña = new System.Windows.Forms.Panel();
            this.lblCopiaUsuario = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pnlLineaContraseña = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblErrorContraseña = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();

            this.pnlUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlLogin.SuspendLayout();
            this.pnlContraseña.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();

            // ── Colores del tema ──────────────────────────
            // Fondo:    #12121E
            // Panel:    #1C1C2D
            // Acento:   #1E90FF
            // Texto:    #B4C8FF
            // Error:    #FF5050
            // Linea off:#3C3C5A

            // ── txtUsuario ──────────────────────────────
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(28, 28, 45);
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsuario.ForeColor = System.Drawing.Color.White;
            this.txtUsuario.Location = new System.Drawing.Point(52, 88);
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(262, 22);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);

            // ── lblNombre ──────────────────────────────
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(180, 200, 255);
            this.lblNombre.Location = new System.Drawing.Point(52, 64);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Text = "USUARIO";

            // ── btnInicioSesion ──────────────────────────
            this.btnInicioSesion.BackColor = System.Drawing.Color.FromArgb(30, 144, 255);
            this.btnInicioSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicioSesion.FlatAppearance.BorderSize = 0;
            this.btnInicioSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(0, 110, 220);
            this.btnInicioSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(0, 80, 180);
            this.btnInicioSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicioSesion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnInicioSesion.ForeColor = System.Drawing.Color.White;
            this.btnInicioSesion.Location = new System.Drawing.Point(95, 172);
            this.btnInicioSesion.Name = "btnInicioSesion";
            this.btnInicioSesion.Size = new System.Drawing.Size(184, 44);
            this.btnInicioSesion.TabIndex = 4;
            this.btnInicioSesion.Text = "Siguiente →";
            this.btnInicioSesion.UseVisualStyleBackColor = false;
            this.btnInicioSesion.Click += new System.EventHandler(this.btnInicioSesion_Click);

            // ── pnlLineaUsuario ──────────────────────────
            this.pnlLineaUsuario.BackColor = System.Drawing.Color.FromArgb(30, 144, 255);
            this.pnlLineaUsuario.Location = new System.Drawing.Point(52, 112);
            this.pnlLineaUsuario.Name = "pnlLineaUsuario";
            this.pnlLineaUsuario.Size = new System.Drawing.Size(262, 2);
            this.pnlLineaUsuario.TabIndex = 9;

            // ── pictureBox2 (ícono usuario) ──────────────
            this.pictureBox2.Location = new System.Drawing.Point(22, 86);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabStop = false;

            // ── lblErrorUsuario ──────────────────────────
            this.lblErrorUsuario.AutoSize = true;
            this.lblErrorUsuario.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblErrorUsuario.ForeColor = System.Drawing.Color.FromArgb(255, 80, 80);
            this.lblErrorUsuario.Location = new System.Drawing.Point(22, 122);
            this.lblErrorUsuario.Name = "lblErrorUsuario";
            this.lblErrorUsuario.Text = "Campo requerido";
            this.lblErrorUsuario.Visible = false;

            // ── pnlUsuario ──────────────────────────────
            this.pnlUsuario.BackColor = System.Drawing.Color.FromArgb(28, 28, 45);
            this.pnlUsuario.Controls.Add(this.pnlLineaUsuario);
            this.pnlUsuario.Controls.Add(this.pictureBox2);
            this.pnlUsuario.Controls.Add(this.lblErrorUsuario);
            this.pnlUsuario.Controls.Add(this.lblNombre);
            this.pnlUsuario.Controls.Add(this.txtUsuario);
            this.pnlUsuario.Location = new System.Drawing.Point(17, 3);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(342, 148);
            this.pnlUsuario.TabIndex = 5;

            // ── pnlLineaContraseña ──────────────────────
            this.pnlLineaContraseña.BackColor = System.Drawing.Color.FromArgb(30, 144, 255);
            this.pnlLineaContraseña.Location = new System.Drawing.Point(52, 112);
            this.pnlLineaContraseña.Name = "pnlLineaContraseña";
            this.pnlLineaContraseña.Size = new System.Drawing.Size(262, 2);
            this.pnlLineaContraseña.TabIndex = 9;

            // ── pictureBox3 (ícono candado) ──────────────
            this.pictureBox3.Location = new System.Drawing.Point(22, 86);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabStop = false;

            // ── lblErrorContraseña ──────────────────────
            this.lblErrorContraseña.AutoSize = true;
            this.lblErrorContraseña.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblErrorContraseña.ForeColor = System.Drawing.Color.FromArgb(255, 80, 80);
            this.lblErrorContraseña.Location = new System.Drawing.Point(22, 122);
            this.lblErrorContraseña.Name = "lblErrorContraseña";
            this.lblErrorContraseña.Text = "Campo requerido";
            this.lblErrorContraseña.Visible = false;

            // ── lblContraseña ──────────────────────────
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.BackColor = System.Drawing.Color.Transparent;
            this.lblContraseña.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblContraseña.ForeColor = System.Drawing.Color.FromArgb(180, 200, 255);
            this.lblContraseña.Location = new System.Drawing.Point(52, 64);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Text = "CONTRASEÑA";

            // ── txtContraseña ──────────────────────────
            this.txtContraseña.BackColor = System.Drawing.Color.FromArgb(28, 28, 45);
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtContraseña.ForeColor = System.Drawing.Color.White;
            this.txtContraseña.Location = new System.Drawing.Point(52, 88);
            this.txtContraseña.Multiline = true;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '●';
            this.txtContraseña.Size = new System.Drawing.Size(262, 22);
            this.txtContraseña.TabIndex = 0;
            this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter);
            this.txtContraseña.Leave += new System.EventHandler(this.txtContraseña_Leave);
            this.txtContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContraseña_KeyPress);

            // ── lblCopiaUsuario ──────────────────────────
            this.lblCopiaUsuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCopiaUsuario.ForeColor = System.Drawing.Color.FromArgb(30, 144, 255);
            this.lblCopiaUsuario.Location = new System.Drawing.Point(52, 36);
            this.lblCopiaUsuario.Name = "lblCopiaUsuario";
            this.lblCopiaUsuario.Size = new System.Drawing.Size(240, 22);
            this.lblCopiaUsuario.Text = "";

            // ── pictureBox4 (flecha volver) ──────────────
            this.pictureBox4.Location = new System.Drawing.Point(18, 30);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(28, 28);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);

            // ── pnlContraseña ──────────────────────────
            this.pnlContraseña.BackColor = System.Drawing.Color.FromArgb(28, 28, 45);
            this.pnlContraseña.Controls.Add(this.lblCopiaUsuario);
            this.pnlContraseña.Controls.Add(this.pictureBox4);
            this.pnlContraseña.Controls.Add(this.pnlLineaContraseña);
            this.pnlContraseña.Controls.Add(this.pictureBox3);
            this.pnlContraseña.Controls.Add(this.lblErrorContraseña);
            this.pnlContraseña.Controls.Add(this.lblContraseña);
            this.pnlContraseña.Controls.Add(this.txtContraseña);
            // ✅ ANIMACIÓN: empieza fuera de pantalla a la derecha
            this.pnlContraseña.Location = new System.Drawing.Point(382, 3);
            this.pnlContraseña.Name = "pnlContraseña";
            this.pnlContraseña.Size = new System.Drawing.Size(342, 148);
            this.pnlContraseña.TabIndex = 10;

            // ── pnlLogin ──────────────────────────────
            this.pnlLogin.BackColor = System.Drawing.Color.FromArgb(28, 28, 45);
            this.pnlLogin.Controls.Add(this.pnlContraseña);
            this.pnlLogin.Controls.Add(this.pnlUsuario);
            this.pnlLogin.Controls.Add(this.btnInicioSesion);
            this.pnlLogin.Location = new System.Drawing.Point(27, 180);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(378, 239);
            this.pnlLogin.TabIndex = 7;

            // ── timer1 (animación slide) ─────────────────
            // ✅ Intervalo más rápido para que la animación sea fluida
            this.timer1.Interval = 8;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

            // ── panel1 (lado derecho decorativo) ─────────
            this.panel1.BackColor = System.Drawing.Color.FromArgb(18, 18, 30);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.lblSubtitulo);
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(428, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 561);
            this.panel1.TabIndex = 11;

            // ── pictureBox1 (logo/imagen decorativa) ─────
            this.pictureBox1.Location = new System.Drawing.Point(55, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(396, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabStop = false;

            // ── lblTitulo (en el panel derecho) ──────────
            this.lblTitulo.AutoSize = false;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(30, 144, 255);
            this.lblTitulo.Location = new System.Drawing.Point(20, 60);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(466, 50);
            this.lblTitulo.Text = "El Club";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ── lblSubtitulo ──────────────────────────────
            this.lblSubtitulo.AutoSize = false;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(120, 140, 200);
            this.lblSubtitulo.Location = new System.Drawing.Point(20, 110);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(466, 24);
            this.lblSubtitulo.Text = "Sistema de Gestión de Ventas";
            this.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ── btnMinimizar ──────────────────────────────
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(18, 18, 30);
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 65);
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Text = "—";
            this.btnMinimizar.Location = new System.Drawing.Point(440, 8);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(28, 28);
            this.btnMinimizar.TabIndex = 10;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);

            // ── btnCerrar ──────────────────────────────
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(18, 18, 30);
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(180, 30, 30);
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Text = "✕";
            this.btnCerrar.Location = new System.Drawing.Point(470, 8);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(28, 28);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);

            // ── frmInicioSesion ──────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(18, 18, 30);
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmInicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesión";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmInicioSesion_KeyDown);

            this.pnlUsuario.ResumeLayout(false);
            this.pnlUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlLogin.ResumeLayout(false);
            this.pnlContraseña.ResumeLayout(false);
            this.pnlContraseña.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnInicioSesion;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblErrorUsuario;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnlLineaUsuario;
        private System.Windows.Forms.Panel pnlContraseña;
        private System.Windows.Forms.Panel pnlLineaContraseña;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblErrorContraseña;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Label lblCopiaUsuario;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
    }
}