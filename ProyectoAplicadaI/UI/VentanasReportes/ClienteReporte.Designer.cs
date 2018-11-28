namespace ProyectoAplicadaI.UI.VentanasReportes
{
    partial class ClienteReporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteReporte));
            this.ClienteViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ClienteViewer
            // 
            this.ClienteViewer.ActiveViewIndex = -1;
            this.ClienteViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClienteViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.ClienteViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClienteViewer.Location = new System.Drawing.Point(0, 0);
            this.ClienteViewer.Name = "ClienteViewer";
            this.ClienteViewer.Size = new System.Drawing.Size(800, 450);
            this.ClienteViewer.TabIndex = 0;
            this.ClienteViewer.Load += new System.EventHandler(this.ClienteViewer_Load);
            // 
            // ClienteReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClienteViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClienteReporte";
            this.Text = "Reporte de Cliente";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ClienteViewer;
    }
}