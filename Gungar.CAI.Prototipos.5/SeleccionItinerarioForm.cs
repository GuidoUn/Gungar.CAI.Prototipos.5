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

        //string[]? itinerarioSeleccionado;
        Itinerario? itinerarioSeleccionado2;

        //GestionProductosItinerarioForm gestionProductosItinerarioForm;
        MenuItinerarioForm menuItinerarioForm;

        string tipoDeParametroAFiltrar;
        string parametroIngresado;

        public SeleccionItinerarioForm()
        {
            InitializeComponent();
            itinerarios = Form1.itinerarios;
        }

        private void refrescar()
        {
            itinerariosListView.Items.Clear();
            foreach (var itinerario in itinerarios)
            {
                var item = new ListViewItem();
                item.Text = itinerario.itinerarioId.ToString();
                item.SubItems.Add(itinerario.cliente.nombre);
                item.SubItems.Add(itinerario.fechaCreacion.ToString(FORMATO_FECHA));
                item.SubItems.Add(itinerario.estado.ToString());
                item.Tag = itinerario;

                itinerariosListView.Items.Add(item);
            }
        }
        private void HabilitarFiltro()
        {
            if (tipoDeParametroAFiltrar != null && parametroIngresado != null && parametroIngresado.Length > 0 && tipoDeParametroAFiltrar!="Sin Filtro")
            {
                filtrarBtn.Enabled = true;
            }
            else
            {
                filtrarBtn.Enabled = false;
            }
        }
        private void SeleccionItinerarioForm_Load(object sender, EventArgs e)
        {
            itinerarioSeleccionadoLabel.Text = "Por favor seleccione un itinerario";

            refrescar();
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

            itinerarioSeleccionadoLabel.Text = $"{itinerarioSeleccionado2.cliente.nombre} ({itinerarioSeleccionado2.itinerarioId})";

            evaluarEstadoBtns();
        }

        private void continuarBtn_Click(object sender, EventArgs e)
        {
            menuItinerarioForm = new MenuItinerarioForm(itinerarioSeleccionado2.itinerarioId);
            menuItinerarioForm.ShowDialog();
            refrescar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void parametrosCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoDeParametroAFiltrar = parametrosCombo.SelectedItem.ToString();
            if(tipoDeParametroAFiltrar=="Sin Filtro")
            {
                refrescar();
            }
            HabilitarFiltro();


        }

        private void filtrarBtn_Click(object sender, EventArgs e)
        {
            itinerariosListView.Items.Clear();
            var itinerariosFiltrado = itinerarios.First();
            var item = new ListViewItem();
            item.Text = itinerariosFiltrado.itinerarioId.ToString();
            item.SubItems.Add(itinerariosFiltrado.cliente.nombre);
            item.SubItems.Add(itinerariosFiltrado.fechaCreacion.ToString(FORMATO_FECHA));
            item.SubItems.Add(itinerariosFiltrado.estado.ToString());
            item.Tag = itinerariosFiltrado;

            itinerariosListView.Items.Add(item);

        }

        private void origenText_TextChanged(object sender, EventArgs e)
        {
            parametroIngresado = parametroTextBox.Text;
            HabilitarFiltro();
        }
    }
}
