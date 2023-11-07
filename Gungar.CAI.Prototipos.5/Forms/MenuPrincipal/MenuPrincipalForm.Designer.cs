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
            // consultarVuelosBtn
            // 
            consultarVuelosBtn.Location = new Point(6, 22);
            consultarVuelosBtn.Name = "consultarVuelosBtn";
            consultarVuelosBtn.Size = new Size(112, 49);
            consultarVuelosBtn.TabIndex = 10;
            consultarVuelosBtn.Text = "Consultar Vuelos";
            consultarVuelosBtn.UseVisualStyleBackColor = true;
            consultarVuelosBtn.Click += consultarVuelosBtn_Click;
            // 
            // consultarHotelesBtn
            // 
            consultarHotelesBtn.Location = new Point(6, 77);
            consultarHotelesBtn.Name = "consultarHotelesBtn";
            consultarHotelesBtn.Size = new Size(112, 49);
            consultarHotelesBtn.TabIndex = 11;
            consultarHotelesBtn.Text = "Consultar Hoteles";
            consultarHotelesBtn.UseVisualStyleBackColor = true;
            consultarHotelesBtn.Click += consultarHotelesBtn_Click;
            // 
            // consultasBox
            // 
            consultasBox.Controls.Add(consultarVuelosBtn);
            consultasBox.Controls.Add(consultarHotelesBtn);
            consultasBox.Location = new Point(192, 255);
            consultasBox.Name = "consultasBox";
            consultasBox.Size = new Size(127, 136);
            consultasBox.TabIndex = 12;
            consultasBox.TabStop = false;
            consultasBox.Text = "Consultas";
            // 
            // salirDelSistemaBtn
            // 
            salirDelSistemaBtn.Location = new Point(448, 37);
            salirDelSistemaBtn.Name = "salirDelSistemaBtn";
            salirDelSistemaBtn.Size = new Size(116, 47);
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