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
using Gungar.CAI.Prototipos._5.Forms.SeleccionItinerario;

namespace Gungar.CAI.Prototipos._5
{
    public partial class SeleccionItinerarioForm : Form
    {
        const string FORMATO_FECHA = "yyyy'-'MM'-'dd'T'HH':'mm";

        SeleccionItinerarioFormModel model;

        MenuItinerarioForm? menuItinerarioForm;

        public SeleccionItinerarioForm()
        {
            InitializeComponent();
            model = new();
        }

        private void refrescar()
        {
            itinerariosListView.Items.Clear();
            foreach (var itinerario in model.ItinerariosEnPantalla)
            {
                // itinerario.EvaluarVencimientoPrereserva(); TODO: Descomentar cuando querramos que a las 48hs venzan las prereservas

                var item = new ListViewItem();
                item.Text = itinerario.ItinerarioId.ToString();
                item.SubItems.Add(itinerario?.Cliente?.GetNombreYApellido());
                item.SubItems.Add(itinerario?.Cliente?.Documento);
                item.SubItems.Add(itinerario?.FechaCreacion.ToString(FORMATO_FECHA));
                item.SubItems.Add(itinerario?.Estado.ToString());
                item.Tag = itinerario;

                itinerariosListView.Items.Add(item);
            }
        }

        private void SeleccionItinerarioForm_Load(object sender, EventArgs e)
        {
            itinerarioSeleccionadoLabel.Text = "Por favor seleccione un itinerario";

            refrescar();
        }
        private void evaluarEstadoBtns()
        {
            continuarBtn.Enabled = model.ItinerarioSeleccionado != null;
            eliminarItinerarioBtn.Enabled = model.ItinerarioSeleccionado != null;
        }

        private void itinerariosListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itinerariosListView.SelectedItems == null)
            {
                return;
            }
            ListViewItem selected = itinerariosListView.SelectedItems[0];
            model.ItinerarioSeleccionado = selected.Tag as Itinerario;

            itinerarioSeleccionadoLabel.Text = $"{model.ItinerarioSeleccionado?.Cliente?.Nombre} ({model.ItinerarioSeleccionado?.ItinerarioId})";

            evaluarEstadoBtns();
        }

        private void continuarBtn_Click(object sender, EventArgs e)
        {
            if (model.ItinerarioSeleccionado != null)
            {
                menuItinerarioForm = new MenuItinerarioForm(model.ItinerarioSeleccionado);
                menuItinerarioForm.ShowDialog();
                refrescar();
            }

        }

        private void filtrarBtn_Click(object sender, EventArgs e)
        {
            model.FiltrarItinerarios(parametroTextBox.Text);
            refrescar();
        }

        private void eliminarItinerarioBtn_Click(object sender, EventArgs e)
        {
            var confirmar = MessageBox.Show("Esta seguro de que desea ELIMINAR el itinerario", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (confirmar == DialogResult.OK)
            {
                model.EliminarItinerarioSeleccionado();
            }

            itinerarioSeleccionadoLabel.Text = "Por favor seleccione un itinerario";
            refrescar();
            evaluarEstadoBtns();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
