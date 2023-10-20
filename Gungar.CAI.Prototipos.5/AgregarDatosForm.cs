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
    public partial class AgregarDatosForm : Form
    {
        const string FORMATO_FECHA = "yyyy-MM-dd";

        Itinerario? itinerario;

        Pasajero? pasajeroSeleccionado;

        public AgregarDatosForm(Itinerario itinerario)
        {
            InitializeComponent();
            //itinerario = MenuPrincipalForm.itinerarios.FirstOrDefault(itinerario => itinerario.itinerarioId == idItinerario);
            this.itinerario = itinerario;
        }

        private void poblarLista()
        {
            pasajerosListView.Items.Clear();

            foreach (var pasajero in itinerario.pasajeros)
            {
                var item = new ListViewItem();
                item.Text = pasajero.Nombre;
                item.SubItems.Add(pasajero.Apellido);
                item.SubItems.Add(pasajero.Documento);
                item.SubItems.Add(pasajero.Email);
                item.SubItems.Add(pasajero.Telefono);
                item.SubItems.Add(pasajero.FechaNacimiento.ToString());
                item.Tag = pasajero;

                pasajerosListView.Items.Add(item);
            }
        }
        private void AgregarDatosForm_Load(object sender, EventArgs e)
        {
            itinerarioLabel.Text = $"{itinerario.cliente.nombre} ({itinerario.itinerarioId})";

            poblarLista();
        }

        private void vaciarCampos()
        {
            nombreTextBox.Text = "";
            apellidoTextBox.Text = "";
            DNITextBox.Text = "";
            emailTextBox.Text = "";
            telefonoTextBox.Text = "";
            fechaNacDatePicker.Value = new DateTime(2023, 06, 3);
        }

        private void agregarPasajeroBtn_Click(object sender, EventArgs e)
        {
            Pasajero nuevoPasajero = new Pasajero(nombreTextBox.Text, apellidoTextBox.Text, DNITextBox.Text, emailTextBox.Text, telefonoTextBox.Text, fechaNacDatePicker.Value.ToString(FORMATO_FECHA));

            itinerario.AgregarPasajero(nuevoPasajero);

            poblarLista();
            vaciarCampos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }
        private void pasajerosListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pasajerosListView.SelectedItems.Count == 0)
            {
                return;
            }

            ListViewItem selected = pasajerosListView.SelectedItems[0];

            pasajeroSeleccionado = itinerario.pasajeros.FirstOrDefault((pasajero) => pasajero.Nombre == selected.Text);

            evaluarVisibilidadBtns();
        }

        private void eliminarPasajeroBtn_Click(object sender, EventArgs e)
        {
            itinerario.EliminarPasajero(pasajeroSeleccionado);
            pasajeroSeleccionado = null;
            poblarLista();
            evaluarVisibilidadBtns();
        }


        private void evaluarVisibilidadBtns()
        {
            eliminarPasajeroBtn.Enabled = pasajeroSeleccionado != null;

        }
    }
}
