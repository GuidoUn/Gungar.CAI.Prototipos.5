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
            nuevoItinerarioBtn = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(101, 127);
            button1.Name = "button1";
            button1.Size = new Size(112, 49);
            button1.TabIndex = 0;
            button1.Text = "Armado de Itinerario";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // df
            // 
            df.AutoSize = true;
            df.Location = new Point(198, 92);
            df.Name = "df";
            df.Size = new Size(87, 15);
            df.TabIndex = 2;
            df.Text = "Menu principal";
            // 
            // nuevoItinerarioBtn
            // 
            nuevoItinerarioBtn.Location = new Point(269, 127);
            nuevoItinerarioBtn.Name = "nuevoItinerarioBtn";
            nuevoItinerarioBtn.Size = new Size(112, 49);
            nuevoItinerarioBtn.TabIndex = 3;
            nuevoItinerarioBtn.Text = "Consultar Disponibilidad";
            nuevoItinerarioBtn.UseVisualStyleBackColor = true;
            nuevoItinerarioBtn.Click += nuevoItinerarioBtn_Click;
            // 
            // button3
            // 
            button3.Location = new Point(101, 199);
            button3.Name = "button3";
            button3.Size = new Size(112, 49);
            button3.TabIndex = 4;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(269, 199);
            button4.Name = "button4";
            button4.Size = new Size(112, 49);
            button4.TabIndex = 5;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(101, 275);
            button5.Name = "button5";
            button5.Size = new Size(112, 49);
            button5.TabIndex = 6;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(269, 275);
            button6.Name = "button6";
            button6.Size = new Size(112, 49);
            button6.TabIndex = 7;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(nuevoItinerarioBtn);
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
        private Button nuevoItinerarioBtn;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}