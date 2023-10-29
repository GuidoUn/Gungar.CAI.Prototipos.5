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
using Gungar.CAI.Prototipos._5.Entidades.Oferta;

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
            itinerarioSeleccionadoLabel.Text = $"{itinerario.ItinerarioId}";
        }

        private void refrescar()
        {
            poblarListaPasajeros();
            poblarItinerario();
            poblarHotelesAgregados();
            estadoLabel.Text = itinerario?.Estado.ToString();
            nombreYApellidoLabel.Text = $"{itinerario?.Cliente?.Nombre} {itinerario?.Cliente?.Apellido}";
            /*if (itinerario.estado == Estado.Cancelada)
            {
                confirmacionBox.Enabled = false;
                gestionarItinerarioBox.Enabled = false;
                cancelarReservaBtn.Enabled = false;
                return;
            }*/
            confirmacionBox.Enabled = !(itinerario.HotelesSeleccionados.Count == 0 || itinerario.Estado == Estado.Pagada);
            gestionarItinerarioBox.Enabled = itinerario.Estado == Estado.Presupuesto;


        }

        private void MenuItinerarioForm_Load(object sender, EventArgs e)
        {
            itinerarioSeleccionadoLabel.Text = $"{itinerario.ItinerarioId}";
            nombreYApellidoLabel.Text = $"{itinerario?.Cliente?.Nombre} {itinerario?.Cliente?.Apellido}";
            refrescar();
            poblarListaPasajeros();
        }

        public void poblarListaPasajeros()
        {
            pasajerosListView.Items.Clear();

            foreach (var pasajero in itinerario.Pasajeros)
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



        private void generarPreReserva_Click(object sender, EventArgs e)
        {
            agregarDatosForm = new AgregarDatosForm(itinerario, true);

            agregarDatosForm.ShowDialog();
            refrescar();

            if (itinerario.Estado == Estado.Presupuesto)
            {
                itinerario.GenerarPrereserva();
                itinerario.Hoteles.ForEach(hotel => HotelesModel.ModificarDisponibilidadHotel(hotel, false));

            }
            else
            {

            }
        }

        private void salirBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void generarReservaBtn_Click(object sender, EventArgs e)
        {
            agregarDatosForm = new AgregarDatosForm(itinerario, false);
            agregarDatosForm.ShowDialog();
            refrescar();

            var confirmar = MessageBox.Show("Esta seguro de que desea confirmar la reserva?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (confirmar == DialogResult.OK)
            {
                itinerario.Estado = Estado.Pagada;
                itinerario.Hoteles.ForEach(hotel => HotelesModel.ModificarDisponibilidadHotel(hotel, false));
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
                itinerario.Estado = Estado.Cancelada;
                itinerario.Hoteles.ForEach(hotel => HotelesModel.ModificarDisponibilidadHotel(hotel, true));
                refrescar();
            }
        }

        private void vuelosBtn_Click(object sender, EventArgs e)
        {
            vuelosForm = new VuelosForm(itinerario);
            vuelosForm.ShowDialog();
            refrescar();
        }
        private void poblarHotelesAgregados()
        {
            hotelesAgregadosListView.Items.Clear();
            foreach (var reservaHotel in itinerario.HotelesSeleccionados)
            {
                var item = new ListViewItem();
                item.Text = reservaHotel.Hotel.Disponibilidad.Nombre;
                item.SubItems.Add(OfertaHotel.CodigoACiudad[reservaHotel.Hotel.CodigoCiudad]);
                item.SubItems.Add(reservaHotel.Hotel.Disponibilidad.Fecha.ToString());
                item.SubItems.Add(reservaHotel.Hotel.Disponibilidad.Fecha.ToString());
                item.SubItems.Add("$ " + HotelesModel.ObtenerPrecioTotal(itinerario.Hoteles).ToString());
                item.SubItems.Add(reservaHotel.Hotel.NombreHotel);
                item.SubItems.Add(reservaHotel.Hotel.Calificacion.ToString());
                item.Tag = reservaHotel;

                hotelesAgregadosListView.Items.Add(item);
            }
        }

        private void anularItinerarioBtn_Click(object sender, EventArgs e)
        {
            var confirmar = MessageBox.Show("¿Está seguro de que desea anular el itinerario?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (confirmar == DialogResult.OK)
            {
                // Anular itinerario...
            }
        }
    }
}
