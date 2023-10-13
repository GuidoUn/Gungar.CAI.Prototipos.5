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
            label1.Location = new Point(46, 28);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 3;
            label1.Text = "Armado de Itinerario";
            // 
            // continuarBtn
            // 
            continuarBtn.Enabled = false;
            continuarBtn.Location = new Point(398, 551);
            continuarBtn.Name = "continuarBtn";
            continuarBtn.Size = new Size(140, 66);
            continuarBtn.TabIndex = 10;
            continuarBtn.Text = "Continuar";
            continuarBtn.UseVisualStyleBackColor = true;
            continuarBtn.Click += continuarBtn_Click;
            // 
            // nuevoItinerarioBox
            // 
            nuevoItinerarioBox.Controls.Add(label3);
            nuevoItinerarioBox.Controls.Add(nuevoPasajeroText);
            nuevoItinerarioBox.Location = new Point(46, 131);
            nuevoItinerarioBox.Name = "nuevoItinerarioBox";
            nuevoItinerarioBox.Size = new Size(308, 132);
            nuevoItinerarioBox.TabIndex = 11;
            nuevoItinerarioBox.TabStop = false;
            nuevoItinerarioBox.Text = "Nuevo Itinerario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 46);
            label3.Name = "label3";
            label3.Size = new Size(136, 15);
            label3.TabIndex = 10;
            label3.Text = "Nombre Nuevo Pasajero";
            // 
            // nuevoPasajeroText
            // 
            nuevoPasajeroText.Location = new Point(28, 64);
            nuevoPasajeroText.Name = "nuevoPasajeroText";
            nuevoPasajeroText.Size = new Size(264, 23);
            nuevoPasajeroText.TabIndex = 9;
            nuevoPasajeroText.TextChanged += nuevoPasajeroText_TextChanged;
            // 
            // radioBox
            // 
            radioBox.Controls.Add(continuarItinerarioRadio);
            radioBox.Controls.Add(nuevoItinerarioRadio);
            radioBox.Location = new Point(46, 46);
            radioBox.Name = "radioBox";
            radioBox.Size = new Size(710, 61);
            radioBox.TabIndex = 15;
            radioBox.TabStop = false;
            // 
            // continuarItinerarioRadio
            // 
            continuarItinerarioRadio.AutoSize = true;
            continuarItinerarioRadio.Location = new Point(133, 22);
            continuarItinerarioRadio.Name = "continuarItinerarioRadio";
            continuarItinerarioRadio.Size = new Size(128, 19);
            continuarItinerarioRadio.TabIndex = 16;
            continuarItinerarioRadio.Text = "Continuar Itinerario";
            continuarItinerarioRadio.UseVisualStyleBackColor = true;
            // 
            // nuevoItinerarioRadio
            // 
            nuevoItinerarioRadio.AutoSize = true;
            nuevoItinerarioRadio.Checked = true;
            nuevoItinerarioRadio.Location = new Point(6, 22);
            nuevoItinerarioRadio.Name = "nuevoItinerarioRadio";
            nuevoItinerarioRadio.Size = new Size(110, 19);
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
            continuarItinerarioBox.Location = new Point(46, 300);
            continuarItinerarioBox.Name = "continuarItinerarioBox";
            continuarItinerarioBox.Size = new Size(652, 234);
            continuarItinerarioBox.TabIndex = 16;
            continuarItinerarioBox.TabStop = false;
            continuarItinerarioBox.Text = "Continuar Itinerario";
            // 
            // itinerarioSeleccionadoLabel
            // 
            itinerarioSeleccionadoLabel.AutoSize = true;
            itinerarioSeleccionadoLabel.Location = new Point(156, 204);
            itinerarioSeleccionadoLabel.Name = "itinerarioSeleccionadoLabel";
            itinerarioSeleccionadoLabel.Size = new Size(152, 15);
            itinerarioSeleccionadoLabel.TabIndex = 13;
            itinerarioSeleccionadoLabel.Text = "itinerarioSeleccionadoLabel";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 204);
            label4.Name = "label4";
            label4.Size = new Size(130, 15);
            label4.TabIndex = 12;
            label4.Text = "Itinerario Seleccionado:";
            // 
            // itinerariosListView
            // 
            itinerariosListView.Columns.AddRange(new ColumnHeader[] { nroHeader, pasajeroHeader, creacionHeader });
            itinerariosListView.FullRowSelect = true;
            itinerariosListView.Location = new Point(22, 36);
            itinerariosListView.MultiSelect = false;
            itinerariosListView.Name = "itinerariosListView";
            itinerariosListView.Size = new Size(594, 165);
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
            label2.Location = new Point(46, 282);
            label2.Name = "label2";
            label2.Size = new Size(239, 15);
            label2.TabIndex = 17;
            label2.Text = "TODO: Agregar filtros a Continuar itinerarios";
            // 
            // button1
            // 
            button1.Location = new Point(252, 551);
            button1.Name = "button1";
            button1.Size = new Size(140, 66);
            button1.TabIndex = 18;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 654);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(continuarItinerarioBox);
            Controls.Add(radioBox);
            Controls.Add(nuevoItinerarioBox);
            Controls.Add(continuarBtn);
            Controls.Add(label1);
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