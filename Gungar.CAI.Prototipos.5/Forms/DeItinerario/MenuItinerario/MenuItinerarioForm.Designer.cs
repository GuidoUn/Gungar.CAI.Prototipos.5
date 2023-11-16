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
            hotelesBtn = new Button();
            label1 = new Label();
            itinerarioSeleccionadoLabel = new Label();
            salirBtn = new Button();
            confirmacionBox = new GroupBox();
            generarReservaBtn = new Button();
            generarPreReservaBtn = new Button();
            estadoLabel = new Label();
            label3 = new Label();
            pasajerosListView = new ListView();
            idProductoHeader = new ColumnHeader();
            nombreHeader = new ColumnHeader();
            fechaNacimientoHeader = new ColumnHeader();
            label2 = new Label();
            label4 = new Label();
            gestionarItinerarioBox = new GroupBox();
            vuelosBtn = new Button();
            clienteBtn = new Button();
            precioTotalLabel = new Label();
            nombreYApellidoLabel = new Label();
            label6 = new Label();
            cancelarReservaBtn = new Button();
            label7 = new Label();
            hotelesAgregadosListView = new ListView();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            columnHeader16 = new ColumnHeader();
            abonadoLabel = new Label();
            vuelosAgregadosListView = new ListView();
            columnHeader0 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader26 = new ColumnHeader();
            columnHeader27 = new ColumnHeader();
            columnHeader28 = new ColumnHeader();
            columnHeader29 = new ColumnHeader();
            faltaClienteLabel = new Label();
            faltaProductoLabel = new Label();
            confirmacionBox.SuspendLayout();
            gestionarItinerarioBox.SuspendLayout();
            SuspendLayout();
            // 
            // hotelesBtn
            // 
            hotelesBtn.Location = new Point(7, 168);
            hotelesBtn.Margin = new Padding(3, 4, 3, 4);
            hotelesBtn.Name = "hotelesBtn";
            hotelesBtn.Size = new Size(283, 45);
            hotelesBtn.TabIndex = 0;
            hotelesBtn.Text = "Agregar | Quitar Hoteles";
            hotelesBtn.UseVisualStyleBackColor = true;
            hotelesBtn.Click += hotelesBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(27, 35);
            label1.Name = "label1";
            label1.Size = new Size(119, 25);
            label1.TabIndex = 1;
            label1.Text = "Itinerario N°:";
            // 
            // itinerarioSeleccionadoLabel
            // 
            itinerarioSeleccionadoLabel.AutoSize = true;
            itinerarioSeleccionadoLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            itinerarioSeleccionadoLabel.Location = new Point(131, 35);
            itinerarioSeleccionadoLabel.Name = "itinerarioSeleccionadoLabel";
            itinerarioSeleccionadoLabel.Size = new Size(246, 25);
            itinerarioSeleccionadoLabel.TabIndex = 2;
            itinerarioSeleccionadoLabel.Text = "itinerarioSeleccionadoLabel";
            // 
            // salirBtn
            // 
            salirBtn.Location = new Point(1226, 35);
            salirBtn.Margin = new Padding(3, 4, 3, 4);
            salirBtn.Name = "salirBtn";
            salirBtn.Size = new Size(133, 52);
            salirBtn.TabIndex = 3;
            salirBtn.Text = "Volver";
            salirBtn.UseVisualStyleBackColor = true;
            salirBtn.Click += salirBtn_Click;
            // 
            // confirmacionBox
            // 
            confirmacionBox.Controls.Add(generarReservaBtn);
            confirmacionBox.Controls.Add(generarPreReservaBtn);
            confirmacionBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            confirmacionBox.Location = new Point(8, 617);
            confirmacionBox.Margin = new Padding(3, 4, 3, 4);
            confirmacionBox.Name = "confirmacionBox";
            confirmacionBox.Padding = new Padding(3, 4, 3, 4);
            confirmacionBox.Size = new Size(297, 176);
            confirmacionBox.TabIndex = 6;
            confirmacionBox.TabStop = false;
            confirmacionBox.Text = "Confirmación";
            // 
            // generarReservaBtn
            // 
            generarReservaBtn.BackColor = SystemColors.Control;
            generarReservaBtn.ForeColor = SystemColors.ControlText;
            generarReservaBtn.Location = new Point(7, 108);
            generarReservaBtn.Margin = new Padding(3, 4, 3, 4);
            generarReservaBtn.Name = "generarReservaBtn";
            generarReservaBtn.Size = new Size(283, 45);
            generarReservaBtn.TabIndex = 8;
            generarReservaBtn.Text = "Confirmar Reserva";
            generarReservaBtn.UseVisualStyleBackColor = false;
            generarReservaBtn.Click += generarReservaBtn_Click;
            // 
            // generarPreReservaBtn
            // 
            generarPreReservaBtn.Location = new Point(7, 39);
            generarPreReservaBtn.Margin = new Padding(3, 4, 3, 4);
            generarPreReservaBtn.Name = "generarPreReservaBtn";
            generarPreReservaBtn.Size = new Size(283, 48);
            generarPreReservaBtn.TabIndex = 7;
            generarPreReservaBtn.Text = "Generar Pre-reserva (48hs)";
            generarPreReservaBtn.UseVisualStyleBackColor = true;
            generarPreReservaBtn.Click += generarPreReserva_Click;
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            estadoLabel.Location = new Point(199, 137);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new Size(106, 23);
            estadoLabel.TabIndex = 8;
            estadoLabel.Text = "estadoLabel";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(24, 137);
            label3.Name = "label3";
            label3.Size = new Size(177, 23);
            label3.TabIndex = 7;
            label3.Text = "Estado del itinerario:";
            // 
            // pasajerosListView
            // 
            pasajerosListView.Columns.AddRange(new ColumnHeader[] { idProductoHeader, nombreHeader, fechaNacimientoHeader });
            pasajerosListView.Location = new Point(312, 740);
            pasajerosListView.Margin = new Padding(3, 4, 3, 4);
            pasajerosListView.MultiSelect = false;
            pasajerosListView.Name = "pasajerosListView";
            pasajerosListView.Size = new Size(1046, 192);
            pasajerosListView.TabIndex = 10;
            pasajerosListView.UseCompatibleStateImageBehavior = false;
            pasajerosListView.View = View.Details;
            // 
            // idProductoHeader
            // 
            idProductoHeader.Text = "Código";
            idProductoHeader.Width = 100;
            // 
            // nombreHeader
            // 
            nombreHeader.Text = "Nombre y apellido";
            nombreHeader.Width = 150;
            // 
            // fechaNacimientoHeader
            // 
            fechaNacimientoHeader.Text = "Fecha de nacimiento";
            fechaNacimientoHeader.Width = 1000;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(312, 713);
            label2.Name = "label2";
            label2.Size = new Size(159, 20);
            label2.TabIndex = 11;
            label2.Text = "Pasajeros del itinerario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(312, 192);
            label4.Name = "label4";
            label4.Size = new Size(208, 20);
            label4.TabIndex = 12;
            label4.Text = "Vuelos agregados al itinerario";
            // 
            // gestionarItinerarioBox
            // 
            gestionarItinerarioBox.Controls.Add(vuelosBtn);
            gestionarItinerarioBox.Controls.Add(clienteBtn);
            gestionarItinerarioBox.Controls.Add(hotelesBtn);
            gestionarItinerarioBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            gestionarItinerarioBox.Location = new Point(8, 195);
            gestionarItinerarioBox.Margin = new Padding(3, 4, 3, 4);
            gestionarItinerarioBox.Name = "gestionarItinerarioBox";
            gestionarItinerarioBox.Padding = new Padding(3, 4, 3, 4);
            gestionarItinerarioBox.Size = new Size(297, 240);
            gestionarItinerarioBox.TabIndex = 13;
            gestionarItinerarioBox.TabStop = false;
            gestionarItinerarioBox.Text = "Gestionar Itinerario";
            // 
            // vuelosBtn
            // 
            vuelosBtn.Location = new Point(6, 101);
            vuelosBtn.Margin = new Padding(3, 4, 3, 4);
            vuelosBtn.Name = "vuelosBtn";
            vuelosBtn.Size = new Size(285, 45);
            vuelosBtn.TabIndex = 7;
            vuelosBtn.Text = "Agregar | Quitar Vuelos";
            vuelosBtn.UseVisualStyleBackColor = true;
            vuelosBtn.Click += vuelosBtn_Click;
            // 
            // clienteBtn
            // 
            clienteBtn.Location = new Point(6, 37);
            clienteBtn.Margin = new Padding(3, 4, 3, 4);
            clienteBtn.Name = "clienteBtn";
            clienteBtn.Size = new Size(285, 45);
            clienteBtn.TabIndex = 6;
            clienteBtn.Text = "Agregar | Modificar Cliente";
            clienteBtn.UseVisualStyleBackColor = true;
            clienteBtn.Click += clienteBtn_Click;
            // 
            // precioTotalLabel
            // 
            precioTotalLabel.AutoSize = true;
            precioTotalLabel.Location = new Point(415, 87);
            precioTotalLabel.Name = "precioTotalLabel";
            precioTotalLabel.Size = new Size(88, 20);
            precioTotalLabel.TabIndex = 14;
            precioTotalLabel.Text = "Precio total:";
            // 
            // nombreYApellidoLabel
            // 
            nombreYApellidoLabel.AutoSize = true;
            nombreYApellidoLabel.Location = new Point(163, 87);
            nombreYApellidoLabel.Name = "nombreYApellidoLabel";
            nombreYApellidoLabel.Size = new Size(131, 20);
            nombreYApellidoLabel.TabIndex = 16;
            nombreYApellidoLabel.Text = "nombre y apellido";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 87);
            label6.Name = "label6";
            label6.Size = new Size(139, 20);
            label6.TabIndex = 15;
            label6.Text = "Nombre y Apellido:";
            // 
            // cancelarReservaBtn
            // 
            cancelarReservaBtn.BackColor = SystemColors.Control;
            cancelarReservaBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cancelarReservaBtn.ForeColor = SystemColors.ControlText;
            cancelarReservaBtn.Location = new Point(15, 884);
            cancelarReservaBtn.Margin = new Padding(3, 4, 3, 4);
            cancelarReservaBtn.Name = "cancelarReservaBtn";
            cancelarReservaBtn.Size = new Size(283, 49);
            cancelarReservaBtn.TabIndex = 9;
            cancelarReservaBtn.Text = "Cancelar itinerario";
            cancelarReservaBtn.UseVisualStyleBackColor = false;
            cancelarReservaBtn.Click += cancelarReservaBtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(312, 456);
            label7.Name = "label7";
            label7.Size = new Size(215, 20);
            label7.TabIndex = 18;
            label7.Text = "Hoteles agregados al itinerario";
            // 
            // hotelesAgregadosListView
            // 
            hotelesAgregadosListView.Columns.AddRange(new ColumnHeader[] { columnHeader8, columnHeader9, columnHeader10, columnHeader12, columnHeader13, columnHeader14, columnHeader15, columnHeader16 });
            hotelesAgregadosListView.Location = new Point(312, 480);
            hotelesAgregadosListView.Margin = new Padding(3, 4, 3, 4);
            hotelesAgregadosListView.MultiSelect = false;
            hotelesAgregadosListView.Name = "hotelesAgregadosListView";
            hotelesAgregadosListView.Size = new Size(1046, 200);
            hotelesAgregadosListView.TabIndex = 17;
            hotelesAgregadosListView.UseCompatibleStateImageBehavior = false;
            hotelesAgregadosListView.View = View.Details;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Código";
            columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Producto";
            columnHeader9.Width = 115;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Destino";
            columnHeader10.Width = 100;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Desde";
            columnHeader12.Width = 105;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Hasta";
            columnHeader13.Width = 105;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Precio";
            columnHeader14.Width = 80;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "Prestador";
            columnHeader15.Width = 95;
            // 
            // columnHeader16
            // 
            columnHeader16.Text = "Categoría";
            columnHeader16.Width = 90;
            // 
            // abonadoLabel
            // 
            abonadoLabel.AutoSize = true;
            abonadoLabel.Location = new Point(637, 87);
            abonadoLabel.Name = "abonadoLabel";
            abonadoLabel.Size = new Size(105, 20);
            abonadoLabel.TabIndex = 19;
            abonadoLabel.Text = "abonadoLabel";
            // 
            // vuelosAgregadosListView
            // 
            vuelosAgregadosListView.Columns.AddRange(new ColumnHeader[] { columnHeader0, columnHeader1, columnHeader5, columnHeader6, columnHeader7, columnHeader2, columnHeader3, columnHeader4, columnHeader26, columnHeader27, columnHeader28, columnHeader29 });
            vuelosAgregadosListView.FullRowSelect = true;
            vuelosAgregadosListView.Location = new Point(312, 216);
            vuelosAgregadosListView.Margin = new Padding(3, 4, 3, 4);
            vuelosAgregadosListView.MultiSelect = false;
            vuelosAgregadosListView.Name = "vuelosAgregadosListView";
            vuelosAgregadosListView.Size = new Size(1046, 215);
            vuelosAgregadosListView.TabIndex = 27;
            vuelosAgregadosListView.UseCompatibleStateImageBehavior = false;
            vuelosAgregadosListView.View = View.Details;
            // 
            // columnHeader0
            // 
            columnHeader0.Text = "Código";
            columnHeader0.Width = 120;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Fecha Salida";
            columnHeader1.Width = 135;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Aerolinea";
            columnHeader5.Width = 135;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Origen";
            columnHeader6.Width = 105;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Destino";
            columnHeader7.Width = 105;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Clase";
            columnHeader2.Width = 85;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Cant. Pasajeros";
            columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Precio Total";
            columnHeader4.Width = 90;
            // 
            // columnHeader26
            // 
            columnHeader26.Text = "Duración";
            columnHeader26.Width = 72;
            // 
            // columnHeader27
            // 
            columnHeader27.Text = "Precio Adulto";
            columnHeader27.Width = 102;
            // 
            // columnHeader28
            // 
            columnHeader28.Text = "Precio Menor";
            columnHeader28.Width = 100;
            // 
            // columnHeader29
            // 
            columnHeader29.Text = "Precio Infante";
            columnHeader29.Width = 105;
            // 
            // faltaClienteLabel
            // 
            faltaClienteLabel.AutoSize = true;
            faltaClienteLabel.ForeColor = Color.IndianRed;
            faltaClienteLabel.Location = new Point(41, 549);
            faltaClienteLabel.Name = "faltaClienteLabel";
            faltaClienteLabel.Size = new Size(180, 20);
            faltaClienteLabel.TabIndex = 28;
            faltaClienteLabel.Text = "* Debe ingresar un cliente";
            // 
            // faltaProductoLabel
            // 
            faltaProductoLabel.AutoSize = true;
            faltaProductoLabel.ForeColor = Color.IndianRed;
            faltaProductoLabel.Location = new Point(41, 573);
            faltaProductoLabel.Name = "faltaProductoLabel";
            faltaProductoLabel.Size = new Size(197, 20);
            faltaProductoLabel.TabIndex = 29;
            faltaProductoLabel.Text = "* Debe ingresar un producto";
            // 
            // MenuItinerarioForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1400, 983);
            Controls.Add(faltaProductoLabel);
            Controls.Add(faltaClienteLabel);
            Controls.Add(vuelosAgregadosListView);
            Controls.Add(abonadoLabel);
            Controls.Add(label7);
            Controls.Add(hotelesAgregadosListView);
            Controls.Add(cancelarReservaBtn);
            Controls.Add(nombreYApellidoLabel);
            Controls.Add(label6);
            Controls.Add(precioTotalLabel);
            Controls.Add(gestionarItinerarioBox);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(pasajerosListView);
            Controls.Add(estadoLabel);
            Controls.Add(label3);
            Controls.Add(confirmacionBox);
            Controls.Add(salirBtn);
            Controls.Add(itinerarioSeleccionadoLabel);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MenuItinerarioForm";
            Text = "MenuItinerarioForm";
            Load += MenuItinerarioForm_Load;
            confirmacionBox.ResumeLayout(false);
            gestionarItinerarioBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button hotelesBtn;
        private Label label1;
        private Label itinerarioSeleccionadoLabel;
        private Button salirBtn;
        private GroupBox confirmacionBox;
        private Button button1;
        private Button button2;
        private Label estadoLabel;
        private Label label3;
        private ListView pasajerosListView;
        private Label label2;
        private Label label4;
        private GroupBox gestionarItinerarioBox;
        private ColumnHeader nombreHeader;
        private ColumnHeader fechaNacimientoHeader;
        private Label precioTotalLabel;
        private Button generarPreReservaBtn;
        private Button generarReservaBtn;
        private Label faltaProductoLabel;
        private Label label6;
        private Label nombreYApellidoLabel;
        private Button vuelosBtn;
        private Button clienteBtn;
        private Button cancelarReservaBtn;
        private Label label7;
        private ListView listView1;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ListView hotelesAgregadosListView;
        private Label abonadoLabel;
        private ListView vuelosAgregadosListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader26;
        private ColumnHeader columnHeader27;
        private ColumnHeader columnHeader28;
        private ColumnHeader columnHeader29;
        private ColumnHeader idProductoHeader;
        private ColumnHeader columnHeader0;
        private Label faltaClienteLabel;
        private ColumnHeader columnHeader15;
        private ColumnHeader columnHeader16;
    }
}