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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(115, 169);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(128, 65);
            button1.TabIndex = 0;
            button1.Text = "Armado de Itinerario";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // df
            // 
            df.AutoSize = true;
            df.Location = new Point(226, 123);
            df.Name = "df";
            df.Size = new Size(108, 20);
            df.TabIndex = 2;
            df.Text = "Menu principal";
            // 
            // consultarDisponibilidadBtn
            // 
            consultarDisponibilidadBtn.Location = new Point(307, 169);
            consultarDisponibilidadBtn.Margin = new Padding(3, 4, 3, 4);
            consultarDisponibilidadBtn.Name = "consultarDisponibilidadBtn";
            consultarDisponibilidadBtn.Size = new Size(128, 65);
            consultarDisponibilidadBtn.TabIndex = 3;
            consultarDisponibilidadBtn.Text = "Consultar Disponibilidad";
            consultarDisponibilidadBtn.UseVisualStyleBackColor = true;
            consultarDisponibilidadBtn.Click += consultarDisponibilidadBtn_Click;
            // 
            // agregarPasajerosBtn
            // 
            agregarPasajerosBtn.Location = new Point(115, 265);
            agregarPasajerosBtn.Margin = new Padding(3, 4, 3, 4);
            agregarPasajerosBtn.Name = "agregarPasajerosBtn";
            agregarPasajerosBtn.Size = new Size(128, 65);
            agregarPasajerosBtn.TabIndex = 4;
            agregarPasajerosBtn.Text = "Agregar pasajeros";
            agregarPasajerosBtn.UseVisualStyleBackColor = true;
            agregarPasajerosBtn.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(307, 265);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(128, 65);
            button4.TabIndex = 5;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(115, 367);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(128, 65);
            button5.TabIndex = 6;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(307, 367);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(128, 65);
            button6.TabIndex = 7;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(agregarPasajerosBtn);
            Controls.Add(consultarDisponibilidadBtn);
            Controls.Add(df);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
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
    }
}