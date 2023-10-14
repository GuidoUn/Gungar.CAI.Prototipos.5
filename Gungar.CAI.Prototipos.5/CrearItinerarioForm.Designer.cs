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
            label3 = new Label();
            nuevoPasajeroText = new TextBox();
            label1 = new Label();
            button1 = new Button();
            continuarBtn = new Button();
            nuevoItinerarioBox.SuspendLayout();
            SuspendLayout();
            // 
            // nuevoItinerarioBox
            // 
            nuevoItinerarioBox.Controls.Add(label3);
            nuevoItinerarioBox.Controls.Add(nuevoPasajeroText);
            nuevoItinerarioBox.Location = new Point(51, 65);
            nuevoItinerarioBox.Name = "nuevoItinerarioBox";
            nuevoItinerarioBox.Size = new Size(308, 132);
            nuevoItinerarioBox.TabIndex = 21;
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
            label3.Text = "Nombre Nuevo Cliente";
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
            button1.Location = new Point(69, 220);
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
            continuarBtn.Location = new Point(215, 220);
            continuarBtn.Name = "continuarBtn";
            continuarBtn.Size = new Size(140, 66);
            continuarBtn.TabIndex = 20;
            continuarBtn.Text = "Continuar";
            continuarBtn.UseVisualStyleBackColor = true;
            continuarBtn.Click += continuarBtn_Click;
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
    }
}