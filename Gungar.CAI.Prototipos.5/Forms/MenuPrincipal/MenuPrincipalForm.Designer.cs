namespace Gungar.CAI.Prototipos._5
{
    partial class MenuPrincipalForm
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
            consultarVuelosBtn = new Button();
            consultarHotelesBtn = new Button();
            consultasBox = new GroupBox();
            salirDelSistemaBtn = new Button();
            consultasBox.SuspendLayout();
            SuspendLayout();
            // 
            // df
            // 
            df.AutoSize = true;
            df.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            df.Location = new Point(201, 67);
            df.Name = "df";
            df.Size = new Size(143, 28);
            df.TabIndex = 2;
            df.Text = "Menu principal";
            df.Click += df_Click;
            // 
            // nuevoItinerarioBtn
            // 
            nuevoItinerarioBtn.Location = new Point(192, 120);
            nuevoItinerarioBtn.Name = "nuevoItinerarioBtn";
            nuevoItinerarioBtn.Size = new Size(161, 37);
            nuevoItinerarioBtn.TabIndex = 8;
            nuevoItinerarioBtn.Text = "Crear nuevo itinerario";
            nuevoItinerarioBtn.UseVisualStyleBackColor = true;
            nuevoItinerarioBtn.Click += nuevoItinerarioBtn_Click;
            // 
            // continuarItinerarioBtn
            // 
            continuarItinerarioBtn.Location = new Point(192, 163);
            continuarItinerarioBtn.Name = "continuarItinerarioBtn";
            continuarItinerarioBtn.Size = new Size(161, 37);
            continuarItinerarioBtn.TabIndex = 9;
            continuarItinerarioBtn.Text = "Continuar Itinerario";
            continuarItinerarioBtn.UseVisualStyleBackColor = true;
            continuarItinerarioBtn.Click += continuarItinerarioBtn_Click;
            // 
            // consultarVuelosBtn
            // 
            consultarVuelosBtn.Location = new Point(12, 22);
            consultarVuelosBtn.Name = "consultarVuelosBtn";
            consultarVuelosBtn.Size = new Size(159, 37);
            consultarVuelosBtn.TabIndex = 10;
            consultarVuelosBtn.Text = "Vuelos";
            consultarVuelosBtn.UseVisualStyleBackColor = true;
            consultarVuelosBtn.Click += consultarVuelosBtn_Click;
            // 
            // consultarHotelesBtn
            // 
            consultarHotelesBtn.Location = new Point(12, 65);
            consultarHotelesBtn.Name = "consultarHotelesBtn";
            consultarHotelesBtn.Size = new Size(159, 37);
            consultarHotelesBtn.TabIndex = 11;
            consultarHotelesBtn.Text = "Hoteles";
            consultarHotelesBtn.UseVisualStyleBackColor = true;
            consultarHotelesBtn.Click += consultarHotelesBtn_Click;
            // 
            // consultasBox
            // 
            consultasBox.Controls.Add(consultarVuelosBtn);
            consultasBox.Controls.Add(consultarHotelesBtn);
            consultasBox.Location = new Point(180, 237);
            consultasBox.Name = "consultasBox";
            consultasBox.Size = new Size(181, 114);
            consultasBox.TabIndex = 12;
            consultasBox.TabStop = false;
            consultasBox.Text = "Buscador";
            // 
            // salirDelSistemaBtn
            // 
            salirDelSistemaBtn.Location = new Point(478, 396);
            salirDelSistemaBtn.Name = "salirDelSistemaBtn";
            salirDelSistemaBtn.Size = new Size(110, 31);
            salirDelSistemaBtn.TabIndex = 13;
            salirDelSistemaBtn.Text = "Salir del Sistema";
            salirDelSistemaBtn.UseVisualStyleBackColor = true;
            salirDelSistemaBtn.Click += salirDelSistemaBtn_Click;
            // 
            // MenuPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 448);
            Controls.Add(salirDelSistemaBtn);
            Controls.Add(consultasBox);
            Controls.Add(continuarItinerarioBtn);
            Controls.Add(nuevoItinerarioBtn);
            Controls.Add(df);
            Name = "MenuPrincipalForm";
            Text = "MenuPrincipal";
            Load += MenuPrincipalForm_Load;
            consultasBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label df;
        private Button nuevoItinerarioBtn;
        private Button continuarItinerarioBtn;
        private Button consultarVuelosBtn;
        private Button consultarHotelesBtn;
        private GroupBox consultasBox;
        private Button salirDelSistemaBtn;
    }
}