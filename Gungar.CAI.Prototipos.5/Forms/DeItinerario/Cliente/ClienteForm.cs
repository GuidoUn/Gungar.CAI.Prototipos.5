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

namespace Gungar.CAI.Prototipos._5
{
    public partial class ClienteForm : Form
    {
        ClienteFormModel model;

        public ClienteForm(Itinerario itinerario)
        {
            InitializeComponent();
            model = new(itinerario);
            nuevoPasajeroText.Text = model.NombreNuevoCliente;
            apellidoText.Text = model.ApellidoNuevoCliente;
            documentoText.Text = model.DocumentoNuevoCliente;
            emailText.Text = model.EmailNuevoCliente;
            telefonoText.Text = model.TelefonoNuevoCliente;
        }

        private void evaluarEstadoBtns()
        {
            continuarBtn.Enabled = !string.IsNullOrEmpty(model.NombreNuevoCliente) && !string.IsNullOrEmpty(model.ApellidoNuevoCliente);
        }

        private void continuarBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(model.NombreNuevoCliente) || string.IsNullOrEmpty(model.ApellidoNuevoCliente))
            {
                return;
            }

            model.Continuar();
            Close();
        }

        private void nuevoPasajeroText_TextChanged(object sender, EventArgs e)
        {
            model.NombreNuevoCliente = nuevoPasajeroText.Text;
            evaluarEstadoBtns();
        }

        private void apellidoText_TextChanged(object sender, EventArgs e)
        {
            model.ApellidoNuevoCliente = apellidoText.Text;
            evaluarEstadoBtns();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
