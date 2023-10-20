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
            pasajerosListView = new ListView();
            nombreHeader = new ColumnHeader();
            apellidoHeader = new ColumnHeader();
            DNIHeader = new ColumnHeader();
            emailHeader = new ColumnHeader();
            telefonoHeader = new ColumnHeader();
            fechaNacHeader = new ColumnHeader();
            groupBox2 = new GroupBox();
            itinerarioLabel = new Label();
            titleLabel = new Label();
            eliminarPasajeroBtn = new Button();
            datosPasajerosGroupBox.SuspendLayout();
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
            datosPasajerosGroupBox.Location = new Point(54, 46);
            datosPasajerosGroupBox.Margin = new Padding(3, 2, 3, 2);
            datosPasajerosGroupBox.Name = "datosPasajerosGroupBox";
            datosPasajerosGroupBox.Padding = new Padding(3, 2, 3, 2);
            datosPasajerosGroupBox.Size = new Size(710, 228);
            datosPasajerosGroupBox.TabIndex = 0;
            datosPasajerosGroupBox.TabStop = false;
            datosPasajerosGroupBox.Text = "Datos pasajeros";
            // 
            // DNITextBox
            // 
            DNITextBox.Location = new Point(378, 58);
            DNITextBox.Margin = new Padding(3, 2, 3, 2);
            DNITextBox.Name = "DNITextBox";
            DNITextBox.Size = new Size(132, 23);
            DNITextBox.TabIndex = 5;
            // 
            // agregarPasajeroBtn
            // 
            agregarPasajeroBtn.Location = new Point(430, 167);
            agregarPasajeroBtn.Margin = new Padding(3, 2, 3, 2);
            agregarPasajeroBtn.Name = "agregarPasajeroBtn";
            agregarPasajeroBtn.Size = new Size(141, 31);
            agregarPasajeroBtn.TabIndex = 11;
            agregarPasajeroBtn.Text = "Agregar pasajero";
            agregarPasajeroBtn.UseVisualStyleBackColor = true;
            agregarPasajeroBtn.Click += agregarPasajeroBtn_Click;
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Location = new Point(211, 34);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new Size(51, 15);
            apellidoLabel.TabIndex = 3;
            apellidoLabel.Text = "Apellido";
            // 
            // fechaNacDatePicker
            // 
            fechaNacDatePicker.Location = new Point(402, 128);
            fechaNacDatePicker.Name = "fechaNacDatePicker";
            fechaNacDatePicker.Size = new Size(231, 23);
            fechaNacDatePicker.TabIndex = 14;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(40, 104);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(41, 15);
            emailLabel.TabIndex = 8;
            emailLabel.Text = "E-Mail";
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(40, 58);
            nombreTextBox.Margin = new Padding(3, 2, 3, 2);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(132, 23);
            nombreTextBox.TabIndex = 0;
            // 
            // DNILabel
            // 
            DNILabel.AutoSize = true;
            DNILabel.Location = new Point(378, 34);
            DNILabel.Name = "DNILabel";
            DNILabel.Size = new Size(27, 15);
            DNILabel.TabIndex = 6;
            DNILabel.Text = "DNI";
            // 
            // telefonoTextBox
            // 
            telefonoTextBox.Location = new Point(248, 128);
            telefonoTextBox.Margin = new Padding(3, 2, 3, 2);
            telefonoTextBox.Name = "telefonoTextBox";
            telefonoTextBox.Size = new Size(132, 23);
            telefonoTextBox.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(402, 104);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 13;
            label1.Text = "Fecha de nacimiento";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(40, 128);
            emailTextBox.Margin = new Padding(3, 2, 3, 2);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(180, 23);
            emailTextBox.TabIndex = 7;
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new Point(248, 104);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new Size(52, 15);
            telefonoLabel.TabIndex = 10;
            telefonoLabel.Text = "Teléfono";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new Point(40, 34);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(51, 15);
            nombreLabel.TabIndex = 1;
            nombreLabel.Text = "Nombre";
            // 
            // apellidoTextBox
            // 
            apellidoTextBox.Location = new Point(211, 58);
            apellidoTextBox.Margin = new Padding(3, 2, 3, 2);
            apellidoTextBox.Name = "apellidoTextBox";
            apellidoTextBox.Size = new Size(132, 23);
            apellidoTextBox.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(893, 29);
            button2.Name = "button2";
            button2.Size = new Size(140, 66);
            button2.TabIndex = 22;
            button2.Text = "Volver al Menu";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pasajerosListView
            // 
            pasajerosListView.Columns.AddRange(new ColumnHeader[] { nombreHeader, apellidoHeader, DNIHeader, emailHeader, telefonoHeader, fechaNacHeader });
            pasajerosListView.FullRowSelect = true;
            pasajerosListView.Location = new Point(21, 28);
            pasajerosListView.Margin = new Padding(3, 2, 3, 2);
            pasajerosListView.Name = "pasajerosListView";
            pasajerosListView.Size = new Size(791, 122);
            pasajerosListView.TabIndex = 23;
            pasajerosListView.UseCompatibleStateImageBehavior = false;
            pasajerosListView.View = View.Details;
            pasajerosListView.SelectedIndexChanged += pasajerosListView_SelectedIndexChanged;
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
            groupBox2.Location = new Point(57, 298);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(830, 165);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pasajeros";
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
            titleLabel.Click += titleLabel_Click;
            // 
            // eliminarPasajeroBtn
            // 
            eliminarPasajeroBtn.Enabled = false;
            eliminarPasajeroBtn.Location = new Point(893, 370);
            eliminarPasajeroBtn.Margin = new Padding(3, 2, 3, 2);
            eliminarPasajeroBtn.Name = "eliminarPasajeroBtn";
            eliminarPasajeroBtn.Size = new Size(141, 31);
            eliminarPasajeroBtn.TabIndex = 15;
            eliminarPasajeroBtn.Text = "Eliminar Pasajero";
            eliminarPasajeroBtn.UseVisualStyleBackColor = true;
            eliminarPasajeroBtn.Click += eliminarPasajeroBtn_Click;
            // 
            // AgregarDatosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1633, 981);
            Controls.Add(eliminarPasajeroBtn);
            Controls.Add(itinerarioLabel);
            Controls.Add(titleLabel);
            Controls.Add(groupBox2);
            Controls.Add(button2);
            Controls.Add(datosPasajerosGroupBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AgregarDatosForm";
            Text = "AgregarDatosForm";
            Load += AgregarDatosForm_Load;
            datosPasajerosGroupBox.ResumeLayout(false);
            datosPasajerosGroupBox.PerformLayout();
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
        private Button eliminarPasajeroBtn;
    }
}