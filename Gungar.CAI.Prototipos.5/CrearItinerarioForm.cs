using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gungar.CAI.Prototipos._5
{
    public partial class CrearItinerarioForm : Form
    {
        string nombreNuevoPasajero;
        string apellidoNuevoPasajero;
        string documentoNuevoPasajero;

        MenuItinerarioForm menuItinerarioForm;

        List<Itinerario>? itinerarios;

        public CrearItinerarioForm()
        {
            InitializeComponent();
            itinerarios = Form1.itinerarios;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void evaluarEstadoBtns()
        {
            continuarBtn.Enabled = nombreNuevoPasajero?.Length > 0 && apellidoNuevoPasajero?.Length > 0;
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

            //int nuevoId = itinerarios[itinerarios.Count - 1].itinerarioId + 1;
            Cliente nuevoCliente = new Cliente(nombreNuevoPasajero, apellidoNuevoPasajero, documentoNuevoPasajero);

            //TODO: Validar que el cliente esté creado ¿?

            Itinerario nuevoItinerario = new Itinerario(nuevoCliente, DateTime.Now);


            itinerarios.Add(nuevoItinerario);


            menuItinerarioForm = new MenuItinerarioForm(nuevoItinerario.itinerarioId);
            this.Visible = false;
            menuItinerarioForm.ShowDialog();
            this.Close();
        }
    }
}
