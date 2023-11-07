using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gungar.CAI.Prototipos._5.Entidades.DeItinerario;
using Gungar.CAI.Prototipos._5.Forms.DeItinerario.Cliente;
using Gungar.CAI.Prototipos._5.Modulos;

namespace Gungar.CAI.Prototipos._5
{
    public partial class ClienteForm : Form
    {
        ClienteFormModel model;

        public ClienteForm()
        {
            InitializeComponent();
        }

        private void ClienteForm_Load(object sender, EventArgs e)
        {
            model = new(VentasModulo.ItinerarioSeleccionado);

            nuevoPasajeroText.Text = model.NombreNuevoCliente;
            apellidoText.Text = model.ApellidoNuevoCliente;
            documentoText.Text = model.DocumentoNuevoCliente;
            emailText.Text = model.EmailNuevoCliente;
            telefonoText.Text = model.TelefonoNuevoCliente;
        }

        private void continuarBtn_Click(object sender, EventArgs e)
        {
            if (!Validador.ValidarCampoRequerido(nuevoPasajeroText, "Nombre")) return;
            if (!Validador.ValidarCampoRequerido(apellidoText, "Apellido")) return;
            // if (!Validador.ValidarCampoRequerido(documentoText, "Documento")) return;     - Es obligatorio?
            // if (!Validador.ValidarCampoRequerido(documentoText, "Email")) return;         - Es obligatorio?
            // if (!Validador.ValidarCampoRequerido(documentoText, "Telefono")) return;      - Es obligatorio?

            model.Continuar();
            Close();
        }

        private void nuevoPasajeroText_TextChanged(object sender, EventArgs e)
        {
            model.NombreNuevoCliente = nuevoPasajeroText.Text;
        }

        private void nuevoPasajeroText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ' ')
            {
                e.Handled = true; // Evita que se escriban números y caracteres especiales
            }
        }

        private void apellidoText_TextChanged(object sender, EventArgs e)
        {
            model.ApellidoNuevoCliente = apellidoText.Text;
        }

        private void apellidoText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ' ')
            {
                e.Handled = true; // Evita que se escriban números y caracteres especiales
            }
        }

        private void documentoText_TextChanged(object sender, EventArgs e)
        {
            model.DocumentoNuevoCliente = documentoText.Text;
        }

        private void emailText_TextChanged(object sender, EventArgs e)
        {
            model.EmailNuevoCliente = emailText.Text;
        }

        private void telefonoText_TextChanged(object sender, EventArgs e)
        {
            model.TelefonoNuevoCliente = telefonoText.Text;
        }

        private void telefonoText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '+' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Evita que se escriban letras y otros caracteres
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
