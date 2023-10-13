namespace Gungar.CAI.Prototipos._5
{
    partial class GestionProductosItinerarioForm
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
            label1 = new Label();
            itinerarioLabel = new Label();
            listView1 = new ListView();
            listView2 = new ListView();
            aerolineaHeader = new ColumnHeader();
            salidaDateHeader = new ColumnHeader();
            arriboHeader = new ColumnHeader();
            duracionVueloHeader = new ColumnHeader();
            precioHeader = new ColumnHeader();
            button1 = new Button();
            vuelosHotelesBox = new GroupBox();
            hotelesRadio = new RadioButton();
            vuelosRadio = new RadioButton();
            groupBox1 = new GroupBox();
            claseLabel = new Label();
            clasesCombo = new ComboBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            groupBox3 = new GroupBox();
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
            origenText = new TextBox();
            label4 = new Label();
            origenLabel = new Label();
            desdeDatePickerLabel = new Label();
            desdeFechaDatePicker = new DateTimePicker();
            aplicarFiltrosBtn = new Button();
            button3 = new Button();
            listasVuelosBox = new GroupBox();
            vueltaBox = new GroupBox();
            groupBox7 = new GroupBox();
            listView4 = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            listView3 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            vuelosHotelesBox.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hastaPreciosNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)desdePreciosNumeric).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cantidadInfantesNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cantidadMenoresNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cantidadAdultosNumeric).BeginInit();
            listasVuelosBox.SuspendLayout();
            vueltaBox.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 16);
            label1.Name = "label1";
            label1.Size = new Size(157, 15);
            label1.TabIndex = 0;
            label1.Text = "Gestión Productos Itinerario:";
            // 
            // itinerarioLabel
            // 
            itinerarioLabel.AutoSize = true;
            itinerarioLabel.Location = new Point(189, 16);
            itinerarioLabel.Name = "itinerarioLabel";
            itinerarioLabel.Size = new Size(82, 15);
            itinerarioLabel.TabIndex = 2;
            itinerarioLabel.Text = "itinerarioLabel";
            // 
            // listView1
            // 
            listView1.Location = new Point(773, 149);
            listView1.Name = "listView1";
            listView1.Size = new Size(490, 403);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { aerolineaHeader, salidaDateHeader, arriboHeader, duracionVueloHeader, precioHeader });
            listView2.Location = new Point(6, 17);
            listView2.Name = "listView2";
            listView2.Size = new Size(704, 192);
            listView2.TabIndex = 4;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // aerolineaHeader
            // 
            aerolineaHeader.Text = "Aerolinea";
            aerolineaHeader.Width = 100;
            // 
            // salidaDateHeader
            // 
            salidaDateHeader.Text = "Fecha de Salida";
            salidaDateHeader.Width = 170;
            // 
            // arriboHeader
            // 
            arriboHeader.Text = "Fecha de Arribo";
            arriboHeader.Width = 170;
            // 
            // duracionVueloHeader
            // 
            duracionVueloHeader.Text = "Duracion";
            duracionVueloHeader.Width = 100;
            // 
            // precioHeader
            // 
            precioHeader.Text = "Precio";
            precioHeader.Width = 100;
            // 
            // button1
            // 
            button1.Location = new Point(24, 757);
            button1.Name = "button1";
            button1.Size = new Size(128, 44);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // vuelosHotelesBox
            // 
            vuelosHotelesBox.Controls.Add(hotelesRadio);
            vuelosHotelesBox.Controls.Add(vuelosRadio);
            vuelosHotelesBox.Location = new Point(11, 22);
            vuelosHotelesBox.Name = "vuelosHotelesBox";
            vuelosHotelesBox.Size = new Size(180, 45);
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
            vuelosRadio.CheckedChanged += vuelosRadio_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(claseLabel);
            groupBox1.Controls.Add(clasesCombo);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(vuelosHotelesBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(hastaFechaDatePicker);
            groupBox1.Controls.Add(destinoText);
            groupBox1.Controls.Add(origenText);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(origenLabel);
            groupBox1.Controls.Add(desdeDatePickerLabel);
            groupBox1.Controls.Add(desdeFechaDatePicker);
            groupBox1.Location = new Point(24, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(716, 194);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // claseLabel
            // 
            claseLabel.AutoSize = true;
            claseLabel.Location = new Point(500, 153);
            claseLabel.Name = "claseLabel";
            claseLabel.Size = new Size(38, 15);
            claseLabel.TabIndex = 24;
            claseLabel.Text = "Clase:";
            // 
            // clasesCombo
            // 
            clasesCombo.FormattingEnabled = true;
            clasesCombo.Items.AddRange(new object[] { "Economy", "Premium", "Business", "First" });
            clasesCombo.Location = new Point(541, 150);
            clasesCombo.Name = "clasesCombo";
            clasesCombo.Size = new Size(141, 23);
            clasesCombo.TabIndex = 24;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(284, 102);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(141, 19);
            checkBox2.TabIndex = 23;
            checkBox2.Text = "Tengo fechas flexibles";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(197, 102);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(81, 19);
            checkBox1.TabIndex = 22;
            checkBox1.Text = "Es solo ida";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(hastaPreciosNumeric);
            groupBox3.Controls.Add(desdePreciosNumeric);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new Point(500, 28);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(189, 90);
            groupBox3.TabIndex = 20;
            groupBox3.TabStop = false;
            groupBox3.Text = "Rango de Precios";
            // 
            // hastaPreciosNumeric
            // 
            hastaPreciosNumeric.Location = new Point(62, 54);
            hastaPreciosNumeric.Name = "hastaPreciosNumeric";
            hastaPreciosNumeric.Size = new Size(120, 23);
            hastaPreciosNumeric.TabIndex = 23;
            // 
            // desdePreciosNumeric
            // 
            desdePreciosNumeric.Location = new Point(62, 23);
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
            groupBox2.Location = new Point(11, 73);
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(197, 165);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 7;
            label3.Text = "Hasta:";
            // 
            // hastaFechaDatePicker
            // 
            hastaFechaDatePicker.Location = new Point(249, 162);
            hastaFechaDatePicker.Name = "hastaFechaDatePicker";
            hastaFechaDatePicker.Size = new Size(231, 23);
            hastaFechaDatePicker.TabIndex = 6;
            // 
            // destinoText
            // 
            destinoText.Location = new Point(249, 69);
            destinoText.Name = "destinoText";
            destinoText.Size = new Size(231, 23);
            destinoText.TabIndex = 5;
            // 
            // origenText
            // 
            origenText.Location = new Point(249, 39);
            origenText.Name = "origenText";
            origenText.Size = new Size(231, 23);
            origenText.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(197, 72);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 3;
            label4.Text = "Destino:";
            // 
            // origenLabel
            // 
            origenLabel.AutoSize = true;
            origenLabel.Location = new Point(197, 42);
            origenLabel.Name = "origenLabel";
            origenLabel.Size = new Size(46, 15);
            origenLabel.TabIndex = 2;
            origenLabel.Text = "Origen:";
            // 
            // desdeDatePickerLabel
            // 
            desdeDatePickerLabel.AutoSize = true;
            desdeDatePickerLabel.Location = new Point(197, 135);
            desdeDatePickerLabel.Name = "desdeDatePickerLabel";
            desdeDatePickerLabel.Size = new Size(42, 15);
            desdeDatePickerLabel.TabIndex = 1;
            desdeDatePickerLabel.Text = "Desde:";
            // 
            // desdeFechaDatePicker
            // 
            desdeFechaDatePicker.Location = new Point(249, 132);
            desdeFechaDatePicker.Name = "desdeFechaDatePicker";
            desdeFechaDatePicker.Size = new Size(231, 23);
            desdeFechaDatePicker.TabIndex = 0;
            // 
            // aplicarFiltrosBtn
            // 
            aplicarFiltrosBtn.Location = new Point(755, 70);
            aplicarFiltrosBtn.Name = "aplicarFiltrosBtn";
            aplicarFiltrosBtn.Size = new Size(190, 49);
            aplicarFiltrosBtn.TabIndex = 21;
            aplicarFiltrosBtn.Text = "Aplicar Filtros";
            aplicarFiltrosBtn.UseVisualStyleBackColor = true;
            aplicarFiltrosBtn.Click += aplicarFiltrosBtn_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1123, 16);
            button3.Name = "button3";
            button3.Size = new Size(146, 53);
            button3.TabIndex = 8;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            // 
            // listasVuelosBox
            // 
            listasVuelosBox.Controls.Add(vueltaBox);
            listasVuelosBox.Location = new Point(24, 234);
            listasVuelosBox.Name = "listasVuelosBox";
            listasVuelosBox.Size = new Size(716, 439);
            listasVuelosBox.TabIndex = 10;
            listasVuelosBox.TabStop = false;
            // 
            // vueltaBox
            // 
            vueltaBox.Controls.Add(groupBox7);
            vueltaBox.Location = new Point(0, 221);
            vueltaBox.Name = "vueltaBox";
            vueltaBox.Size = new Size(716, 215);
            vueltaBox.TabIndex = 6;
            vueltaBox.TabStop = false;
            vueltaBox.Text = "Vuelta";
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(listView4);
            groupBox7.Location = new Point(0, 215);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(716, 215);
            groupBox7.TabIndex = 5;
            groupBox7.TabStop = false;
            groupBox7.Text = "Ida";
            // 
            // listView4
            // 
            listView4.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6 });
            listView4.Location = new Point(6, 22);
            listView4.Name = "listView4";
            listView4.Size = new Size(704, 187);
            listView4.TabIndex = 4;
            listView4.UseCompatibleStateImageBehavior = false;
            listView4.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.DisplayIndex = 1;
            columnHeader4.Text = "Fecha de Ida";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.DisplayIndex = 0;
            columnHeader5.Text = "Aerolinea";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Fecha de Vuelta";
            columnHeader6.Width = 100;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(groupBox5);
            groupBox4.Controls.Add(listView2);
            groupBox4.Location = new Point(24, 234);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(716, 215);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Ida";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(listView3);
            groupBox5.Location = new Point(0, 215);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(716, 215);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "Ida";
            // 
            // listView3
            // 
            listView3.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView3.Location = new Point(6, 22);
            listView3.Name = "listView3";
            listView3.Size = new Size(704, 187);
            listView3.TabIndex = 4;
            listView3.UseCompatibleStateImageBehavior = false;
            listView3.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.DisplayIndex = 1;
            columnHeader1.Text = "Fecha de Ida";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.DisplayIndex = 0;
            columnHeader2.Text = "Aerolinea";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Fecha de Vuelta";
            columnHeader3.Width = 100;
            // 
            // GestionProductosItinerarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1430, 813);
            Controls.Add(groupBox4);
            Controls.Add(listasVuelosBox);
            Controls.Add(aplicarFiltrosBtn);
            Controls.Add(button3);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(itinerarioLabel);
            Controls.Add(label1);
            Name = "GestionProductosItinerarioForm";
            Text = "GestionProductosItinerarioForm";
            Load += GestionProductosItinerarioForm_Load;
            vuelosHotelesBox.ResumeLayout(false);
            vuelosHotelesBox.PerformLayout();
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
            listasVuelosBox.ResumeLayout(false);
            vueltaBox.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label itinerarioLabel;
        private ListView listView1;
        private ListView listView2;
        private Button button1;
        private GroupBox vuelosHotelesBox;
        private RadioButton hotelesRadio;
        private RadioButton vuelosRadio;
        private GroupBox groupBox1;
        private DateTimePicker desdeFechaDatePicker;
        private Label desdeDatePickerLabel;
        private Label label4;
        private Label origenLabel;
        private TextBox destinoText;
        private TextBox origenText;
        private Label label3;
        private DateTimePicker hastaFechaDatePicker;
        private GroupBox groupBox2;
        private Label label7;
        private Label label5;
        private Label label6;
        private GroupBox groupBox3;
        private Label label9;
        private Label label10;
        private NumericUpDown hastaPreciosNumeric;
        private NumericUpDown desdePreciosNumeric;
        private NumericUpDown cantidadInfantesNumeric;
        private NumericUpDown cantidadMenoresNumeric;
        private NumericUpDown cantidadAdultosNumeric;
        private Button aplicarFiltrosBtn;
        private Button button3;
        private ColumnHeader aerolineaHeader;
        private ColumnHeader salidaDateHeader;
        private CheckBox checkBox1;
        private ColumnHeader arriboHeader;
        private CheckBox checkBox2;
        private GroupBox listasVuelosBox;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private ListView listView3;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private GroupBox vueltaBox;
        private GroupBox groupBox7;
        private ListView listView4;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader precioHeader;
        private ColumnHeader duracionVueloHeader;
        private Label claseLabel;
        private ComboBox clasesCombo;
    }
}