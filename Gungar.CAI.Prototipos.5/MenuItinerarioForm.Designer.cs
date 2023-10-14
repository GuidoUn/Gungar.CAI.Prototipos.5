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
            button1 = new Button();
            button2 = new Button();
            estadoLabel = new Label();
            label3 = new Label();
            listView1 = new ListView();
            pasajerosListView = new ListView();
            nombreHeader = new ColumnHeader();
            fechaNacimientoHeader = new ColumnHeader();
            label2 = new Label();
            label4 = new Label();
            gestionarItinerarioBox = new GroupBox();
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
            label1.Location = new Point(21, 21);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 1;
            label1.Text = "Itinerario:";
            // 
            // itinerarioSeleccionadoLabel
            // 
            itinerarioSeleccionadoLabel.AutoSize = true;
            itinerarioSeleccionadoLabel.Location = new Point(79, 22);
            itinerarioSeleccionadoLabel.Name = "itinerarioSeleccionadoLabel";
            itinerarioSeleccionadoLabel.Size = new Size(152, 15);
            itinerarioSeleccionadoLabel.TabIndex = 2;
            itinerarioSeleccionadoLabel.Text = "itinerarioSeleccionadoLabel";
            // 
            // salirBtn
            // 
            salirBtn.Location = new Point(871, 21);
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
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Location = new Point(54, 255);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(177, 142);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Confirmación";
            // 
            // button1
            // 
            button1.Location = new Point(15, 79);
            button1.Name = "button1";
            button1.Size = new Size(145, 49);
            button1.TabIndex = 8;
            button1.Text = "Confirmar Reserva";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(15, 22);
            button2.Name = "button2";
            button2.Size = new Size(145, 51);
            button2.TabIndex = 7;
            button2.Text = "Generar Pre-reserva (48hs)";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new Point(79, 54);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new Size(70, 15);
            estadoLabel.TabIndex = 8;
            estadoLabel.Text = "estadoLabel";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 54);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 7;
            label3.Text = "Estado:";
            // 
            // listView1
            // 
            listView1.Location = new Point(509, 120);
            listView1.Name = "listView1";
            listView1.Size = new Size(478, 301);
            listView1.TabIndex = 9;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // pasajerosListView
            // 
            pasajerosListView.Columns.AddRange(new ColumnHeader[] { nombreHeader, fechaNacimientoHeader });
            pasajerosListView.Location = new Point(259, 125);
            pasajerosListView.MultiSelect = false;
            pasajerosListView.Name = "pasajerosListView";
            pasajerosListView.Size = new Size(244, 296);
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
            // MenuItinerarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 658);
            Controls.Add(gestionarItinerarioBox);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(pasajerosListView);
            Controls.Add(listView1);
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
        private ListView listView1;
        private ListView pasajerosListView;
        private Label label2;
        private Label label4;
        private GroupBox gestionarItinerarioBox;
        private ColumnHeader nombreHeader;
        private ColumnHeader fechaNacimientoHeader;
    }
}