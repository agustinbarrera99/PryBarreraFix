// ═══════════════════════════════════════════════════════════
// frmCargarProveedor.Designer.cs  — tema oscuro unificado
// ═══════════════════════════════════════════════════════════
namespace pryFernandezIES
{
    partial class frmCargarProveedor
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
            this.fbdSeleccionCarpeta = new System.Windows.Forms.FolderBrowserDialog();
            this.txtNombreArchivo = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSeleccionCarpeta = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlBarra = new System.Windows.Forms.Panel();

            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();

            // ── COLORES ──────────────────────────────────
            System.Drawing.Color colorFondo = System.Drawing.Color.FromArgb(22, 22, 38);
            System.Drawing.Color colorPanel = System.Drawing.Color.FromArgb(18, 18, 30);
            System.Drawing.Color colorAcento = System.Drawing.Color.FromArgb(30, 144, 255);
            System.Drawing.Color colorTexto = System.Drawing.Color.FromArgb(180, 200, 255);
            System.Drawing.Color colorInput = System.Drawing.Color.FromArgb(28, 28, 45);

            // ── lblTitulo ─────────────────────────────────
            this.lblTitulo.AutoSize = false;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = colorAcento;
            this.lblTitulo.Location = new System.Drawing.Point(340, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(380, 36);
            this.lblTitulo.Text = "Crear Archivo de Proveedor";

            // ── pnlBarra ──────────────────────────────────
            this.pnlBarra.BackColor = colorAcento;
            this.pnlBarra.Location = new System.Drawing.Point(340, 58);
            this.pnlBarra.Name = "pnlBarra";
            this.pnlBarra.Size = new System.Drawing.Size(400, 2);

            // ── Panel izquierdo (selección de carpeta) ────
            // label1
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = colorTexto;
            this.label1.Location = new System.Drawing.Point(20, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 52);
            this.label1.Text = "Seleccioná la carpeta donde se guardará el archivo del proveedor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // pictureBox1 (ícono carpeta)
            this.pictureBox1.Location = new System.Drawing.Point(125, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabStop = false;

            // btnSeleccionCarpeta
            this.btnSeleccionCarpeta.BackColor = colorAcento;
            this.btnSeleccionCarpeta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionCarpeta.FlatAppearance.BorderSize = 0;
            this.btnSeleccionCarpeta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(0, 110, 220);
            this.btnSeleccionCarpeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionCarpeta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSeleccionCarpeta.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionCarpeta.Location = new System.Drawing.Point(60, 230);
            this.btnSeleccionCarpeta.Name = "btnSeleccionCarpeta";
            this.btnSeleccionCarpeta.Size = new System.Drawing.Size(200, 52);
            this.btnSeleccionCarpeta.TabIndex = 0;
            this.btnSeleccionCarpeta.Text = "📁  Seleccionar Carpeta";
            this.btnSeleccionCarpeta.UseVisualStyleBackColor = false;
            this.btnSeleccionCarpeta.Click += new System.EventHandler(this.btnSeleccionCarpeta_Click);

            // lblDireccion (ruta seleccionada)
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblDireccion.ForeColor = System.Drawing.Color.FromArgb(120, 140, 200);
            this.lblDireccion.Location = new System.Drawing.Point(10, 295);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(298, 80);
            this.lblDireccion.TextAlign = System.Drawing.ContentAlignment.TopCenter;

            // panel1
            this.panel1.BackColor = colorPanel;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSeleccionCarpeta);
            this.panel1.Controls.Add(this.lblDireccion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 565);
            this.panel1.TabIndex = 7;

            // ── Panel derecho (nombre + guardar) ──────────
            // label3
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.ForeColor = colorTexto;
            this.label3.Location = new System.Drawing.Point(340, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(390, 52);
            this.label3.Text = "Escribí el nombre del archivo donde se guardará el proveedor";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // pictureBox2 (ícono archivo)
            this.pictureBox2.Location = new System.Drawing.Point(496, 56);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabStop = false;

            // label2 ("Nombre del archivo")
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = colorTexto;
            this.label2.Location = new System.Drawing.Point(340, 200);
            this.label2.Name = "label2";
            this.label2.Text = "Nombre del archivo (.csv)";

            // txtNombreArchivo
            this.txtNombreArchivo.BackColor = colorInput;
            this.txtNombreArchivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreArchivo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNombreArchivo.ForeColor = System.Drawing.Color.White;
            this.txtNombreArchivo.Location = new System.Drawing.Point(340, 222);
            this.txtNombreArchivo.Name = "txtNombreArchivo";
            this.txtNombreArchivo.Size = new System.Drawing.Size(380, 28);
            this.txtNombreArchivo.TabIndex = 3;

            // btnGuardar
            this.btnGuardar.BackColor = colorAcento;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(0, 110, 220);
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(430, 275);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(200, 52);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "💾  Guardar Archivo";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            // ── frmCargarProveedor ─────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = colorFondo;
            this.ClientSize = new System.Drawing.Size(752, 565);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlBarra);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreArchivo);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmCargarProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargar Proveedor";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCargarProveedor_KeyDown);

            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnSeleccionCarpeta;
        private System.Windows.Forms.FolderBrowserDialog fbdSeleccionCarpeta;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNombreArchivo;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlBarra;
    }
}