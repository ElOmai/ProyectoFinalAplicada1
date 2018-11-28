namespace ProyectoAplicadaI.UI.VentanasReportes
{
    partial class VentanadeListadeEmpeños
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanadeListadeEmpeños));
            this.ReciboViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ReciboViewer
            // 
            this.ReciboViewer.ActiveViewIndex = -1;
            this.ReciboViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReciboViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.ReciboViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReciboViewer.Location = new System.Drawing.Point(0, 0);
            this.ReciboViewer.Name = "ReciboViewer";
            this.ReciboViewer.Size = new System.Drawing.Size(800, 450);
            this.ReciboViewer.TabIndex = 0;
            this.ReciboViewer.Load += new System.EventHandler(this.CrystalReportViewer1_Load);
            // 
            // VentanadeListadeRecibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReciboViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanadeListadeRecibo";
            this.Text = "Reporte  de Recibos";
            this.Load += new System.EventHandler(this.VentanadeLista_de_Recibo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ReciboViewer;
    }
}