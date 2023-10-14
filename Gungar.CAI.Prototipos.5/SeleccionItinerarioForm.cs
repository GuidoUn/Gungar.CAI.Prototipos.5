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
        const string FORMATO_FECHA = "yyyy'-'MM'-'dd'T'HH':'mm";

        List<Itinerario> itinerarios;

        string[]? itinerarioSeleccionado;
        Itinerario? itinerarioSeleccionado2;

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
                item.Text = itinerario.itinerarioId.ToString();
                item.SubItems.Add(itinerario.nombreCliente);
                item.SubItems.Add(itinerario.fechaCreacion.ToString(FORMATO_FECHA));
                item.Tag = itinerario;

                itinerariosListView.Items.Add(item);
            }
        }
        private void evaluarEstadoBtns()
        {
            continuarBtn.Enabled = itinerarioSeleccionado2 != null;
        }

        private void itinerariosListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itinerariosListView.SelectedItems.Count == 0)
            {
                return;
            }

            ListViewItem selected = itinerariosListView.SelectedItems[0];

            itinerarioSeleccionado2 = itinerarios.FirstOrDefault((itinerario) => itinerario == selected.Tag);

            itinerarioSeleccionadoLabel.Text = $"{itinerarioSeleccionado2.nombreCliente} ({itinerarioSeleccionado2.itinerarioId})";

            evaluarEstadoBtns();
        }

        private void continuarBtn_Click(object sender, EventArgs e)
        {
            menuItinerarioForm = new MenuItinerarioForm(itinerarioSeleccionado2.itinerarioId);
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
