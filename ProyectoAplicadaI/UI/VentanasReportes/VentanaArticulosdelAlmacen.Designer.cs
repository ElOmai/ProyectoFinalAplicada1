namespace ProyectoAplicadaI.UI.VentanasReportes
{
    partial class VentanaArticulosdelAlmacen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaArticulosdelAlmacen));
            this.AlmacenViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // AlmacenViewer
            // 
            this.AlmacenViewer.ActiveViewIndex = -1;
            this.AlmacenViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AlmacenViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.AlmacenViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AlmacenViewer.Location = new System.Drawing.Point(0, 0);
            this.AlmacenViewer.Name = "AlmacenViewer";
            this.AlmacenViewer.Size = new System.Drawing.Size(800, 450);
            this.AlmacenViewer.TabIndex = 0;
            this.AlmacenViewer.Load += new System.EventHandler(this.AlmacenViewer_Load);
            // 
            // VentanaArticulosdelAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AlmacenViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaArticulosdelAlmacen";
            this.Text = "Reporte de Articulos de en Almacen";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer AlmacenViewer;
    }
}