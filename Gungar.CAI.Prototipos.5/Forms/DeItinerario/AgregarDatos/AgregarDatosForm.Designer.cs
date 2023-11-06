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
            datosPasajerosGroupBox.Location = new Point(62, 503);
            datosPasajerosGroupBox.Name = "datosPasajerosGroupBox";
            datosPasajerosGroupBox.Size = new Size(502, 304);
            datosPasajerosGroupBox.TabIndex = 0;
            datosPasajerosGroupBox.TabStop = false;
            datosPasajerosGroupBox.Text = "Nuevo pasajero";
            // 
            // DNITextBox
            // 
            DNITextBox.Location = new Point(46, 175);
            DNITextBox.Name = "DNITextBox";
            DNITextBox.Size = new Size(150, 27);
            DNITextBox.TabIndex = 5;
            // 
            // agregarPasajeroBtn
            // 
            agregarPasajeroBtn.Location = new Point(326, 235);
            agregarPasajeroBtn.Name = "agregarPasajeroBtn";
            agregarPasajeroBtn.Size = new Size(161, 41);
            agregarPasajeroBtn.TabIndex = 11;
            agregarPasajeroBtn.Text = "Aceptar";
            agregarPasajeroBtn.UseVisualStyleBackColor = true;
            agregarPasajeroBtn.Click += agregarPasajeroBtn_Click;
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Location = new Point(241, 45);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new Size(66, 20);
            apellidoLabel.TabIndex = 3;
            apellidoLabel.Text = "Apellido";
            // 
            // fechaNacDatePicker
            // 
            fechaNacDatePicker.Location = new Point(241, 175);
            fechaNacDatePicker.Margin = new Padding(3, 4, 3, 4);
            fechaNacDatePicker.Name = "fechaNacDatePicker";
            fechaNacDatePicker.Size = new Size(245, 27);
            fechaNacDatePicker.TabIndex = 14;
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(46, 77);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(150, 27);
            nombreTextBox.TabIndex = 0;
            nombreTextBox.KeyPress += nombreTextBox_KeyPress;
            // 
            // DNILabel
            // 
            DNILabel.AutoSize = true;
            DNILabel.Location = new Point(46, 147);
            DNILabel.Name = "DNILabel";
            DNILabel.Size = new Size(35, 20);
            DNILabel.TabIndex = 6;
            DNILabel.Text = "DNI";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(241, 147);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 13;
            label1.Text = "Fecha de nacimiento";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new Point(46, 45);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(64, 20);
            nombreLabel.TabIndex = 1;
            nombreLabel.Text = "Nombre";
            // 
            // apellidoTextBox
            // 
            apellidoTextBox.Location = new Point(241, 77);
            apellidoTextBox.Name = "apellidoTextBox";
            apellidoTextBox.Size = new Size(150, 27);
            apellidoTextBox.TabIndex = 2;
            apellidoTextBox.KeyPress += apellidoTextBox_KeyPress;
            // 
            // button2
            // 
            button2.Location = new Point(1206, 16);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(142, 69);
            button2.TabIndex = 22;
            button2.Text = "Volver al Menu";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pasajerosItinerarioListView);
            groupBox2.Location = new Point(62, 131);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(502, 285);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pasajeros del itinerario";
            // 
            // pasajerosItinerarioListView
            // 
            pasajerosItinerarioListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader6 });
            pasajerosItinerarioListView.FullRowSelect = true;
            pasajerosItinerarioListView.Location = new Point(7, 37);
            pasajerosItinerarioListView.Name = "pasajerosItinerarioListView";
            pasajerosItinerarioListView.Size = new Size(479, 239);
            pasajerosItinerarioListView.TabIndex = 24;
            pasajerosItinerarioListView.UseCompatibleStateImageBehavior = false;
            pasajerosItinerarioListView.View = View.Details;
            pasajerosItinerarioListView.SelectedIndexChanged += pasajerosItinerarioListView_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nombre";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Apellido";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "DNI";
            columnHeader3.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Fecha de nacimiento";
            columnHeader6.Width = 150;
            // 
            // itinerarioLabel
            // 
            itinerarioLabel.AutoSize = true;
            itinerarioLabel.Location = new Point(278, 25);
            itinerarioLabel.Name = "itinerarioLabel";
            itinerarioLabel.Size = new Size(105, 20);
            itinerarioLabel.TabIndex = 26;
            itinerarioLabel.Text = "itinerarioLabel";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(62, 25);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(232, 20);
            titleLabel.TabIndex = 25;
            titleLabel.Text = "Agregando Pasajeros al Itinerario:";
            // 
            // quitarAsignacionBtn
            // 
            quitarAsignacionBtn.Enabled = false;
            quitarAsignacionBtn.Location = new Point(602, 832);
            quitarAsignacionBtn.Name = "quitarAsignacionBtn";
            quitarAsignacionBtn.Size = new Size(197, 41);
            quitarAsignacionBtn.TabIndex = 15;
            quitarAsignacionBtn.Text = "Quitar asignación ^ ^ ^";
            quitarAsignacionBtn.UseVisualStyleBackColor = true;
            quitarAsignacionBtn.Click += quitarAsignacionBtn_Click;
            // 
            // confirmarBtn
            // 
            confirmarBtn.Location = new Point(1187, 945);
            confirmarBtn.Margin = new Padding(3, 4, 3, 4);
            confirmarBtn.Name = "confirmarBtn";
            confirmarBtn.Size = new Size(160, 88);
            confirmarBtn.TabIndex = 27;
            confirmarBtn.Text = "Confirmar";
            confirmarBtn.UseVisualStyleBackColor = true;
            confirmarBtn.Click += confirmarBtn_Click;
            // 
            // productosAgregadosListView
            // 
            productosAgregadosListView.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader12, columnHeader13, columnHeader14 });
            productosAgregadosListView.FullRowSelect = true;
            productosAgregadosListView.Location = new Point(602, 161);
            productosAgregadosListView.Margin = new Padding(3, 4, 3, 4);
            productosAgregadosListView.MultiSelect = false;
            productosAgregadosListView.Name = "productosAgregadosListView";
            productosAgregadosListView.Size = new Size(745, 644);
            productosAgregadosListView.TabIndex = 28;
            productosAgregadosListView.UseCompatibleStateImageBehavior = false;
            productosAgregadosListView.View = View.Details;
            productosAgregadosListView.SelectedIndexChanged += productosAgregadosListView_SelectedIndexChanged;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Codigo";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Producto";
            columnHeader8.Width = 70;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Origen/Destino";
            columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Desde";
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Hasta";
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Precio Total";
            columnHeader12.Width = 80;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Prestador";
            columnHeader13.Width = 70;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Categoria";
            columnHeader14.Width = 80;
            // 
            // asignarBtn
            // 
            asignarBtn.Enabled = false;
            asignarBtn.Location = new Point(368, 832);
            asignarBtn.Name = "asignarBtn";
            asignarBtn.Size = new Size(195, 41);
            asignarBtn.TabIndex = 29;
            asignarBtn.Text = "Asignar al producto v v v";
            asignarBtn.UseVisualStyleBackColor = true;
            asignarBtn.Click += asignarBtn_Click;
            // 
            // pasajerosProductoListView
            // 
            pasajerosProductoListView.Columns.AddRange(new ColumnHeader[] { codigoHeader, dniHeader, nombreHeader2, apellidoHeader2, fechaNacHeader2 });
            pasajerosProductoListView.FullRowSelect = true;
            pasajerosProductoListView.Location = new Point(7, 27);
            pasajerosProductoListView.Name = "pasajerosProductoListView";
            pasajerosProductoListView.Size = new Size(1059, 187);
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
            dniHeader.Text = "DNI";
            dniHeader.Width = 100;
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
            groupBox1.Location = new Point(62, 879);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1086, 220);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pasajeros del producto";
            // 
            // editarPasajeroBtn
            // 
            editarPasajeroBtn.Enabled = false;
            editarPasajeroBtn.Location = new Point(262, 421);
            editarPasajeroBtn.Name = "editarPasajeroBtn";
            editarPasajeroBtn.Size = new Size(133, 41);
            editarPasajeroBtn.TabIndex = 30;
            editarPasajeroBtn.Text = "Editar pasajero";
            editarPasajeroBtn.UseVisualStyleBackColor = true;
            editarPasajeroBtn.Click += editarPasajeroBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(602, 131);
            label2.Name = "label2";
            label2.Size = new Size(163, 20);
            label2.TabIndex = 31;
            label2.Text = "Producto seleccionado:";
            // 
            // productoLabel
            // 
            productoLabel.AutoSize = true;
            productoLabel.Location = new Point(759, 131);
            productoLabel.Name = "productoLabel";
            productoLabel.Size = new Size(106, 20);
            productoLabel.TabIndex = 32;
            productoLabel.Text = "productoLabel";
            // 
            // pasajeroLabel
            // 
            pasajeroLabel.AutoSize = true;
            pasajeroLabel.Location = new Point(213, 95);
            pasajeroLabel.Name = "pasajeroLabel";
            pasajeroLabel.Size = new Size(102, 20);
            pasajeroLabel.TabIndex = 34;
            pasajeroLabel.Text = "pasajeroLabel";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 95);
            label4.Name = "label4";
            label4.Size = new Size(158, 20);
            label4.TabIndex = 33;
            label4.Text = "Pasajero seleccionado:";
            // 
            // eliminarPasajeroBtn
            // 
            eliminarPasajeroBtn.Enabled = false;
            eliminarPasajeroBtn.Location = new Point(400, 421);
            eliminarPasajeroBtn.Name = "eliminarPasajeroBtn";
            eliminarPasajeroBtn.Size = new Size(163, 41);
            eliminarPasajeroBtn.TabIndex = 35;
            eliminarPasajeroBtn.Text = "Eliminar pasajero";
            eliminarPasajeroBtn.UseVisualStyleBackColor = true;
            eliminarPasajeroBtn.Click += eliminarPasajeroBtn_Click;
            // 
            // AgregarDatosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 1080);
            Controls.Add(eliminarPasajeroBtn);
            Controls.Add(pasajeroLabel);
            Controls.Add(label4);
            Controls.Add(productoLabel);
            Controls.Add(label2);
            Controls.Add(editarPasajeroBtn);
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
    }
}