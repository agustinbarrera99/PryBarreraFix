namespace pryFernandezIES
{
    partial class frmBuscarProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarProveedor));

            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnEliminarProveedor = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnModificarProveedor = new System.Windows.Forms.Button();
            this.btnNuevoProveedor = new System.Windows.Forms.Button();
            this.btnMostrarProveedor = new System.Windows.Forms.Button();
            this.treDirectorios = new System.Windows.Forms.TreeView();
            this.pnlCargarProveedor = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtJurisd = new System.Windows.Forms.TextBox();
            this.lblJurisd = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtLiquidador = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblLiquidador = new System.Windows.Forms.Label();
            this.lblEntidad = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtEntidad = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblApertura = new System.Windows.Forms.Label();
            this.txtJuzg = new System.Windows.Forms.TextBox();
            this.txtApertura = new System.Windows.Forms.TextBox();
            this.lblJuzg = new System.Windows.Forms.Label();
            this.lblNumExpediente = new System.Windows.Forms.Label();
            this.txtNumExpediente = new System.Windows.Forms.TextBox();
            this.dgrArchivos = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);

            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlCargarProveedor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrArchivos)).BeginInit();
            this.SuspendLayout();

            // ── COLORES ──────────────────────────────────
            System.Drawing.Color colorFondo = System.Drawing.Color.FromArgb(22, 22, 38);
            System.Drawing.Color colorPanel = System.Drawing.Color.FromArgb(18, 18, 30);
            System.Drawing.Color colorAcento = System.Drawing.Color.FromArgb(30, 144, 255);
            System.Drawing.Color colorTexto = System.Drawing.Color.FromArgb(180, 200, 255);
            System.Drawing.Color colorInput = System.Drawing.Color.FromArgb(28, 28, 45);

            // ── Helper botones del menú lateral ───────────
            System.Action<System.Windows.Forms.Button, string, int> estiloBtn =
                (btn, texto, y) =>
                {
                    btn.BackColor = colorAcento;
                    btn.Cursor = System.Windows.Forms.Cursors.Hand;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(0, 110, 220);
                    btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
                    btn.ForeColor = System.Drawing.Color.White;
                    btn.Location = new System.Drawing.Point(20, y);
                    btn.Size = new System.Drawing.Size(200, 36);
                    btn.Text = texto;
                    btn.UseVisualStyleBackColor = false;
                };

            // ── treDirectorios ────────────────────────────
            this.treDirectorios.BackColor = colorInput;
            this.treDirectorios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treDirectorios.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.treDirectorios.ForeColor = colorTexto;
            this.treDirectorios.Location = new System.Drawing.Point(8, 8);
            this.treDirectorios.Name = "treDirectorios";
            this.treDirectorios.Size = new System.Drawing.Size(230, 270);
            this.treDirectorios.TabIndex = 0;

            // ── Botones panel izquierdo ───────────────────
            estiloBtn(this.btnMostrarProveedor, "▸  Mostrar", 290);
            estiloBtn(this.btnNuevoProveedor, "▸  Nuevo", 334);
            estiloBtn(this.btnModificarProveedor, "▸  Modificar", 378);
            estiloBtn(this.btnEliminarProveedor, "▸  Eliminar", 422);
            estiloBtn(this.btnLimpiar, "▸  Limpiar", 466);

            this.btnMostrarProveedor.TabIndex = 1;
            this.btnNuevoProveedor.TabIndex = 2;
            this.btnModificarProveedor.TabIndex = 3;
            this.btnEliminarProveedor.TabIndex = 4;
            this.btnLimpiar.TabIndex = 14;

            // Los que solo se muestran después de cargar
            this.btnNuevoProveedor.Visible = false;
            this.btnModificarProveedor.Visible = false;
            this.btnEliminarProveedor.Visible = false;
            this.btnLimpiar.Visible = false;

            this.btnMostrarProveedor.Click += new System.EventHandler(this.btnMostrarProveedor_Click);
            this.btnNuevoProveedor.Click += new System.EventHandler(this.btnNuevoProveedor_Click);
            this.btnModificarProveedor.Click += new System.EventHandler(this.btnModificarProveedor_Click);
            this.btnEliminarProveedor.Click += new System.EventHandler(this.btnEliminarProveedor_Click);
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            // ── Panel izquierdo del SplitContainer ────────
            this.splitContainer1.Panel1.BackColor = colorPanel;
            this.splitContainer1.Panel1.Controls.Add(this.btnEliminarProveedor);
            this.splitContainer1.Panel1.Controls.Add(this.btnLimpiar);
            this.splitContainer1.Panel1.Controls.Add(this.btnModificarProveedor);
            this.splitContainer1.Panel1.Controls.Add(this.btnNuevoProveedor);
            this.splitContainer1.Panel1.Controls.Add(this.btnMostrarProveedor);
            this.splitContainer1.Panel1.Controls.Add(this.treDirectorios);

            // ── dgrArchivos ───────────────────────────────
            this.dgrArchivos.BackgroundColor = colorFondo;
            this.dgrArchivos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgrArchivos.ColumnHeadersDefaultCellStyle.BackColor = colorPanel;
            this.dgrArchivos.ColumnHeadersDefaultCellStyle.ForeColor = colorAcento;
            this.dgrArchivos.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgrArchivos.ColumnHeadersDefaultCellStyle.SelectionBackColor = colorPanel;
            this.dgrArchivos.DefaultCellStyle.BackColor = colorInput;
            this.dgrArchivos.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(200, 210, 240);
            this.dgrArchivos.DefaultCellStyle.SelectionBackColor = colorAcento;
            this.dgrArchivos.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgrArchivos.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgrArchivos.EnableHeadersVisualStyles = false;
            this.dgrArchivos.GridColor = System.Drawing.Color.FromArgb(40, 40, 65);
            this.dgrArchivos.RowHeadersVisible = false;
            this.dgrArchivos.RowTemplate.Height = 24;
            this.dgrArchivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrArchivos.Location = new System.Drawing.Point(6, 4);
            this.dgrArchivos.Name = "dgrArchivos";
            this.dgrArchivos.ReadOnly = true;
            this.dgrArchivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrArchivos.Size = new System.Drawing.Size(488, 278);
            this.dgrArchivos.TabIndex = 1;
            this.dgrArchivos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrArchivos_CellContentClick);

            // ── Helper labels del formulario ──────────────
            System.Action<System.Windows.Forms.Label, string, int, int> estiloLabel =
                (lbl, txt, x, y) =>
                {
                    lbl.AutoSize = true;
                    lbl.Font = new System.Drawing.Font("Segoe UI", 8.5F);
                    lbl.ForeColor = colorTexto;
                    lbl.Location = new System.Drawing.Point(x, y);
                    lbl.Text = txt;
                };

            estiloLabel(this.lblNumero, "N°", 10, 16);
            estiloLabel(this.lblEntidad, "Entidad", 10, 46);
            estiloLabel(this.lblApertura, "Apertura", 10, 76);
            estiloLabel(this.lblNumExpediente, "N° Expediente", 10, 106);
            estiloLabel(this.lblJuzg, "Juzgado", 10, 136);
            estiloLabel(this.lblJurisd, "Jurisdicción", 10, 166);
            estiloLabel(this.lblDireccion, "Dirección", 10, 196);
            estiloLabel(this.lblLiquidador, "Liquidador Responsable", 10, 226);

            // ── Helper textboxes del formulario ───────────
            System.Action<System.Windows.Forms.TextBox, int> estiloTxt =
                (txt, y) =>
                {
                    txt.BackColor = colorInput;
                    txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    txt.Font = new System.Drawing.Font("Segoe UI", 9F);
                    txt.ForeColor = System.Drawing.Color.White;
                    txt.Location = new System.Drawing.Point(190, y);
                    txt.Size = new System.Drawing.Size(180, 22);
                };

            estiloTxt(this.txtNumero, 12);
            estiloTxt(this.txtEntidad, 42);
            estiloTxt(this.txtApertura, 72);
            estiloTxt(this.txtNumExpediente, 102);
            estiloTxt(this.txtJuzg, 132);
            estiloTxt(this.txtJurisd, 162);
            estiloTxt(this.txtDireccion, 192);
            estiloTxt(this.txtLiquidador, 222);

            this.txtNumero.TabIndex = 1;
            this.txtEntidad.TabIndex = 3;
            this.txtApertura.TabIndex = 5;
            this.txtNumExpediente.TabIndex = 7;
            this.txtJuzg.TabIndex = 9;
            this.txtJurisd.TabIndex = 15;
            this.txtDireccion.TabIndex = 11;
            this.txtLiquidador.TabIndex = 13;

            this.txtNumero.Name = "txtNumero";
            this.txtEntidad.Name = "txtEntidad";
            this.txtApertura.Name = "txtApertura";
            this.txtNumExpediente.Name = "txtNumExpediente";
            this.txtJuzg.Name = "txtJuzg";
            this.txtJurisd.Name = "txtJurisd";
            this.txtDireccion.Name = "txtDireccion";
            this.txtLiquidador.Name = "txtLiquidador";

            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            this.txtEntidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEntidad_KeyPress);
            this.txtApertura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApertura_KeyPress);
            this.txtNumExpediente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumExpediente_KeyPress);
            this.txtJuzg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJuzg_KeyPress);
            this.txtJurisd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJurisd_KeyPress);
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            this.txtLiquidador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLiquidador_KeyPress);

            // ── groupBox1 ─────────────────────────────────
            this.groupBox1.BackColor = colorFondo;
            this.groupBox1.ForeColor = colorTexto;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Controls.Add(this.txtJurisd);
            this.groupBox1.Controls.Add(this.lblJurisd);
            this.groupBox1.Controls.Add(this.lblNumero);
            this.groupBox1.Controls.Add(this.txtLiquidador);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.lblLiquidador);
            this.groupBox1.Controls.Add(this.lblEntidad);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.txtEntidad);
            this.groupBox1.Controls.Add(this.lblDireccion);
            this.groupBox1.Controls.Add(this.lblApertura);
            this.groupBox1.Controls.Add(this.txtJuzg);
            this.groupBox1.Controls.Add(this.txtApertura);
            this.groupBox1.Controls.Add(this.lblJuzg);
            this.groupBox1.Controls.Add(this.lblNumExpediente);
            this.groupBox1.Controls.Add(this.txtNumExpediente);
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 258);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Proveedor";

            // ── pnlCargarProveedor ─────────────────────────
            this.pnlCargarProveedor.BackColor = colorFondo;
            this.pnlCargarProveedor.Controls.Add(this.groupBox1);
            this.pnlCargarProveedor.Location = new System.Drawing.Point(4, 288);
            this.pnlCargarProveedor.Name = "pnlCargarProveedor";
            this.pnlCargarProveedor.Size = new System.Drawing.Size(492, 278);
            this.pnlCargarProveedor.TabIndex = 2;
            this.pnlCargarProveedor.Visible = false;

            // ── Panel derecho del SplitContainer ──────────
            this.splitContainer1.Panel2.BackColor = colorFondo;
            this.splitContainer1.Panel2.Controls.Add(this.pnlCargarProveedor);
            this.splitContainer1.Panel2.Controls.Add(this.dgrArchivos);

            // ── splitContainer1 ───────────────────────────
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(752, 565);
            this.splitContainer1.SplitterDistance = 248;
            this.splitContainer1.TabIndex = 0;

            // ── imageList1 ────────────────────────────────
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "archivo.png");
            this.imageList1.Images.SetKeyName(1, "carpeta.png");
            this.imageList1.Images.SetKeyName(2, "carpeta-removebg-preview.png");
            this.imageList1.Images.SetKeyName(3, "archivo-removebg-preview.png");

            // ── frmBuscarProveedor ─────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = colorFondo;
            this.ClientSize = new System.Drawing.Size(752, 565);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmBuscarProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Proveedor";
            this.Load += new System.EventHandler(this.frmBuscarProveedor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBuscarProveedor_KeyDown);

            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlCargarProveedor.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrArchivos)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treDirectorios;
        private System.Windows.Forms.Button btnMostrarProveedor;
        private System.Windows.Forms.DataGridView dgrArchivos;
        private System.Windows.Forms.Button btnNuevoProveedor;
        private System.Windows.Forms.Panel pnlCargarProveedor;
        private System.Windows.Forms.TextBox txtNumExpediente;
        private System.Windows.Forms.Label lblNumExpediente;
        private System.Windows.Forms.TextBox txtApertura;
        private System.Windows.Forms.Label lblApertura;
        private System.Windows.Forms.TextBox txtEntidad;
        private System.Windows.Forms.Label lblEntidad;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtJuzg;
        private System.Windows.Forms.Label lblJuzg;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtLiquidador;
        private System.Windows.Forms.Label lblLiquidador;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtJurisd;
        private System.Windows.Forms.Label lblJurisd;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnEliminarProveedor;
        private System.Windows.Forms.Button btnModificarProveedor;
    }
}