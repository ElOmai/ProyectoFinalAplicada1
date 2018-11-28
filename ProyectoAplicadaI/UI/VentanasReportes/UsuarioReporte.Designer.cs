namespace ProyectoAplicadaI.UI.VentanasReportes
{
    partial class UsuarioReporte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioReporte));
            this.UsuarioViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // UsuarioViewer
            // 
            this.UsuarioViewer.ActiveViewIndex = -1;
            this.UsuarioViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsuarioViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.UsuarioViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsuarioViewer.Location = new System.Drawing.Point(0, 0);
            this.UsuarioViewer.Name = "UsuarioViewer";
            this.UsuarioViewer.Size = new System.Drawing.Size(800, 450);
            this.UsuarioViewer.TabIndex = 0;
            this.UsuarioViewer.Load += new System.EventHandler(this.UsuarioViewer_Load);
            // 
            // UsuarioReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UsuarioViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UsuarioReporte";
            this.Text = "Reporte de Usuarios";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer UsuarioViewer;
    }
}