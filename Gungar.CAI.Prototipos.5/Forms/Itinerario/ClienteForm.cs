using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gungar.CAI.Prototipos._5.Entidades.Itinerario;

namespace Gungar.CAI.Prototipos._5
{
    public partial class ClienteForm : Form
    {
        string? nombreNuevoPasajero;
        string? apellidoNuevoPasajero;
        string? documentoNuevoPasajero;

        Itinerario itinerario;

        public ClienteForm(Itinerario itinerario)
        {
            InitializeComponent();
            this.itinerario = itinerario;
            this.nombreNuevoPasajero = itinerario.cliente?.nombre;
            this.apellidoNuevoPasajero = itinerario.cliente?.apellido;
            this.documentoNuevoPasajero = itinerario.cliente?.documento;
            actualizarCampos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void evaluarEstadoBtns()
        {
            continuarBtn.Enabled = nombreNuevoPasajero?.Length > 0 && apellidoNuevoPasajero?.Length > 0;
        }

        private void actualizarCampos()
        {
            nuevoPasajeroText.Text = this.nombreNuevoPasajero;
            apellidoText.Text = this.apellidoNuevoPasajero;
            documentoText.Text = this.documentoNuevoPasajero;
        }

        private void nuevoPasajeroText_TextChanged(object sender, EventArgs e)
        {
            nombreNuevoPasajero = nuevoPasajeroText.Text;
            evaluarEstadoBtns();
        }

        private void apellidoText_TextChanged(object sender, EventArgs e)
        {
            apellidoNuevoPasajero = apellidoText.Text;
            evaluarEstadoBtns();
        }

        private void documentoText_TextChanged(object sender, EventArgs e)
        {
            documentoNuevoPasajero = documentoText.Text;
        }

        private void continuarBtn_Click(object sender, EventArgs e)
        {
            var item = new ListViewItem();

            if (string.IsNullOrEmpty(nombreNuevoPasajero) || string.IsNullOrEmpty(apellidoNuevoPasajero))
            {
                return;
            }

            Cliente nuevoCliente = new Cliente(nombreNuevoPasajero, apellidoNuevoPasajero, documentoNuevoPasajero);

            itinerario.AsignarCliente(nuevoCliente);
            this.Close();
        }
    }
}
