namespace Gungar.CAI.Prototipos._5
{
    partial class Form2
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
            continuarBtn = new Button();
            nuevoItinerarioBox = new GroupBox();
            label3 = new Label();
            nuevoPasajeroText = new TextBox();
            radioBox = new GroupBox();
            continuarItinerarioRadio = new RadioButton();
            nuevoItinerarioRadio = new RadioButton();
            continuarItinerarioBox = new GroupBox();
            itinerarioSeleccionadoLabel = new Label();
            label4 = new Label();
            itinerariosListView = new ListView();
            nroHeader = new ColumnHeader();
            pasajeroHeader = new ColumnHeader();
            creacionHeader = new ColumnHeader();
            label2 = new Label();
            button1 = new Button();
            nuevoItinerarioBox.SuspendLayout();
            radioBox.SuspendLayout();
            continuarItinerarioBox.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 37);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 3;
            label1.Text = "Armado de Itinerario";
            // 
            // continuarBtn
            // 
            continuarBtn.Enabled = false;
            continuarBtn.Location = new Point(455, 735);
            continuarBtn.Margin = new Padding(3, 4, 3, 4);
            continuarBtn.Name = "continuarBtn";
            continuarBtn.Size = new Size(160, 88);
            continuarBtn.TabIndex = 10;
            continuarBtn.Text = "Continuar";
            continuarBtn.UseVisualStyleBackColor = true;
            continuarBtn.Click += continuarBtn_Click;
            // 
            // nuevoItinerarioBox
            // 
            nuevoItinerarioBox.Controls.Add(label3);
            nuevoItinerarioBox.Controls.Add(nuevoPasajeroText);
            nuevoItinerarioBox.Location = new Point(53, 175);
            nuevoItinerarioBox.Margin = new Padding(3, 4, 3, 4);
            nuevoItinerarioBox.Name = "nuevoItinerarioBox";
            nuevoItinerarioBox.Padding = new Padding(3, 4, 3, 4);
            nuevoItinerarioBox.Size = new Size(352, 176);
            nuevoItinerarioBox.TabIndex = 11;
            nuevoItinerarioBox.TabStop = false;
            nuevoItinerarioBox.Text = "Nuevo Itinerario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 61);
            label3.Name = "label3";
            label3.Size = new Size(170, 20);
            label3.TabIndex = 10;
            label3.Text = "Nombre Nuevo Pasajero";
            // 
            // nuevoPasajeroText
            // 
            nuevoPasajeroText.Location = new Point(32, 85);
            nuevoPasajeroText.Margin = new Padding(3, 4, 3, 4);
            nuevoPasajeroText.Name = "nuevoPasajeroText";
            nuevoPasajeroText.Size = new Size(301, 27);
            nuevoPasajeroText.TabIndex = 9;
            nuevoPasajeroText.TextChanged += nuevoPasajeroText_TextChanged;
            // 
            // radioBox
            // 
            radioBox.Controls.Add(continuarItinerarioRadio);
            radioBox.Controls.Add(nuevoItinerarioRadio);
            radioBox.Location = new Point(53, 61);
            radioBox.Margin = new Padding(3, 4, 3, 4);
            radioBox.Name = "radioBox";
            radioBox.Padding = new Padding(3, 4, 3, 4);
            radioBox.Size = new Size(811, 81);
            radioBox.TabIndex = 15;
            radioBox.TabStop = false;
            // 
            // continuarItinerarioRadio
            // 
            continuarItinerarioRadio.AutoSize = true;
            continuarItinerarioRadio.Location = new Point(152, 29);
            continuarItinerarioRadio.Margin = new Padding(3, 4, 3, 4);
            continuarItinerarioRadio.Name = "continuarItinerarioRadio";
            continuarItinerarioRadio.Size = new Size(158, 24);
            continuarItinerarioRadio.TabIndex = 16;
            continuarItinerarioRadio.Text = "Continuar Itinerario";
            continuarItinerarioRadio.UseVisualStyleBackColor = true;
            // 
            // nuevoItinerarioRadio
            // 
            nuevoItinerarioRadio.AutoSize = true;
            nuevoItinerarioRadio.Checked = true;
            nuevoItinerarioRadio.Location = new Point(7, 29);
            nuevoItinerarioRadio.Margin = new Padding(3, 4, 3, 4);
            nuevoItinerarioRadio.Name = "nuevoItinerarioRadio";
            nuevoItinerarioRadio.Size = new Size(137, 24);
            nuevoItinerarioRadio.TabIndex = 15;
            nuevoItinerarioRadio.TabStop = true;
            nuevoItinerarioRadio.Text = "Nuevo Itinerario";
            nuevoItinerarioRadio.UseVisualStyleBackColor = true;
            nuevoItinerarioRadio.CheckedChanged += nuevoItinerarioRadio_CheckedChanged;
            // 
            // continuarItinerarioBox
            // 
            continuarItinerarioBox.Controls.Add(itinerarioSeleccionadoLabel);
            continuarItinerarioBox.Controls.Add(label4);
            continuarItinerarioBox.Controls.Add(itinerariosListView);
            continuarItinerarioBox.Enabled = false;
            continuarItinerarioBox.Location = new Point(53, 400);
            continuarItinerarioBox.Margin = new Padding(3, 4, 3, 4);
            continuarItinerarioBox.Name = "continuarItinerarioBox";
            continuarItinerarioBox.Padding = new Padding(3, 4, 3, 4);
            continuarItinerarioBox.Size = new Size(745, 312);
            continuarItinerarioBox.TabIndex = 16;
            continuarItinerarioBox.TabStop = false;
            continuarItinerarioBox.Text = "Continuar Itinerario";
            // 
            // itinerarioSeleccionadoLabel
            // 
            itinerarioSeleccionadoLabel.AutoSize = true;
            itinerarioSeleccionadoLabel.Location = new Point(178, 272);
            itinerarioSeleccionadoLabel.Name = "itinerarioSeleccionadoLabel";
            itinerarioSeleccionadoLabel.Size = new Size(194, 20);
            itinerarioSeleccionadoLabel.TabIndex = 13;
            itinerarioSeleccionadoLabel.Text = "itinerarioSeleccionadoLabel";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 272);
            label4.Name = "label4";
            label4.Size = new Size(165, 20);
            label4.TabIndex = 12;
            label4.Text = "Itinerario Seleccionado:";
            // 
            // itinerariosListView
            // 
            itinerariosListView.Columns.AddRange(new ColumnHeader[] { nroHeader, pasajeroHeader, creacionHeader });
            itinerariosListView.FullRowSelect = true;
            itinerariosListView.Location = new Point(25, 48);
            itinerariosListView.Margin = new Padding(3, 4, 3, 4);
            itinerariosListView.MultiSelect = false;
            itinerariosListView.Name = "itinerariosListView";
            itinerariosListView.Size = new Size(678, 219);
            itinerariosListView.TabIndex = 10;
            itinerariosListView.UseCompatibleStateImageBehavior = false;
            itinerariosListView.View = View.Details;
            itinerariosListView.SelectedIndexChanged += itinerariosListView_SelectedIndexChanged;
            // 
            // nroHeader
            // 
            nroHeader.Text = "Numero de Itinerario";
            nroHeader.Width = 150;
            // 
            // pasajeroHeader
            // 
            pasajeroHeader.Text = "Pasajero";
            pasajeroHeader.Width = 150;
            // 
            // creacionHeader
            // 
            creacionHeader.Text = "Fecha de Creación";
            creacionHeader.Width = 150;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 376);
            label2.Name = "label2";
            label2.Size = new Size(302, 20);
            label2.TabIndex = 17;
            label2.Text = "TODO: Agregar filtros a Continuar itinerarios";
            // 
            // button1
            // 
            button1.Location = new Point(288, 735);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(160, 88);
            button1.TabIndex = 18;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 872);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(continuarItinerarioBox);
            Controls.Add(radioBox);
            Controls.Add(nuevoItinerarioBox);
            Controls.Add(continuarBtn);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            nuevoItinerarioBox.ResumeLayout(false);
            nuevoItinerarioBox.PerformLayout();
            radioBox.ResumeLayout(false);
            radioBox.PerformLayout();
            continuarItinerarioBox.ResumeLayout(false);
            continuarItinerarioBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button continuarBtn;
        private GroupBox nuevoItinerarioBox;
        private Label label3;
        private TextBox nuevoPasajeroText;
        private GroupBox radioBox;
        private RadioButton continuarItinerarioRadio;
        private RadioButton nuevoItinerarioRadio;
        private GroupBox continuarItinerarioBox;
        private Label itinerarioSeleccionadoLabel;
        private Label label4;
        private ListView itinerariosListView;
        private ColumnHeader nroHeader;
        private ColumnHeader pasajeroHeader;
        private ColumnHeader creacionHeader;
        private Label label2;
        private Button button1;
    }
}