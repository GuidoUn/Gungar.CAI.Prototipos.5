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
            df = new Label();
            button4 = new Button();
            nuevoItinerarioBtn = new Button();
            continuarItinerarioBtn = new Button();
            consultarDisponibilidadBtn = new Button();
            SuspendLayout();
            // 
            // df
            // 
            df.AutoSize = true;
            df.Location = new Point(239, 123);
            df.Name = "df";
            df.Size = new Size(108, 20);
            df.TabIndex = 2;
            df.Text = "Menu principal";
            // 
            // button4
            // 
            button4.Location = new Point(494, 445);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(128, 65);
            button4.TabIndex = 5;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // nuevoItinerarioBtn
            // 
            nuevoItinerarioBtn.Location = new Point(226, 169);
            nuevoItinerarioBtn.Margin = new Padding(3, 4, 3, 4);
            nuevoItinerarioBtn.Name = "nuevoItinerarioBtn";
            nuevoItinerarioBtn.Size = new Size(128, 65);
            nuevoItinerarioBtn.TabIndex = 8;
            nuevoItinerarioBtn.Text = "Nuevo Itinerario";
            nuevoItinerarioBtn.UseVisualStyleBackColor = true;
            nuevoItinerarioBtn.Click += nuevoItinerarioBtn_Click;
            // 
            // continuarItinerarioBtn
            // 
            continuarItinerarioBtn.Location = new Point(226, 243);
            continuarItinerarioBtn.Margin = new Padding(3, 4, 3, 4);
            continuarItinerarioBtn.Name = "continuarItinerarioBtn";
            continuarItinerarioBtn.Size = new Size(128, 65);
            continuarItinerarioBtn.TabIndex = 9;
            continuarItinerarioBtn.Text = "Continuar Itinerario";
            continuarItinerarioBtn.UseVisualStyleBackColor = true;
            continuarItinerarioBtn.Click += continuarItinerarioBtn_Click;
            // 
            // consultarDisponibilidadBtn
            // 
            consultarDisponibilidadBtn.Location = new Point(226, 316);
            consultarDisponibilidadBtn.Margin = new Padding(3, 4, 3, 4);
            consultarDisponibilidadBtn.Name = "consultarDisponibilidadBtn";
            consultarDisponibilidadBtn.Size = new Size(128, 65);
            consultarDisponibilidadBtn.TabIndex = 3;
            consultarDisponibilidadBtn.Text = "Consultar Disponibilidad";
            consultarDisponibilidadBtn.UseVisualStyleBackColor = true;
            consultarDisponibilidadBtn.Click += consultarDisponibilidadBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 598);
            Controls.Add(continuarItinerarioBtn);
            Controls.Add(nuevoItinerarioBtn);
            Controls.Add(consultarDisponibilidadBtn);
            Controls.Add(button4);
            Controls.Add(df);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label df;
        private Button button4;
        private Button nuevoItinerarioBtn;
        private Button continuarItinerarioBtn;
        private Button consultarDisponibilidadBtn;
    }
}