namespace ProyectoAplicadaI.UI.Registros
{
    partial class RegistrodeEmpeño
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
            System.Windows.Forms.Label reciboIdLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label fechaVencimientoLabel;
            System.Windows.Forms.Label clienteIdLabel;
            System.Windows.Forms.Label articuloIdLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label montoLabel;
            System.Windows.Forms.Label montoTotalLabel;
            System.Windows.Forms.Label estadodelArticuloLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrodeEmpeño));
            this.reciboIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.fechadeEmpeñoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaActualDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.clienteIdComboBox = new System.Windows.Forms.ComboBox();
            this.articuloIdComboBox = new System.Windows.Forms.ComboBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.cantidadNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.montoTextBox = new System.Windows.Forms.TextBox();
            this.DetalledataGridView = new System.Windows.Forms.DataGridView();
            this.montoTotalTextBox = new System.Windows.Forms.TextBox();
            this.estadolabel = new System.Windows.Forms.Label();
            this.HayErrores = new System.Windows.Forms.ErrorProvider(this.components);
            this.nombrelabel = new System.Windows.Forms.Label();
            this.Removerbutton = new System.Windows.Forms.Button();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            reciboIdLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            fechaVencimientoLabel = new System.Windows.Forms.Label();
            clienteIdLabel = new System.Windows.Forms.Label();
            articuloIdLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            cantidadLabel = new System.Windows.Forms.Label();
            montoLabel = new System.Windows.Forms.Label();
            montoTotalLabel = new System.Windows.Forms.Label();
            estadodelArticuloLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reciboIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HayErrores)).BeginInit();
            this.SuspendLayout();
            // 
            // reciboIdLabel
            // 
            reciboIdLabel.AutoSize = true;
            reciboIdLabel.Location = new System.Drawing.Point(12, 19);
            reciboIdLabel.Name = "reciboIdLabel";
            reciboIdLabel.Size = new System.Drawing.Size(21, 13);
            reciboIdLabel.TabIndex = 1;
            reciboIdLabel.Text = "ID:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(291, 63);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(100, 13);
            fechaLabel.TabIndex = 3;
            fechaLabel.Text = "Fecha de Empeño :";
            // 
            // fechaVencimientoLabel
            // 
            fechaVencimientoLabel.AutoSize = true;
            fechaVencimientoLabel.Location = new System.Drawing.Point(291, 37);
            fechaVencimientoLabel.Name = "fechaVencimientoLabel";
            fechaVencimientoLabel.Size = new System.Drawing.Size(73, 13);
            fechaVencimientoLabel.TabIndex = 5;
            fechaVencimientoLabel.Text = "Fecha Actual:";
            // 
            // clienteIdLabel
            // 
            clienteIdLabel.AutoSize = true;
            clienteIdLabel.Location = new System.Drawing.Point(12, 66);
            clienteIdLabel.Name = "clienteIdLabel";
            clienteIdLabel.Size = new System.Drawing.Size(42, 13);
            clienteIdLabel.TabIndex = 7;
            clienteIdLabel.Text = "Cliente:";
            // 
            // articuloIdLabel
            // 
            articuloIdLabel.AutoSize = true;
            articuloIdLabel.Location = new System.Drawing.Point(12, 125);
            articuloIdLabel.Name = "articuloIdLabel";
            articuloIdLabel.Size = new System.Drawing.Size(45, 13);
            articuloIdLabel.TabIndex = 9;
            articuloIdLabel.Text = "Articulo:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(206, 125);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 11;
            descripcionLabel.Text = "Descripcion:";
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Location = new System.Drawing.Point(12, 179);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(52, 13);
            cantidadLabel.TabIndex = 13;
            cantidadLabel.Text = "Cantidad:";
            // 
            // montoLabel
            // 
            montoLabel.AutoSize = true;
            montoLabel.Location = new System.Drawing.Point(206, 179);
            montoLabel.Name = "montoLabel";
            montoLabel.Size = new System.Drawing.Size(40, 13);
            montoLabel.TabIndex = 15;
            montoLabel.Text = "Monto:";
            // 
            // montoTotalLabel
            // 
            montoTotalLabel.AutoSize = true;
            montoTotalLabel.Location = new System.Drawing.Point(375, 456);
            montoTotalLabel.Name = "montoTotalLabel";
            montoTotalLabel.Size = new System.Drawing.Size(64, 13);
            montoTotalLabel.TabIndex = 20;
            montoTotalLabel.Text = "Monto Total";
            // 
            // estadodelArticuloLabel
            // 
            estadodelArticuloLabel.AutoSize = true;
            estadodelArticuloLabel.Location = new System.Drawing.Point(291, 91);
            estadodelArticuloLabel.Name = "estadodelArticuloLabel";
            estadodelArticuloLabel.Size = new System.Drawing.Size(95, 13);
            estadodelArticuloLabel.TabIndex = 27;
            estadodelArticuloLabel.Text = "Estadodel Articulo:";
            // 
            // reciboIdNumericUpDown
            // 
            this.reciboIdNumericUpDown.Location = new System.Drawing.Point(78, 15);
            this.reciboIdNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.reciboIdNumericUpDown.Name = "reciboIdNumericUpDown";
            this.reciboIdNumericUpDown.Size = new System.Drawing.Size(122, 20);
            this.reciboIdNumericUpDown.TabIndex = 0;
            // 
            // fechadeEmpeñoDateTimePicker
            // 
            this.fechadeEmpeñoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechadeEmpeñoDateTimePicker.Location = new System.Drawing.Point(393, 59);
            this.fechadeEmpeñoDateTimePicker.Name = "fechadeEmpeñoDateTimePicker";
            this.fechadeEmpeñoDateTimePicker.Size = new System.Drawing.Size(97, 20);
            this.fechadeEmpeñoDateTimePicker.TabIndex = 14;
            this.fechadeEmpeñoDateTimePicker.ValueChanged += new System.EventHandler(this.FechadeEmpeñoDateTimePicker_ValueChanged);
            // 
            // fechaActualDateTimePicker
            // 
            this.fechaActualDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaActualDateTimePicker.Location = new System.Drawing.Point(393, 33);
            this.fechaActualDateTimePicker.Name = "fechaActualDateTimePicker";
            this.fechaActualDateTimePicker.Size = new System.Drawing.Size(97, 20);
            this.fechaActualDateTimePicker.TabIndex = 13;
            this.fechaActualDateTimePicker.ValueChanged += new System.EventHandler(this.FechaActualDateTimePicker_ValueChanged);
            // 
            // clienteIdComboBox
            // 
            this.clienteIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clienteIdComboBox.FormattingEnabled = true;
            this.clienteIdComboBox.Location = new System.Drawing.Point(78, 63);
            this.clienteIdComboBox.Name = "clienteIdComboBox";
            this.clienteIdComboBox.Size = new System.Drawing.Size(122, 21);
            this.clienteIdComboBox.TabIndex = 2;
            // 
            // articuloIdComboBox
            // 
            this.articuloIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.articuloIdComboBox.FormattingEnabled = true;
            this.articuloIdComboBox.Location = new System.Drawing.Point(78, 121);
            this.articuloIdComboBox.Name = "articuloIdComboBox";
            this.articuloIdComboBox.Size = new System.Drawing.Size(122, 21);
            this.articuloIdComboBox.TabIndex = 3;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.Location = new System.Drawing.Point(278, 109);
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(120, 50);
            this.descripcionTextBox.TabIndex = 4;
            // 
            // cantidadNumericUpDown
            // 
            this.cantidadNumericUpDown.Location = new System.Drawing.Point(76, 175);
            this.cantidadNumericUpDown.Name = "cantidadNumericUpDown";
            this.cantidadNumericUpDown.Size = new System.Drawing.Size(122, 20);
            this.cantidadNumericUpDown.TabIndex = 5;
            // 
            // montoTextBox
            // 
            this.montoTextBox.Location = new System.Drawing.Point(278, 175);
            this.montoTextBox.Name = "montoTextBox";
            this.montoTextBox.Size = new System.Drawing.Size(120, 20);
            this.montoTextBox.TabIndex = 6;
            // 
            // DetalledataGridView
            // 
            this.DetalledataGridView.AllowUserToAddRows = false;
            this.DetalledataGridView.AllowUserToDeleteRows = false;
            this.DetalledataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalledataGridView.Location = new System.Drawing.Point(12, 202);
            this.DetalledataGridView.Name = "DetalledataGridView";
            this.DetalledataGridView.ReadOnly = true;
            this.DetalledataGridView.Size = new System.Drawing.Size(445, 235);
            this.DetalledataGridView.TabIndex = 17;
            // 
            // montoTotalTextBox
            // 
            this.montoTotalTextBox.Location = new System.Drawing.Point(361, 472);
            this.montoTotalTextBox.Name = "montoTotalTextBox";
            this.montoTotalTextBox.ReadOnly = true;
            this.montoTotalTextBox.Size = new System.Drawing.Size(93, 20);
            this.montoTotalTextBox.TabIndex = 12;
            // 
            // estadolabel
            // 
            this.estadolabel.AutoSize = true;
            this.estadolabel.Location = new System.Drawing.Point(384, 93);
            this.estadolabel.Name = "estadolabel";
            this.estadolabel.Size = new System.Drawing.Size(0, 13);
            this.estadolabel.TabIndex = 31;
            // 
            // HayErrores
            // 
            this.HayErrores.ContainerControl = this;
            this.HayErrores.Icon = ((System.Drawing.Icon)(resources.GetObject("HayErrores.Icon")));
            // 
            // nombrelabel
            // 
            this.nombrelabel.AutoSize = true;
            this.nombrelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrelabel.Location = new System.Drawing.Point(291, 11);
            this.nombrelabel.Name = "nombrelabel";
            this.nombrelabel.Size = new System.Drawing.Size(50, 13);
            this.nombrelabel.TabIndex = 32;
            this.nombrelabel.Text = "Nombre";
            // 
            // Removerbutton
            // 
            this.Removerbutton.FlatAppearance.BorderSize = 0;
            this.Removerbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Removerbutton.Image = global::ProyectoAplicadaI.Properties.Resources.icons8_Cancel_32;
            this.Removerbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Removerbutton.Location = new System.Drawing.Point(415, 163);
            this.Removerbutton.Name = "Removerbutton";
            this.Removerbutton.Size = new System.Drawing.Size(89, 37);
            this.Removerbutton.TabIndex = 8;
            this.Removerbutton.Text = "Remover";
            this.Removerbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Removerbutton.UseVisualStyleBackColor = true;
            this.Removerbutton.Click += new System.EventHandler(this.Removerbutton_Click);
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.FlatAppearance.BorderSize = 0;
            this.Agregarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Agregarbutton.Image = global::ProyectoAplicadaI.Properties.Resources.icons8_Plus_32;
            this.Agregarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Agregarbutton.Location = new System.Drawing.Point(415, 112);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(89, 38);
            this.Agregarbutton.TabIndex = 7;
            this.Agregarbutton.Text = "Agregar";
            this.Agregarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.FlatAppearance.BorderSize = 0;
            this.Eliminarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eliminarbutton.Image = global::ProyectoAplicadaI.Properties.Resources.icons8_Delete_Document_321;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminarbutton.Location = new System.Drawing.Point(237, 456);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(80, 36);
            this.Eliminarbutton.TabIndex = 11;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.FlatAppearance.BorderSize = 0;
            this.Guardarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Guardarbutton.Image = global::ProyectoAplicadaI.Properties.Resources.icons8_Save_321;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardarbutton.Location = new System.Drawing.Point(131, 456);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(80, 36);
            this.Guardarbutton.TabIndex = 9;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.FlatAppearance.BorderSize = 0;
            this.Nuevobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nuevobutton.Image = global::ProyectoAplicadaI.Properties.Resources.icons8_Broom_321;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevobutton.Location = new System.Drawing.Point(25, 456);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(80, 36);
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
            this.Buscarbutton.Image = global::ProyectoAplicadaI.Properties.Resources.icons8_View_32;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(204, 5);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 40);
            this.Buscarbutton.TabIndex = 1;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // RegistrodeRecibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(508, 504);
            this.Controls.Add(this.nombrelabel);
            this.Controls.Add(this.estadolabel);
            this.Controls.Add(this.Removerbutton);
            this.Controls.Add(this.Agregarbutton);
            this.Controls.Add(estadodelArticuloLabel);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(montoTotalLabel);
            this.Controls.Add(this.montoTotalTextBox);
            this.Controls.Add(this.DetalledataGridView);
            this.Controls.Add(montoLabel);
            this.Controls.Add(this.montoTextBox);
            this.Controls.Add(cantidadLabel);
            this.Controls.Add(this.cantidadNumericUpDown);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(articuloIdLabel);
            this.Controls.Add(this.articuloIdComboBox);
            this.Controls.Add(clienteIdLabel);
            this.Controls.Add(this.clienteIdComboBox);
            this.Controls.Add(fechaVencimientoLabel);
            this.Controls.Add(this.fechaActualDateTimePicker);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechadeEmpeñoDateTimePicker);
            this.Controls.Add(reciboIdLabel);
            this.Controls.Add(this.reciboIdNumericUpDown);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrodeRecibo";
            this.Text = "Registro de Recibo ";
            this.Load += new System.EventHandler(this.RegistrodeRecibo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reciboIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HayErrores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown reciboIdNumericUpDown;
        private System.Windows.Forms.DateTimePicker fechadeEmpeñoDateTimePicker;
        private System.Windows.Forms.DateTimePicker fechaActualDateTimePicker;
        private System.Windows.Forms.ComboBox clienteIdComboBox;
        private System.Windows.Forms.ComboBox articuloIdComboBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.NumericUpDown cantidadNumericUpDown;
        private System.Windows.Forms.TextBox montoTextBox;
        private System.Windows.Forms.DataGridView DetalledataGridView;
        private System.Windows.Forms.TextBox montoTotalTextBox;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Removerbutton;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.Label estadolabel;
        private System.Windows.Forms.ErrorProvider HayErrores;
        private System.Windows.Forms.Label nombrelabel;
    }
}