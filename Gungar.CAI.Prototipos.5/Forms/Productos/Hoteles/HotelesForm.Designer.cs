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
            agregarProductoBtn = new Button();
            quitarProductoBtn = new Button();
            itinerarioListView = new ListView();
            itinerarioNombreHeader = new ColumnHeader();
            groupBox4 = new GroupBox();
            hotelesListView = new ListView();
            hotelesHeader = new ColumnHeader();
            NombreHeader = new ColumnHeader();
            disponibilidadHeader = new ColumnHeader();
            direccionHeader = new ColumnHeader();
            estrellasHeader = new ColumnHeader();
            codigoCiudadHeader = new ColumnHeader();
            precioHeader = new ColumnHeader();
            fechaHeader = new ColumnHeader();
            capacidadAdultosHeader = new ColumnHeader();
            capacidadMenoresHeader = new ColumnHeader();
            capacidadInfantesHeader = new ColumnHeader();
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
            groupBox1.Location = new Point(17, 55);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(1023, 323);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // borrarFechasBtn
            // 
            borrarFechasBtn.Location = new Point(356, 275);
            borrarFechasBtn.Margin = new Padding(4, 5, 4, 5);
            borrarFechasBtn.Name = "borrarFechasBtn";
            borrarFechasBtn.Size = new Size(329, 38);
            borrarFechasBtn.TabIndex = 26;
            borrarFechasBtn.Text = "Borrar Fechas";
            borrarFechasBtn.UseVisualStyleBackColor = true;
            borrarFechasBtn.Click += borrarFechasBtn_Click;
            // 
            // claseLabel
            // 
            claseLabel.AutoSize = true;
            claseLabel.Location = new Point(714, 225);
            claseLabel.Margin = new Padding(4, 0, 4, 0);
            claseLabel.Name = "claseLabel";
            claseLabel.Size = new Size(92, 25);
            claseLabel.TabIndex = 24;
            claseLabel.Text = "Categoría:";
            // 
            // clasesCombo
            // 
            clasesCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            clasesCombo.FormattingEnabled = true;
            clasesCombo.Items.AddRange(new object[] { "Todas", "5 Estrellas", "4 Estrellas", "3 Estrellas", "2 Estrellas", "1 Estrella" });
            clasesCombo.Location = new Point(803, 220);
            clasesCombo.Margin = new Padding(4, 5, 4, 5);
            clasesCombo.Name = "clasesCombo";
            clasesCombo.Size = new Size(180, 33);
            clasesCombo.TabIndex = 24;
            // 
            // aplicarFiltrosBtn
            // 
            aplicarFiltrosBtn.Location = new Point(713, 270);
            aplicarFiltrosBtn.Margin = new Padding(4, 5, 4, 5);
            aplicarFiltrosBtn.Name = "aplicarFiltrosBtn";
            aplicarFiltrosBtn.Size = new Size(271, 38);
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
            groupBox3.Location = new Point(714, 47);
            groupBox3.Margin = new Padding(4, 5, 4, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 5, 4, 5);
            groupBox3.Size = new Size(270, 150);
            groupBox3.TabIndex = 20;
            groupBox3.TabStop = false;
            groupBox3.Text = "Rango de Precios";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, -90);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(133, 25);
            label1.TabIndex = 25;
            label1.Text = "Itinerario actual";
            // 
            // hastaPreciosNumeric
            // 
            hastaPreciosNumeric.Location = new Point(89, 90);
            hastaPreciosNumeric.Margin = new Padding(4, 5, 4, 5);
            hastaPreciosNumeric.Maximum = new decimal(new int[] { -1593835521, 466537709, 54210, 0 });
            hastaPreciosNumeric.Name = "hastaPreciosNumeric";
            hastaPreciosNumeric.Size = new Size(171, 31);
            hastaPreciosNumeric.TabIndex = 23;
            // 
            // desdePreciosNumeric
            // 
            desdePreciosNumeric.Location = new Point(89, 38);
            desdePreciosNumeric.Margin = new Padding(4, 5, 4, 5);
            desdePreciosNumeric.Maximum = new decimal(new int[] { -1593835521, 466537709, 54210, 0 });
            desdePreciosNumeric.Name = "desdePreciosNumeric";
            desdePreciosNumeric.Size = new Size(171, 31);
            desdePreciosNumeric.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 93);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(61, 25);
            label9.TabIndex = 15;
            label9.Text = "Hasta:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(20, 42);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(66, 25);
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
            groupBox2.Location = new Point(16, 47);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(257, 257);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cantidad de Pasajeros";
            // 
            // cantidadInfantesNumeric
            // 
            cantidadInfantesNumeric.Location = new Point(101, 138);
            cantidadInfantesNumeric.Margin = new Padding(4, 5, 4, 5);
            cantidadInfantesNumeric.Name = "cantidadInfantesNumeric";
            cantidadInfantesNumeric.Size = new Size(133, 31);
            cantidadInfantesNumeric.TabIndex = 26;
            // 
            // cantidadMenoresNumeric
            // 
            cantidadMenoresNumeric.Location = new Point(101, 90);
            cantidadMenoresNumeric.Margin = new Padding(4, 5, 4, 5);
            cantidadMenoresNumeric.Name = "cantidadMenoresNumeric";
            cantidadMenoresNumeric.Size = new Size(133, 31);
            cantidadMenoresNumeric.TabIndex = 25;
            // 
            // cantidadAdultosNumeric
            // 
            cantidadAdultosNumeric.Location = new Point(101, 42);
            cantidadAdultosNumeric.Margin = new Padding(4, 5, 4, 5);
            cantidadAdultosNumeric.Name = "cantidadAdultosNumeric";
            cantidadAdultosNumeric.Size = new Size(133, 31);
            cantidadAdultosNumeric.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 142);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(79, 25);
            label7.TabIndex = 18;
            label7.Text = "Infantes:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 93);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(85, 25);
            label5.TabIndex = 15;
            label5.Text = "Menores:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 42);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(78, 25);
            label6.TabIndex = 14;
            label6.Text = "Adultos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(281, 233);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(61, 25);
            label3.TabIndex = 7;
            label3.Text = "Hasta:";
            // 
            // hastaFechaDatePicker
            // 
            hastaFechaDatePicker.Location = new Point(356, 228);
            hastaFechaDatePicker.Margin = new Padding(4, 5, 4, 5);
            hastaFechaDatePicker.Name = "hastaFechaDatePicker";
            hastaFechaDatePicker.Size = new Size(328, 31);
            hastaFechaDatePicker.TabIndex = 6;
            hastaFechaDatePicker.ValueChanged += hastaFechaDatePicker_ValueChanged;
            // 
            // destinoText
            // 
            destinoText.Location = new Point(356, 110);
            destinoText.Margin = new Padding(4, 5, 4, 5);
            destinoText.Name = "destinoText";
            destinoText.Size = new Size(328, 31);
            destinoText.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(281, 115);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(77, 25);
            label4.TabIndex = 3;
            label4.Text = "Destino:";
            // 
            // desdeDatePickerLabel
            // 
            desdeDatePickerLabel.AutoSize = true;
            desdeDatePickerLabel.Location = new Point(281, 183);
            desdeDatePickerLabel.Margin = new Padding(4, 0, 4, 0);
            desdeDatePickerLabel.Name = "desdeDatePickerLabel";
            desdeDatePickerLabel.Size = new Size(66, 25);
            desdeDatePickerLabel.TabIndex = 1;
            desdeDatePickerLabel.Text = "Desde:";
            // 
            // desdeFechaDatePicker
            // 
            desdeFechaDatePicker.Location = new Point(356, 178);
            desdeFechaDatePicker.Margin = new Padding(4, 5, 4, 5);
            desdeFechaDatePicker.Name = "desdeFechaDatePicker";
            desdeFechaDatePicker.Size = new Size(328, 31);
            desdeFechaDatePicker.TabIndex = 0;
            desdeFechaDatePicker.ValueChanged += desdeFechaDatePicker_ValueChanged;
            // 
            // itinerarioLabel
            // 
            itinerarioLabel.AutoSize = true;
            itinerarioLabel.Location = new Point(181, 25);
            itinerarioLabel.Margin = new Padding(4, 0, 4, 0);
            itinerarioLabel.Name = "itinerarioLabel";
            itinerarioLabel.Size = new Size(122, 25);
            itinerarioLabel.TabIndex = 9;
            itinerarioLabel.Text = "itinerarioLabel";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(17, 25);
            titleLabel.Margin = new Padding(4, 0, 4, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(156, 25);
            titleLabel.TabIndex = 8;
            titleLabel.Text = "Gestionar Hoteles:";
            // 
            // modificarItinerarioBox
            // 
            modificarItinerarioBox.Controls.Add(agregarProductoBtn);
            modificarItinerarioBox.Controls.Add(quitarProductoBtn);
            modificarItinerarioBox.Controls.Add(itinerarioListView);
            modificarItinerarioBox.Location = new Point(1090, 410);
            modificarItinerarioBox.Margin = new Padding(4, 5, 4, 5);
            modificarItinerarioBox.Name = "modificarItinerarioBox";
            modificarItinerarioBox.Padding = new Padding(4, 5, 4, 5);
            modificarItinerarioBox.Size = new Size(750, 792);
            modificarItinerarioBox.TabIndex = 27;
            modificarItinerarioBox.TabStop = false;
            // 
            // agregarProductoBtn
            // 
            agregarProductoBtn.Location = new Point(9, 303);
            agregarProductoBtn.Margin = new Padding(4, 5, 4, 5);
            agregarProductoBtn.Name = "agregarProductoBtn";
            agregarProductoBtn.Size = new Size(107, 38);
            agregarProductoBtn.TabIndex = 23;
            agregarProductoBtn.Text = "Agregar";
            agregarProductoBtn.UseVisualStyleBackColor = true;
            agregarProductoBtn.Click += agregarProductoBtn_Click;
            // 
            // quitarProductoBtn
            // 
            quitarProductoBtn.Location = new Point(9, 352);
            quitarProductoBtn.Margin = new Padding(4, 5, 4, 5);
            quitarProductoBtn.Name = "quitarProductoBtn";
            quitarProductoBtn.Size = new Size(107, 38);
            quitarProductoBtn.TabIndex = 22;
            quitarProductoBtn.Text = "Quitar";
            quitarProductoBtn.UseVisualStyleBackColor = true;
            // 
            // itinerarioListView
            // 
            itinerarioListView.Columns.AddRange(new ColumnHeader[] { itinerarioNombreHeader });
            itinerarioListView.Location = new Point(124, 27);
            itinerarioListView.Margin = new Padding(4, 5, 4, 5);
            itinerarioListView.Name = "itinerarioListView";
            itinerarioListView.Size = new Size(843, 682);
            itinerarioListView.TabIndex = 24;
            itinerarioListView.UseCompatibleStateImageBehavior = false;
            itinerarioListView.View = View.Details;
            // 
            // itinerarioNombreHeader
            // 
            itinerarioNombreHeader.Text = "Nombre";
            itinerarioNombreHeader.Width = 100;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(hotelesListView);
            groupBox4.Location = new Point(17, 410);
            groupBox4.Margin = new Padding(4, 5, 4, 5);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4, 5, 4, 5);
            groupBox4.Size = new Size(1073, 792);
            groupBox4.TabIndex = 28;
            groupBox4.TabStop = false;
            groupBox4.Text = "Hoteles";
            // 
            // hotelesListView
            // 
            hotelesListView.Columns.AddRange(new ColumnHeader[] { hotelesHeader, NombreHeader, disponibilidadHeader, direccionHeader, estrellasHeader, codigoCiudadHeader, precioHeader, fechaHeader, capacidadAdultosHeader, capacidadMenoresHeader, capacidadInfantesHeader });
            hotelesListView.FullRowSelect = true;
            hotelesListView.Location = new Point(9, 27);
            hotelesListView.Margin = new Padding(4, 5, 4, 5);
            hotelesListView.Name = "hotelesListView";
            hotelesListView.Size = new Size(1054, 682);
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
            NombreHeader.Width = 120;
            // 
            // disponibilidadHeader
            // 
            disponibilidadHeader.Text = "Disponibilidad";
            disponibilidadHeader.Width = 100;
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
            // fechaHeader
            // 
            fechaHeader.Text = "Fecha";
            fechaHeader.Width = 100;
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
            // HotelesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1170);
            Controls.Add(groupBox4);
            Controls.Add(modificarItinerarioBox);
            Controls.Add(groupBox1);
            Controls.Add(itinerarioLabel);
            Controls.Add(titleLabel);
            Margin = new Padding(4, 5, 4, 5);
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
        private Button quitarProductoBtn;
        private ListView itinerarioListView;
        private GroupBox groupBox4;
        private ListView hotelesListView;
        private ColumnHeader hotelesHeader;
        private ColumnHeader direccionHeader;
        private ColumnHeader estrellasHeader;
        private ColumnHeader disponibilidadHeader;
        private ColumnHeader NombreHeader;
        private ColumnHeader codigoCiudadHeader;
        private ColumnHeader precioHeader;
        private ColumnHeader fechaHeader;
        private ColumnHeader capacidadAdultosHeader;
        private ColumnHeader capacidadMenoresHeader;
        private ColumnHeader capacidadInfantesHeader;
        private Button borrarFechasBtn;
        private ColumnHeader itinerarioNombreHeader;
    }
}