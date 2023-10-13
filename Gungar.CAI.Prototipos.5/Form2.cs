using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Gungar.CAI.Prototipos._5
{

    public partial class Form2 : Form
    {
        const string FORMATO_FECHA = "yyyy-MM-dd";

        public static List<string[]> itinerarios = new List<string[]> {
            new string[3] { "1", "Pedro Martinez", new DateTime(2023, 05, 17).ToString(FORMATO_FECHA) },
            new string[3] { "2", "Diego Maradona", new DateTime(2023, 06, 1).ToString(FORMATO_FECHA) },
            new string[3] { "3", "Lionel Messi", new DateTime(2023, 06, 3).ToString(FORMATO_FECHA) }
        };

        string nuevoPasajero;

        string idSeleccionado;

        string[]? itinerarioSeleccionado;

        string[]? itinerarioAContinuar;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
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
        }

        private void itinerariosListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itinerariosListView.SelectedItems.Count == 0)
            {
                return;
            }

            ListViewItem selected = itinerariosListView.SelectedItems[0];

            itinerarioSeleccionado = itinerarios.FirstOrDefault((itinerario) => itinerario[0] == selected.Text);

            itinerarioSeleccionadoLabel.Text = $"{itinerarioSeleccionado[1]} ({itinerarioSeleccionado[0]})";

            evaluarEstadoRadioBtns();
        }

        private void nuevoPasajeroText_TextChanged(object sender, EventArgs e)
        {
            nuevoPasajero = nuevoPasajeroText.Text;
            evaluarEstadoRadioBtns();
        }

        private void evaluarEstadoRadioBtns()
        {
            if (nuevoItinerarioRadio.Checked)
            {
                nuevoItinerarioBox.Enabled = true;
                continuarItinerarioBox.Enabled = false;
                if (nuevoPasajero?.Length > 0)
                {
                    continuarBtn.Enabled = true;
                    return;
                }
                continuarBtn.Enabled = false;
                return;
            }

            nuevoItinerarioBox.Enabled = false;
            continuarItinerarioBox.Enabled = true;
            if (itinerarioSeleccionado != null)
            {
                continuarBtn.Enabled = true;
                return;
            }
            continuarBtn.Enabled = false;
        }

        private void nuevoItinerarioRadio_CheckedChanged(object sender, EventArgs e)
        {
            evaluarEstadoRadioBtns();
        }

        private string[] crearNuevoItinerario()
        {
            var item = new ListViewItem();

            int nuevoId = Int32.Parse(itinerarios[itinerarios.Count - 1][0]) + 1;

            string[] nuevoItinerario = new string[3] { nuevoId.ToString(), nuevoPasajero, DateTime.Now.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss") };

            item.Text = nuevoItinerario[0];
            item.SubItems.Add(nuevoItinerario[1]);
            item.SubItems.Add(nuevoItinerario[2]);
            item.Tag = nuevoItinerario;

            itinerarios.Add(nuevoItinerario);
            return nuevoItinerario;
        }
        private void continuarBtn_Click(object sender, EventArgs e)
        {
            GestionProductosItinerarioForm gestionProductosItinerarioForm;
            if (nuevoItinerarioRadio.Checked)
            {
                itinerarioAContinuar = crearNuevoItinerario();
                gestionProductosItinerarioForm = new GestionProductosItinerarioForm(itinerarioAContinuar[0], true);
            }
            else
            {
                itinerarioAContinuar = itinerarioSeleccionado;
                gestionProductosItinerarioForm = new GestionProductosItinerarioForm(itinerarioAContinuar[0], false);
            }

            gestionProductosItinerarioForm.ShowDialog();
            //this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
