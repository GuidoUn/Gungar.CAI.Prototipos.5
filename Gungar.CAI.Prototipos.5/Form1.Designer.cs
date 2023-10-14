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
            nuevoItinerarioBtn = new Button();
            continuarItinerarioBtn = new Button();
            consultarDisponibilidadBtn = new Button();
            SuspendLayout();
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 448);
            Controls.Add(continuarItinerarioBtn);
            Controls.Add(nuevoItinerarioBtn);
            Controls.Add(consultarDisponibilidadBtn);
            Controls.Add(df);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label df;
        private Button nuevoItinerarioBtn;
        private Button continuarItinerarioBtn;
        private Button consultarDisponibilidadBtn;
    }
}