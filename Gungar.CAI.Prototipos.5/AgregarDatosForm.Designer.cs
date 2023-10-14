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
            emailLabel = new Label();
            nombreTextBox = new TextBox();
            DNILabel = new Label();
            telefonoTextBox = new TextBox();
            label1 = new Label();
            emailTextBox = new TextBox();
            telefonoLabel = new Label();
            nombreLabel = new Label();
            apellidoTextBox = new TextBox();
            button2 = new Button();
            label2 = new Label();
            seleccionarItinerarioBox = new GroupBox();
            itinerarioSeleccionadoLabel = new Label();
            label4 = new Label();
            itinerariosListView = new ListView();
            nroHeader = new ColumnHeader();
            pasajeroHeader = new ColumnHeader();
            creacionHeader = new ColumnHeader();
            continuarBtn = new Button();
            pasajerosListView = new ListView();
            nombreHeader = new ColumnHeader();
            apellidoHeader = new ColumnHeader();
            DNIHeader = new ColumnHeader();
            emailHeader = new ColumnHeader();
            telefonoHeader = new ColumnHeader();
            fechaNacHeader = new ColumnHeader();
            groupBox2 = new GroupBox();
            datosPasajerosGroupBox.SuspendLayout();
            seleccionarItinerarioBox.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // datosPasajerosGroupBox
            // 
            datosPasajerosGroupBox.Controls.Add(DNITextBox);
            datosPasajerosGroupBox.Controls.Add(agregarPasajeroBtn);
            datosPasajerosGroupBox.Controls.Add(apellidoLabel);
            datosPasajerosGroupBox.Controls.Add(fechaNacDatePicker);
            datosPasajerosGroupBox.Controls.Add(emailLabel);
            datosPasajerosGroupBox.Controls.Add(nombreTextBox);
            datosPasajerosGroupBox.Controls.Add(DNILabel);
            datosPasajerosGroupBox.Controls.Add(telefonoTextBox);
            datosPasajerosGroupBox.Controls.Add(label1);
            datosPasajerosGroupBox.Controls.Add(emailTextBox);
            datosPasajerosGroupBox.Controls.Add(telefonoLabel);
            datosPasajerosGroupBox.Controls.Add(nombreLabel);
            datosPasajerosGroupBox.Controls.Add(apellidoTextBox);
            datosPasajerosGroupBox.Location = new Point(62, 61);
            datosPasajerosGroupBox.Name = "datosPasajerosGroupBox";
            datosPasajerosGroupBox.Size = new Size(811, 304);
            datosPasajerosGroupBox.TabIndex = 0;
            datosPasajerosGroupBox.TabStop = false;
            datosPasajerosGroupBox.Text = "Datos pasajeros";
            // 
            // DNITextBox
            // 
            DNITextBox.Location = new Point(432, 78);
            DNITextBox.Name = "DNITextBox";
            DNITextBox.Size = new Size(150, 27);
            DNITextBox.TabIndex = 5;
            // 
            // agregarPasajeroBtn
            // 
            agregarPasajeroBtn.Location = new Point(492, 223);
            agregarPasajeroBtn.Name = "agregarPasajeroBtn";
            agregarPasajeroBtn.Size = new Size(161, 41);
            agregarPasajeroBtn.TabIndex = 11;
            agregarPasajeroBtn.Text = "Agregar pasajero";
            agregarPasajeroBtn.UseVisualStyleBackColor = true;
            agregarPasajeroBtn.Click += agregarPasajeroBtn_Click;
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Location = new Point(241, 46);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new Size(66, 20);
            apellidoLabel.TabIndex = 3;
            apellidoLabel.Text = "Apellido";
            // 
            // fechaNacDatePicker
            // 
            fechaNacDatePicker.Location = new Point(459, 170);
            fechaNacDatePicker.Margin = new Padding(3, 4, 3, 4);
            fechaNacDatePicker.Name = "fechaNacDatePicker";
            fechaNacDatePicker.Size = new Size(263, 27);
            fechaNacDatePicker.TabIndex = 14;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(46, 138);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(52, 20);
            emailLabel.TabIndex = 8;
            emailLabel.Text = "E-Mail";
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(46, 78);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(150, 27);
            nombreTextBox.TabIndex = 0;
            // 
            // DNILabel
            // 
            DNILabel.AutoSize = true;
            DNILabel.Location = new Point(432, 46);
            DNILabel.Name = "DNILabel";
            DNILabel.Size = new Size(35, 20);
            DNILabel.TabIndex = 6;
            DNILabel.Text = "DNI";
            // 
            // telefonoTextBox
            // 
            telefonoTextBox.Location = new Point(283, 170);
            telefonoTextBox.Name = "telefonoTextBox";
            telefonoTextBox.Size = new Size(150, 27);
            telefonoTextBox.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(459, 138);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 13;
            label1.Text = "Fecha de nacimiento";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(46, 170);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(205, 27);
            emailTextBox.TabIndex = 7;
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new Point(283, 138);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new Size(67, 20);
            telefonoLabel.TabIndex = 10;
            telefonoLabel.Text = "Teléfono";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new Point(46, 46);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(64, 20);
            nombreLabel.TabIndex = 1;
            nombreLabel.Text = "Nombre";
            // 
            // apellidoTextBox
            // 
            apellidoTextBox.Location = new Point(241, 78);
            apellidoTextBox.Name = "apellidoTextBox";
            apellidoTextBox.Size = new Size(150, 27);
            apellidoTextBox.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(1227, 506);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(160, 88);
            button2.TabIndex = 22;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(992, 147);
            label2.Name = "label2";
            label2.Size = new Size(302, 20);
            label2.TabIndex = 21;
            label2.Text = "TODO: Agregar filtros a Continuar itinerarios";
            // 
            // seleccionarItinerarioBox
            // 
            seleccionarItinerarioBox.Controls.Add(itinerarioSeleccionadoLabel);
            seleccionarItinerarioBox.Controls.Add(label4);
            seleccionarItinerarioBox.Controls.Add(itinerariosListView);
            seleccionarItinerarioBox.Location = new Point(992, 186);
            seleccionarItinerarioBox.Margin = new Padding(3, 4, 3, 4);
            seleccionarItinerarioBox.Name = "seleccionarItinerarioBox";
            seleccionarItinerarioBox.Padding = new Padding(3, 4, 3, 4);
            seleccionarItinerarioBox.Size = new Size(745, 312);
            seleccionarItinerarioBox.TabIndex = 20;
            seleccionarItinerarioBox.TabStop = false;
            seleccionarItinerarioBox.Text = "Seleccione el Itinerario al cual desea agregar pasajeros";
            // 
            // itinerarioSeleccionadoLabel
            // 
            itinerarioSeleccionadoLabel.AutoSize = true;
            itinerarioSeleccionadoLabel.Location = new Point(196, 273);
            itinerarioSeleccionadoLabel.Name = "itinerarioSeleccionadoLabel";
            itinerarioSeleccionadoLabel.Size = new Size(194, 20);
            itinerarioSeleccionadoLabel.TabIndex = 13;
            itinerarioSeleccionadoLabel.Text = "itinerarioSeleccionadoLabel";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 273);
            label4.Name = "label4";
            label4.Size = new Size(165, 20);
            label4.TabIndex = 12;
            label4.Text = "Itinerario Seleccionado:";
            // 
            // itinerariosListView
            // 
            itinerariosListView.Columns.AddRange(new ColumnHeader[] { nroHeader, pasajeroHeader, creacionHeader });
            itinerariosListView.FullRowSelect = true;
            itinerariosListView.Location = new Point(25, 48);
            itinerariosListView.Margin = new Padding(3, 4, 3, 4);
            itinerariosListView.MultiSelect = false;
            itinerariosListView.Name = "itinerariosListView";
            itinerariosListView.Size = new Size(678, 219);
            itinerariosListView.TabIndex = 10;
            itinerariosListView.UseCompatibleStateImageBehavior = false;
            itinerariosListView.View = View.Details;
            itinerariosListView.SelectedIndexChanged += itinerariosListView_SelectedIndexChanged;
            // 
            // nroHeader
            // 
            nroHeader.Text = "Numero de Itinerario";
            nroHeader.Width = 150;
            // 
            // pasajeroHeader
            // 
            pasajeroHeader.Text = "Pasajero";
            pasajeroHeader.Width = 150;
            // 
            // creacionHeader
            // 
            creacionHeader.Text = "Fecha de Creación";
            creacionHeader.Width = 150;
            // 
            // continuarBtn
            // 
            continuarBtn.Enabled = false;
            continuarBtn.Location = new Point(1394, 506);
            continuarBtn.Margin = new Padding(3, 4, 3, 4);
            continuarBtn.Name = "continuarBtn";
            continuarBtn.Size = new Size(160, 88);
            continuarBtn.TabIndex = 19;
            continuarBtn.Text = "Continuar";
            continuarBtn.UseVisualStyleBackColor = true;
            // 
            // pasajerosListView
            // 
            pasajerosListView.Columns.AddRange(new ColumnHeader[] { nombreHeader, apellidoHeader, DNIHeader, emailHeader, telefonoHeader, fechaNacHeader });
            pasajerosListView.Location = new Point(24, 38);
            pasajerosListView.Name = "pasajerosListView";
            pasajerosListView.Size = new Size(761, 127);
            pasajerosListView.TabIndex = 23;
            pasajerosListView.UseCompatibleStateImageBehavior = false;
            pasajerosListView.View = View.Details;
            // 
            // nombreHeader
            // 
            nombreHeader.Text = "Nombre";
            nombreHeader.Width = 100;
            // 
            // apellidoHeader
            // 
            apellidoHeader.Text = "Apellido";
            apellidoHeader.Width = 100;
            // 
            // DNIHeader
            // 
            DNIHeader.Text = "DNI";
            DNIHeader.Width = 120;
            // 
            // emailHeader
            // 
            emailHeader.Text = "E-Mail";
            emailHeader.Width = 170;
            // 
            // telefonoHeader
            // 
            telefonoHeader.Text = "Teléfono";
            telefonoHeader.Width = 100;
            // 
            // fechaNacHeader
            // 
            fechaNacHeader.Text = "Fecha de nacimiento";
            fechaNacHeader.Width = 150;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pasajerosListView);
            groupBox2.Location = new Point(65, 398);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(808, 220);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pasajeros";
            // 
            // AgregarDatosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1866, 1325);
            Controls.Add(groupBox2);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(seleccionarItinerarioBox);
            Controls.Add(continuarBtn);
            Controls.Add(datosPasajerosGroupBox);
            Name = "AgregarDatosForm";
            Text = "AgregarDatosForm";
            Load += AgregarDatosForm_Load;
            datosPasajerosGroupBox.ResumeLayout(false);
            datosPasajerosGroupBox.PerformLayout();
            seleccionarItinerarioBox.ResumeLayout(false);
            seleccionarItinerarioBox.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox datosPasajerosGroupBox;
        private TextBox nombreTextBox;
        private Label apellidoLabel;
        private TextBox apellidoTextBox;
        private Label nombreLabel;
        private Label emailLabel;
        private TextBox emailTextBox;
        private Label DNILabel;
        private TextBox DNITextBox;
        private Label telefonoLabel;
        private TextBox telefonoTextBox;
        private Button agregarPasajeroBtn;
        private Label label1;
        private DateTimePicker fechaNacDatePicker;
        private Button button2;
        private Label label2;
        private GroupBox seleccionarItinerarioBox;
        private Label itinerarioSeleccionadoLabel;
        private Label label4;
        private ListView itinerariosListView;
        private ColumnHeader nroHeader;
        private ColumnHeader pasajeroHeader;
        private ColumnHeader creacionHeader;
        private Button continuarBtn;
        private ListView pasajerosListView;
        private GroupBox groupBox2;
        private ColumnHeader nombreHeader;
        private ColumnHeader apellidoHeader;
        private ColumnHeader DNIHeader;
        private ColumnHeader emailHeader;
        private ColumnHeader telefonoHeader;
        private ColumnHeader fechaNacHeader;
    }
}