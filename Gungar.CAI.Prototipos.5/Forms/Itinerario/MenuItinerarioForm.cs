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
    public partial class MenuItinerarioForm : Form
    {
        Itinerario? itinerario;

        AgregarDatosForm agregarDatosForm;

        VuelosForm vuelosForm;
        HotelesForm hotelesForm;
        ClienteForm clienteForm;

        public static List<string[]> productosItinerarios = new List<string[]>
        {
             new string[] { "Hotel", "Mendoza", "29/11/2023", "3/12/2023", "$710", "Hilton", "4 estrellas" },
             new string[] { "Hotel", "Mendoza", "3/12/2023", "10/12/2023", "$310", "Once", "2 estrellas" },
             new string[] { "Vuelo", "Mendoza", "29/11/2023", "29/11/2023", "$290", "Aerolineas Argentinas", "Economy" },
             new string[] { "Vuelo", "Mendoza", "3/12/2023", "3/12/2023", "$250", "Aerolineas Argentinas", "Economy" }
        };

        public MenuItinerarioForm(Itinerario itinerario)
        {
            InitializeComponent();

            this.itinerario = itinerario;
            clienteForm = new ClienteForm(itinerario);
            agregarDatosForm = new AgregarDatosForm(itinerario);
            itinerarioSeleccionadoLabel.Text = $"{itinerario.itinerarioId}";
        }

        private void refrescar()
        {
            poblarListaPasajeros();
            poblarItinerario();
            estadoLabel.Text = itinerario.estado.ToString();
            nombreYApellidoLabel.Text = $"{itinerario?.cliente?.nombre} {itinerario?.cliente?.apellido}";
            if (itinerario.estado == Estado.Cancelada)
            {
                confirmacionBox.Enabled = false;
                gestionarItinerarioBox.Enabled = false;
                cancelarReservaBtn.Enabled = false;
                return;
            }
            confirmacionBox.Enabled = !(itinerario.pasajeros.Count == 0 || productosItinerarios.Count == 0 || itinerario.estado == Estado.Pagada);
            gestionarItinerarioBox.Enabled = itinerario.estado == Estado.Presupuesto;

        }

        private void MenuItinerarioForm_Load(object sender, EventArgs e)
        {
            itinerarioSeleccionadoLabel.Text = $"{itinerario.itinerarioId}";
            nombreYApellidoLabel.Text = $"{itinerario?.cliente?.nombre} {itinerario?.cliente?.apellido}";
            refrescar();
            poblarListaPasajeros();
        }

        public void poblarListaPasajeros()
        {
            pasajerosListView.Items.Clear();

            foreach (var pasajero in itinerario.pasajeros)
            {
                var item = new ListViewItem();
                item.Text = pasajero.Nombre + " " + pasajero.Apellido;
                item.SubItems.Add(pasajero.FechaNacimiento.ToString());
                item.Tag = pasajero;

                pasajerosListView.Items.Add(item);
            }
        }

        private void poblarItinerario()
        {
            productosAgregadosListView.Items.Clear();
            foreach (var producto in productosItinerarios)
            {
                var item = new ListViewItem();
                item.Text = producto[0];
                item.SubItems.Add(producto[1]);
                item.SubItems.Add(producto[2]);
                item.SubItems.Add(producto[3]);
                item.SubItems.Add(producto[4]);
                item.SubItems.Add(producto[5]);
                item.SubItems.Add(producto[6]);
                item.Tag = producto;

                productosAgregadosListView.Items.Add(item);
            }
        }

        private void hotelesBtn_Click(object sender, EventArgs e)
        {
            hotelesForm = new HotelesForm(itinerario);
            hotelesForm.ShowDialog();
            refrescar();
        }

        private void agregarPasajerosBtn_Click(object sender, EventArgs e)
        {
            agregarDatosForm.ShowDialog();
            refrescar();
        }

        private void generarPreReserva_Click(object sender, EventArgs e)
        {
            if (itinerario.estado == Estado.Presupuesto)
            {
                itinerario.GenerarPrereserva();
            }
            else
            {
                itinerario.estado = Estado.Presupuesto;
            }
            refrescar();
        }

        private void salirBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void generarReservaBtn_Click(object sender, EventArgs e)
        {
            var confirmar = MessageBox.Show("Esta seguro de que desea confirmar la reserva?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (confirmar == DialogResult.OK)
            {
                itinerario.estado = Estado.Pagada;

                refrescar();

            }
        }

        private void clienteBtn_Click(object sender, EventArgs e)
        {
            clienteForm.ShowDialog();
            refrescar();
        }

        private void cancelarReservaBtn_Click(object sender, EventArgs e)
        {

            var confirmar = MessageBox.Show("Esta seguro de que desea CANCELAR la reserva?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (confirmar == DialogResult.OK)
            {
                itinerario.estado = Estado.Cancelada;
                refrescar();
            }
        }

        private void vuelosBtn_Click(object sender, EventArgs e)
        {
            vuelosForm = new VuelosForm(itinerario);
            vuelosForm.ShowDialog();
            refrescar();
        }
    }
}
