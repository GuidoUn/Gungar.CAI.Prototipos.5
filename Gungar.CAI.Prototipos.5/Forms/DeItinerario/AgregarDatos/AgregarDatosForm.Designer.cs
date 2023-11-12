namespace Gungar.CAI.Prototipos._5
{
    partial class AgregarDatosForm
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
            datosPasajerosGroupBox = new GroupBox();
            DNITextBox = new TextBox();
            agregarPasajeroBtn = new Button();
            apellidoLabel = new Label();
            fechaNacDatePicker = new DateTimePicker();
            nombreTextBox = new TextBox();
            DNILabel = new Label();
            label1 = new Label();
            nombreLabel = new Label();
            apellidoTextBox = new TextBox();
            button2 = new Button();
            groupBox2 = new GroupBox();
            pasajerosItinerarioListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            itinerarioLabel = new Label();
            titleLabel = new Label();
            quitarAsignacionBtn = new Button();
            confirmarBtn = new Button();
            productosAgregadosListView = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            asignarBtn = new Button();
            pasajerosProductoListView = new ListView();
            codigoHeader = new ColumnHeader();
            dniHeader = new ColumnHeader();
            nombreHeader2 = new ColumnHeader();
            apellidoHeader2 = new ColumnHeader();
            fechaNacHeader2 = new ColumnHeader();
            groupBox1 = new GroupBox();
            editarPasajeroBtn = new Button();
            label2 = new Label();
            productoLabel = new Label();
            pasajeroLabel = new Label();
            label4 = new Label();
            eliminarPasajeroBtn = new Button();
            datosPasajerosGroupBox.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // datosPasajerosGroupBox
            // 
            datosPasajerosGroupBox.Controls.Add(DNITextBox);
            datosPasajerosGroupBox.Controls.Add(agregarPasajeroBtn);
            datosPasajerosGroupBox.Controls.Add(apellidoLabel);
            datosPasajerosGroupBox.Controls.Add(fechaNacDatePicker);
            datosPasajerosGroupBox.Controls.Add(nombreTextBox);
            datosPasajerosGroupBox.Controls.Add(DNILabel);
            datosPasajerosGroupBox.Controls.Add(label1);
            datosPasajerosGroupBox.Controls.Add(nombreLabel);
            datosPasajerosGroupBox.Controls.Add(apellidoTextBox);
            datosPasajerosGroupBox.Location = new Point(60, 73);
            datosPasajerosGroupBox.Margin = new Padding(3, 2, 3, 2);
            datosPasajerosGroupBox.Name = "datosPasajerosGroupBox";
            datosPasajerosGroupBox.Padding = new Padding(3, 2, 3, 2);
            datosPasajerosGroupBox.Size = new Size(426, 221);
            datosPasajerosGroupBox.TabIndex = 0;
            datosPasajerosGroupBox.TabStop = false;
            datosPasajerosGroupBox.Text = "Crear nuevo pasajero";
            // 
            // DNITextBox
            // 
            DNITextBox.Location = new Point(15, 114);
            DNITextBox.Margin = new Padding(3, 2, 3, 2);
            DNITextBox.Name = "DNITextBox";
            DNITextBox.Size = new Size(132, 23);
            DNITextBox.TabIndex = 5;
            DNITextBox.KeyPress += documentoTextBox_KeyPress;
            // 
            // agregarPasajeroBtn
            // 
            agregarPasajeroBtn.Location = new Point(289, 177);
            agregarPasajeroBtn.Margin = new Padding(3, 2, 3, 2);
            agregarPasajeroBtn.Name = "agregarPasajeroBtn";
            agregarPasajeroBtn.Size = new Size(113, 31);
            agregarPasajeroBtn.TabIndex = 11;
            agregarPasajeroBtn.Text = "Guardar pasajero";
            agregarPasajeroBtn.UseVisualStyleBackColor = true;
            agregarPasajeroBtn.Click += agregarPasajeroBtn_Click;
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Location = new Point(187, 28);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new Size(51, 15);
            apellidoLabel.TabIndex = 3;
            apellidoLabel.Text = "Apellido";
            // 
            // fechaNacDatePicker
            // 
            fechaNacDatePicker.Location = new Point(187, 114);
            fechaNacDatePicker.Name = "fechaNacDatePicker";
            fechaNacDatePicker.Size = new Size(215, 23);
            fechaNacDatePicker.TabIndex = 14;
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(15, 52);
            nombreTextBox.Margin = new Padding(3, 2, 3, 2);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(132, 23);
            nombreTextBox.TabIndex = 0;
            nombreTextBox.KeyPress += nombreTextBox_KeyPress;
            // 
            // DNILabel
            // 
            DNILabel.Location = new Point(15, 93);
            DNILabel.Name = "DNILabel";
            DNILabel.Size = new Size(152, 30);
            DNILabel.TabIndex = 6;
            DNILabel.Text = "Documento / Pasaporte";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(187, 93);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 13;
            label1.Text = "Fecha de nacimiento";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new Point(15, 28);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(51, 15);
            nombreLabel.TabIndex = 1;
            nombreLabel.Text = "Nombre";
            // 
            // apellidoTextBox
            // 
            apellidoTextBox.Location = new Point(187, 52);
            apellidoTextBox.Margin = new Padding(3, 2, 3, 2);
            apellidoTextBox.Name = "apellidoTextBox";
            apellidoTextBox.Size = new Size(132, 23);
            apellidoTextBox.TabIndex = 2;
            apellidoTextBox.KeyPress += apellidoTextBox_KeyPress;
            // 
            // button2
            // 
            button2.Location = new Point(885, 685);
            button2.Name = "button2";
            button2.Size = new Size(114, 39);
            button2.TabIndex = 22;
            button2.Text = "Volver al Menu";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(eliminarPasajeroBtn);
            groupBox2.Controls.Add(pasajerosItinerarioListView);
            groupBox2.Controls.Add(editarPasajeroBtn);
            groupBox2.Location = new Point(569, 73);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(579, 221);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pasajeros del itinerario";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // pasajerosItinerarioListView
            // 
            pasajerosItinerarioListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader6 });
            pasajerosItinerarioListView.FullRowSelect = true;
            pasajerosItinerarioListView.Location = new Point(6, 28);
            pasajerosItinerarioListView.Margin = new Padding(3, 2, 3, 2);
            pasajerosItinerarioListView.Name = "pasajerosItinerarioListView";
            pasajerosItinerarioListView.Size = new Size(562, 109);
            pasajerosItinerarioListView.TabIndex = 24;
            pasajerosItinerarioListView.UseCompatibleStateImageBehavior = false;
            pasajerosItinerarioListView.View = View.Details;
            pasajerosItinerarioListView.SelectedIndexChanged += pasajerosItinerarioListView_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nombre";
            columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Apellido";
            columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Documento/Pasaporte";
            columnHeader3.Width = 165;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Fecha de nacimiento";
            columnHeader6.Width = 150;
            // 
            // itinerarioLabel
            // 
            itinerarioLabel.AutoSize = true;
            itinerarioLabel.Location = new Point(243, 19);
            itinerarioLabel.Name = "itinerarioLabel";
            itinerarioLabel.Size = new Size(82, 15);
            itinerarioLabel.TabIndex = 26;
            itinerarioLabel.Text = "itinerarioLabel";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(54, 19);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(183, 15);
            titleLabel.TabIndex = 25;
            titleLabel.Text = "Agregando Pasajeros al Itinerario:";
            // 
            // quitarAsignacionBtn
            // 
            quitarAsignacionBtn.Enabled = false;
            quitarAsignacionBtn.Location = new Point(369, 479);
            quitarAsignacionBtn.Margin = new Padding(3, 2, 3, 2);
            quitarAsignacionBtn.Name = "quitarAsignacionBtn";
            quitarAsignacionBtn.Size = new Size(208, 31);
            quitarAsignacionBtn.TabIndex = 15;
            quitarAsignacionBtn.Text = "Quitar pasajero del producto ^ ^ ^";
            quitarAsignacionBtn.UseVisualStyleBackColor = true;
            quitarAsignacionBtn.Click += quitarAsignacionBtn_Click;
            // 
            // confirmarBtn
            // 
            confirmarBtn.Location = new Point(1021, 685);
            confirmarBtn.Name = "confirmarBtn";
            confirmarBtn.Size = new Size(116, 39);
            confirmarBtn.TabIndex = 27;
            confirmarBtn.Text = "Confirmar";
            confirmarBtn.UseVisualStyleBackColor = true;
            confirmarBtn.Click += confirmarBtn_Click;
            // 
            // productosAgregadosListView
            // 
            productosAgregadosListView.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader12, columnHeader5, columnHeader13, columnHeader14 });
            productosAgregadosListView.FullRowSelect = true;
            productosAgregadosListView.Location = new Point(66, 338);
            productosAgregadosListView.MultiSelect = false;
            productosAgregadosListView.Name = "productosAgregadosListView";
            productosAgregadosListView.Size = new Size(1071, 119);
            productosAgregadosListView.TabIndex = 28;
            productosAgregadosListView.UseCompatibleStateImageBehavior = false;
            productosAgregadosListView.View = View.Details;
            productosAgregadosListView.SelectedIndexChanged += productosAgregadosListView_SelectedIndexChanged;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Codigo";
            columnHeader4.Width = 80;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Producto";
            columnHeader8.Width = 130;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Origen/Destino";
            columnHeader9.Width = 115;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Desde";
            columnHeader10.Width = 137;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Hasta";
            columnHeader11.Width = 137;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Precio Total";
            columnHeader12.Width = 95;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Cant. Pasajeros";
            columnHeader5.Width = 110;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Prestador";
            columnHeader13.Width = 130;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Categoria";
            columnHeader14.Width = 80;
            // 
            // asignarBtn
            // 
            asignarBtn.Enabled = false;
            asignarBtn.Location = new Point(609, 479);
            asignarBtn.Margin = new Padding(3, 2, 3, 2);
            asignarBtn.Name = "asignarBtn";
            asignarBtn.Size = new Size(216, 31);
            asignarBtn.TabIndex = 29;
            asignarBtn.Text = "Asignar pasasjero al producto v v v";
            asignarBtn.UseVisualStyleBackColor = true;
            asignarBtn.Click += asignarBtn_Click;
            // 
            // pasajerosProductoListView
            // 
            pasajerosProductoListView.Columns.AddRange(new ColumnHeader[] { codigoHeader, dniHeader, nombreHeader2, apellidoHeader2, fechaNacHeader2 });
            pasajerosProductoListView.FullRowSelect = true;
            pasajerosProductoListView.Location = new Point(6, 20);
            pasajerosProductoListView.Margin = new Padding(3, 2, 3, 2);
            pasajerosProductoListView.Name = "pasajerosProductoListView";
            pasajerosProductoListView.Size = new Size(1071, 107);
            pasajerosProductoListView.TabIndex = 24;
            pasajerosProductoListView.UseCompatibleStateImageBehavior = false;
            pasajerosProductoListView.View = View.Details;
            pasajerosProductoListView.SelectedIndexChanged += pasajerosProductoListView_SelectedIndexChanged;
            // 
            // codigoHeader
            // 
            codigoHeader.Text = "Código";
            codigoHeader.Width = 100;
            // 
            // dniHeader
            // 
            dniHeader.Text = "Documento/Pasaporte";
            dniHeader.Width = 165;
            // 
            // nombreHeader2
            // 
            nombreHeader2.Text = "Nombre";
            nombreHeader2.Width = 110;
            // 
            // apellidoHeader2
            // 
            apellidoHeader2.Text = "Apellido";
            apellidoHeader2.Width = 110;
            // 
            // fechaNacHeader2
            // 
            fechaNacHeader2.Text = "Fecha de nacimiento";
            fechaNacHeader2.Width = 200;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pasajerosProductoListView);
            groupBox1.Location = new Point(60, 534);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(1088, 131);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pasajeros del producto";
            // 
            // editarPasajeroBtn
            // 
            editarPasajeroBtn.Enabled = false;
            editarPasajeroBtn.Location = new Point(452, 177);
            editarPasajeroBtn.Margin = new Padding(3, 2, 3, 2);
            editarPasajeroBtn.Name = "editarPasajeroBtn";
            editarPasajeroBtn.Size = new Size(116, 31);
            editarPasajeroBtn.TabIndex = 30;
            editarPasajeroBtn.Text = "Editar pasajero";
            editarPasajeroBtn.UseVisualStyleBackColor = true;
            editarPasajeroBtn.Click += editarPasajeroBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 316);
            label2.Name = "label2";
            label2.Size = new Size(131, 15);
            label2.TabIndex = 31;
            label2.Text = "Producto seleccionado:";
            // 
            // productoLabel
            // 
            productoLabel.AutoSize = true;
            productoLabel.Location = new Point(203, 316);
            productoLabel.Name = "productoLabel";
            productoLabel.Size = new Size(84, 15);
            productoLabel.TabIndex = 32;
            productoLabel.Text = "productoLabel";
            // 
            // pasajeroLabel
            // 
            pasajeroLabel.AutoSize = true;
            pasajeroLabel.Location = new Point(701, 38);
            pasajeroLabel.Name = "pasajeroLabel";
            pasajeroLabel.Size = new Size(79, 15);
            pasajeroLabel.TabIndex = 34;
            pasajeroLabel.Text = "pasajeroLabel";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(569, 38);
            label4.Name = "label4";
            label4.Size = new Size(126, 15);
            label4.TabIndex = 33;
            label4.Text = "Pasajero seleccionado:";
            // 
            // eliminarPasajeroBtn
            // 
            eliminarPasajeroBtn.Enabled = false;
            eliminarPasajeroBtn.Location = new Point(326, 177);
            eliminarPasajeroBtn.Margin = new Padding(3, 2, 3, 2);
            eliminarPasajeroBtn.Name = "eliminarPasajeroBtn";
            eliminarPasajeroBtn.Size = new Size(120, 31);
            eliminarPasajeroBtn.TabIndex = 35;
            eliminarPasajeroBtn.Text = "Eliminar pasajero";
            eliminarPasajeroBtn.UseVisualStyleBackColor = true;
            eliminarPasajeroBtn.Click += eliminarPasajeroBtn_Click;
            // 
            // AgregarDatosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1167, 750);
            Controls.Add(pasajeroLabel);
            Controls.Add(label4);
            Controls.Add(productoLabel);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(asignarBtn);
            Controls.Add(productosAgregadosListView);
            Controls.Add(confirmarBtn);
            Controls.Add(quitarAsignacionBtn);
            Controls.Add(itinerarioLabel);
            Controls.Add(titleLabel);
            Controls.Add(groupBox2);
            Controls.Add(button2);
            Controls.Add(datosPasajerosGroupBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AgregarDatosForm";
            Text = "  ";
            Load += AgregarDatosForm_Load;
            datosPasajerosGroupBox.ResumeLayout(false);
            datosPasajerosGroupBox.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox datosPasajerosGroupBox;
        private TextBox nombreTextBox;
        private Label apellidoLabel;
        private TextBox apellidoTextBox;
        private Label nombreLabel;
        private Label DNILabel;
        private TextBox DNITextBox;
        private Button agregarPasajeroBtn;
        private Label label1;
        private DateTimePicker fechaNacDatePicker;
        private Button button2;
        private ListView pasajerosListView;
        private GroupBox groupBox2;
        private ColumnHeader nombreHeader;
        private ColumnHeader apellidoHeader;
        private ColumnHeader DNIHeader;
        private ColumnHeader emailHeader;
        private ColumnHeader telefonoHeader;
        private ColumnHeader fechaNacHeader;
        private Label itinerarioLabel;
        private Label titleLabel;
        private Button quitarAsignacionBtn;
        private Button confirmarBtn;
        private ListView productosAgregadosListView;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private Button asignarBtn;
        private ListView pasajerosProductoListView;
        private ColumnHeader dniHeader;
        private ListView listView3;
        private ColumnHeader columnHeader20;
        private ColumnHeader columnHeader21;
        private ColumnHeader columnHeader22;
        private ColumnHeader columnHeader23;
        private ColumnHeader columnHeader24;
        private ColumnHeader columnHeader25;
        private ListView pasajerosItinerarioListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader6;
        private GroupBox groupBox1;
        private Button editarPasajeroBtn;
        private Label label2;
        private Label productoLabel;
        private Label pasajeroLabel;
        private Label label4;
        private Button eliminarPasajeroBtn;
        private ColumnHeader nombreHeader2;
        private ColumnHeader apellidoHeader2;
        private ColumnHeader fechaNacHeader2;
        private ColumnHeader columnHeader4;
        private ColumnHeader codigoHeader;
        private ColumnHeader columnHeader5;
    }
}