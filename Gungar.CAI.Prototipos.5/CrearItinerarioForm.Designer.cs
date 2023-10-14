namespace Gungar.CAI.Prototipos._5
{
    partial class CrearItinerarioForm
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
            nuevoItinerarioBox = new GroupBox();
            label5 = new Label();
            label6 = new Label();
            apellidoText = new TextBox();
            label3 = new Label();
            nuevoPasajeroText = new TextBox();
            label1 = new Label();
            button1 = new Button();
            continuarBtn = new Button();
            documentoText = new TextBox();
            nuevoItinerarioBox.SuspendLayout();
            SuspendLayout();
            // 
            // nuevoItinerarioBox
            // 
            nuevoItinerarioBox.Controls.Add(documentoText);
            nuevoItinerarioBox.Controls.Add(label5);
            nuevoItinerarioBox.Controls.Add(label6);
            nuevoItinerarioBox.Controls.Add(apellidoText);
            nuevoItinerarioBox.Controls.Add(label3);
            nuevoItinerarioBox.Controls.Add(nuevoPasajeroText);
            nuevoItinerarioBox.Location = new Point(51, 65);
            nuevoItinerarioBox.Name = "nuevoItinerarioBox";
            nuevoItinerarioBox.Size = new Size(308, 237);
            nuevoItinerarioBox.TabIndex = 21;
            nuevoItinerarioBox.TabStop = false;
            nuevoItinerarioBox.Text = "Datos de cliente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 153);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 14;
            label5.Text = "Documento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 99);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 16;
            label6.Text = "Apellido";
            // 
            // apellidoText
            // 
            apellidoText.Location = new Point(28, 117);
            apellidoText.Name = "apellidoText";
            apellidoText.Size = new Size(264, 23);
            apellidoText.TabIndex = 15;
            apellidoText.TextChanged += apellidoText_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 46);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 10;
            label3.Text = "Nombre";
            // 
            // nuevoPasajeroText
            // 
            nuevoPasajeroText.Location = new Point(28, 64);
            nuevoPasajeroText.Name = "nuevoPasajeroText";
            nuevoPasajeroText.Size = new Size(264, 23);
            nuevoPasajeroText.TabIndex = 9;
            nuevoPasajeroText.TextChanged += nuevoPasajeroText_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 27);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 19;
            label1.Text = "Armado de Itinerario";
            // 
            // button1
            // 
            button1.Location = new Point(219, 335);
            button1.Name = "button1";
            button1.Size = new Size(140, 66);
            button1.TabIndex = 22;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // continuarBtn
            // 
            continuarBtn.Enabled = false;
            continuarBtn.Location = new Point(73, 335);
            continuarBtn.Name = "continuarBtn";
            continuarBtn.Size = new Size(140, 66);
            continuarBtn.TabIndex = 20;
            continuarBtn.Text = "Continuar";
            continuarBtn.UseVisualStyleBackColor = true;
            continuarBtn.Click += continuarBtn_Click;
            // 
            // documentoText
            // 
            documentoText.Location = new Point(28, 171);
            documentoText.Name = "documentoText";
            documentoText.Size = new Size(264, 23);
            documentoText.TabIndex = 17;
            documentoText.TextChanged += documentoText_TextChanged;
            // 
            // CrearItinerarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 703);
            Controls.Add(nuevoItinerarioBox);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(continuarBtn);
            Name = "CrearItinerarioForm";
            Text = "CrearItinerarioForm";
            nuevoItinerarioBox.ResumeLayout(false);
            nuevoItinerarioBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox nuevoItinerarioBox;
        private Label label3;
        private TextBox nuevoPasajeroText;
        private Label label1;
        private Button button1;
        private Button continuarBtn;
        private Label label5;
        private Label label6;
        private TextBox apellidoText;
        private TextBox documentoText;
    }
}