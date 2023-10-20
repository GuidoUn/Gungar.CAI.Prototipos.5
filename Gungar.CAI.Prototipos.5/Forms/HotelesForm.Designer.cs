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
            precioTotalLabel = new Label();
            agregarProductoBtn = new Button();
            quitarProductoBtn = new Button();
            itinerarioListView = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader17 = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            columnHeader16 = new ColumnHeader();
            columnHeader18 = new ColumnHeader();
            columnHeader19 = new ColumnHeader();
            columnHeader20 = new ColumnHeader();
            columnHeader21 = new ColumnHeader();
            columnHeader22 = new ColumnHeader();
            groupBox4 = new GroupBox();
            hotelesListView = new ListView();
            hotelesHeader = new ColumnHeader();
            direccionHeader = new ColumnHeader();
            estrellasHeader = new ColumnHeader();
            disponibilidadHeader = new ColumnHeader();
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
            groupBox1.Location = new Point(12, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(716, 194);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // claseLabel
            // 
            claseLabel.AutoSize = true;
            claseLabel.Location = new Point(500, 135);
            claseLabel.Name = "claseLabel";
            claseLabel.Size = new Size(61, 15);
            claseLabel.TabIndex = 24;
            claseLabel.Text = "Categoría:";
            // 
            // clasesCombo
            // 
            clasesCombo.FormattingEnabled = true;
            clasesCombo.Items.AddRange(new object[] { "Todas", "5 Estrellas", "4 Estrellas", "3 Estrellas", "2 Estrellas", "1 Estrellas" });
            clasesCombo.Location = new Point(562, 132);
            clasesCombo.Name = "clasesCombo";
            clasesCombo.Size = new Size(127, 23);
            clasesCombo.TabIndex = 24;
            // 
            // aplicarFiltrosBtn
            // 
            aplicarFiltrosBtn.Location = new Point(499, 162);
            aplicarFiltrosBtn.Name = "aplicarFiltrosBtn";
            aplicarFiltrosBtn.Size = new Size(190, 23);
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
            groupBox3.Location = new Point(500, 28);
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
            groupBox2.Location = new Point(11, 28);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(180, 154);
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
            label3.Location = new Point(197, 162);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 7;
            label3.Text = "Hasta:";
            // 
            // hastaFechaDatePicker
            // 
            hastaFechaDatePicker.Location = new Point(249, 159);
            hastaFechaDatePicker.Name = "hastaFechaDatePicker";
            hastaFechaDatePicker.Size = new Size(231, 23);
            hastaFechaDatePicker.TabIndex = 6;
            // 
            // destinoText
            // 
            destinoText.Location = new Point(249, 81);
            destinoText.Name = "destinoText";
            destinoText.Size = new Size(231, 23);
            destinoText.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(197, 84);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 3;
            label4.Text = "Destino:";
            // 
            // desdeDatePickerLabel
            // 
            desdeDatePickerLabel.AutoSize = true;
            desdeDatePickerLabel.Location = new Point(197, 132);
            desdeDatePickerLabel.Name = "desdeDatePickerLabel";
            desdeDatePickerLabel.Size = new Size(42, 15);
            desdeDatePickerLabel.TabIndex = 1;
            desdeDatePickerLabel.Text = "Desde:";
            // 
            // desdeFechaDatePicker
            // 
            desdeFechaDatePicker.Location = new Point(249, 129);
            desdeFechaDatePicker.Name = "desdeFechaDatePicker";
            desdeFechaDatePicker.Size = new Size(231, 23);
            desdeFechaDatePicker.TabIndex = 0;
            // 
            // itinerarioLabel
            // 
            itinerarioLabel.AutoSize = true;
            itinerarioLabel.Location = new Point(177, 15);
            itinerarioLabel.Name = "itinerarioLabel";
            itinerarioLabel.Size = new Size(82, 15);
            itinerarioLabel.TabIndex = 9;
            itinerarioLabel.Text = "itinerarioLabel";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(12, 15);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(157, 15);
            titleLabel.TabIndex = 8;
            titleLabel.Text = "Gestión Productos Itinerario:";
            // 
            // modificarItinerarioBox
            // 
            modificarItinerarioBox.Controls.Add(precioTotalLabel);
            modificarItinerarioBox.Controls.Add(agregarProductoBtn);
            modificarItinerarioBox.Controls.Add(quitarProductoBtn);
            modificarItinerarioBox.Controls.Add(itinerarioListView);
            modificarItinerarioBox.Location = new Point(763, 246);
            modificarItinerarioBox.Name = "modificarItinerarioBox";
            modificarItinerarioBox.Size = new Size(525, 475);
            modificarItinerarioBox.TabIndex = 27;
            modificarItinerarioBox.TabStop = false;
            // 
            // precioTotalLabel
            // 
            precioTotalLabel.AutoSize = true;
            precioTotalLabel.Location = new Point(354, 433);
            precioTotalLabel.Name = "precioTotalLabel";
            precioTotalLabel.Size = new Size(104, 15);
            precioTotalLabel.TabIndex = 27;
            precioTotalLabel.Text = "Precio Total: $1560";
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
            // itinerarioListView
            // 
            itinerarioListView.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6, columnHeader17, columnHeader15, columnHeader16, columnHeader18, columnHeader19, columnHeader20, columnHeader21, columnHeader22 });
            itinerarioListView.Location = new Point(87, 16);
            itinerarioListView.Name = "itinerarioListView";
            itinerarioListView.Size = new Size(591, 411);
            itinerarioListView.TabIndex = 24;
            itinerarioListView.UseCompatibleStateImageBehavior = false;
            itinerarioListView.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Producto";
            columnHeader4.Width = 70;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Prestador";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Cant Pasajeros";
            columnHeader6.Width = 100;
            // 
            // columnHeader17
            // 
            columnHeader17.Text = "Origen/Destino";
            columnHeader17.Width = 100;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "Precio Total";
            // 
            // columnHeader16
            // 
            columnHeader16.Text = "Categoría";
            columnHeader16.Width = 70;
            // 
            // columnHeader18
            // 
            columnHeader18.Text = "Desde";
            // 
            // columnHeader19
            // 
            columnHeader19.Text = "Hasta";
            // 
            // columnHeader20
            // 
            columnHeader20.Text = "Precio Adulto";
            columnHeader20.Width = 100;
            // 
            // columnHeader21
            // 
            columnHeader21.Text = "Precio Menor";
            columnHeader21.Width = 100;
            // 
            // columnHeader22
            // 
            columnHeader22.Text = "Precio Infante";
            columnHeader22.Width = 100;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(hotelesListView);
            groupBox4.Location = new Point(12, 246);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(650, 475);
            groupBox4.TabIndex = 28;
            groupBox4.TabStop = false;
            groupBox4.Text = "Hoteles";
            // 
            // hotelesListView
            // 
            hotelesListView.Columns.AddRange(new ColumnHeader[] { hotelesHeader, direccionHeader, estrellasHeader, disponibilidadHeader });
            hotelesListView.Location = new Point(6, 16);
            hotelesListView.Name = "hotelesListView";
            hotelesListView.Size = new Size(591, 411);
            hotelesListView.TabIndex = 24;
            hotelesListView.UseCompatibleStateImageBehavior = false;
            hotelesListView.View = View.Details;
            // 
            // hotelesHeader
            // 
            hotelesHeader.Text = "Hotel";
            hotelesHeader.Width = 100;
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
            // disponibilidadHeader
            // 
            disponibilidadHeader.Text = "Disponibilidad";
            disponibilidadHeader.Width = 100;
            // 
            // HotelesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(groupBox4);
            Controls.Add(modificarItinerarioBox);
            Controls.Add(groupBox1);
            Controls.Add(itinerarioLabel);
            Controls.Add(titleLabel);
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
            modificarItinerarioBox.PerformLayout();
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
        private Label precioTotalLabel;
        private Button agregarProductoBtn;
        private Button quitarProductoBtn;
        private ListView itinerarioListView;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader17;
        private ColumnHeader columnHeader15;
        private ColumnHeader columnHeader16;
        private ColumnHeader columnHeader18;
        private ColumnHeader columnHeader19;
        private ColumnHeader columnHeader20;
        private ColumnHeader columnHeader21;
        private ColumnHeader columnHeader22;
        private GroupBox groupBox4;
        private ListView hotelesListView;
        private ColumnHeader hotelesHeader;
        private ColumnHeader direccionHeader;
        private ColumnHeader estrellasHeader;
        private ColumnHeader disponibilidadHeader;
    }
}