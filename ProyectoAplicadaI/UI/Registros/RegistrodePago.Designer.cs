namespace ProyectoAplicadaI.UI.Cobro
{
    partial class RegistrodePago
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cobroIdLabel;
            System.Windows.Forms.Label abonoLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label estadodelArticuloLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrodePago));
            this.FiltrocomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CriteriotextBox = new System.Windows.Forms.TextBox();
            this.FechacheckBox = new System.Windows.Forms.CheckBox();
            this.DesdedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.HastadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CobrosdataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GeneralerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.deudatextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cobroIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PagosTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AbonostextBox = new System.Windows.Forms.TextBox();
            this.estadolabel = new System.Windows.Forms.Label();
            this.Buscarcobrobutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Cobrarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            cobroIdLabel = new System.Windows.Forms.Label();
            abonoLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            estadodelArticuloLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CobrosdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobroIdNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // cobroIdLabel
            // 
            cobroIdLabel.AutoSize = true;
            cobroIdLabel.Location = new System.Drawing.Point(5, 18);
            cobroIdLabel.Name = "cobroIdLabel";
            cobroIdLabel.Size = new System.Drawing.Size(21, 13);
            cobroIdLabel.TabIndex = 16;
            cobroIdLabel.Text = "ID:";
            // 
            // abonoLabel
            // 
            abonoLabel.AutoSize = true;
            abonoLabel.Location = new System.Drawing.Point(590, 434);
            abonoLabel.Name = "abonoLabel";
            abonoLabel.Size = new System.Drawing.Size(35, 13);
            abonoLabel.TabIndex = 26;
            abonoLabel.Text = "Pago:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(572, 9);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 22;
            fechaLabel.Text = "Fecha:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(426, 410);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(53, 13);
            label6.TabIndex = 24;
            label6.Text = "Abonado:";
            // 
            // estadodelArticuloLabel
            // 
            estadodelArticuloLabel.AutoSize = true;
            estadodelArticuloLabel.Location = new System.Drawing.Point(574, 33);
            estadodelArticuloLabel.Name = "estadodelArticuloLabel";
            estadodelArticuloLabel.Size = new System.Drawing.Size(95, 13);
            estadodelArticuloLabel.TabIndex = 23;
            estadodelArticuloLabel.Text = "Estadodel Articulo:";
            // 
            // FiltrocomboBox
            // 
            this.FiltrocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltrocomboBox.FormattingEnabled = true;
            this.FiltrocomboBox.Items.AddRange(new object[] {
            "Recibo Id"});
            this.FiltrocomboBox.Location = new System.Drawing.Point(55, 55);
            this.FiltrocomboBox.Name = "FiltrocomboBox";
            this.FiltrocomboBox.Size = new System.Drawing.Size(163, 21);
            this.FiltrocomboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Filtro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Criterio:";
            // 
            // CriteriotextBox
            // 
            this.CriteriotextBox.Location = new System.Drawing.Point(280, 55);
            this.CriteriotextBox.Name = "CriteriotextBox";
            this.CriteriotextBox.Size = new System.Drawing.Size(163, 20);
            this.CriteriotextBox.TabIndex = 3;
            // 
            // FechacheckBox
            // 
            this.FechacheckBox.AutoSize = true;
            this.FechacheckBox.Checked = true;
            this.FechacheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FechacheckBox.Location = new System.Drawing.Point(55, 79);
            this.FechacheckBox.Name = "FechacheckBox";
            this.FechacheckBox.Size = new System.Drawing.Size(56, 17);
            this.FechacheckBox.TabIndex = 4;
            this.FechacheckBox.Text = "Fecha";
            this.FechacheckBox.UseVisualStyleBackColor = true;
            // 
            // DesdedateTimePicker
            // 
            this.DesdedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DesdedateTimePicker.Location = new System.Drawing.Point(55, 97);
            this.DesdedateTimePicker.Name = "DesdedateTimePicker";
            this.DesdedateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.DesdedateTimePicker.TabIndex = 5;
            // 
            // HastadateTimePicker
            // 
            this.HastadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.HastadateTimePicker.Location = new System.Drawing.Point(246, 97);
            this.HastadateTimePicker.Name = "HastadateTimePicker";
            this.HastadateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.HastadateTimePicker.TabIndex = 6;
            // 
            // CobrosdataGridView
            // 
            this.CobrosdataGridView.AllowUserToAddRows = false;
            this.CobrosdataGridView.AllowUserToDeleteRows = false;
            this.CobrosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CobrosdataGridView.Location = new System.Drawing.Point(8, 123);
            this.CobrosdataGridView.Name = "CobrosdataGridView";
            this.CobrosdataGridView.ReadOnly = true;
            this.CobrosdataGridView.Size = new System.Drawing.Size(744, 275);
            this.CobrosdataGridView.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Desde :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Hasta:";
            // 
            // GeneralerrorProvider
            // 
            this.GeneralerrorProvider.ContainerControl = this;
            this.GeneralerrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("GeneralerrorProvider.Icon")));
            // 
            // deudatextBox
            // 
            this.deudatextBox.Location = new System.Drawing.Point(637, 406);
            this.deudatextBox.Name = "deudatextBox";
            this.deudatextBox.ReadOnly = true;
            this.deudatextBox.Size = new System.Drawing.Size(100, 20);
            this.deudatextBox.TabIndex = 12;
            this.deudatextBox.TextChanged += new System.EventHandler(this.DeudatextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(590, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Deuda :";
            // 
            // cobroIdNumericUpDown
            // 
            this.cobroIdNumericUpDown.Location = new System.Drawing.Point(55, 14);
            this.cobroIdNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.cobroIdNumericUpDown.Name = "cobroIdNumericUpDown";
            this.cobroIdNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.cobroIdNumericUpDown.TabIndex = 0;
            // 
            // PagosTextBox
            // 
            this.PagosTextBox.Location = new System.Drawing.Point(637, 431);
            this.PagosTextBox.Name = "PagosTextBox";
            this.PagosTextBox.Size = new System.Drawing.Size(100, 20);
            this.PagosTextBox.TabIndex = 8;
            this.PagosTextBox.TextChanged += new System.EventHandler(this.PagosTextBox_TextChanged);
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(618, 7);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(103, 20);
            this.fechaDateTimePicker.TabIndex = 14;
            // 
            // AbonostextBox
            // 
            this.AbonostextBox.Location = new System.Drawing.Point(487, 406);
            this.AbonostextBox.Name = "AbonostextBox";
            this.AbonostextBox.ReadOnly = true;
            this.AbonostextBox.Size = new System.Drawing.Size(100, 20);
            this.AbonostextBox.TabIndex = 13;
            // 
            // estadolabel
            // 
            this.estadolabel.AutoSize = true;
            this.estadolabel.Location = new System.Drawing.Point(678, 35);
            this.estadolabel.Name = "estadolabel";
            this.estadolabel.Size = new System.Drawing.Size(0, 13);
            this.estadolabel.TabIndex = 15;
            // 
            // Buscarcobrobutton
            // 
            this.Buscarcobrobutton.FlatAppearance.BorderSize = 0;
            this.Buscarcobrobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buscarcobrobutton.Image = global::ProyectoAplicadaI.Properties.Resources.icons8_View_328;
            this.Buscarcobrobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarcobrobutton.Location = new System.Drawing.Point(181, 3);
            this.Buscarcobrobutton.Name = "Buscarcobrobutton";
            this.Buscarcobrobutton.Size = new System.Drawing.Size(75, 42);
            this.Buscarcobrobutton.TabIndex = 1;
            this.Buscarcobrobutton.Text = "Buscar";
            this.Buscarcobrobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarcobrobutton.UseVisualStyleBackColor = true;
            this.Buscarcobrobutton.Click += new System.EventHandler(this.Buscarcobrobutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.FlatAppearance.BorderSize = 0;
            this.Eliminarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eliminarbutton.Image = global::ProyectoAplicadaI.Properties.Resources.icons8_Delete_Document_323;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminarbutton.Location = new System.Drawing.Point(296, 410);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 35);
            this.Eliminarbutton.TabIndex = 11;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Cobrarbutton
            // 
            this.Cobrarbutton.FlatAppearance.BorderSize = 0;
            this.Cobrarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cobrarbutton.Image = global::ProyectoAplicadaI.Properties.Resources.icons8_Cash_in_Hand_32;
            this.Cobrarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cobrarbutton.Location = new System.Drawing.Point(166, 410);
            this.Cobrarbutton.Name = "Cobrarbutton";
            this.Cobrarbutton.Size = new System.Drawing.Size(75, 35);
            this.Cobrarbutton.TabIndex = 9;
            this.Cobrarbutton.Text = "Cobrar";
            this.Cobrarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cobrarbutton.UseVisualStyleBackColor = true;
            this.Cobrarbutton.Click += new System.EventHandler(this.Cobrarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.FlatAppearance.BorderSize = 0;
            this.Nuevobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nuevobutton.Image = global::ProyectoAplicadaI.Properties.Resources.icons8_Broom_323;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevobutton.Location = new System.Drawing.Point(36, 410);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 37);
            this.Nuevobutton.TabIndex = 10;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.FlatAppearance.BorderSize = 0;
            this.Buscarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buscarbutton.Image = global::ProyectoAplicadaI.Properties.Resources.icons8_View_328;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(453, 45);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 41);
            this.Buscarbutton.TabIndex = 7;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // RegistrodePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(759, 457);
            this.Controls.Add(this.estadolabel);
            this.Controls.Add(estadodelArticuloLabel);
            this.Controls.Add(label6);
            this.Controls.Add(this.AbonostextBox);
            this.Controls.Add(this.Buscarcobrobutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(abonoLabel);
            this.Controls.Add(this.PagosTextBox);
            this.Controls.Add(cobroIdLabel);
            this.Controls.Add(this.cobroIdNumericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deudatextBox);
            this.Controls.Add(this.Cobrarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CobrosdataGridView);
            this.Controls.Add(this.HastadateTimePicker);
            this.Controls.Add(this.DesdedateTimePicker);
            this.Controls.Add(this.FechacheckBox);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.CriteriotextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FiltrocomboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrodePago";
            this.Text = "Registro de Pago";
            this.Load += new System.EventHandler(this.CobrosdeEmpeño_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CobrosdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobroIdNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FiltrocomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CriteriotextBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.CheckBox FechacheckBox;
        private System.Windows.Forms.DateTimePicker DesdedateTimePicker;
        private System.Windows.Forms.DateTimePicker HastadateTimePicker;
        private System.Windows.Forms.DataGridView CobrosdataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider GeneralerrorProvider;
        private System.Windows.Forms.Button Cobrarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox deudatextBox;
        private System.Windows.Forms.Button Buscarcobrobutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.TextBox PagosTextBox;
        private System.Windows.Forms.NumericUpDown cobroIdNumericUpDown;
        private System.Windows.Forms.TextBox AbonostextBox;
        private System.Windows.Forms.Label estadolabel;
    }
}