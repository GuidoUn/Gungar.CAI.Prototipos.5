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
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            abonadoLabel = new Label();
            vuelosAgregadosListView = new ListView();
            columnHeader15 = new ColumnHeader();
            columnHeader16 = new ColumnHeader();
            columnHeader17 = new ColumnHeader();
            columnHeader18 = new ColumnHeader();
            columnHeader19 = new ColumnHeader();
            columnHeader20 = new ColumnHeader();
            columnHeader21 = new ColumnHeader();
            columnHeader22 = new ColumnHeader();
            columnHeader23 = new ColumnHeader();
            columnHeader24 = new ColumnHeader();
            columnHeader25 = new ColumnHeader();
            confirmacionBox.SuspendLayout();
            gestionarItinerarioBox.SuspendLayout();
            SuspendLayout();
            // 
            // hotelesBtn
            // 
            hotelesBtn.Location = new Point(21, 227);
            hotelesBtn.Margin = new Padding(4, 5, 4, 5);
            hotelesBtn.Name = "hotelesBtn";
            hotelesBtn.Size = new Size(207, 85);
            hotelesBtn.TabIndex = 0;
            hotelesBtn.Text = "Agregar/Quitar Hoteles";
            hotelesBtn.UseVisualStyleBackColor = true;
            hotelesBtn.Click += hotelesBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 63);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(153, 25);
            label1.TabIndex = 1;
            label1.Text = "Itinerario número:";
            // 
            // itinerarioSeleccionadoLabel
            // 
            itinerarioSeleccionadoLabel.AutoSize = true;
            itinerarioSeleccionadoLabel.Location = new Point(184, 63);
            itinerarioSeleccionadoLabel.Margin = new Padding(4, 0, 4, 0);
            itinerarioSeleccionadoLabel.Name = "itinerarioSeleccionadoLabel";
            itinerarioSeleccionadoLabel.Size = new Size(226, 25);
            itinerarioSeleccionadoLabel.TabIndex = 2;
            itinerarioSeleccionadoLabel.Text = "itinerarioSeleccionadoLabel";
            // 
            // salirBtn
            // 
            salirBtn.Location = new Point(1533, 37);
            salirBtn.Margin = new Padding(4, 5, 4, 5);
            salirBtn.Name = "salirBtn";
            salirBtn.Size = new Size(166, 78);
            salirBtn.TabIndex = 3;
            salirBtn.Text = "Salir";
            salirBtn.UseVisualStyleBackColor = true;
            salirBtn.Click += salirBtn_Click;
            // 
            // confirmacionBox
            // 
            confirmacionBox.Controls.Add(generarReservaBtn);
            confirmacionBox.Controls.Add(generarPreReservaBtn);
            confirmacionBox.Location = new Point(77, 703);
            confirmacionBox.Margin = new Padding(4, 5, 4, 5);
            confirmacionBox.Name = "confirmacionBox";
            confirmacionBox.Padding = new Padding(4, 5, 4, 5);
            confirmacionBox.Size = new Size(253, 237);
            confirmacionBox.TabIndex = 6;
            confirmacionBox.TabStop = false;
            confirmacionBox.Text = "Confirmación";
            // 
            // generarReservaBtn
            // 
            generarReservaBtn.Location = new Point(21, 132);
            generarReservaBtn.Margin = new Padding(4, 5, 4, 5);
            generarReservaBtn.Name = "generarReservaBtn";
            generarReservaBtn.Size = new Size(207, 82);
            generarReservaBtn.TabIndex = 8;
            generarReservaBtn.Text = "Confirmar Reserva";
            generarReservaBtn.UseVisualStyleBackColor = true;
            generarReservaBtn.Click += generarReservaBtn_Click;
            // 
            // generarPreReservaBtn
            // 
            generarPreReservaBtn.Location = new Point(21, 37);
            generarPreReservaBtn.Margin = new Padding(4, 5, 4, 5);
            generarPreReservaBtn.Name = "generarPreReservaBtn";
            generarPreReservaBtn.Size = new Size(207, 85);
            generarPreReservaBtn.TabIndex = 7;
            generarPreReservaBtn.Text = "Generar Pre-reserva (48hs)";
            generarPreReservaBtn.UseVisualStyleBackColor = true;
            generarPreReservaBtn.Click += generarPreReserva_Click;
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new Point(111, 113);
            estadoLabel.Margin = new Padding(4, 0, 4, 0);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new Size(107, 25);
            estadoLabel.TabIndex = 8;
            estadoLabel.Text = "estadoLabel";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 113);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 7;
            label3.Text = "Estado:";
            // 
            // pasajerosListView
            // 
            pasajerosListView.Columns.AddRange(new ColumnHeader[] { nombreHeader, fechaNacimientoHeader });
            pasajerosListView.Location = new Point(390, 1108);
            pasajerosListView.Margin = new Padding(4, 5, 4, 5);
            pasajerosListView.MultiSelect = false;
            pasajerosListView.Name = "pasajerosListView";
            pasajerosListView.Size = new Size(1307, 239);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(923, 1073);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 11;
            label2.Text = "Pasajeros";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(893, 172);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(158, 25);
            label4.TabIndex = 12;
            label4.Text = "Vuelos Agregados";
            // 
            // gestionarItinerarioBox
            // 
            gestionarItinerarioBox.Controls.Add(vuelosBtn);
            gestionarItinerarioBox.Controls.Add(clienteBtn);
            gestionarItinerarioBox.Controls.Add(hotelesBtn);
            gestionarItinerarioBox.Location = new Point(77, 172);
            gestionarItinerarioBox.Margin = new Padding(4, 5, 4, 5);
            gestionarItinerarioBox.Name = "gestionarItinerarioBox";
            gestionarItinerarioBox.Padding = new Padding(4, 5, 4, 5);
            gestionarItinerarioBox.Size = new Size(253, 345);
            gestionarItinerarioBox.TabIndex = 13;
            gestionarItinerarioBox.TabStop = false;
            gestionarItinerarioBox.Text = "Gestionar Itinerario";
            // 
            // vuelosBtn
            // 
            vuelosBtn.Location = new Point(21, 132);
            vuelosBtn.Margin = new Padding(4, 5, 4, 5);
            vuelosBtn.Name = "vuelosBtn";
            vuelosBtn.Size = new Size(207, 85);
            vuelosBtn.TabIndex = 7;
            vuelosBtn.Text = "Agregar/Quitar Vuelos";
            vuelosBtn.UseVisualStyleBackColor = true;
            vuelosBtn.Click += vuelosBtn_Click;
            // 
            // clienteBtn
            // 
            clienteBtn.Location = new Point(21, 37);
            clienteBtn.Margin = new Padding(4, 5, 4, 5);
            clienteBtn.Name = "clienteBtn";
            clienteBtn.Size = new Size(207, 85);
            clienteBtn.TabIndex = 6;
            clienteBtn.Text = "Agregar/Modificar Cliente";
            clienteBtn.UseVisualStyleBackColor = true;
            clienteBtn.Click += clienteBtn_Click;
            // 
            // precioTotalLabel
            // 
            precioTotalLabel.AutoSize = true;
            precioTotalLabel.Location = new Point(451, 63);
            precioTotalLabel.Margin = new Padding(4, 0, 4, 0);
            precioTotalLabel.Name = "precioTotalLabel";
            precioTotalLabel.Size = new Size(139, 25);
            precioTotalLabel.TabIndex = 14;
            precioTotalLabel.Text = "precioTotalLabel";
            // 
            // nombreYApellidoLabel
            // 
            nombreYApellidoLabel.AutoSize = true;
            nombreYApellidoLabel.Location = new Point(183, 15);
            nombreYApellidoLabel.Margin = new Padding(4, 0, 4, 0);
            nombreYApellidoLabel.Name = "nombreYApellidoLabel";
            nombreYApellidoLabel.Size = new Size(157, 25);
            nombreYApellidoLabel.TabIndex = 16;
            nombreYApellidoLabel.Text = "nombre y apellido";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 15);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(167, 25);
            label6.TabIndex = 15;
            label6.Text = "Nombre y Apellido:";
            // 
            // cancelarReservaBtn
            // 
            cancelarReservaBtn.Location = new Point(99, 950);
            cancelarReservaBtn.Margin = new Padding(4, 5, 4, 5);
            cancelarReservaBtn.Name = "cancelarReservaBtn";
            cancelarReservaBtn.Size = new Size(207, 82);
            cancelarReservaBtn.TabIndex = 9;
            cancelarReservaBtn.Text = "Cancelar Reserva";
            cancelarReservaBtn.UseVisualStyleBackColor = true;
            cancelarReservaBtn.Click += cancelarReservaBtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(893, 618);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(165, 25);
            label7.TabIndex = 18;
            label7.Text = "Hoteles Agregados";
            // 
            // hotelesAgregadosListView
            // 
            hotelesAgregadosListView.Columns.AddRange(new ColumnHeader[] { columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader12, columnHeader13, columnHeader14 });
            hotelesAgregadosListView.Location = new Point(390, 648);
            hotelesAgregadosListView.Margin = new Padding(4, 5, 4, 5);
            hotelesAgregadosListView.MultiSelect = false;
            hotelesAgregadosListView.Name = "hotelesAgregadosListView";
            hotelesAgregadosListView.Size = new Size(1307, 389);
            hotelesAgregadosListView.TabIndex = 17;
            hotelesAgregadosListView.UseCompatibleStateImageBehavior = false;
            hotelesAgregadosListView.View = View.Details;
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
            // abonadoLabel
            // 
            abonadoLabel.AutoSize = true;
            abonadoLabel.Location = new Point(641, 63);
            abonadoLabel.Margin = new Padding(4, 0, 4, 0);
            abonadoLabel.Name = "abonadoLabel";
            abonadoLabel.Size = new Size(125, 25);
            abonadoLabel.TabIndex = 19;
            abonadoLabel.Text = "abonadoLabel";
            // 
            // vuelosAgregadosListView
            // 
            vuelosAgregadosListView.Columns.AddRange(new ColumnHeader[] { columnHeader15, columnHeader16, columnHeader17, columnHeader18, columnHeader19, columnHeader20, columnHeader21, columnHeader22, columnHeader23, columnHeader24, columnHeader25 });
            vuelosAgregadosListView.FullRowSelect = true;
            vuelosAgregadosListView.Location = new Point(390, 202);
            vuelosAgregadosListView.Margin = new Padding(4, 5, 4, 5);
            vuelosAgregadosListView.MultiSelect = false;
            vuelosAgregadosListView.Name = "vuelosAgregadosListView";
            vuelosAgregadosListView.Size = new Size(1307, 389);
            vuelosAgregadosListView.TabIndex = 26;
            vuelosAgregadosListView.UseCompatibleStateImageBehavior = false;
            vuelosAgregadosListView.View = View.Details;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "Aerolinea";
            columnHeader15.Width = 80;
            // 
            // columnHeader16
            // 
            columnHeader16.Text = "Origen";
            columnHeader16.Width = 100;
            // 
            // columnHeader17
            // 
            columnHeader17.Text = "Destino";
            columnHeader17.Width = 100;
            // 
            // columnHeader18
            // 
            columnHeader18.Text = "Fecha Salida";
            columnHeader18.Width = 90;
            // 
            // columnHeader19
            // 
            columnHeader19.Text = "Duracion";
            columnHeader19.Width = 70;
            // 
            // columnHeader20
            // 
            columnHeader20.Text = "Clase";
            columnHeader20.Width = 80;
            // 
            // columnHeader21
            // 
            columnHeader21.Text = "Cant. Pasajeros";
            columnHeader21.Width = 90;
            // 
            // columnHeader22
            // 
            columnHeader22.Text = "Precio Total";
            columnHeader22.Width = 90;
            // 
            // columnHeader23
            // 
            columnHeader23.Text = "Precio Adulto";
            // 
            // columnHeader24
            // 
            columnHeader24.Text = "Precio Menor";
            // 
            // columnHeader25
            // 
            columnHeader25.Text = "Precio Infante";
            // 
            // MenuItinerarioForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1919, 1440);
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
            Margin = new Padding(4, 5, 4, 5);
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
        private Label label5;
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
        private ColumnHeader columnHeader15;
        private ColumnHeader columnHeader16;
        private ColumnHeader columnHeader17;
        private ColumnHeader columnHeader18;
        private ColumnHeader columnHeader19;
        private ColumnHeader columnHeader20;
        private ColumnHeader columnHeader21;
        private ColumnHeader columnHeader22;
        private ColumnHeader columnHeader23;
        private ColumnHeader columnHeader24;
        private ColumnHeader columnHeader25;
    }
}