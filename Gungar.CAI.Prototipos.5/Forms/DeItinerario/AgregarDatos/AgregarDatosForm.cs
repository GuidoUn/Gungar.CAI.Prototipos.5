using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gungar.CAI.Prototipos._5.Entidades;
using Gungar.CAI.Prototipos._5.Entidades.DeItinerario;
using Gungar.CAI.Prototipos._5.Entidades.DeItinerario.Reservas;
using Gungar.CAI.Prototipos._5.Modulos;

namespace Gungar.CAI.Prototipos._5
{
    public partial class AgregarDatosForm : Form
    {
        const string FORMATO_FECHA = "yyyy-MM-dd";

        Itinerario? itinerario;

        Pasajero? pasajeroSeleccionado;

        Pasajero? pasajeroProductoSeleccionado;

        //ReservaHotel hotelSeleccionado;

        IReservaProducto productoSeleccionado;

        bool esPreReserva; // TODO: Borrar si no se usa

        public AgregarDatosForm(Itinerario itinerario, bool esPreReserva)
        {
            InitializeComponent();
            this.itinerario = itinerario;
            this.esPreReserva = esPreReserva;
        }
        private void poblarProductosAgregados()
        {
            productosAgregadosListView.Items.Clear();
            foreach (var reservaHotel in itinerario.HotelesSeleccionados)
            {
                var item = new ListViewItem();
                item.Text = reservaHotel.Hotel.NombreHotel;
                item.SubItems.Add(reservaHotel.Hotel.Disponibilidad.Nombre);
                item.Tag = reservaHotel;

                productosAgregadosListView.Items.Add(item);
            }

            itinerario.VuelosAgregados.ForEach(reservaVuelo =>
            {
                var item = new ListViewItem();
                item.Text = reservaVuelo.Vuelo.Aerolinea;
                item.SubItems.Add(reservaVuelo.Vuelo.Origen);
                item.Tag = reservaVuelo;

                productosAgregadosListView.Items.Add(item);
            });
        }

        private void poblarListaTotalDePasajerosItinerario()
        {
            pasajerosItinerarioListView.Items.Clear();

            List<IReservaProducto> reservaProductos = VentasModulo.GetProductosAgregados(itinerario.ItinerarioId); // TODO: Usar model

            reservaProductos.ForEach(reservaProducto =>
            {
                reservaProducto.Pasajeros.ForEach(pasajero =>
                {
                    var item = new ListViewItem();
                    item.Text = pasajero.Nombre;
                    item.SubItems.Add(pasajero.Apellido);
                    item.SubItems.Add(pasajero.Documento);
                    item.SubItems.Add(pasajero.Email);
                    item.SubItems.Add(pasajero.Telefono);
                    item.SubItems.Add(pasajero.FechaNacimiento.ToString());
                    item.Tag = pasajero;

                    pasajerosItinerarioListView.Items.Add(item);
                });
            });
        }

        private void poblarListaPasajeros()
        {
            pasajerosProductosListView.Items.Clear();
            //if (hotelSeleccionado == null)
            //{
            //    return;
            //} 
            if (productoSeleccionado == null)
                return;

            //foreach (var pasajero in hotelSeleccionado.Pasajeros)
            //{
            //    var item = new ListViewItem();
            //    item.Text = pasajero.Nombre;
            //    item.SubItems.Add(pasajero.Apellido);
            //    item.SubItems.Add(pasajero.Documento);
            //    item.SubItems.Add(pasajero.Email);
            //    item.SubItems.Add(pasajero.Telefono);
            //    item.SubItems.Add(pasajero.FechaNacimiento.ToString());
            //    item.Tag = pasajero;

            //    pasajerosProductosListView.Items.Add(item);
            //}

            foreach (var pasajero in productoSeleccionado.Pasajeros)
            {
                var item = new ListViewItem();
                item.Text = pasajero.Nombre;
                item.SubItems.Add(pasajero.Apellido);
                item.SubItems.Add(pasajero.Documento);
                item.SubItems.Add(pasajero.Email);
                item.SubItems.Add(pasajero.Telefono);
                item.SubItems.Add(pasajero.FechaNacimiento.ToString());
                item.Tag = pasajero;

                pasajerosProductosListView.Items.Add(item);
            }
        }

        private void AgregarDatosForm_Load(object sender, EventArgs e)
        {
            itinerarioLabel.Text = $"{itinerario?.Cliente?.Nombre} ({itinerario?.ItinerarioId})";

            poblarListaPasajeros();

            poblarProductosAgregados();
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
            Pasajero nuevoPasajero = new Pasajero(nombreTextBox.Text, apellidoTextBox.Text, DNITextBox.Text, emailTextBox.Text, telefonoTextBox.Text, fechaNacDatePicker.Value.ToString(FORMATO_FECHA));

            //if (hotelSeleccionado == null) return;
            //hotelSeleccionado.Pasajeros.Add(nuevoPasajero);
            if (productoSeleccionado == null) return;
            productoSeleccionado.Pasajeros.Add(nuevoPasajero);


            poblarListaPasajeros();
            poblarListaTotalDePasajerosItinerario();
            vaciarCampos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void eliminarPasajeroBtn_Click(object sender, EventArgs e)
        {
            //hotelSeleccionado.Pasajeros.Remove(pasajeroProductoSeleccionado);
            productoSeleccionado.Pasajeros.Remove(pasajeroProductoSeleccionado);
            pasajeroProductoSeleccionado = null;
            poblarListaPasajeros();
            poblarListaTotalDePasajerosItinerario();
            evaluarVisibilidadBtns();
        }


        private void evaluarVisibilidadBtns()
        {
            eliminarPasajeroBtn.Enabled = pasajeroProductoSeleccionado != null;

            //asignarBtn.Enabled = pasajeroSeleccionado != null && hotelSeleccionado != null;
            asignarBtn.Enabled = pasajeroSeleccionado != null && productoSeleccionado != null;
        }

        private void confirmarBtn_Click(object sender, EventArgs e)
        {
            itinerario.GenerarPrereserva();
            itinerario.HotelesSeleccionados.ForEach(reservaHotel => AlmacenHoteles.ModificarDisponibilidadHotel(reservaHotel.Hotel, false));
            this.Close();
        }

        private void productosAgregadosListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (productosAgregadosListView.SelectedItems.Count == 0) return;
            //hotelSeleccionado = (ReservaHotel)productosAgregadosListView.SelectedItems[0].Tag;
            productoSeleccionado = (IReservaProducto)productosAgregadosListView.SelectedItems[0].Tag;
            poblarListaPasajeros();
            evaluarVisibilidadBtns();
        }

        private void pasajerosItinerarioListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pasajerosItinerarioListView.SelectedItems.Count == 0) return;
            pasajeroSeleccionado = (Pasajero)pasajerosItinerarioListView.SelectedItems[0].Tag;
            evaluarVisibilidadBtns();
        }

        private void asignarBtn_Click(object sender, EventArgs e)
        {
            //if (pasajeroSeleccionado == null || hotelSeleccionado == null) return;
            if (pasajeroSeleccionado == null || productoSeleccionado == null) return;
            //hotelSeleccionado.Pasajeros.Add(pasajeroSeleccionado);
            productoSeleccionado.Pasajeros.Add(pasajeroSeleccionado);
            poblarListaPasajeros();
        }

        private void pasajerosProductosListView_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (pasajerosProductosListView.SelectedItems.Count == 0)
            {
                return;
            }

            pasajeroProductoSeleccionado = (Pasajero)pasajerosProductosListView.SelectedItems[0].Tag;

            evaluarVisibilidadBtns();
        }
    }
}
