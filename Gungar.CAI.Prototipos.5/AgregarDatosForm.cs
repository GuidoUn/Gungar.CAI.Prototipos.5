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

        public static List<string[]> itinerarios = new List<string[]> {
            new string[3] { "1", "Pedro Martinez", new DateTime(2023, 05, 17).ToString(FORMATO_FECHA) },
            new string[3] { "2", "Diego Maradona", new DateTime(2023, 06, 1).ToString(FORMATO_FECHA) },
            new string[3] { "3", "Lionel Messi", new DateTime(2023, 06, 3).ToString(FORMATO_FECHA) }
        };

        string[]? itinerarioSeleccionado;

        public static List<string[]> pasajeros = new List<string[]> {
            new string[6] { "Pedro", "Martinez", "28669206", "pemartinez@live.com", "1193692693", new DateTime(1996, 05, 17).ToString(FORMATO_FECHA) },
            new string[6] { "Diego", "Maradona", "73848021", "eldiego@hotmail.com", "1137599627", new DateTime(1986, 02, 1).ToString(FORMATO_FECHA) },
            new string[6] { "Lionel", "Messi",   "42756987", "mesias@outlook.com.ar", "1128759115", new DateTime(2022, 12, 3).ToString(FORMATO_FECHA) }
        };

        public AgregarDatosForm()
        {

            InitializeComponent();

        }



        private void AgregarDatosForm_Load(object sender, EventArgs e)
        {
            itinerariosListView.Items.Clear();
            itinerarioSeleccionadoLabel.Text = "Por favor seleccione un itinerario";


            foreach (var itinerario in itinerarios)
            {
                var item = new ListViewItem();
                item.Text = itinerario[0];
                item.SubItems.Add(itinerario[1]);
                item.SubItems.Add(itinerario[2]);
                item.Tag = itinerario;

                itinerariosListView.Items.Add(item);
            }

            pasajerosListView.Items.Clear();

            foreach (var pasajero in pasajeros)
            {
                var item = new ListViewItem();
                item.Text = pasajero[0];
                item.SubItems.Add(pasajero[1]);
                item.SubItems.Add(pasajero[2]);
                item.SubItems.Add(pasajero[3]);
                item.SubItems.Add(pasajero[4]);
                item.SubItems.Add(pasajero[5]);
                item.Tag = pasajero;

                pasajerosListView.Items.Add(item);
            }
        }

        private void itinerariosListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itinerariosListView.SelectedItems.Count == 0)
            {
                continuarBtn.Enabled = false;
                return;
            }

            ListViewItem selected = itinerariosListView.SelectedItems[0];

            itinerarioSeleccionado = itinerarios.FirstOrDefault((itinerario) => itinerario[0] == selected.Text);

            itinerarioSeleccionadoLabel.Text = $"{itinerarioSeleccionado[1]} ({itinerarioSeleccionado[0]})";

            if (itinerarioSeleccionado != null)
            {
                continuarBtn.Enabled = true;
                return;
            }
        }

        private void agregarPasajeroBtn_Click(object sender, EventArgs e)
        {
            string[] nuevoPasajero = { nombreTextBox.Text, apellidoTextBox.Text, DNITextBox.Text, emailTextBox.Text, telefonoTextBox.Text, fechaNacDatePicker.Value.ToString(FORMATO_FECHA) };
            var item = new ListViewItem();
            item.Text = nuevoPasajero[0];
            item.SubItems.Add(nuevoPasajero[1]);
            item.SubItems.Add(nuevoPasajero[2]);
            item.SubItems.Add(nuevoPasajero[3]);
            item.SubItems.Add(nuevoPasajero[4]);
            item.SubItems.Add(nuevoPasajero[5]);
            item.Tag = nuevoPasajero;

            pasajerosListView.Items.Add(item);

            nombreTextBox.Text = "";
            apellidoTextBox.Text = "";
            DNITextBox.Text = "";
            emailTextBox.Text = "";
            telefonoTextBox.Text = "";
            fechaNacDatePicker.Value = new DateTime(2023, 06, 3);
        }
    }
}
