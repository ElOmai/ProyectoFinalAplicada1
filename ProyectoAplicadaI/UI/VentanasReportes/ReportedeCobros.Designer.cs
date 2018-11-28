namespace ProyectoAplicadaI.UI.VentanasReportes
{
    partial class ReportedeCobros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportedeCobros));
            this.CobrosViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CobrosViewer
            // 
            this.CobrosViewer.ActiveViewIndex = -1;
            this.CobrosViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CobrosViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.CobrosViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CobrosViewer.Location = new System.Drawing.Point(0, 0);
            this.CobrosViewer.Name = "CobrosViewer";
            this.CobrosViewer.Size = new System.Drawing.Size(800, 450);
            this.CobrosViewer.TabIndex = 0;
            this.CobrosViewer.Load += new System.EventHandler(this.CobrosViewer_Load);
            // 
            // ReportedeCobros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CobrosViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportedeCobros";
            this.Text = "Reporte de Pagos";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CobrosViewer;
    }
}