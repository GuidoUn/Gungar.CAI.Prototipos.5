namespace Gungar.CAI.Prototipos._5
{
    partial class HotelesForm
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
            groupBox1 = new GroupBox();
            borrarFechasBtn = new Button();
            claseLabel = new Label();
            clasesCombo = new ComboBox();
            aplicarFiltrosBtn = new Button();
            groupBox3 = new GroupBox();
            label1 = new Label();
            hastaPreciosNumeric = new NumericUpDown();
            desdePreciosNumeric = new NumericUpDown();
            label9 = new Label();
            label10 = new Label();
            groupBox2 = new GroupBox();
            cantidadInfantesNumeric = new NumericUpDown();
            cantidadMenoresNumeric = new NumericUpDown();
            cantidadAdultosNumeric = new NumericUpDown();
            label7 = new Label();
            label5 = new Label();
            label6 = new Label();
            label3 = new Label();
            hastaFechaDatePicker = new DateTimePicker();
            destinoText = new TextBox();
            label4 = new Label();
            desdeDatePickerLabel = new Label();
            desdeFechaDatePicker = new DateTimePicker();
            itinerarioLabel = new Label();
            titleLabel = new Label();
            modificarItinerarioBox = new GroupBox();
            hotelesAgregadosListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            agregarProductoBtn = new Button();
            quitarHotelBtn = new Button();
            groupBox4 = new GroupBox();
            hotelesListView = new ListView();
            hotelesHeader = new ColumnHeader();
            NombreHeader = new ColumnHeader();
            disponibilidadHeader = new ColumnHeader();
            direccionHeader = new ColumnHeader();
            estrellasHeader = new ColumnHeader();
            codigoCiudadHeader = new ColumnHeader();
            precioHeader = new ColumnHeader();
            capacidadAdultosHeader = new ColumnHeader();
            capacidadMenoresHeader = new ColumnHeader();
            capacidadInfantesHeader = new ColumnHeader();
            volverBtn = new Button();
            pasajerosEnBusquedaBox = new GroupBox();
            infantesEnBusquedaLabel = new Label();
            menoresEnBusquedaLabel = new Label();
            adultosEnBusquedaLabel = new Label();
            label13 = new Label();
            label14 = new Label();
            label12 = new Label();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hastaPreciosNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)desdePreciosNumeric).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cantidadInfantesNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cantidadMenoresNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cantidadAdultosNumeric).BeginInit();
            modificarItinerarioBox.SuspendLayout();
            groupBox4.SuspendLayout();
            pasajerosEnBusquedaBox.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(borrarFechasBtn);
            groupBox1.Controls.Add(claseLabel);
            groupBox1.Controls.Add(clasesCombo);
            groupBox1.Controls.Add(aplicarFiltrosBtn);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(hastaFechaDatePicker);
            groupBox1.Controls.Add(destinoText);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(desdeDatePickerLabel);
            groupBox1.Controls.Add(desdeFechaDatePicker);
            groupBox1.Location = new Point(14, 44);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(818, 259);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // borrarFechasBtn
            // 
            borrarFechasBtn.Location = new Point(285, 220);
            borrarFechasBtn.Margin = new Padding(3, 4, 3, 4);
            borrarFechasBtn.Name = "borrarFechasBtn";
            borrarFechasBtn.Size = new Size(263, 31);
            borrarFechasBtn.TabIndex = 26;
            borrarFechasBtn.Text = "Borrar Fechas";
            borrarFechasBtn.UseVisualStyleBackColor = true;
            borrarFechasBtn.Click += borrarFechasBtn_Click;
            // 
            // claseLabel
            // 
            claseLabel.AutoSize = true;
            claseLabel.Location = new Point(571, 180);
            claseLabel.Name = "claseLabel";
            claseLabel.Size = new Size(77, 20);
            claseLabel.TabIndex = 24;
            claseLabel.Text = "Categoría:";
            // 
            // clasesCombo
            // 
            clasesCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            clasesCombo.FormattingEnabled = true;
            clasesCombo.Items.AddRange(new object[] { "Todas", "5 Estrellas", "4 Estrellas", "3 Estrellas", "2 Estrellas", "1 Estrella" });
            clasesCombo.Location = new Point(642, 176);
            clasesCombo.Margin = new Padding(3, 4, 3, 4);
            clasesCombo.Name = "clasesCombo";
            clasesCombo.Size = new Size(145, 28);
            clasesCombo.TabIndex = 24;
            // 
            // aplicarFiltrosBtn
            // 
            aplicarFiltrosBtn.Location = new Point(570, 216);
            aplicarFiltrosBtn.Margin = new Padding(3, 4, 3, 4);
            aplicarFiltrosBtn.Name = "aplicarFiltrosBtn";
            aplicarFiltrosBtn.Size = new Size(217, 31);
            aplicarFiltrosBtn.TabIndex = 21;
            aplicarFiltrosBtn.Text = "Aplicar Filtros";
            aplicarFiltrosBtn.UseVisualStyleBackColor = true;
            aplicarFiltrosBtn.Click += aplicarFiltrosBtn_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(hastaPreciosNumeric);
            groupBox3.Controls.Add(desdePreciosNumeric);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new Point(571, 37);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(216, 120);
            groupBox3.TabIndex = 20;
            groupBox3.TabStop = false;
            groupBox3.Text = "Rango de Precios";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, -72);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 25;
            label1.Text = "Itinerario actual";
            // 
            // hastaPreciosNumeric
            // 
            hastaPreciosNumeric.Location = new Point(71, 72);
            hastaPreciosNumeric.Margin = new Padding(3, 4, 3, 4);
            hastaPreciosNumeric.Maximum = new decimal(new int[] { -1593835521, 466537709, 54210, 0 });
            hastaPreciosNumeric.Name = "hastaPreciosNumeric";
            hastaPreciosNumeric.Size = new Size(137, 27);
            hastaPreciosNumeric.TabIndex = 23;
            // 
            // desdePreciosNumeric
            // 
            desdePreciosNumeric.Location = new Point(71, 31);
            desdePreciosNumeric.Margin = new Padding(3, 4, 3, 4);
            desdePreciosNumeric.Maximum = new decimal(new int[] { -1593835521, 466537709, 54210, 0 });
            desdePreciosNumeric.Name = "desdePreciosNumeric";
            desdePreciosNumeric.Size = new Size(137, 27);
            desdePreciosNumeric.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 75);
            label9.Name = "label9";
            label9.Size = new Size(50, 20);
            label9.TabIndex = 15;
            label9.Text = "Hasta:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 33);
            label10.Name = "label10";
            label10.Size = new Size(54, 20);
            label10.TabIndex = 14;
            label10.Text = "Desde:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cantidadInfantesNumeric);
            groupBox2.Controls.Add(cantidadMenoresNumeric);
            groupBox2.Controls.Add(cantidadAdultosNumeric);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(13, 37);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(206, 205);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cantidad de Pasajeros";
            // 
            // cantidadInfantesNumeric
            // 
            cantidadInfantesNumeric.Location = new Point(81, 111);
            cantidadInfantesNumeric.Margin = new Padding(3, 4, 3, 4);
            cantidadInfantesNumeric.Name = "cantidadInfantesNumeric";
            cantidadInfantesNumeric.Size = new Size(106, 27);
            cantidadInfantesNumeric.TabIndex = 26;
            // 
            // cantidadMenoresNumeric
            // 
            cantidadMenoresNumeric.Location = new Point(81, 72);
            cantidadMenoresNumeric.Margin = new Padding(3, 4, 3, 4);
            cantidadMenoresNumeric.Name = "cantidadMenoresNumeric";
            cantidadMenoresNumeric.Size = new Size(106, 27);
            cantidadMenoresNumeric.TabIndex = 25;
            // 
            // cantidadAdultosNumeric
            // 
            cantidadAdultosNumeric.Location = new Point(81, 33);
            cantidadAdultosNumeric.Margin = new Padding(3, 4, 3, 4);
            cantidadAdultosNumeric.Name = "cantidadAdultosNumeric";
            cantidadAdultosNumeric.Size = new Size(106, 27);
            cantidadAdultosNumeric.TabIndex = 24;
            cantidadAdultosNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            cantidadAdultosNumeric.ValueChanged += cantidadAdultosNumeric_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 113);
            label7.Name = "label7";
            label7.Size = new Size(64, 20);
            label7.TabIndex = 18;
            label7.Text = "Infantes:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 75);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 15;
            label5.Text = "Menores:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 33);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 14;
            label6.Text = "Adultos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(225, 187);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 7;
            label3.Text = "Hasta:";
            // 
            // hastaFechaDatePicker
            // 
            hastaFechaDatePicker.Location = new Point(285, 183);
            hastaFechaDatePicker.Margin = new Padding(3, 4, 3, 4);
            hastaFechaDatePicker.Name = "hastaFechaDatePicker";
            hastaFechaDatePicker.Size = new Size(263, 27);
            hastaFechaDatePicker.TabIndex = 6;
            hastaFechaDatePicker.ValueChanged += hastaFechaDatePicker_ValueChanged;
            // 
            // destinoText
            // 
            destinoText.Location = new Point(285, 88);
            destinoText.Margin = new Padding(3, 4, 3, 4);
            destinoText.Name = "destinoText";
            destinoText.Size = new Size(263, 27);
            destinoText.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(225, 92);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 3;
            label4.Text = "Destino:";
            // 
            // desdeDatePickerLabel
            // 
            desdeDatePickerLabel.AutoSize = true;
            desdeDatePickerLabel.Location = new Point(225, 147);
            desdeDatePickerLabel.Name = "desdeDatePickerLabel";
            desdeDatePickerLabel.Size = new Size(54, 20);
            desdeDatePickerLabel.TabIndex = 1;
            desdeDatePickerLabel.Text = "Desde:";
            // 
            // desdeFechaDatePicker
            // 
            desdeFechaDatePicker.Location = new Point(285, 143);
            desdeFechaDatePicker.Margin = new Padding(3, 4, 3, 4);
            desdeFechaDatePicker.Name = "desdeFechaDatePicker";
            desdeFechaDatePicker.Size = new Size(263, 27);
            desdeFechaDatePicker.TabIndex = 0;
            desdeFechaDatePicker.ValueChanged += desdeFechaDatePicker_ValueChanged;
            // 
            // itinerarioLabel
            // 
            itinerarioLabel.AutoSize = true;
            itinerarioLabel.Location = new Point(145, 20);
            itinerarioLabel.Name = "itinerarioLabel";
            itinerarioLabel.Size = new Size(105, 20);
            itinerarioLabel.TabIndex = 9;
            itinerarioLabel.Text = "itinerarioLabel";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(14, 20);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(130, 20);
            titleLabel.TabIndex = 8;
            titleLabel.Text = "Gestionar Hoteles:";
            // 
            // modificarItinerarioBox
            // 
            modificarItinerarioBox.Controls.Add(hotelesAgregadosListView);
            modificarItinerarioBox.Controls.Add(agregarProductoBtn);
            modificarItinerarioBox.Controls.Add(quitarHotelBtn);
            modificarItinerarioBox.Location = new Point(872, 328);
            modificarItinerarioBox.Margin = new Padding(3, 4, 3, 4);
            modificarItinerarioBox.Name = "modificarItinerarioBox";
            modificarItinerarioBox.Padding = new Padding(3, 4, 3, 4);
            modificarItinerarioBox.Size = new Size(600, 633);
            modificarItinerarioBox.TabIndex = 27;
            modificarItinerarioBox.TabStop = false;
            // 
            // hotelesAgregadosListView
            // 
            hotelesAgregadosListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10 });
            hotelesAgregadosListView.FullRowSelect = true;
            hotelesAgregadosListView.Location = new Point(99, 21);
            hotelesAgregadosListView.Margin = new Padding(3, 4, 3, 4);
            hotelesAgregadosListView.Name = "hotelesAgregadosListView";
            hotelesAgregadosListView.Size = new Size(493, 547);
            hotelesAgregadosListView.TabIndex = 25;
            hotelesAgregadosListView.UseCompatibleStateImageBehavior = false;
            hotelesAgregadosListView.View = View.Details;
            hotelesAgregadosListView.SelectedIndexChanged += hotelesAgregadosListView_SelectedIndexChanged_1;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Hotel";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tipo de habitación";
            columnHeader2.TextAlign = HorizontalAlignment.Right;
            columnHeader2.Width = 137;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Disponibilidad";
            columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Direccion";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Estrellas";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Ciudad";
            columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Precio";
            columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Capacidad adultos";
            columnHeader8.Width = 160;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Capacidad menores";
            columnHeader9.Width = 160;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Capacidad infantes";
            columnHeader10.Width = 160;
            // 
            // agregarProductoBtn
            // 
            agregarProductoBtn.Location = new Point(7, 243);
            agregarProductoBtn.Margin = new Padding(3, 4, 3, 4);
            agregarProductoBtn.Name = "agregarProductoBtn";
            agregarProductoBtn.Size = new Size(86, 31);
            agregarProductoBtn.TabIndex = 23;
            agregarProductoBtn.Text = "Agregar";
            agregarProductoBtn.UseVisualStyleBackColor = true;
            agregarProductoBtn.Click += agregarProductoBtn_Click;
            // 
            // quitarHotelBtn
            // 
            quitarHotelBtn.Location = new Point(7, 281);
            quitarHotelBtn.Margin = new Padding(3, 4, 3, 4);
            quitarHotelBtn.Name = "quitarHotelBtn";
            quitarHotelBtn.Size = new Size(86, 31);
            quitarHotelBtn.TabIndex = 22;
            quitarHotelBtn.Text = "Quitar";
            quitarHotelBtn.UseVisualStyleBackColor = true;
            quitarHotelBtn.Click += quitarHotelBtn_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(hotelesListView);
            groupBox4.Location = new Point(14, 328);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(858, 633);
            groupBox4.TabIndex = 28;
            groupBox4.TabStop = false;
            groupBox4.Text = "Hoteles";
            // 
            // hotelesListView
            // 
            hotelesListView.Columns.AddRange(new ColumnHeader[] { hotelesHeader, NombreHeader, disponibilidadHeader, direccionHeader, estrellasHeader, codigoCiudadHeader, precioHeader, capacidadAdultosHeader, capacidadMenoresHeader, capacidadInfantesHeader });
            hotelesListView.FullRowSelect = true;
            hotelesListView.Location = new Point(7, 21);
            hotelesListView.Margin = new Padding(3, 4, 3, 4);
            hotelesListView.Name = "hotelesListView";
            hotelesListView.Size = new Size(844, 547);
            hotelesListView.TabIndex = 24;
            hotelesListView.UseCompatibleStateImageBehavior = false;
            hotelesListView.View = View.Details;
            hotelesListView.SelectedIndexChanged += hotelesListView_SelectedIndexChanged;
            // 
            // hotelesHeader
            // 
            hotelesHeader.Text = "Hotel";
            hotelesHeader.Width = 100;
            // 
            // NombreHeader
            // 
            NombreHeader.Text = "Tipo de habitación";
            NombreHeader.TextAlign = HorizontalAlignment.Right;
            NombreHeader.Width = 137;
            // 
            // disponibilidadHeader
            // 
            disponibilidadHeader.Text = "Disponibilidad";
            disponibilidadHeader.Width = 110;
            // 
            // direccionHeader
            // 
            direccionHeader.Text = "Direccion";
            direccionHeader.Width = 100;
            // 
            // estrellasHeader
            // 
            estrellasHeader.Text = "Estrellas";
            estrellasHeader.Width = 100;
            // 
            // codigoCiudadHeader
            // 
            codigoCiudadHeader.Text = "Ciudad";
            codigoCiudadHeader.Width = 100;
            // 
            // precioHeader
            // 
            precioHeader.Text = "Precio";
            precioHeader.Width = 100;
            // 
            // capacidadAdultosHeader
            // 
            capacidadAdultosHeader.Text = "Capacidad adultos";
            capacidadAdultosHeader.Width = 160;
            // 
            // capacidadMenoresHeader
            // 
            capacidadMenoresHeader.Text = "Capacidad menores";
            capacidadMenoresHeader.Width = 160;
            // 
            // capacidadInfantesHeader
            // 
            capacidadInfantesHeader.Text = "Capacidad infantes";
            capacidadInfantesHeader.Width = 160;
            // 
            // volverBtn
            // 
            volverBtn.Location = new Point(911, 44);
            volverBtn.Margin = new Padding(3, 4, 3, 4);
            volverBtn.Name = "volverBtn";
            volverBtn.Size = new Size(176, 68);
            volverBtn.TabIndex = 31;
            volverBtn.Text = "Volver";
            volverBtn.UseVisualStyleBackColor = true;
            volverBtn.Click += volverBtn_Click;
            // 
            // pasajerosEnBusquedaBox
            // 
            pasajerosEnBusquedaBox.Controls.Add(infantesEnBusquedaLabel);
            pasajerosEnBusquedaBox.Controls.Add(menoresEnBusquedaLabel);
            pasajerosEnBusquedaBox.Controls.Add(adultosEnBusquedaLabel);
            pasajerosEnBusquedaBox.Controls.Add(label13);
            pasajerosEnBusquedaBox.Controls.Add(label14);
            pasajerosEnBusquedaBox.Controls.Add(label12);
            pasajerosEnBusquedaBox.Location = new Point(838, 199);
            pasajerosEnBusquedaBox.Margin = new Padding(2, 3, 2, 3);
            pasajerosEnBusquedaBox.Name = "pasajerosEnBusquedaBox";
            pasajerosEnBusquedaBox.Padding = new Padding(2, 3, 2, 3);
            pasajerosEnBusquedaBox.Size = new Size(190, 104);
            pasajerosEnBusquedaBox.TabIndex = 32;
            pasajerosEnBusquedaBox.TabStop = false;
            pasajerosEnBusquedaBox.Text = "Pasajeros En Busqueda";
            pasajerosEnBusquedaBox.Visible = false;
            // 
            // infantesEnBusquedaLabel
            // 
            infantesEnBusquedaLabel.AutoSize = true;
            infantesEnBusquedaLabel.Location = new Point(72, 63);
            infantesEnBusquedaLabel.Margin = new Padding(2, 0, 2, 0);
            infantesEnBusquedaLabel.Name = "infantesEnBusquedaLabel";
            infantesEnBusquedaLabel.Size = new Size(178, 20);
            infantesEnBusquedaLabel.TabIndex = 37;
            infantesEnBusquedaLabel.Text = "infantesEnBusquedaLabel";
            // 
            // menoresEnBusquedaLabel
            // 
            menoresEnBusquedaLabel.AutoSize = true;
            menoresEnBusquedaLabel.Location = new Point(72, 43);
            menoresEnBusquedaLabel.Margin = new Padding(2, 0, 2, 0);
            menoresEnBusquedaLabel.Name = "menoresEnBusquedaLabel";
            menoresEnBusquedaLabel.Size = new Size(183, 20);
            menoresEnBusquedaLabel.TabIndex = 36;
            menoresEnBusquedaLabel.Text = "menoresEnBusquedaLabel";
            // 
            // adultosEnBusquedaLabel
            // 
            adultosEnBusquedaLabel.AutoSize = true;
            adultosEnBusquedaLabel.Location = new Point(72, 20);
            adultosEnBusquedaLabel.Margin = new Padding(2, 0, 2, 0);
            adultosEnBusquedaLabel.Name = "adultosEnBusquedaLabel";
            adultosEnBusquedaLabel.Size = new Size(175, 20);
            adultosEnBusquedaLabel.TabIndex = 35;
            adultosEnBusquedaLabel.Text = "adultosEnBusquedaLabel";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(5, 43);
            label13.Name = "label13";
            label13.Size = new Size(69, 20);
            label13.TabIndex = 33;
            label13.Text = "Menores:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(5, 20);
            label14.Name = "label14";
            label14.Size = new Size(63, 20);
            label14.TabIndex = 32;
            label14.Text = "Adultos:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(5, 63);
            label12.Name = "label12";
            label12.Size = new Size(64, 20);
            label12.TabIndex = 34;
            label12.Text = "Infantes:";
            // 
            // HotelesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1938, 1032);
            Controls.Add(pasajerosEnBusquedaBox);
            Controls.Add(volverBtn);
            Controls.Add(groupBox4);
            Controls.Add(modificarItinerarioBox);
            Controls.Add(groupBox1);
            Controls.Add(itinerarioLabel);
            Controls.Add(titleLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "HotelesForm";
            Text = "HotelesForm";
            Load += HotelesForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)hastaPreciosNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)desdePreciosNumeric).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cantidadInfantesNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)cantidadMenoresNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)cantidadAdultosNumeric).EndInit();
            modificarItinerarioBox.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            pasajerosEnBusquedaBox.ResumeLayout(false);
            pasajerosEnBusquedaBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label claseLabel;
        private ComboBox clasesCombo;
        private Button aplicarFiltrosBtn;
        private GroupBox groupBox3;
        private Label label1;
        private NumericUpDown hastaPreciosNumeric;
        private NumericUpDown desdePreciosNumeric;
        private Label label9;
        private Label label10;
        private GroupBox groupBox2;
        private NumericUpDown cantidadInfantesNumeric;
        private NumericUpDown cantidadMenoresNumeric;
        private NumericUpDown cantidadAdultosNumeric;
        private Label label7;
        private Label label5;
        private Label label6;
        private Label label3;
        private DateTimePicker hastaFechaDatePicker;
        private TextBox destinoText;
        private Label label4;
        private Label desdeDatePickerLabel;
        private DateTimePicker desdeFechaDatePicker;
        private Label itinerarioLabel;
        private Label titleLabel;
        private GroupBox modificarItinerarioBox;
        private Button agregarProductoBtn;
        private Button quitarHotelBtn;
        private GroupBox groupBox4;
        private ListView hotelesListView;
        private ColumnHeader hotelesHeader;
        private ColumnHeader direccionHeader;
        private ColumnHeader estrellasHeader;
        private ColumnHeader disponibilidadHeader;
        private ColumnHeader NombreHeader;
        private ColumnHeader codigoCiudadHeader;
        private ColumnHeader precioHeader;
        private ColumnHeader capacidadAdultosHeader;
        private ColumnHeader capacidadMenoresHeader;
        private ColumnHeader capacidadInfantesHeader;
        private Button borrarFechasBtn;
        private Button volverBtn;
        private ListView hotelesAgregadosListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private GroupBox pasajerosEnBusquedaBox;
        private Label infantesEnBusquedaLabel;
        private Label menoresEnBusquedaLabel;
        private Label adultosEnBusquedaLabel;
        private Label label13;
        private Label label14;
        private Label label12;
    }
}