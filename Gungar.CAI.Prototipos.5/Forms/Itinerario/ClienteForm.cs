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

namespace Gungar.CAI.Prototipos._5
{
    public partial class ClienteForm : Form
    {
        string? nombreNuevoCliente;
        string? apellidoNuevoCliente;
        string? documentoNuevoCliente;
        string? emailNuevoCliente;
        string? telefonoNuevoCliente;

        Itinerario itinerario;

        public ClienteForm(Itinerario itinerario)
        {
            InitializeComponent();
            this.itinerario = itinerario;
            this.nombreNuevoCliente = itinerario.Cliente?.Nombre;
            this.apellidoNuevoCliente = itinerario.Cliente?.Apellido;
            this.documentoNuevoCliente = itinerario.Cliente?.Documento;
            this.emailNuevoCliente = itinerario.Cliente?.Email;
            this.telefonoNuevoCliente = itinerario.Cliente?.Telefono;
            actualizarCampos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void evaluarEstadoBtns()
        {
            continuarBtn.Enabled = nombreNuevoCliente?.Length > 0 && apellidoNuevoCliente?.Length > 0;
        }

        private void actualizarCampos()
        {
            nuevoPasajeroText.Text = this.nombreNuevoCliente;
            apellidoText.Text = this.apellidoNuevoCliente;
            documentoText.Text = this.documentoNuevoCliente;
            emailText.Text = this.emailNuevoCliente;
            telefonoText.Text = this.telefonoNuevoCliente;
        }

        private void nuevoPasajeroText_TextChanged(object sender, EventArgs e)
        {
            nombreNuevoCliente = nuevoPasajeroText.Text;
            evaluarEstadoBtns();
        }

        private void apellidoText_TextChanged(object sender, EventArgs e)
        {
            apellidoNuevoCliente = apellidoText.Text;
            evaluarEstadoBtns();
        }

        private void continuarBtn_Click(object sender, EventArgs e)
        {
            var item = new ListViewItem();

            if (string.IsNullOrEmpty(nombreNuevoCliente) || string.IsNullOrEmpty(apellidoNuevoCliente))
            {
                return;
            }

            Cliente nuevoCliente = new Cliente(nombreNuevoCliente, apellidoNuevoCliente, documentoText.Text, emailText.Text, telefonoText.Text);

            itinerario.AsignarCliente(nuevoCliente);
            this.Close();
        }
    }
}
