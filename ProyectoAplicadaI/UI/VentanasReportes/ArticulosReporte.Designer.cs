namespace ProyectoAplicadaI.UI.VentanasReportes
{
    partial class ArticulosReporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArticulosReporte));
            this.ArticulosViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ArticulosViewer
            // 
            this.ArticulosViewer.ActiveViewIndex = -1;
            this.ArticulosViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ArticulosViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.ArticulosViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ArticulosViewer.Location = new System.Drawing.Point(0, 0);
            this.ArticulosViewer.Name = "ArticulosViewer";
            this.ArticulosViewer.Size = new System.Drawing.Size(800, 450);
            this.ArticulosViewer.TabIndex = 0;
            this.ArticulosViewer.Load += new System.EventHandler(this.ArticulosViewer_Load);
            // 
            // ArticulosReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ArticulosViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ArticulosReporte";
            this.Text = "Reporte de Articulos";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ArticulosViewer;
    }
}