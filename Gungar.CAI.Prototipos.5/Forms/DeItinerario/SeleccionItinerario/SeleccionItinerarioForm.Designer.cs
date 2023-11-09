namespace Gungar.CAI.Prototipos._5
{
    partial class SeleccionItinerarioForm
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
            label2 = new Label();
            button1 = new Button();
            continuarBtn = new Button();
            parametroTextBox = new TextBox();
            origenLabel = new Label();
            filtrarBtn = new Button();
            itinerariosListView = new ListView();
            nroHeader = new ColumnHeader();
            pasajeroHeader = new ColumnHeader();
            documentoHeader = new ColumnHeader();
            creacionHeader = new ColumnHeader();
            estadoHeader = new ColumnHeader();
            label4 = new Label();
            itinerarioSeleccionadoLabel = new Label();
            eliminarItinerarioBtn = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 132);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 19;
            // 
            // button1
            // 
            button1.Location = new Point(1089, 44);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(118, 75);
            button1.TabIndex = 20;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // continuarBtn
            // 
            continuarBtn.Enabled = false;
            continuarBtn.Location = new Point(480, 767);
            continuarBtn.Margin = new Padding(3, 4, 3, 4);
            continuarBtn.Name = "continuarBtn";
            continuarBtn.Size = new Size(198, 113);
            continuarBtn.TabIndex = 21;
            continuarBtn.Text = "Consultar/ Modificar";
            continuarBtn.UseVisualStyleBackColor = true;
            continuarBtn.Click += continuarBtn_Click;
            // 
            // parametroTextBox
            // 
            parametroTextBox.Location = new Point(97, 88);
            parametroTextBox.Margin = new Padding(3, 4, 3, 4);
            parametroTextBox.Name = "parametroTextBox";
            parametroTextBox.Size = new Size(500, 27);
            parametroTextBox.TabIndex = 24;
            // 
            // origenLabel
            // 
            origenLabel.AutoSize = true;
            origenLabel.Location = new Point(97, 64);
            origenLabel.Name = "origenLabel";
            origenLabel.Size = new Size(506, 20);
            origenLabel.TabIndex = 23;
            origenLabel.Text = "Dato de búsqueda (Número de Itinerario, Nombre, Apellido o Documento)";
            // 
            // filtrarBtn
            // 
            filtrarBtn.Location = new Point(606, 88);
            filtrarBtn.Margin = new Padding(3, 4, 3, 4);
            filtrarBtn.Name = "filtrarBtn";
            filtrarBtn.Size = new Size(118, 31);
            filtrarBtn.TabIndex = 27;
            filtrarBtn.Text = "Filtrar";
            filtrarBtn.UseVisualStyleBackColor = true;
            filtrarBtn.Click += filtrarBtn_Click;
            // 
            // itinerariosListView
            // 
            itinerariosListView.Columns.AddRange(new ColumnHeader[] { nroHeader, pasajeroHeader, documentoHeader, creacionHeader, estadoHeader });
            itinerariosListView.FullRowSelect = true;
            itinerariosListView.Location = new Point(97, 163);
            itinerariosListView.Margin = new Padding(3, 4, 3, 4);
            itinerariosListView.MultiSelect = false;
            itinerariosListView.Name = "itinerariosListView";
            itinerariosListView.Size = new Size(985, 531);
            itinerariosListView.TabIndex = 10;
            itinerariosListView.UseCompatibleStateImageBehavior = false;
            itinerariosListView.View = View.Details;
            itinerariosListView.SelectedIndexChanged += itinerariosListView_SelectedIndexChanged;
            // 
            // nroHeader
            // 
            nroHeader.Text = "Nro";
            nroHeader.Width = 100;
            // 
            // pasajeroHeader
            // 
            pasajeroHeader.Text = "Cliente";
            pasajeroHeader.Width = 150;
            // 
            // documentoHeader
            // 
            documentoHeader.Text = "Documento";
            documentoHeader.Width = 100;
            // 
            // creacionHeader
            // 
            creacionHeader.Text = "Fecha de Creación";
            creacionHeader.Width = 150;
            // 
            // estadoHeader
            // 
            estadoHeader.Text = "Estado";
            estadoHeader.Width = 100;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(397, 743);
            label4.Name = "label4";
            label4.Size = new Size(165, 20);
            label4.TabIndex = 12;
            label4.Text = "Itinerario Seleccionado:";
            // 
            // itinerarioSeleccionadoLabel
            // 
            itinerarioSeleccionadoLabel.AutoSize = true;
            itinerarioSeleccionadoLabel.Location = new Point(568, 743);
            itinerarioSeleccionadoLabel.Name = "itinerarioSeleccionadoLabel";
            itinerarioSeleccionadoLabel.Size = new Size(194, 20);
            itinerarioSeleccionadoLabel.TabIndex = 13;
            itinerarioSeleccionadoLabel.Text = "itinerarioSeleccionadoLabel";
            // 
            // eliminarItinerarioBtn
            // 
            eliminarItinerarioBtn.Enabled = false;
            eliminarItinerarioBtn.Location = new Point(1099, 397);
            eliminarItinerarioBtn.Margin = new Padding(3, 4, 3, 4);
            eliminarItinerarioBtn.Name = "eliminarItinerarioBtn";
            eliminarItinerarioBtn.Size = new Size(160, 31);
            eliminarItinerarioBtn.TabIndex = 28;
            eliminarItinerarioBtn.Text = "Eliminar Itinerario";
            eliminarItinerarioBtn.UseVisualStyleBackColor = true;
            eliminarItinerarioBtn.Click += eliminarItinerarioBtn_Click;
            // 
            // SeleccionItinerarioForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1509, 999);
            Controls.Add(eliminarItinerarioBtn);
            Controls.Add(itinerarioSeleccionadoLabel);
            Controls.Add(filtrarBtn);
            Controls.Add(label4);
            Controls.Add(itinerariosListView);
            Controls.Add(parametroTextBox);
            Controls.Add(origenLabel);
            Controls.Add(continuarBtn);
            Controls.Add(button1);
            Controls.Add(label2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SeleccionItinerarioForm";
            Text = "SeleccionItinerarioForm";
            Load += SeleccionItinerarioForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button button1;
        private Button continuarBtn;
        private TextBox origenText;
        private Label origenLabel;
        private Button filtrarBtn;
        private TextBox parametroTextBox;
        private ListView itinerariosListView;
        private ColumnHeader nroHeader;
        private ColumnHeader pasajeroHeader;
        private ColumnHeader documentoHeader;
        private ColumnHeader creacionHeader;
        private ColumnHeader estadoHeader;
        private Label label4;
        private Label itinerarioSeleccionadoLabel;
        private Button eliminarItinerarioBtn;
    }
}