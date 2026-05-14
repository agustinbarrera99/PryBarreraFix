// ═══════════════════════════════════════════════════════════
// frmCargaPrograma.Designer.cs  — tema oscuro unificado
// ═══════════════════════════════════════════════════════════
namespace pryFernandezIES
{
    partial class frmCargaPrograma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargaPrograma));

            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tiempoCarga = new System.Windows.Forms.Timer(this.components);
            this.pbrCarga = new System.Windows.Forms.ProgressBar();
            this.lblCarga = new System.Windows.Forms.Label();
            this.lblTexto = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();

            // ── btnCerrar ──────────────────────────────
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(0, 22, 53);
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(180, 30, 30);
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Text = "✕";
            this.btnCerrar.Location = new System.Drawing.Point(905, 8);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(24, 24);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.UseVisualStyleBackColor = false;

            // ── btnMinimizar ───────────────────────────
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(0, 22, 53);
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 65);
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Text = "—";
            this.btnMinimizar.Location = new System.Drawing.Point(875, 8);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(24, 24);
            this.btnMinimizar.TabIndex = 6;
            this.btnMinimizar.UseVisualStyleBackColor = false;

            // ── pictureBox1 (logo/splash) ──────────────
            this.pictureBox1.Location = new System.Drawing.Point(-32, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1000, 380);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabStop = false;

            // ── lblTexto ("Cargando sistema...") ───────
            this.lblTexto.AutoSize = false;
            this.lblTexto.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblTexto.ForeColor = System.Drawing.Color.FromArgb(180, 200, 255);
            this.lblTexto.Location = new System.Drawing.Point(0, 420);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(934, 24);
            this.lblTexto.Text = "Cargando sistema...";
            this.lblTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ── pbrCarga ───────────────────────────────
            this.pbrCarga.Location = new System.Drawing.Point(217, 452);
            this.pbrCarga.Name = "pbrCarga";
            this.pbrCarga.Size = new System.Drawing.Size(500, 16);
            this.pbrCarga.Step = 20;
            this.pbrCarga.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbrCarga.TabIndex = 8;
            this.pbrCarga.Visible = true;
            // ✅ Color de la barra (requiere owner draw o SetState via SendMessage en el .cs)

            // ── lblCarga (porcentaje) ──────────────────
            this.lblCarga.AutoSize = false;
            this.lblCarga.BackColor = System.Drawing.Color.Transparent;
            this.lblCarga.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCarga.ForeColor = System.Drawing.Color.FromArgb(30, 144, 255);
            this.lblCarga.Location = new System.Drawing.Point(0, 475);
            this.lblCarga.Name = "lblCarga";
            this.lblCarga.Size = new System.Drawing.Size(934, 22);
            this.lblCarga.TabIndex = 9;
            this.lblCarga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ── tiempoCarga ────────────────────────────
            this.tiempoCarga.Enabled = true;
            this.tiempoCarga.Interval = 60;
            this.tiempoCarga.Tick += new System.EventHandler(this.tiempoCarga_Tick);

            // ── frmCargaPrograma ────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(0, 22, 53);
            this.ClientSize = new System.Drawing.Size(934, 510);
            this.Controls.Add(this.lblCarga);
            this.Controls.Add(this.pbrCarga);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmCargaPrograma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargando...";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCargaPrograma_KeyDown);

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar pbrCarga;
        private System.Windows.Forms.Timer tiempoCarga;
        private System.Windows.Forms.Label lblCarga;
        private System.Windows.Forms.Label lblTexto;
    }
}