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
    public partial class MenuItinerarioForm : Form
    {
        Itinerario? itinerario;

        AgregarDatosForm agregarDatosForm;

        GestionProductosItinerarioForm gestionProductosItinerarioForm;

        public static List<string[]> productosItinerarios = new List<string[]>
        {
             new string[] { "Hotel", "Mendoza", "29/11/2023", "3/12/2023", "$710", "Hilton", "4 estrellas" },
             new string[] { "Hotel", "Mendoza", "3/12/2023", "10/12/2023", "$310", "Once", "2 estrellas" },
             new string[] { "Vuelo", "Mendoza", "29/11/2023", "29/11/2023", "$290", "Aerolineas Argentinas", "Economy" },
             new string[] { "Vuelo", "Mendoza", "3/12/2023", "3/12/2023", "$250", "Aerolineas Argentinas", "Economy" }
        };

        public MenuItinerarioForm(int idItinerario)
        {
            InitializeComponent();

            itinerario = Form1.itinerarios.FirstOrDefault(itinerario => itinerario.itinerarioId == idItinerario);
            agregarDatosForm = new AgregarDatosForm(itinerario.itinerarioId);
            gestionProductosItinerarioForm = new GestionProductosItinerarioForm(itinerario.itinerarioId, true);
        }

        private void refrescar()
        {
            estadoLabel.Text = itinerario.estado.ToString();
            if (itinerario.pasajeros.Count == 0 || productosItinerarios.Count == 0 || itinerario.estado == Estado.Reserva)
            {
                generarPreReservaBtn.Enabled = false;
                generarReservaBtn.Enabled = false;
            }
            else
            {
                generarPreReservaBtn.Enabled = true;
                generarReservaBtn.Enabled = true;

            }
            gestionarItinerarioBox.Enabled = itinerario.estado == Estado.Presupuesto;
            poblarListaPasajeros();
            poblarItinerario();
        }

        private void MenuItinerarioForm_Load(object sender, EventArgs e)
        {
            itinerarioSeleccionadoLabel.Text = $"{itinerario.itinerarioId}";
            nombreYApellidoLabel.Text = $"{itinerario.cliente.nombre} {itinerario.cliente?.apellido}";
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
            //foreach (var producto in productosItinerarios)          
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

                //listView1.Items.Add(item);
                productosAgregadosListView.Items.Add(item);
            }
        }

        private void gestionarProductosBtn_Click(object sender, EventArgs e)
        {
            gestionProductosItinerarioForm.ShowDialog();
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
                itinerario.estado = Estado.Prereserva;
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
                itinerario.estado = Estado.Reserva;

                refrescar();

            }

        }


    }
}
