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
            continuarItinerarioBox = new GroupBox();
            itinerarioSeleccionadoLabel = new Label();
            label4 = new Label();
            itinerariosListView = new ListView();
            nroHeader = new ColumnHeader();
            pasajeroHeader = new ColumnHeader();
            creacionHeader = new ColumnHeader();
            estadoHeader = new ColumnHeader();
            label2 = new Label();
            button1 = new Button();
            continuarBtn = new Button();
            parametroTextBox = new TextBox();
            origenLabel = new Label();
            filtroLabel = new Label();
            parametrosCombo = new ComboBox();
            filtrarBtn = new Button();
            continuarItinerarioBox.SuspendLayout();
            SuspendLayout();
            // 
            // continuarItinerarioBox
            // 
            continuarItinerarioBox.Controls.Add(itinerarioSeleccionadoLabel);
            continuarItinerarioBox.Controls.Add(label4);
            continuarItinerarioBox.Controls.Add(itinerariosListView);
            continuarItinerarioBox.Location = new Point(74, 117);
            continuarItinerarioBox.Name = "continuarItinerarioBox";
            continuarItinerarioBox.Size = new Size(652, 234);
            continuarItinerarioBox.TabIndex = 18;
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
            itinerariosListView.Columns.AddRange(new ColumnHeader[] { nroHeader, pasajeroHeader, creacionHeader, estadoHeader });
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
            nroHeader.Text = "Nro";
            nroHeader.Width = 100;
            // 
            // pasajeroHeader
            // 
            pasajeroHeader.Text = "Cliente";
            pasajeroHeader.Width = 150;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 99);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 19;
            // 
            // button1
            // 
            button1.Location = new Point(279, 401);
            button1.Name = "button1";
            button1.Size = new Size(103, 56);
            button1.TabIndex = 20;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // continuarBtn
            // 
            continuarBtn.Enabled = false;
            continuarBtn.Location = new Point(388, 401);
            continuarBtn.Name = "continuarBtn";
            continuarBtn.Size = new Size(103, 56);
            continuarBtn.TabIndex = 21;
            continuarBtn.Text = "Consultar/ Modificar";
            continuarBtn.UseVisualStyleBackColor = true;
            continuarBtn.Click += continuarBtn_Click;
            // 
            // parametroTextBox
            // 
            parametroTextBox.Location = new Point(336, 72);
            parametroTextBox.Name = "parametroTextBox";
            parametroTextBox.Size = new Size(231, 23);
            parametroTextBox.TabIndex = 24;
            parametroTextBox.TextChanged += origenText_TextChanged;
            // 
            // origenLabel
            // 
            origenLabel.AutoSize = true;
            origenLabel.Location = new Point(336, 54);
            origenLabel.Name = "origenLabel";
            origenLabel.Size = new Size(187, 15);
            origenLabel.TabIndex = 23;
            origenLabel.Text = "Ingrese el parámetro seleccionado";
            // 
            // filtroLabel
            // 
            filtroLabel.AutoSize = true;
            filtroLabel.Location = new Point(85, 54);
            filtroLabel.Name = "filtroLabel";
            filtroLabel.Size = new Size(204, 15);
            filtroLabel.TabIndex = 25;
            filtroLabel.Text = "Seleccione el parámetro de búsqueda";
            // 
            // parametrosCombo
            // 
            parametrosCombo.FormattingEnabled = true;
            parametrosCombo.Items.AddRange(new object[] { "Sin Filtro", "Nombre", "Documento", "Numero Itininerario" });
            parametrosCombo.Location = new Point(85, 72);
            parametrosCombo.Name = "parametrosCombo";
            parametrosCombo.Size = new Size(204, 23);
            parametrosCombo.TabIndex = 26;
            parametrosCombo.SelectedIndexChanged += parametrosCombo_SelectedIndexChanged;
            // 
            // filtrarBtn
            // 
            filtrarBtn.Enabled = false;
            filtrarBtn.Location = new Point(602, 72);
            filtrarBtn.Name = "filtrarBtn";
            filtrarBtn.Size = new Size(103, 23);
            filtrarBtn.TabIndex = 27;
            filtrarBtn.Text = "Filtrar";
            filtrarBtn.UseVisualStyleBackColor = true;
            filtrarBtn.Click += filtrarBtn_Click;
            // 
            // SeleccionItinerarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1320, 749);
            Controls.Add(filtrarBtn);
            Controls.Add(filtroLabel);
            Controls.Add(parametrosCombo);
            Controls.Add(parametroTextBox);
            Controls.Add(origenLabel);
            Controls.Add(continuarBtn);
            Controls.Add(button1);
            Controls.Add(continuarItinerarioBox);
            Controls.Add(label2);
            Name = "SeleccionItinerarioForm";
            Text = "SeleccionItinerarioForm";
            Load += SeleccionItinerarioForm_Load;
            continuarItinerarioBox.ResumeLayout(false);
            continuarItinerarioBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox continuarItinerarioBox;
        private Label itinerarioSeleccionadoLabel;
        private Label label4;
        private ListView itinerariosListView;
        private ColumnHeader nroHeader;
        private ColumnHeader pasajeroHeader;
        private ColumnHeader creacionHeader;
        private Label label2;
        private Button button1;
        private Button continuarBtn;
        private ColumnHeader estadoHeader;
        private TextBox origenText;
        private Label origenLabel;
        private Label filtroLabel;
        private ComboBox parametrosCombo;
        private Button filtrarBtn;
        private TextBox parametroTextBox;
    }
}