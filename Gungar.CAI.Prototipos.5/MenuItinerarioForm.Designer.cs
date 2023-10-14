namespace Gungar.CAI.Prototipos._5
{
    partial class MenuItinerarioForm
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
            gestionarProductosBtn = new Button();
            label1 = new Label();
            itinerarioSeleccionadoLabel = new Label();
            salirBtn = new Button();
            agregarPasajerosBtn = new Button();
            SuspendLayout();
            // 
            // gestionarProductosBtn
            // 
            gestionarProductosBtn.Location = new Point(94, 103);
            gestionarProductosBtn.Name = "gestionarProductosBtn";
            gestionarProductosBtn.Size = new Size(145, 51);
            gestionarProductosBtn.TabIndex = 0;
            gestionarProductosBtn.Text = "Gestionar Productos";
            gestionarProductosBtn.UseVisualStyleBackColor = true;
            gestionarProductosBtn.Click += gestionarProductosBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 21);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 1;
            label1.Text = "Itinerario:";
            // 
            // itinerarioSeleccionadoLabel
            // 
            itinerarioSeleccionadoLabel.AutoSize = true;
            itinerarioSeleccionadoLabel.Location = new Point(79, 22);
            itinerarioSeleccionadoLabel.Name = "itinerarioSeleccionadoLabel";
            itinerarioSeleccionadoLabel.Size = new Size(152, 15);
            itinerarioSeleccionadoLabel.TabIndex = 2;
            itinerarioSeleccionadoLabel.Text = "itinerarioSeleccionadoLabel";
            // 
            // salirBtn
            // 
            salirBtn.Location = new Point(355, 22);
            salirBtn.Name = "salirBtn";
            salirBtn.Size = new Size(116, 47);
            salirBtn.TabIndex = 3;
            salirBtn.Text = "Salir";
            salirBtn.UseVisualStyleBackColor = true;
            salirBtn.Click += salirBtn_Click;
            // 
            // agregarPasajerosBtn
            // 
            agregarPasajerosBtn.Location = new Point(94, 160);
            agregarPasajerosBtn.Name = "agregarPasajerosBtn";
            agregarPasajerosBtn.Size = new Size(145, 49);
            agregarPasajerosBtn.TabIndex = 5;
            agregarPasajerosBtn.Text = "Agregar pasajeros";
            agregarPasajerosBtn.UseVisualStyleBackColor = true;
            agregarPasajerosBtn.Click += agregarPasajerosBtn_Click;
            // 
            // MenuItinerarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(agregarPasajerosBtn);
            Controls.Add(salirBtn);
            Controls.Add(itinerarioSeleccionadoLabel);
            Controls.Add(label1);
            Controls.Add(gestionarProductosBtn);
            Name = "MenuItinerarioForm";
            Text = "MenuItinerarioForm";
            Load += MenuItinerarioForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button gestionarProductosBtn;
        private Label label1;
        private Label itinerarioSeleccionadoLabel;
        private Button salirBtn;
        private Button agregarPasajerosBtn;
    }
}