namespace Gungar.CAI.Prototipos._5
{
    partial class ClienteForm
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
            telefonoText = new TextBox();
            label4 = new Label();
            emailText = new TextBox();
            label2 = new Label();
            documentoText = new TextBox();
            label5 = new Label();
            label6 = new Label();
            apellidoText = new TextBox();
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
            nuevoItinerarioBox.Controls.Add(telefonoText);
            nuevoItinerarioBox.Controls.Add(label4);
            nuevoItinerarioBox.Controls.Add(emailText);
            nuevoItinerarioBox.Controls.Add(label2);
            nuevoItinerarioBox.Controls.Add(documentoText);
            nuevoItinerarioBox.Controls.Add(label5);
            nuevoItinerarioBox.Controls.Add(label6);
            nuevoItinerarioBox.Controls.Add(apellidoText);
            nuevoItinerarioBox.Controls.Add(label3);
            nuevoItinerarioBox.Controls.Add(nuevoPasajeroText);
            nuevoItinerarioBox.Location = new Point(58, 87);
            nuevoItinerarioBox.Margin = new Padding(3, 4, 3, 4);
            nuevoItinerarioBox.Name = "nuevoItinerarioBox";
            nuevoItinerarioBox.Padding = new Padding(3, 4, 3, 4);
            nuevoItinerarioBox.Size = new Size(334, 401);
            nuevoItinerarioBox.TabIndex = 21;
            nuevoItinerarioBox.TabStop = false;
            nuevoItinerarioBox.Text = "Datos de cliente";
            // 
            // telefonoText
            // 
            telefonoText.Location = new Point(14, 348);
            telefonoText.Margin = new Padding(3, 4, 3, 4);
            telefonoText.Name = "telefonoText";
            telefonoText.Size = new Size(301, 27);
            telefonoText.TabIndex = 21;
            telefonoText.TextChanged += telefonoText_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 324);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 20;
            label4.Text = "Telefono";
            // 
            // emailText
            // 
            emailText.Location = new Point(14, 276);
            emailText.Margin = new Padding(3, 4, 3, 4);
            emailText.Name = "emailText";
            emailText.Size = new Size(301, 27);
            emailText.TabIndex = 19;
            emailText.TextChanged += emailText_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 252);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 18;
            label2.Text = "Email";
            // 
            // documentoText
            // 
            documentoText.Location = new Point(14, 205);
            documentoText.Margin = new Padding(3, 4, 3, 4);
            documentoText.Name = "documentoText";
            documentoText.Size = new Size(301, 27);
            documentoText.TabIndex = 17;
            documentoText.TextChanged += documentoText_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 181);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 14;
            label5.Text = "Documento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 109);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 16;
            label6.Text = "Apellido";
            // 
            // apellidoText
            // 
            apellidoText.Location = new Point(14, 133);
            apellidoText.Margin = new Padding(3, 4, 3, 4);
            apellidoText.Name = "apellidoText";
            apellidoText.Size = new Size(301, 27);
            apellidoText.TabIndex = 15;
            apellidoText.TextChanged += apellidoText_TextChanged;
            apellidoText.KeyPress += apellidoText_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 39);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 10;
            label3.Text = "Nombre";
            // 
            // nuevoPasajeroText
            // 
            nuevoPasajeroText.Location = new Point(14, 63);
            nuevoPasajeroText.Margin = new Padding(3, 4, 3, 4);
            nuevoPasajeroText.Name = "nuevoPasajeroText";
            nuevoPasajeroText.Size = new Size(301, 27);
            nuevoPasajeroText.TabIndex = 9;
            nuevoPasajeroText.TextChanged += nuevoPasajeroText_TextChanged;
            nuevoPasajeroText.KeyPress += nuevoPasajeroText_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 36);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 19;
            label1.Text = "Datos de cliente";
            // 
            // button1
            // 
            button1.Location = new Point(232, 507);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(160, 88);
            button1.TabIndex = 22;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // continuarBtn
            // 
            continuarBtn.Location = new Point(58, 507);
            continuarBtn.Margin = new Padding(3, 4, 3, 4);
            continuarBtn.Name = "continuarBtn";
            continuarBtn.Size = new Size(160, 88);
            continuarBtn.TabIndex = 20;
            continuarBtn.Text = "Continuar";
            continuarBtn.UseVisualStyleBackColor = true;
            continuarBtn.Click += continuarBtn_Click;
            // 
            // ClienteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 937);
            Controls.Add(nuevoItinerarioBox);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(continuarBtn);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ClienteForm";
            Text = "ClienteForm";
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
        private Label label5;
        private Label label6;
        private TextBox apellidoText;
        private TextBox documentoText;
        private TextBox telefonoText;
        private Label label4;
        private TextBox emailText;
        private Label label2;
    }
}