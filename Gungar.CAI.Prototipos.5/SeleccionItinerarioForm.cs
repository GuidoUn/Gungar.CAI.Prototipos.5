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
    public partial class SeleccionItinerarioForm : Form
    {
        const string FORMATO_FECHA = "yyyy-MM-dd";

        //public static List<string[]> itinerarios = new List<string[]> {
        //    new string[3] { "1", "Pedro Martinez", new DateTime(2023, 05, 17).ToString(FORMATO_FECHA) },
        //    new string[3] { "2", "Diego Maradona", new DateTime(2023, 06, 1).ToString(FORMATO_FECHA) },
        //    new string[3] { "3", "Lionel Messi", new DateTime(2023, 06, 3).ToString(FORMATO_FECHA) }
        //};

        List<string[]> itinerarios;

        string[]? itinerarioSeleccionado;

        GestionProductosItinerarioForm gestionProductosItinerarioForm;
        MenuItinerarioForm menuItinerarioForm;

        public SeleccionItinerarioForm()
        {
            InitializeComponent();
            itinerarios = Form1.itinerarios;
        }

        private void SeleccionItinerarioForm_Load(object sender, EventArgs e)
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
        private void evaluarEstadoBtns()
        {
            if (itinerarioSeleccionado?[0].Length > 0)
            {
                continuarBtn.Enabled = true;
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

            evaluarEstadoBtns();
        }

        private void continuarBtn_Click(object sender, EventArgs e)
        {
            //gestionProductosItinerarioForm = new GestionProductosItinerarioForm(itinerarioSeleccionado[0], false);
            menuItinerarioForm = new MenuItinerarioForm(itinerarioSeleccionado[0]);
            this.Visible = false;
            menuItinerarioForm.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
