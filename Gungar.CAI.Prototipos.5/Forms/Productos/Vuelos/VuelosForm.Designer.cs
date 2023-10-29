namespace Gungar.CAI.Prototipos._5
{
    partial class VuelosForm
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
            soloIdaCheckBox = new CheckBox();
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
            vuelosHotelesBox = new GroupBox();
            hotelesRadio = new RadioButton();
            vuelosRadio = new RadioButton();
            vueltaLabel = new Label();
            vueltaDatePicker = new DateTimePicker();
            destinoText = new TextBox();
            origenText = new TextBox();
            label4 = new Label();
            origenLabel = new Label();
            desdeDatePickerLabel = new Label();
            idaDatePicker = new DateTimePicker();
            itinerarioLabel = new Label();
            titleLabel = new Label();
            modificarItinerarioBox = new GroupBox();
            listView1 = new ListView();
            columnHeader26 = new ColumnHeader();
            columnHeader27 = new ColumnHeader();
            columnHeader28 = new ColumnHeader();
            columnHeader29 = new ColumnHeader();
            columnHeader30 = new ColumnHeader();
            columnHeader31 = new ColumnHeader();
            columnHeader32 = new ColumnHeader();
            columnHeader33 = new ColumnHeader();
            columnHeader36 = new ColumnHeader();
            columnHeader41 = new ColumnHeader();
            agregarProductoBtn = new Button();
            quitarProductoBtn = new Button();
            vuelosIdaBox = new GroupBox();
            vuelosIdaListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader23 = new ColumnHeader();
            columnHeader25 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            vueltaBox = new GroupBox();
            vuelosVueltaListView = new ListView();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            columnHeader34 = new ColumnHeader();
            columnHeader35 = new ColumnHeader();
            columnHeader37 = new ColumnHeader();
            columnHeader24 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader38 = new ColumnHeader();
            columnHeader39 = new ColumnHeader();
            columnHeader40 = new ColumnHeader();
            volverBtn = new Button();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hastaPreciosNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)desdePreciosNumeric).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cantidadInfantesNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cantidadMenoresNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cantidadAdultosNumeric).BeginInit();
            vuelosHotelesBox.SuspendLayout();
            modificarItinerarioBox.SuspendLayout();
            vuelosIdaBox.SuspendLayout();
            vueltaBox.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(borrarFechasBtn);
            groupBox1.Controls.Add(claseLabel);
            groupBox1.Controls.Add(clasesCombo);
            groupBox1.Controls.Add(aplicarFiltrosBtn);
            groupBox1.Controls.Add(soloIdaCheckBox);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(vuelosHotelesBox);
            groupBox1.Controls.Add(vueltaLabel);
            groupBox1.Controls.Add(vueltaDatePicker);
            groupBox1.Controls.Add(destinoText);
            groupBox1.Controls.Add(origenText);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(origenLabel);
            groupBox1.Controls.Add(desdeDatePickerLabel);
            groupBox1.Controls.Add(idaDatePicker);
            groupBox1.Location = new Point(12, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(700, 194);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // borrarFechasBtn
            // 
            borrarFechasBtn.Location = new Point(284, 94);
            borrarFechasBtn.Name = "borrarFechasBtn";
            borrarFechasBtn.Size = new Size(196, 23);
            borrarFechasBtn.TabIndex = 25;
            borrarFechasBtn.Text = "Borrar Fechas";
            borrarFechasBtn.UseVisualStyleBackColor = true;
            borrarFechasBtn.Click += borrarFechasBtn_Click;
            // 
            // claseLabel
            // 
            claseLabel.AutoSize = true;
            claseLabel.Location = new Point(25, 156);
            claseLabel.Name = "claseLabel";
            claseLabel.Size = new Size(38, 15);
            claseLabel.TabIndex = 24;
            claseLabel.Text = "Clase:";
            // 
            // clasesCombo
            // 
            clasesCombo.FormattingEnabled = true;
            clasesCombo.Items.AddRange(new object[] { "Economy", "Premium", "Business", "First" });
            clasesCombo.Location = new Point(77, 153);
            clasesCombo.Name = "clasesCombo";
            clasesCombo.Size = new Size(93, 23);
            clasesCombo.TabIndex = 24;
            // 
            // aplicarFiltrosBtn
            // 
            aplicarFiltrosBtn.Enabled = false;
            aplicarFiltrosBtn.Location = new Point(499, 126);
            aplicarFiltrosBtn.Name = "aplicarFiltrosBtn";
            aplicarFiltrosBtn.Size = new Size(190, 53);
            aplicarFiltrosBtn.TabIndex = 21;
            aplicarFiltrosBtn.Text = "Buscar";
            aplicarFiltrosBtn.UseVisualStyleBackColor = true;
            aplicarFiltrosBtn.Click += aplicarFiltrosBtn_Click;
            // 
            // soloIdaCheckBox
            // 
            soloIdaCheckBox.AutoSize = true;
            soloIdaCheckBox.Location = new Point(197, 97);
            soloIdaCheckBox.Name = "soloIdaCheckBox";
            soloIdaCheckBox.Size = new Size(81, 19);
            soloIdaCheckBox.TabIndex = 22;
            soloIdaCheckBox.Text = "Es solo ida";
            soloIdaCheckBox.UseVisualStyleBackColor = true;
            soloIdaCheckBox.CheckedChanged += soloIdaCheckBox_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(hastaPreciosNumeric);
            groupBox3.Controls.Add(desdePreciosNumeric);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new Point(500, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(189, 90);
            groupBox3.TabIndex = 20;
            groupBox3.TabStop = false;
            groupBox3.Text = "Rango de Precios";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, -54);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 25;
            label1.Text = "Itinerario actual";
            // 
            // hastaPreciosNumeric
            // 
            hastaPreciosNumeric.Location = new Point(62, 54);
            hastaPreciosNumeric.Maximum = new decimal(new int[] { -1593835521, 466537709, 54210, 0 });
            hastaPreciosNumeric.Name = "hastaPreciosNumeric";
            hastaPreciosNumeric.Size = new Size(120, 23);
            hastaPreciosNumeric.TabIndex = 23;
            // 
            // desdePreciosNumeric
            // 
            desdePreciosNumeric.Location = new Point(62, 23);
            desdePreciosNumeric.Maximum = new decimal(new int[] { -1593835521, 466537709, 54210, 0 });
            desdePreciosNumeric.Name = "desdePreciosNumeric";
            desdePreciosNumeric.Size = new Size(120, 23);
            desdePreciosNumeric.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 56);
            label9.Name = "label9";
            label9.Size = new Size(40, 15);
            label9.TabIndex = 15;
            label9.Text = "Hasta:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 25);
            label10.Name = "label10";
            label10.Size = new Size(42, 15);
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
            groupBox2.Location = new Point(6, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(180, 115);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cantidad de Pasajeros";
            // 
            // cantidadInfantesNumeric
            // 
            cantidadInfantesNumeric.Location = new Point(71, 83);
            cantidadInfantesNumeric.Name = "cantidadInfantesNumeric";
            cantidadInfantesNumeric.Size = new Size(93, 23);
            cantidadInfantesNumeric.TabIndex = 26;
            // 
            // cantidadMenoresNumeric
            // 
            cantidadMenoresNumeric.Location = new Point(71, 54);
            cantidadMenoresNumeric.Name = "cantidadMenoresNumeric";
            cantidadMenoresNumeric.Size = new Size(93, 23);
            cantidadMenoresNumeric.TabIndex = 25;
            // 
            // cantidadAdultosNumeric
            // 
            cantidadAdultosNumeric.Location = new Point(71, 25);
            cantidadAdultosNumeric.Name = "cantidadAdultosNumeric";
            cantidadAdultosNumeric.Size = new Size(93, 23);
            cantidadAdultosNumeric.TabIndex = 24;
            cantidadAdultosNumeric.ValueChanged += cantidadAdultosNumeric_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 85);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 18;
            label7.Text = "Infantes:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 56);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 15;
            label5.Text = "Menores:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 25);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 14;
            label6.Text = "Adultos:";
            // 
            // vuelosHotelesBox
            // 
            vuelosHotelesBox.Controls.Add(hotelesRadio);
            vuelosHotelesBox.Controls.Add(vuelosRadio);
            vuelosHotelesBox.Location = new Point(11, 16);
            vuelosHotelesBox.Name = "vuelosHotelesBox";
            vuelosHotelesBox.Size = new Size(0, 0);
            vuelosHotelesBox.TabIndex = 6;
            vuelosHotelesBox.TabStop = false;
            vuelosHotelesBox.Text = "Tipo de producto";
            // 
            // hotelesRadio
            // 
            hotelesRadio.AutoSize = true;
            hotelesRadio.Location = new Point(81, 20);
            hotelesRadio.Name = "hotelesRadio";
            hotelesRadio.Size = new Size(65, 19);
            hotelesRadio.TabIndex = 1;
            hotelesRadio.Text = "Hoteles";
            hotelesRadio.UseVisualStyleBackColor = true;
            // 
            // vuelosRadio
            // 
            vuelosRadio.AutoSize = true;
            vuelosRadio.Checked = true;
            vuelosRadio.Location = new Point(6, 20);
            vuelosRadio.Name = "vuelosRadio";
            vuelosRadio.Size = new Size(60, 19);
            vuelosRadio.TabIndex = 0;
            vuelosRadio.TabStop = true;
            vuelosRadio.Text = "Vuelos";
            vuelosRadio.UseVisualStyleBackColor = true;
            // 
            // vueltaLabel
            // 
            vueltaLabel.AutoSize = true;
            vueltaLabel.Location = new Point(197, 159);
            vueltaLabel.Name = "vueltaLabel";
            vueltaLabel.Size = new Size(43, 15);
            vueltaLabel.TabIndex = 7;
            vueltaLabel.Text = "Vuelta:";
            // 
            // vueltaDatePicker
            // 
            vueltaDatePicker.Location = new Point(249, 156);
            vueltaDatePicker.Name = "vueltaDatePicker";
            vueltaDatePicker.Size = new Size(231, 23);
            vueltaDatePicker.TabIndex = 6;
            vueltaDatePicker.ValueChanged += vueltaDatePicker_ValueChanged;
            // 
            // destinoText
            // 
            destinoText.Location = new Point(249, 63);
            destinoText.Name = "destinoText";
            destinoText.Size = new Size(231, 23);
            destinoText.TabIndex = 5;
            // 
            // origenText
            // 
            origenText.Location = new Point(249, 33);
            origenText.Name = "origenText";
            origenText.Size = new Size(231, 23);
            origenText.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(197, 66);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 3;
            label4.Text = "Destino:";
            // 
            // origenLabel
            // 
            origenLabel.AutoSize = true;
            origenLabel.Location = new Point(197, 36);
            origenLabel.Name = "origenLabel";
            origenLabel.Size = new Size(46, 15);
            origenLabel.TabIndex = 2;
            origenLabel.Text = "Origen:";
            // 
            // desdeDatePickerLabel
            // 
            desdeDatePickerLabel.AutoSize = true;
            desdeDatePickerLabel.Location = new Point(197, 129);
            desdeDatePickerLabel.Name = "desdeDatePickerLabel";
            desdeDatePickerLabel.Size = new Size(26, 15);
            desdeDatePickerLabel.TabIndex = 1;
            desdeDatePickerLabel.Text = "Ida:";
            // 
            // idaDatePicker
            // 
            idaDatePicker.Location = new Point(249, 126);
            idaDatePicker.Name = "idaDatePicker";
            idaDatePicker.Size = new Size(231, 23);
            idaDatePicker.TabIndex = 0;
            idaDatePicker.ValueChanged += idaDatePicker_ValueChanged;
            // 
            // itinerarioLabel
            // 
            itinerarioLabel.AutoSize = true;
            itinerarioLabel.Location = new Point(122, 16);
            itinerarioLabel.Name = "itinerarioLabel";
            itinerarioLabel.Size = new Size(82, 15);
            itinerarioLabel.TabIndex = 9;
            itinerarioLabel.Text = "itinerarioLabel";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(12, 16);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(98, 15);
            titleLabel.TabIndex = 8;
            titleLabel.Text = "Gestionar Vuelos:";
            // 
            // modificarItinerarioBox
            // 
            modificarItinerarioBox.Controls.Add(listView1);
            modificarItinerarioBox.Controls.Add(agregarProductoBtn);
            modificarItinerarioBox.Controls.Add(quitarProductoBtn);
            modificarItinerarioBox.Location = new Point(896, 234);
            modificarItinerarioBox.Name = "modificarItinerarioBox";
            modificarItinerarioBox.Size = new Size(624, 564);
            modificarItinerarioBox.TabIndex = 27;
            modificarItinerarioBox.TabStop = false;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader26, columnHeader27, columnHeader28, columnHeader29, columnHeader30, columnHeader31, columnHeader32, columnHeader33, columnHeader36, columnHeader41 });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(87, 16);
            listView1.Name = "listView1";
            listView1.Size = new Size(531, 542);
            listView1.TabIndex = 25;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader26
            // 
            columnHeader26.Text = "Aerolinea";
            columnHeader26.Width = 80;
            // 
            // columnHeader27
            // 
            columnHeader27.Text = "Origen";
            columnHeader27.Width = 100;
            // 
            // columnHeader28
            // 
            columnHeader28.Text = "Destino";
            columnHeader28.Width = 100;
            // 
            // columnHeader29
            // 
            columnHeader29.Text = "Fecha Salida";
            columnHeader29.Width = 90;
            // 
            // columnHeader30
            // 
            columnHeader30.Text = "Duracion";
            columnHeader30.Width = 70;
            // 
            // columnHeader31
            // 
            columnHeader31.Text = "Clase";
            columnHeader31.Width = 80;
            // 
            // columnHeader32
            // 
            columnHeader32.Text = "Disponibilidad";
            columnHeader32.Width = 90;
            // 
            // columnHeader33
            // 
            columnHeader33.Text = "Precio Adulto";
            columnHeader33.Width = 90;
            // 
            // columnHeader36
            // 
            columnHeader36.Text = "Precio Menor";
            columnHeader36.Width = 90;
            // 
            // columnHeader41
            // 
            columnHeader41.Text = "Precio Infante";
            columnHeader41.Width = 90;
            // 
            // agregarProductoBtn
            // 
            agregarProductoBtn.Location = new Point(6, 182);
            agregarProductoBtn.Name = "agregarProductoBtn";
            agregarProductoBtn.Size = new Size(75, 23);
            agregarProductoBtn.TabIndex = 23;
            agregarProductoBtn.Text = "Agregar";
            agregarProductoBtn.UseVisualStyleBackColor = true;
            // 
            // quitarProductoBtn
            // 
            quitarProductoBtn.Location = new Point(6, 211);
            quitarProductoBtn.Name = "quitarProductoBtn";
            quitarProductoBtn.Size = new Size(75, 23);
            quitarProductoBtn.TabIndex = 22;
            quitarProductoBtn.Text = "Quitar";
            quitarProductoBtn.UseVisualStyleBackColor = true;
            // 
            // vuelosIdaBox
            // 
            vuelosIdaBox.Controls.Add(vuelosIdaListView);
            vuelosIdaBox.Location = new Point(12, 234);
            vuelosIdaBox.Name = "vuelosIdaBox";
            vuelosIdaBox.Size = new Size(878, 274);
            vuelosIdaBox.TabIndex = 28;
            vuelosIdaBox.TabStop = false;
            vuelosIdaBox.Text = "Ida";
            // 
            // vuelosIdaListView
            // 
            vuelosIdaListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader9, columnHeader23, columnHeader25, columnHeader10, columnHeader11, columnHeader12 });
            vuelosIdaListView.FullRowSelect = true;
            vuelosIdaListView.Location = new Point(11, 16);
            vuelosIdaListView.Name = "vuelosIdaListView";
            vuelosIdaListView.Size = new Size(861, 252);
            vuelosIdaListView.TabIndex = 24;
            vuelosIdaListView.UseCompatibleStateImageBehavior = false;
            vuelosIdaListView.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Aerolinea";
            columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Origen";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Destino";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Fecha Salida";
            columnHeader4.Width = 90;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Duracion";
            columnHeader9.Width = 70;
            // 
            // columnHeader23
            // 
            columnHeader23.Text = "Clase";
            columnHeader23.Width = 80;
            // 
            // columnHeader25
            // 
            columnHeader25.Text = "Disponibilidad";
            columnHeader25.Width = 90;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Precio Adulto";
            columnHeader10.Width = 90;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Precio Menor";
            columnHeader11.Width = 90;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Precio Infante";
            columnHeader12.Width = 90;
            // 
            // vueltaBox
            // 
            vueltaBox.Controls.Add(vuelosVueltaListView);
            vueltaBox.Location = new Point(12, 514);
            vueltaBox.Name = "vueltaBox";
            vueltaBox.Size = new Size(878, 284);
            vueltaBox.TabIndex = 29;
            vueltaBox.TabStop = false;
            vueltaBox.Text = "Vuelta";
            // 
            // vuelosVueltaListView
            // 
            vuelosVueltaListView.Columns.AddRange(new ColumnHeader[] { columnHeader13, columnHeader14, columnHeader34, columnHeader35, columnHeader37, columnHeader24, columnHeader8, columnHeader38, columnHeader39, columnHeader40 });
            vuelosVueltaListView.FullRowSelect = true;
            vuelosVueltaListView.Location = new Point(11, 22);
            vuelosVueltaListView.Name = "vuelosVueltaListView";
            vuelosVueltaListView.Size = new Size(861, 256);
            vuelosVueltaListView.TabIndex = 25;
            vuelosVueltaListView.UseCompatibleStateImageBehavior = false;
            vuelosVueltaListView.View = View.Details;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Aerolinea";
            columnHeader13.Width = 80;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Origen";
            columnHeader14.Width = 100;
            // 
            // columnHeader34
            // 
            columnHeader34.Text = "Destino";
            columnHeader34.Width = 100;
            // 
            // columnHeader35
            // 
            columnHeader35.Text = "Fecha Salida";
            columnHeader35.Width = 90;
            // 
            // columnHeader37
            // 
            columnHeader37.Text = "Duracion";
            columnHeader37.Width = 70;
            // 
            // columnHeader24
            // 
            columnHeader24.Text = "Clase";
            columnHeader24.Width = 80;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Disponibilidad";
            columnHeader8.Width = 90;
            // 
            // columnHeader38
            // 
            columnHeader38.Text = "Precio Adulto";
            columnHeader38.Width = 90;
            // 
            // columnHeader39
            // 
            columnHeader39.Text = "Precio Menor";
            columnHeader39.Width = 90;
            // 
            // columnHeader40
            // 
            columnHeader40.Text = "Precio Infante";
            columnHeader40.Width = 90;
            // 
            // volverBtn
            // 
            volverBtn.Location = new Point(823, 76);
            volverBtn.Name = "volverBtn";
            volverBtn.Size = new Size(154, 51);
            volverBtn.TabIndex = 30;
            volverBtn.Text = "Volver";
            volverBtn.UseVisualStyleBackColor = true;
            volverBtn.Click += volverBtn_Click;
            // 
            // VuelosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1560, 826);
            Controls.Add(volverBtn);
            Controls.Add(vueltaBox);
            Controls.Add(vuelosIdaBox);
            Controls.Add(modificarItinerarioBox);
            Controls.Add(groupBox1);
            Controls.Add(itinerarioLabel);
            Controls.Add(titleLabel);
            Name = "VuelosForm";
            Text = "Vuelos";
            Load += VuelosForm_Load;
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
            vuelosHotelesBox.ResumeLayout(false);
            vuelosHotelesBox.PerformLayout();
            modificarItinerarioBox.ResumeLayout(false);
            vuelosIdaBox.ResumeLayout(false);
            vueltaBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label claseLabel;
        private ComboBox clasesCombo;
        private Button aplicarFiltrosBtn;
        private CheckBox soloIdaCheckBox;
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
        private GroupBox vuelosHotelesBox;
        private RadioButton hotelesRadio;
        private RadioButton vuelosRadio;
        private Label vueltaLabel;
        private DateTimePicker vueltaDatePicker;
        private TextBox destinoText;
        private TextBox origenText;
        private Label label4;
        private Label origenLabel;
        private Label desdeDatePickerLabel;
        private DateTimePicker idaDatePicker;
        private Label itinerarioLabel;
        private Label titleLabel;
        private GroupBox modificarItinerarioBox;
        private Button agregarProductoBtn;
        private Button quitarProductoBtn;
        private GroupBox vuelosIdaBox;
        private ListView vuelosIdaListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private GroupBox vueltaBox;
        private ListView vuelosVueltaListView;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader34;
        private ColumnHeader columnHeader35;
        private ColumnHeader columnHeader37;
        private ColumnHeader columnHeader38;
        private ColumnHeader columnHeader39;
        private ColumnHeader columnHeader40;
        private ColumnHeader columnHeader23;
        private ColumnHeader columnHeader24;
        private ColumnHeader columnHeader25;
        private ColumnHeader columnHeader8;
        private ListView listView1;
        private ColumnHeader columnHeader26;
        private ColumnHeader columnHeader27;
        private ColumnHeader columnHeader28;
        private ColumnHeader columnHeader29;
        private ColumnHeader columnHeader30;
        private ColumnHeader columnHeader31;
        private ColumnHeader columnHeader32;
        private ColumnHeader columnHeader33;
        private ColumnHeader columnHeader36;
        private ColumnHeader columnHeader41;
        private Button borrarFechasBtn;
        private Button volverBtn;
    }
}