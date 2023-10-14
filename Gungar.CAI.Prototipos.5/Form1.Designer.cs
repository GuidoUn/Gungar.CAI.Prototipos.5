namespace Gungar.CAI.Prototipos._5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            df = new Label();
            consultarDisponibilidadBtn = new Button();
            agregarPasajerosBtn = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            nuevoItinerarioBtn = new Button();
            continuarItinerarioBtn = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1, 334);
            button1.Name = "button1";
            button1.Size = new Size(112, 49);
            button1.TabIndex = 0;
            button1.Text = "Armado de Itinerario";
            button1.UseVisualStyleBackColor = true;
            // 
            // df
            // 
            df.AutoSize = true;
            df.Location = new Point(209, 92);
            df.Name = "df";
            df.Size = new Size(87, 15);
            df.TabIndex = 2;
            df.Text = "Menu principal";
            // 
            // consultarDisponibilidadBtn
            // 
            consultarDisponibilidadBtn.Location = new Point(198, 237);
            consultarDisponibilidadBtn.Name = "consultarDisponibilidadBtn";
            consultarDisponibilidadBtn.Size = new Size(112, 49);
            consultarDisponibilidadBtn.TabIndex = 3;
            consultarDisponibilidadBtn.Text = "Consultar Disponibilidad";
            consultarDisponibilidadBtn.UseVisualStyleBackColor = true;
            consultarDisponibilidadBtn.Click += consultarDisponibilidadBtn_Click;
            // 
            // agregarPasajerosBtn
            // 
            agregarPasajerosBtn.Location = new Point(590, 334);
            agregarPasajerosBtn.Name = "agregarPasajerosBtn";
            agregarPasajerosBtn.Size = new Size(112, 49);
            agregarPasajerosBtn.TabIndex = 4;
            agregarPasajerosBtn.Text = "Agregar pasajeros";
            agregarPasajerosBtn.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(432, 334);
            button4.Name = "button4";
            button4.Size = new Size(112, 49);
            button4.TabIndex = 5;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(145, 334);
            button5.Name = "button5";
            button5.Size = new Size(112, 49);
            button5.TabIndex = 6;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(282, 334);
            button6.Name = "button6";
            button6.Size = new Size(112, 49);
            button6.TabIndex = 7;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // nuevoItinerarioBtn
            // 
            nuevoItinerarioBtn.Location = new Point(198, 127);
            nuevoItinerarioBtn.Name = "nuevoItinerarioBtn";
            nuevoItinerarioBtn.Size = new Size(112, 49);
            nuevoItinerarioBtn.TabIndex = 8;
            nuevoItinerarioBtn.Text = "Nuevo Itinerario";
            nuevoItinerarioBtn.UseVisualStyleBackColor = true;
            nuevoItinerarioBtn.Click += nuevoItinerarioBtn_Click;
            // 
            // continuarItinerarioBtn
            // 
            continuarItinerarioBtn.Location = new Point(198, 182);
            continuarItinerarioBtn.Name = "continuarItinerarioBtn";
            continuarItinerarioBtn.Size = new Size(112, 49);
            continuarItinerarioBtn.TabIndex = 9;
            continuarItinerarioBtn.Text = "Continuar Itinerario";
            continuarItinerarioBtn.UseVisualStyleBackColor = true;
            continuarItinerarioBtn.Click += continuarItinerarioBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(continuarItinerarioBtn);
            Controls.Add(nuevoItinerarioBtn);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(agregarPasajerosBtn);
            Controls.Add(consultarDisponibilidadBtn);
            Controls.Add(df);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label df;
        private Button consultarDisponibilidadBtn;
        private Button agregarPasajerosBtn;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button nuevoItinerarioBtn;
        private Button continuarItinerarioBtn;
    }
}