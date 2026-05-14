namespace pryFernandezIES
{
    partial class frmUsuarios
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblEstadoConexion = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.dgvLogs = new System.Windows.Forms.DataGridView();
            this.grbRegistro = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lstCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTituloUsuarios = new System.Windows.Forms.Label();
            this.lblTituloLogs = new System.Windows.Forms.Label();
            this.pnlBarra = new System.Windows.Forms.Panel();

            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).BeginInit();
            this.grbRegistro.SuspendLayout();
            this.SuspendLayout();

            // ── Helper estilos DataGridView ────────────────
            System.Action<System.Windows.Forms.DataGridView> estiloGrid = (dgv) =>
            {
                dgv.BackgroundColor = System.Drawing.Color.FromArgb(22, 22, 38);
                dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
                dgv.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(18, 18, 30);
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(30, 144, 255);
                dgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
                dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(18, 18, 30);
                dgv.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(28, 28, 45);
                dgv.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(200, 210, 240);
                dgv.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(30, 144, 255);
                dgv.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
                dgv.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
                dgv.EnableHeadersVisualStyles = false;
                dgv.GridColor = System.Drawing.Color.FromArgb(40, 40, 65);
                dgv.RowHeadersVisible = false;
                dgv.RowTemplate.Height = 24;
                dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
                dgv.ReadOnly = true;
            };

            // ── lblTituloUsuarios ─────────────────────────
            this.lblTituloUsuarios.AutoSize = true;
            this.lblTituloUsuarios.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTituloUsuarios.ForeColor = System.Drawing.Color.FromArgb(30, 144, 255);
            this.lblTituloUsuarios.Location = new System.Drawing.Point(12, 14);
            this.lblTituloUsuarios.Name = "lblTituloUsuarios";
            this.lblTituloUsuarios.Text = "Usuarios registrados";

            // ── lblTituloLogs ─────────────────────────────
            this.lblTituloLogs.AutoSize = true;
            this.lblTituloLogs.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTituloLogs.ForeColor = System.Drawing.Color.FromArgb(30, 144, 255);
            this.lblTituloLogs.Location = new System.Drawing.Point(374, 14);
            this.lblTituloLogs.Name = "lblTituloLogs";
            this.lblTituloLogs.Text = "Historial de actividad (Logs)";

            // ── pnlBarra ──────────────────────────────────
            this.pnlBarra.BackColor = System.Drawing.Color.FromArgb(30, 144, 255);
            this.pnlBarra.Location = new System.Drawing.Point(12, 38);
            this.pnlBarra.Name = "pnlBarra";
            this.pnlBarra.Size = new System.Drawing.Size(728, 2);

            // ── dgvUsuarios ───────────────────────────────
            estiloGrid(this.dgvUsuarios);
            this.dgvUsuarios.Location = new System.Drawing.Point(12, 46);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(348, 248);
            this.dgvUsuarios.TabIndex = 1;

            // ── dgvLogs ───────────────────────────────────
            estiloGrid(this.dgvLogs);
            this.dgvLogs.Location = new System.Drawing.Point(374, 46);
            this.dgvLogs.Name = "dgvLogs";
            this.dgvLogs.Size = new System.Drawing.Size(366, 460);
            this.dgvLogs.TabIndex = 2;

            // ── grbRegistro ───────────────────────────────
            this.grbRegistro.BackColor = System.Drawing.Color.FromArgb(22, 22, 38);
            this.grbRegistro.ForeColor = System.Drawing.Color.FromArgb(180, 200, 255);
            this.grbRegistro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grbRegistro.Controls.Add(this.button1);
            this.grbRegistro.Controls.Add(this.lstCategoria);
            this.grbRegistro.Controls.Add(this.lblCategoria);
            this.grbRegistro.Controls.Add(this.txtContraseña);
            this.grbRegistro.Controls.Add(this.txtNombre);
            this.grbRegistro.Controls.Add(this.lblContraseña);
            this.grbRegistro.Controls.Add(this.lblNombre);
            this.grbRegistro.Location = new System.Drawing.Point(12, 310);
            this.grbRegistro.Name = "grbRegistro";
            this.grbRegistro.Size = new System.Drawing.Size(348, 196);
            this.grbRegistro.TabIndex = 3;
            this.grbRegistro.TabStop = false;
            this.grbRegistro.Text = "Nuevo Usuario";

            // ── Labels del formulario de registro ─────────
            System.Action<System.Windows.Forms.Label, string, int> estiloLbl = (lbl, txt, y) =>
            {
                lbl.AutoSize = true;
                lbl.Font = new System.Drawing.Font("Segoe UI", 9F);
                lbl.ForeColor = System.Drawing.Color.FromArgb(180, 200, 255);
                lbl.Location = new System.Drawing.Point(20, y);
                lbl.Text = txt;
            };
            estiloLbl(this.lblNombre, "Nombre", 36);
            estiloLbl(this.lblContraseña, "Contraseña", 70);
            estiloLbl(this.lblCategoria, "Categoría", 104);

            // ── TextBoxes del formulario ───────────────────
            System.Action<System.Windows.Forms.TextBox, int> estiloTxt = (txt, y) =>
            {
                txt.BackColor = System.Drawing.Color.FromArgb(28, 28, 45);
                txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                txt.Font = new System.Drawing.Font("Segoe UI", 9.5F);
                txt.ForeColor = System.Drawing.Color.White;
                txt.Location = new System.Drawing.Point(110, y);
                txt.Size = new System.Drawing.Size(210, 24);
            };
            estiloTxt(this.txtNombre, 32);
            estiloTxt(this.txtContraseña, 66);
            this.txtNombre.Name = "txtNombre";
            this.txtContraseña.Name = "txtContraseña";
            this.txtNombre.TabIndex = 2;
            this.txtContraseña.TabIndex = 3;

            // ── lstCategoria ──────────────────────────────
            this.lstCategoria.BackColor = System.Drawing.Color.FromArgb(28, 28, 45);
            this.lstCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lstCategoria.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lstCategoria.ForeColor = System.Drawing.Color.White;
            this.lstCategoria.FormattingEnabled = true;
            this.lstCategoria.Items.AddRange(new object[] { "Admin", "User" });
            this.lstCategoria.Location = new System.Drawing.Point(110, 100);
            this.lstCategoria.Name = "lstCategoria";
            this.lstCategoria.Size = new System.Drawing.Size(210, 24);
            this.lstCategoria.TabIndex = 5;

            // ── button1 (Registrar) ───────────────────────
            this.button1.BackColor = System.Drawing.Color.FromArgb(30, 144, 255);
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(0, 110, 220);
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(110, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Registrar Usuario";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);

            // ── statusStrip1 ──────────────────────────────
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(14, 14, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.lblEstadoConexion });
            this.statusStrip1.Location = new System.Drawing.Point(0, 543);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(752, 22);
            this.statusStrip1.TabIndex = 0;

            this.lblEstadoConexion.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblEstadoConexion.ForeColor = System.Drawing.Color.FromArgb(180, 200, 255);
            this.lblEstadoConexion.Name = "lblEstadoConexion";
            this.lblEstadoConexion.Text = "Conectando...";

            // ── frmUsuarios ───────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(22, 22, 38);
            this.ClientSize = new System.Drawing.Size(752, 565);
            this.Controls.Add(this.grbRegistro);
            this.Controls.Add(this.dgvLogs);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.pnlBarra);
            this.Controls.Add(this.lblTituloLogs);
            this.Controls.Add(this.lblTituloUsuarios);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmUsuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmUsuarios_KeyDown);

            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).EndInit();
            this.grbRegistro.ResumeLayout(false);
            this.grbRegistro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblEstadoConexion;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridView dgvLogs;
        private System.Windows.Forms.GroupBox grbRegistro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox lstCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTituloUsuarios;
        private System.Windows.Forms.Label lblTituloLogs;
        private System.Windows.Forms.Panel pnlBarra;
    }
}