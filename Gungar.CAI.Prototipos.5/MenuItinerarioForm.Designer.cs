namespace Gungar.CAI.Prototipos._5
{
    partial class MenuItinerarioForm
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
            gestionarProductosBtn = new Button();
            label1 = new Label();
            itinerarioSeleccionadoLabel = new Label();
            salirBtn = new Button();
            agregarPasajerosBtn = new Button();
            groupBox1 = new GroupBox();
            generarReservaBtn = new Button();
            generarPreReservaBtn = new Button();
            estadoLabel = new Label();
            label3 = new Label();
            pasajerosListView = new ListView();
            nombreHeader = new ColumnHeader();
            fechaNacimientoHeader = new ColumnHeader();
            productosAgregadosListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            label2 = new Label();
            label4 = new Label();
            gestionarItinerarioBox = new GroupBox();
            precioTotalLabel = new Label();
            nombreYApellidoLabel = new Label();
            label6 = new Label();
            groupBox1.SuspendLayout();
            gestionarItinerarioBox.SuspendLayout();
            SuspendLayout();
            // 
            // gestionarProductosBtn
            // 
            gestionarProductosBtn.Location = new Point(15, 22);
            gestionarProductosBtn.Name = "gestionarProductosBtn";
            gestionarProductosBtn.Size = new Size(145, 51);
            gestionarProductosBtn.TabIndex = 0;
            gestionarProductosBtn.Text = "Agregar/Quitar Productos";
            gestionarProductosBtn.UseVisualStyleBackColor = true;
            gestionarProductosBtn.Click += gestionarProductosBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 38);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 1;
            label1.Text = "Itinerario número:";
            // 
            // itinerarioSeleccionadoLabel
            // 
            itinerarioSeleccionadoLabel.AutoSize = true;
            itinerarioSeleccionadoLabel.Location = new Point(129, 38);
            itinerarioSeleccionadoLabel.Name = "itinerarioSeleccionadoLabel";
            itinerarioSeleccionadoLabel.Size = new Size(152, 15);
            itinerarioSeleccionadoLabel.TabIndex = 2;
            itinerarioSeleccionadoLabel.Text = "itinerarioSeleccionadoLabel";
            // 
            // salirBtn
            // 
            salirBtn.Location = new Point(920, 22);
            salirBtn.Name = "salirBtn";
            salirBtn.Size = new Size(116, 47);
            salirBtn.TabIndex = 3;
            salirBtn.Text = "Salir";
            salirBtn.UseVisualStyleBackColor = true;
            salirBtn.Click += salirBtn_Click;
            // 
            // agregarPasajerosBtn
            // 
            agregarPasajerosBtn.Location = new Point(15, 79);
            agregarPasajerosBtn.Name = "agregarPasajerosBtn";
            agregarPasajerosBtn.Size = new Size(145, 49);
            agregarPasajerosBtn.TabIndex = 5;
            agregarPasajerosBtn.Text = "Agregar/Quitar Pasajeros";
            agregarPasajerosBtn.UseVisualStyleBackColor = true;
            agregarPasajerosBtn.Click += agregarPasajerosBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(generarReservaBtn);
            groupBox1.Controls.Add(generarPreReservaBtn);
            groupBox1.Location = new Point(54, 255);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(177, 142);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Confirmación";
            // 
            // generarReservaBtn
            // 
            generarReservaBtn.Location = new Point(15, 79);
            generarReservaBtn.Name = "generarReservaBtn";
            generarReservaBtn.Size = new Size(145, 49);
            generarReservaBtn.TabIndex = 8;
            generarReservaBtn.Text = "Confirmar Reserva";
            generarReservaBtn.UseVisualStyleBackColor = true;
            generarReservaBtn.Click += generarReservaBtn_Click;
            // 
            // generarPreReservaBtn
            // 
            generarPreReservaBtn.Location = new Point(15, 22);
            generarPreReservaBtn.Name = "generarPreReservaBtn";
            generarPreReservaBtn.Size = new Size(145, 51);
            generarPreReservaBtn.TabIndex = 7;
            generarPreReservaBtn.Text = "Generar Pre-reserva (48hs)";
            generarPreReservaBtn.UseVisualStyleBackColor = true;
            generarPreReservaBtn.Click += generarPreReserva_Click;
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new Point(78, 68);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new Size(70, 15);
            estadoLabel.TabIndex = 8;
            estadoLabel.Text = "estadoLabel";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 68);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 7;
            label3.Text = "Estado:";
            // 
            // pasajerosListView
            // 
            pasajerosListView.Columns.AddRange(new ColumnHeader[] { nombreHeader, fechaNacimientoHeader });
            pasajerosListView.Location = new Point(259, 120);
            pasajerosListView.MultiSelect = false;
            pasajerosListView.Name = "pasajerosListView";
            pasajerosListView.Size = new Size(244, 301);
            pasajerosListView.TabIndex = 10;
            pasajerosListView.UseCompatibleStateImageBehavior = false;
            pasajerosListView.View = View.Details;
            // 
            // nombreHeader
            // 
            nombreHeader.Text = "Nombre y apellido";
            nombreHeader.Width = 110;
            // 
            // fechaNacimientoHeader
            // 
            fechaNacimientoHeader.Text = "Fecha de nacimiento";
            fechaNacimientoHeader.Width = 1000;
            // 
            // productosAgregadosListView
            // 
            productosAgregadosListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            productosAgregadosListView.Location = new Point(509, 120);
            productosAgregadosListView.MultiSelect = false;
            productosAgregadosListView.Name = "productosAgregadosListView";
            productosAgregadosListView.Size = new Size(527, 301);
            productosAgregadosListView.TabIndex = 9;
            productosAgregadosListView.UseCompatibleStateImageBehavior = false;
            productosAgregadosListView.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Producto";
            columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Origen/Destino";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Desde";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Hasta";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Precio Total";
            columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Prestador";
            columnHeader6.Width = 70;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Categoria";
            columnHeader7.Width = 80;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(355, 103);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 11;
            label2.Text = "Pasajeros";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(661, 103);
            label4.Name = "label4";
            label4.Size = new Size(121, 15);
            label4.TabIndex = 12;
            label4.Text = "Productos Agregados";
            // 
            // gestionarItinerarioBox
            // 
            gestionarItinerarioBox.Controls.Add(gestionarProductosBtn);
            gestionarItinerarioBox.Controls.Add(agregarPasajerosBtn);
            gestionarItinerarioBox.Location = new Point(54, 103);
            gestionarItinerarioBox.Name = "gestionarItinerarioBox";
            gestionarItinerarioBox.Size = new Size(177, 146);
            gestionarItinerarioBox.TabIndex = 13;
            gestionarItinerarioBox.TabStop = false;
            gestionarItinerarioBox.Text = "Gestionar Itinerario";
            // 
            // precioTotalLabel
            // 
            precioTotalLabel.AutoSize = true;
            precioTotalLabel.Location = new Point(657, 435);
            precioTotalLabel.Name = "precioTotalLabel";
            precioTotalLabel.Size = new Size(104, 15);
            precioTotalLabel.TabIndex = 14;
            precioTotalLabel.Text = "Precio Total: $1560";
            // 
            // nombreYApellidoLabel
            // 
            nombreYApellidoLabel.AutoSize = true;
            nombreYApellidoLabel.Location = new Point(128, 9);
            nombreYApellidoLabel.Name = "nombreYApellidoLabel";
            nombreYApellidoLabel.Size = new Size(103, 15);
            nombreYApellidoLabel.TabIndex = 16;
            nombreYApellidoLabel.Text = "nombre y apellido";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 9);
            label6.Name = "label6";
            label6.Size = new Size(110, 15);
            label6.TabIndex = 15;
            label6.Text = "Nombre y Apellido:";
            // 
            // MenuItinerarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 658);
            Controls.Add(nombreYApellidoLabel);
            Controls.Add(label6);
            Controls.Add(precioTotalLabel);
            Controls.Add(gestionarItinerarioBox);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(pasajerosListView);
            Controls.Add(productosAgregadosListView);
            Controls.Add(estadoLabel);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(salirBtn);
            Controls.Add(itinerarioSeleccionadoLabel);
            Controls.Add(label1);
            Name = "MenuItinerarioForm";
            Text = "MenuItinerarioForm";
            Load += MenuItinerarioForm_Load;
            groupBox1.ResumeLayout(false);
            gestionarItinerarioBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button gestionarProductosBtn;
        private Label label1;
        private Label itinerarioSeleccionadoLabel;
        private Button salirBtn;
        private Button agregarPasajerosBtn;
        private GroupBox groupBox1;
        private Button button1;
        private Button button2;
        private Label estadoLabel;
        private Label label3;
        private ListView pasajerosListView;
        private ListView productosAgregadosListView;
        private Label label2;
        private Label label4;
        private GroupBox gestionarItinerarioBox;
        private ColumnHeader nombreHeader;
        private ColumnHeader fechaNacimientoHeader;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Label precioTotalLabel;
        private Button generarPreReservaBtn;
        private Button generarReservaBtn;
        private Label label5;
        private Label label6;
        private Label nombreYApellidoLabel;
    }
}