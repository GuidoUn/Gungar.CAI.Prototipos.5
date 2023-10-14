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

        public List<string[]> pasajeros = new List<string[]> {
            new string[6] { "Jose", "Fernandez", "28669206", "pemartinez@live.com", "1193692693", new DateTime(1996, 05, 17).ToString(FORMATO_FECHA) },
            new string[6] { "Martin", "Advincula", "73848021", "eldiego@hotmail.com", "1137599627", new DateTime(1986, 02, 1).ToString(FORMATO_FECHA) },
            new string[6] { "Manuel", "Lopez",   "42756987", "mesias@outlook.com.ar", "1128759115", new DateTime(2022, 12, 3).ToString(FORMATO_FECHA) }
        };

        string[]? itinerario;

        string[]? pasajeroSeleccionado;

        public AgregarDatosForm(string idItinerario)
        {
            InitializeComponent();
            itinerario = Form1.itinerarios.FirstOrDefault(itinerario => itinerario[0] == idItinerario);
        }

        private void poblarLista()
        {
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
        private void AgregarDatosForm_Load(object sender, EventArgs e)
        {
            itinerarioLabel.Text = $"{itinerario[1]} ({itinerario[0]})";

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
            string[] nuevoPasajero = { nombreTextBox.Text, apellidoTextBox.Text, DNITextBox.Text, emailTextBox.Text, telefonoTextBox.Text, fechaNacDatePicker.Value.ToString(FORMATO_FECHA) };

            pasajeros.Add(nuevoPasajero);

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

            pasajeroSeleccionado = pasajeros.FirstOrDefault((pasajero) => pasajero[0] == selected.Text);

            evaluarVisibilidadBtns();
        }

        private void eliminarPasajeroBtn_Click(object sender, EventArgs e)
        {
            pasajeros.Remove(pasajeroSeleccionado);
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
