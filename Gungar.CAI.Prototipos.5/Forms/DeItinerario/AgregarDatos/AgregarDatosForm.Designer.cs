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
            apellidoLabel = new Label();
            fechaNacDatePicker = new DateTimePicker();
            nombreTextBox = new TextBox();
            DNILabel = new Label();
            label1 = new Label();
            nombreLabel = new Label();
            apellidoTextBox = new TextBox();
            agregarPasajeroBtn = new Button();
            button2 = new Button();
            groupBox2 = new GroupBox();
            eliminarPasajeroBtn = new Button();
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
            label2 = new Label();
            productoLabel = new Label();
            pasajeroLabel = new Label();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            groupBox3 = new GroupBox();
            label6 = new Label();
            datosPasajerosGroupBox.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // datosPasajerosGroupBox
            // 
            datosPasajerosGroupBox.Controls.Add(DNITextBox);
            datosPasajerosGroupBox.Controls.Add(apellidoLabel);
            datosPasajerosGroupBox.Controls.Add(fechaNacDatePicker);
            datosPasajerosGroupBox.Controls.Add(nombreTextBox);
            datosPasajerosGroupBox.Controls.Add(DNILabel);
            datosPasajerosGroupBox.Controls.Add(label1);
            datosPasajerosGroupBox.Controls.Add(nombreLabel);
            datosPasajerosGroupBox.Controls.Add(apellidoTextBox);
            datosPasajerosGroupBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            datosPasajerosGroupBox.Location = new Point(69, 109);
            datosPasajerosGroupBox.Name = "datosPasajerosGroupBox";
            datosPasajerosGroupBox.Size = new Size(431, 281);
            datosPasajerosGroupBox.TabIndex = 0;
            datosPasajerosGroupBox.TabStop = false;
            datosPasajerosGroupBox.Text = "1°: Crear nuevo pasajero";
            // 
            // DNITextBox
            // 
            DNITextBox.Location = new Point(17, 152);
            DNITextBox.Name = "DNITextBox";
            DNITextBox.Size = new Size(173, 29);
            DNITextBox.TabIndex = 5;
            DNITextBox.KeyPress += documentoTextBox_KeyPress;
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Location = new Point(214, 37);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new Size(72, 23);
            apellidoLabel.TabIndex = 3;
            apellidoLabel.Text = "Apellido";
            // 
            // fechaNacDatePicker
            // 
            fechaNacDatePicker.Location = new Point(17, 227);
            fechaNacDatePicker.Margin = new Padding(3, 4, 3, 4);
            fechaNacDatePicker.Name = "fechaNacDatePicker";
            fechaNacDatePicker.Size = new Size(245, 29);
            fechaNacDatePicker.TabIndex = 14;
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(17, 69);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(150, 29);
            nombreTextBox.TabIndex = 0;
            nombreTextBox.KeyPress += nombreTextBox_KeyPress;
            // 
            // DNILabel
            // 
            DNILabel.Location = new Point(17, 124);
            DNILabel.Name = "DNILabel";
            DNILabel.Size = new Size(208, 40);
            DNILabel.TabIndex = 6;
            DNILabel.Text = "Documento o Pasaporte";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 199);
            label1.Name = "label1";
            label1.Size = new Size(168, 23);
            label1.TabIndex = 13;
            label1.Text = "Fecha de nacimiento";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new Point(17, 37);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(73, 23);
            nombreLabel.TabIndex = 1;
            nombreLabel.Text = "Nombre";
            // 
            // apellidoTextBox
            // 
            apellidoTextBox.Location = new Point(214, 69);
            apellidoTextBox.Name = "apellidoTextBox";
            apellidoTextBox.Size = new Size(150, 29);
            apellidoTextBox.TabIndex = 2;
            apellidoTextBox.KeyPress += apellidoTextBox_KeyPress;
            // 
            // agregarPasajeroBtn
            // 
            agregarPasajeroBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            agregarPasajeroBtn.Location = new Point(514, 227);
            agregarPasajeroBtn.Name = "agregarPasajeroBtn";
            agregarPasajeroBtn.Size = new Size(168, 35);
            agregarPasajeroBtn.TabIndex = 11;
            agregarPasajeroBtn.Text = "Guardar pasajero  →";
            agregarPasajeroBtn.UseVisualStyleBackColor = true;
            agregarPasajeroBtn.Click += agregarPasajeroBtn_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(1169, 31);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(130, 52);
            button2.TabIndex = 22;
            button2.Text = "Volver";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(eliminarPasajeroBtn);
            groupBox2.Controls.Add(pasajerosItinerarioListView);
            groupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(696, 109);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(603, 281);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lista de pasajeros";
            // 
            // eliminarPasajeroBtn
            // 
            eliminarPasajeroBtn.Enabled = false;
            eliminarPasajeroBtn.Location = new Point(459, 227);
            eliminarPasajeroBtn.Name = "eliminarPasajeroBtn";
            eliminarPasajeroBtn.Size = new Size(137, 41);
            eliminarPasajeroBtn.TabIndex = 35;
            eliminarPasajeroBtn.Text = "Eliminar pasajero";
            eliminarPasajeroBtn.UseVisualStyleBackColor = true;
            eliminarPasajeroBtn.Click += eliminarPasajeroBtn_Click;
            // 
            // pasajerosItinerarioListView
            // 
            pasajerosItinerarioListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader6 });
            pasajerosItinerarioListView.FullRowSelect = true;
            pasajerosItinerarioListView.Location = new Point(7, 37);
            pasajerosItinerarioListView.Name = "pasajerosItinerarioListView";
            pasajerosItinerarioListView.Size = new Size(589, 172);
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
            itinerarioLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            itinerarioLabel.Location = new Point(379, 41);
            itinerarioLabel.Name = "itinerarioLabel";
            itinerarioLabel.Size = new Size(134, 25);
            itinerarioLabel.TabIndex = 26;
            itinerarioLabel.Text = "itinerarioLabel";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            titleLabel.Location = new Point(75, 41);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(337, 25);
            titleLabel.TabIndex = 25;
            titleLabel.Text = "Agregar los pasajeros del itinerario N°:";
            // 
            // quitarAsignacionBtn
            // 
            quitarAsignacionBtn.Enabled = false;
            quitarAsignacionBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            quitarAsignacionBtn.Location = new Point(423, 711);
            quitarAsignacionBtn.Name = "quitarAsignacionBtn";
            quitarAsignacionBtn.Size = new Size(238, 41);
            quitarAsignacionBtn.TabIndex = 15;
            quitarAsignacionBtn.Text = "Quitar pasajero del producto  ↑";
            quitarAsignacionBtn.UseVisualStyleBackColor = true;
            quitarAsignacionBtn.Click += quitarAsignacionBtn_Click;
            // 
            // confirmarBtn
            // 
            confirmarBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            confirmarBtn.Location = new Point(1167, 967);
            confirmarBtn.Margin = new Padding(3, 4, 3, 4);
            confirmarBtn.Name = "confirmarBtn";
            confirmarBtn.Size = new Size(133, 52);
            confirmarBtn.TabIndex = 27;
            confirmarBtn.Text = "Confirmar";
            confirmarBtn.UseVisualStyleBackColor = true;
            confirmarBtn.Click += confirmarBtn_Click;
            // 
            // productosAgregadosListView
            // 
            productosAgregadosListView.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader12, columnHeader5, columnHeader13, columnHeader14 });
            productosAgregadosListView.FullRowSelect = true;
            productosAgregadosListView.Location = new Point(75, 532);
            productosAgregadosListView.Margin = new Padding(3, 4, 3, 4);
            productosAgregadosListView.MultiSelect = false;
            productosAgregadosListView.Name = "productosAgregadosListView";
            productosAgregadosListView.Size = new Size(1223, 157);
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
            asignarBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            asignarBtn.Location = new Point(697, 711);
            asignarBtn.Name = "asignarBtn";
            asignarBtn.Size = new Size(247, 41);
            asignarBtn.TabIndex = 29;
            asignarBtn.Text = "Asignar pasasjero al producto  ↓";
            asignarBtn.UseVisualStyleBackColor = true;
            asignarBtn.Click += asignarBtn_Click;
            // 
            // pasajerosProductoListView
            // 
            pasajerosProductoListView.Columns.AddRange(new ColumnHeader[] { codigoHeader, dniHeader, nombreHeader2, apellidoHeader2, fechaNacHeader2 });
            pasajerosProductoListView.FullRowSelect = true;
            pasajerosProductoListView.Location = new Point(7, 27);
            pasajerosProductoListView.Name = "pasajerosProductoListView";
            pasajerosProductoListView.Size = new Size(1223, 148);
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
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(69, 757);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1243, 192);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pasajeros añadidos al producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(482, 457);
            label2.Name = "label2";
            label2.Size = new Size(194, 23);
            label2.TabIndex = 31;
            label2.Text = "Producto seleccionado:";
            // 
            // productoLabel
            // 
            productoLabel.AutoSize = true;
            productoLabel.BackColor = SystemColors.Control;
            productoLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            productoLabel.Location = new Point(675, 457);
            productoLabel.Name = "productoLabel";
            productoLabel.Size = new Size(127, 23);
            productoLabel.TabIndex = 32;
            productoLabel.Text = "productoLabel";
            // 
            // pasajeroLabel
            // 
            pasajeroLabel.AutoSize = true;
            pasajeroLabel.BackColor = SystemColors.Control;
            pasajeroLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            pasajeroLabel.Location = new Point(675, 420);
            pasajeroLabel.Name = "pasajeroLabel";
            pasajeroLabel.Size = new Size(120, 23);
            pasajeroLabel.TabIndex = 34;
            pasajeroLabel.Text = "pasajeroLabel";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(482, 420);
            label4.Name = "label4";
            label4.Size = new Size(187, 23);
            label4.TabIndex = 33;
            label4.Text = "Pasajero seleccionado:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(75, 420);
            label3.Name = "label3";
            label3.Size = new Size(389, 23);
            label3.TabIndex = 35;
            label3.Text = "2°: Seleccione un pasajero de \"Lista de pasajeros\":";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(66, 343);
            label5.Name = "label5";
            label5.Size = new Size(320, 17);
            label5.TabIndex = 36;
            label5.Text = "3°: Seleccione un pasajero de la \"Lista de productos\".";
            // 
            // groupBox3
            // 
            groupBox3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(69, 504);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(1242, 195);
            groupBox3.TabIndex = 37;
            groupBox3.TabStop = false;
            groupBox3.Text = "Lista de productos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(75, 457);
            label6.Name = "label6";
            label6.Size = new Size(401, 23);
            label6.TabIndex = 38;
            label6.Text = "3°: Seleccione un producto de \"Lista de productos\":";
            // 
            // AgregarDatosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1363, 1085);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(agregarPasajeroBtn);
            Controls.Add(pasajeroLabel);
            Controls.Add(label4);
            Controls.Add(productoLabel);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(asignarBtn);
            Controls.Add(productosAgregadosListView);
            Controls.Add(confirmarBtn);
            Controls.Add(quitarAsignacionBtn);
            Controls.Add(itinerarioLabel);
            Controls.Add(titleLabel);
            Controls.Add(groupBox2);
            Controls.Add(datosPasajerosGroupBox);
            Controls.Add(groupBox3);
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
        private Label label3;
        private Label label5;
        private GroupBox groupBox3;
        private Label label6;
    }
}