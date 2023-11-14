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
            df.Location = new Point(299, 100);
            df.Margin = new Padding(4, 0, 4, 0);
            df.Name = "df";
            df.Size = new Size(250, 41);
            df.TabIndex = 2;
            df.Text = "Menu principal ⌂";
            df.Click += df_Click;
            // 
            // nuevoItinerarioBtn
            // 
            nuevoItinerarioBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            nuevoItinerarioBtn.Location = new Point(203, 197);
            nuevoItinerarioBtn.Margin = new Padding(4, 5, 4, 5);
            nuevoItinerarioBtn.Name = "nuevoItinerarioBtn";
            nuevoItinerarioBtn.Size = new Size(401, 62);
            nuevoItinerarioBtn.TabIndex = 8;
            nuevoItinerarioBtn.Text = "Crear nuevo itinerario";
            nuevoItinerarioBtn.UseVisualStyleBackColor = true;
            nuevoItinerarioBtn.Click += nuevoItinerarioBtn_Click;
            // 
            // continuarItinerarioBtn
            // 
            continuarItinerarioBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            continuarItinerarioBtn.Location = new Point(203, 269);
            continuarItinerarioBtn.Margin = new Padding(4, 5, 4, 5);
            continuarItinerarioBtn.Name = "continuarItinerarioBtn";
            continuarItinerarioBtn.Size = new Size(401, 62);
            continuarItinerarioBtn.TabIndex = 9;
            continuarItinerarioBtn.Text = "Continuar | Consultar itinerario existente";
            continuarItinerarioBtn.UseVisualStyleBackColor = true;
            continuarItinerarioBtn.Click += continuarItinerarioBtn_Click;
            // 
            // consultarVuelosBtn
            // 
            consultarVuelosBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            consultarVuelosBtn.Location = new Point(21, 40);
            consultarVuelosBtn.Margin = new Padding(4, 5, 4, 5);
            consultarVuelosBtn.Name = "consultarVuelosBtn";
            consultarVuelosBtn.Size = new Size(364, 62);
            consultarVuelosBtn.TabIndex = 10;
            consultarVuelosBtn.Text = "Vuelos";
            consultarVuelosBtn.UseVisualStyleBackColor = true;
            consultarVuelosBtn.Click += consultarVuelosBtn_Click;
            // 
            // consultarHotelesBtn
            // 
            consultarHotelesBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            consultarHotelesBtn.Location = new Point(21, 112);
            consultarHotelesBtn.Margin = new Padding(4, 5, 4, 5);
            consultarHotelesBtn.Name = "consultarHotelesBtn";
            consultarHotelesBtn.Size = new Size(364, 62);
            consultarHotelesBtn.TabIndex = 11;
            consultarHotelesBtn.Text = "Hoteles";
            consultarHotelesBtn.UseVisualStyleBackColor = true;
            consultarHotelesBtn.Click += consultarHotelesBtn_Click;
            // 
            // consultasBox
            // 
            consultasBox.Controls.Add(consultarVuelosBtn);
            consultasBox.Controls.Add(consultarHotelesBtn);
            consultasBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            consultasBox.Location = new Point(203, 378);
            consultasBox.Margin = new Padding(4, 5, 4, 5);
            consultasBox.Name = "consultasBox";
            consultasBox.Padding = new Padding(4, 5, 4, 5);
            consultasBox.Size = new Size(401, 190);
            consultasBox.TabIndex = 12;
            consultasBox.TabStop = false;
            consultasBox.Text = "Consultar disponibilidad";
            // 
            // salirDelSistemaBtn
            // 
            salirDelSistemaBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            salirDelSistemaBtn.Location = new Point(663, 660);
            salirDelSistemaBtn.Margin = new Padding(4, 5, 4, 5);
            salirDelSistemaBtn.Name = "salirDelSistemaBtn";
            salirDelSistemaBtn.Size = new Size(177, 52);
            salirDelSistemaBtn.TabIndex = 13;
            salirDelSistemaBtn.Text = "Salir del sistema";
            salirDelSistemaBtn.UseVisualStyleBackColor = true;
            salirDelSistemaBtn.Click += salirDelSistemaBtn_Click;
            // 
            // MenuPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 747);
            Controls.Add(salirDelSistemaBtn);
            Controls.Add(consultasBox);
            Controls.Add(continuarItinerarioBtn);
            Controls.Add(nuevoItinerarioBtn);
            Controls.Add(df);
            Margin = new Padding(4, 5, 4, 5);
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