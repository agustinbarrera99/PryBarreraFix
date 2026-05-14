namespace pryFernandezIES
{
    partial class frmClientes
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
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblEstadoConexion = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnLocura = new System.Windows.Forms.Button();
            this.btnActividad = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblBuscarHint = new System.Windows.Forms.Label();
            this.pnlBarra = new System.Windows.Forms.Panel();

            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();

            // ── lblTitulo ────────────────────────────────
            this.lblTitulo.AutoSize = false;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.None;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(30, 144, 255);
            this.lblTitulo.Location = new System.Drawing.Point(12, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(300, 32);
            this.lblTitulo.Text = "Gestión de Clientes";

            // ── pnlBarra (línea separadora) ───────────────
            this.pnlBarra.BackColor = System.Drawing.Color.FromArgb(30, 144, 255);
            this.pnlBarra.Location = new System.Drawing.Point(12, 50);
            this.pnlBarra.Name = "pnlBarra";
            this.pnlBarra.Size = new System.Drawing.Size(728, 2);

            // ── dgvCliente ────────────────────────────────
            this.dgvCliente.BackgroundColor = System.Drawing.Color.FromArgb(22, 22, 38);
            this.dgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCliente.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(18, 18, 30);
            this.dgvCliente.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(30, 144, 255);
            this.dgvCliente.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvCliente.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(18, 18, 30);
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(28, 28, 45);
            this.dgvCliente.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(200, 210, 240);
            this.dgvCliente.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(30, 144, 255);
            this.dgvCliente.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCliente.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvCliente.EnableHeadersVisualStyles = false;
            this.dgvCliente.GridColor = System.Drawing.Color.FromArgb(40, 40, 65);
            this.dgvCliente.Location = new System.Drawing.Point(12, 62);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.RowHeadersVisible = false;
            this.dgvCliente.RowTemplate.Height = 24;
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(728, 370);
            this.dgvCliente.TabIndex = 0;
            this.dgvCliente.ReadOnly = true;

            // ── lblBuscarHint ─────────────────────────────
            this.lblBuscarHint.AutoSize = true;
            this.lblBuscarHint.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblBuscarHint.ForeColor = System.Drawing.Color.FromArgb(120, 140, 200);
            this.lblBuscarHint.Location = new System.Drawing.Point(12, 448);
            this.lblBuscarHint.Name = "lblBuscarHint";
            this.lblBuscarHint.Text = "Buscar por Código:";

            // ── txtBuscar ─────────────────────────────────
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(28, 28, 45);
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBuscar.ForeColor = System.Drawing.Color.White;
            this.txtBuscar.Location = new System.Drawing.Point(135, 444);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(140, 26);
            this.txtBuscar.TabIndex = 2;

            // ── btnLocura (Buscar) ────────────────────────
            this.btnLocura.BackColor = System.Drawing.Color.FromArgb(30, 144, 255);
            this.btnLocura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLocura.FlatAppearance.BorderSize = 0;
            this.btnLocura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(0, 110, 220);
            this.btnLocura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocura.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLocura.ForeColor = System.Drawing.Color.White;
            this.btnLocura.Location = new System.Drawing.Point(282, 443);
            this.btnLocura.Name = "btnLocura";
            this.btnLocura.Size = new System.Drawing.Size(100, 28);
            this.btnLocura.TabIndex = 3;
            this.btnLocura.Text = "Buscar";
            this.btnLocura.UseVisualStyleBackColor = false;
            this.btnLocura.Click += new System.EventHandler(this.btnLocura_Click);

            // ── btnActividad ──────────────────────────────
            this.btnActividad.BackColor = System.Drawing.Color.FromArgb(22, 22, 38);
            this.btnActividad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActividad.FlatAppearance.BorderSize = 1;
            this.btnActividad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(30, 144, 255);
            this.btnActividad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(30, 144, 255);
            this.btnActividad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActividad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnActividad.ForeColor = System.Drawing.Color.FromArgb(30, 144, 255);
            this.btnActividad.Location = new System.Drawing.Point(560, 443);
            this.btnActividad.Name = "btnActividad";
            this.btnActividad.Size = new System.Drawing.Size(180, 28);
            this.btnActividad.TabIndex = 4;
            this.btnActividad.Text = "✦  Modificar Actividad";
            this.btnActividad.UseVisualStyleBackColor = false;
            this.btnActividad.Click += new System.EventHandler(this.btnActividad_Click);

            // ── statusStrip1 ──────────────────────────────
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(14, 14, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.lblEstadoConexion });
            this.statusStrip1.Location = new System.Drawing.Point(0, 543);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(752, 22);
            this.statusStrip1.TabIndex = 1;

            this.lblEstadoConexion.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblEstadoConexion.ForeColor = System.Drawing.Color.FromArgb(180, 200, 255);
            this.lblEstadoConexion.Name = "lblEstadoConexion";
            this.lblEstadoConexion.Text = "Conectando...";

            // ── frmClientes ───────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(22, 22, 38);
            this.ClientSize = new System.Drawing.Size(752, 565);
            this.Controls.Add(this.btnActividad);
            this.Controls.Add(this.btnLocura);
            this.Controls.Add(this.lblBuscarHint);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.pnlBarra);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmClientes_KeyDown);

            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblEstadoConexion;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnLocura;
        private System.Windows.Forms.Button btnActividad;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblBuscarHint;
        private System.Windows.Forms.Panel pnlBarra;
    }
}