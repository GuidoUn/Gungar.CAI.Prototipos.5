﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gungar.CAI.Prototipos._5.Entidades.DeItinerario;

namespace Gungar.CAI.Prototipos._5
{
    public partial class SeleccionItinerarioForm : Form
    {
        const string FORMATO_FECHA = "yyyy'-'MM'-'dd'T'HH':'mm";

        //List<Itinerario> itinerarios;

        Itinerario? itinerarioSeleccionado;

        MenuItinerarioForm menuItinerarioForm;

        string tipoDeParametroAFiltrar;
        string parametroIngresado;

        public SeleccionItinerarioForm()
        {
            InitializeComponent();
            //itinerarios = AppModel.itinerarios;
        }

        private void refrescar()
        {
            itinerariosListView.Items.Clear();
            foreach (var itinerario in AppModel.itinerarios)
            {
                var item = new ListViewItem();
                item.Text = itinerario.itinerarioId.ToString();
                item.SubItems.Add($"{itinerario?.cliente?.nombre} {itinerario?.cliente?.apellido}");
                item.SubItems.Add(itinerario?.cliente?.documento);
                item.SubItems.Add(itinerario?.fechaCreacion.ToString(FORMATO_FECHA));
                item.SubItems.Add(itinerario?.estado.ToString());
                item.Tag = itinerario;

                itinerariosListView.Items.Add(item);
            }
        }
        private void HabilitarFiltro()
        {
            if (tipoDeParametroAFiltrar != null && parametroIngresado != null && parametroIngresado.Length > 0 && tipoDeParametroAFiltrar != "Sin Filtro")
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
            continuarBtn.Enabled = itinerarioSeleccionado != null;
            eliminarItinerarioBtn.Enabled = !(itinerarioSeleccionado == null);
        }

        private void itinerariosListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itinerariosListView.SelectedItems.Count == 0)
            {
                return;
            }

            ListViewItem selected = itinerariosListView.SelectedItems[0];
            itinerarioSeleccionado = selected.Tag as Itinerario;

            itinerarioSeleccionadoLabel.Text = $"{itinerarioSeleccionado?.cliente?.nombre} ({itinerarioSeleccionado?.itinerarioId})";

            evaluarEstadoBtns();
        }

        private void continuarBtn_Click(object sender, EventArgs e)
        {
            menuItinerarioForm = new MenuItinerarioForm(itinerarioSeleccionado);
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
            if (tipoDeParametroAFiltrar == "Sin Filtro")
            {
                refrescar();
            }
            HabilitarFiltro();


        }

        private void filtrarBtn_Click(object sender, EventArgs e)
        {
            itinerariosListView.Items.Clear();
            var itinerariosFiltrado = AppModel.itinerarios.First();
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

        private void eliminarItinerarioBtn_Click(object sender, EventArgs e)
        {
            var confirmar = MessageBox.Show("Esta seguro de que desea ELIMINAR el itinerario", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (confirmar != DialogResult.OK)
            {
                return;
            }
            if (itinerarioSeleccionado != null)
            {

                AppModel.eliminarItinerario(itinerarioSeleccionado);
            }
            itinerarioSeleccionado = null;
            itinerarioSeleccionadoLabel.Text = "Por favor seleccione un itinerario";
            refrescar();
            evaluarEstadoBtns();
        }
    }
}
