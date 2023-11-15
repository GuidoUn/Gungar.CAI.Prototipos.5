using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gungar.CAI.Prototipos._5.Almacenes;
using Gungar.CAI.Prototipos._5.Entidades.DeItinerario;
using Gungar.CAI.Prototipos._5.Entidades.DeItinerario.Reservas;
using Gungar.CAI.Prototipos._5.Entidades.Oferta;
using Gungar.CAI.Prototipos._5.Forms.Productos.Hoteles;
using Gungar.CAI.Prototipos._5.Modulos;

namespace Gungar.CAI.Prototipos._5
{
    public partial class HotelesForm : Form
    {
        HotelesFormModel model;

        public HotelesForm()
        {
            InitializeComponent();
        }

        private void HotelesForm_Load(object sender, EventArgs e)
        {
            model = new HotelesFormModel(VentasModulo.ItinerarioSeleccionado);

            if (model.EsConsulta)
            {
                titleLabel.Text = "Consulta disponibilidad de hoteles";
                itinerarioLabel.Text = "";
                modificarItinerarioBox.Visible = false;
            }
            else
            {
                itinerarioLabel.Text = $"{model.Itinerario?.Cliente?.Nombre} ({model.Itinerario?.ItinerarioId})";
            }

            clasesCombo.SelectedIndex = 0;

            desdeFechaDatePicker.MinDate = DateTime.Now;
            hastaFechaDatePicker.MinDate = DateTime.Now;
            borrarFechas();
            poblarProductosAgregados();
        }

        private void poblarHoteles()
        {
            var listaDeHotelesDisponibles = model.GetHotelesDisponibles(destinoText.Text, Decimal.ToInt32(cantidadAdultosNumeric.Value), Decimal.ToInt32(cantidadMenoresNumeric.Value), Decimal.ToInt32(cantidadInfantesNumeric.Value), clasesCombo.Text, model.DesdeFechaSeleccionada, model.HastaFechaSeleccionada, desdePreciosNumeric.Value, hastaPreciosNumeric.Value);

            hotelesListView.Items.Clear();
            foreach (var hotel in listaDeHotelesDisponibles)
            {
                if (hotel.Disponibilidad.Cantidad > 0)
                {
                    var item = new ListViewItem();
                    item.Text = hotel.NombreHotel;
                    item.SubItems.Add(hotel.Disponibilidad.Nombre);
                    item.SubItems.Add(hotel.Disponibilidad.Capacidad.ToString());
                    item.SubItems.Add(hotel.Direccion.Calle + " " + hotel.Direccion.Numero);
                    item.SubItems.Add(Constantes.CalificacionesInvertidas[hotel.Calificacion]);
                    item.SubItems.Add(Constantes.Ciudades[hotel.CodigoCiudad]);
                    item.SubItems.Add("$" + hotel.Disponibilidad.Tarifa.ToString());
                    item.SubItems.Add(hotel.Disponibilidad.CapacidadAdultos.ToString());
                    item.SubItems.Add(hotel.Disponibilidad.CapacidadMenores.ToString());
                    item.SubItems.Add(hotel.Disponibilidad.CapacidadInfantes.ToString());
                    item.Tag = hotel;

                    hotelesListView.Items.Add(item);
                }
                if (listaDeHotelesDisponibles.Count <= 0)
                {
                    MessageBox.Show("No tenemos hoteles disponibles para los filtros seleccionados", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };
        }

        private void poblarProductosAgregados()
        {
            if (!model.EsConsulta)
            {
                hotelesAgregadosListView.Items.Clear();
                foreach (var reservaHotel in model.Itinerario?.HotelesSeleccionados)
                {
                    var item = new ListViewItem();
                    item.Text = reservaHotel.Hotel.NombreHotel;
                    item.SubItems.Add(reservaHotel.Hotel.Disponibilidad.Nombre);
                    item.SubItems.Add(reservaHotel.Hotel.Disponibilidad.Capacidad.ToString());
                    item.SubItems.Add(reservaHotel.Hotel.Direccion.Calle);
                    item.SubItems.Add(Constantes.CalificacionesInvertidas[reservaHotel.Hotel.Calificacion]);
                    item.SubItems.Add(Constantes.Ciudades[reservaHotel.Hotel.CodigoCiudad]);
                    item.SubItems.Add("$" + reservaHotel.PrecioTotal.ToString());
                    item.SubItems.Add(reservaHotel.Hotel.Disponibilidad.CapacidadAdultos.ToString());
                    item.SubItems.Add(reservaHotel.Hotel.Disponibilidad.CapacidadMenores.ToString());
                    item.SubItems.Add(reservaHotel.Hotel.Disponibilidad.CapacidadInfantes.ToString());
                    item.Tag = reservaHotel;

                    hotelesAgregadosListView.Items.Add(item);
                }
            }
        }

        private void aplicarFiltrosBtn_Click(object sender, EventArgs e)
        {
            if (!Validador.ValidarRangoDeFechas(model.DesdeFechaSeleccionada, model.HastaFechaSeleccionada))
            {
                hotelesListView.Items.Clear();
                return;
            }
            poblarHoteles();
            guardarDatosBusqueda();
        }
        private void guardarDatosBusqueda()
        {
            model.AdultosEnBusqueda = decimal.ToInt32(cantidadAdultosNumeric.Value);
            adultosEnBusquedaLabel.Text = model.AdultosEnBusqueda.ToString();

            model.MenoresEnBusqueda = decimal.ToInt32(cantidadMenoresNumeric.Value);
            menoresEnBusquedaLabel.Text = model.MenoresEnBusqueda.ToString();

            model.InfantesEnBusqueda = decimal.ToInt32(cantidadInfantesNumeric.Value);
            infantesEnBusquedaLabel.Text = model.InfantesEnBusqueda.ToString();

            pasajerosEnBusquedaBox.Visible = true;
        }

        private void desdeFechaDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (model.EsFechaMayorALaIngresada(desdeFechaDatePicker.Value, model.HastaFechaSeleccionada))
            {
                model.HastaFechaSeleccionada = desdeFechaDatePicker.Value.AddDays(1);
                hastaFechaDatePicker.Value = desdeFechaDatePicker.Value.AddDays(1);
            }
            desdeFechaDatePicker.Format = DateTimePickerFormat.Short;
            model.DesdeFechaSeleccionada = desdeFechaDatePicker.Value;
        }

        private void hastaFechaDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (model.EsFechaMayorALaIngresada(model.DesdeFechaSeleccionada, hastaFechaDatePicker.Value))
            {
                MessageBox.Show("Por favor, primero ingrese la fecha 'DESDE', y luego asegúrese que sea ANTERIOR a la fecha 'HASTA'.", "Seleccionar fecha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                model.HastaFechaSeleccionada = model.DesdeFechaSeleccionada.AddDays(1);
                hastaFechaDatePicker.Value = model.DesdeFechaSeleccionada.AddDays(1);
                return;

            }
            hastaFechaDatePicker.Format = DateTimePickerFormat.Short;
            model.HastaFechaSeleccionada = hastaFechaDatePicker.Value;
        }

        private void borrarFechas()
        {
            desdeFechaDatePicker.Value = DateTime.Now;
            hastaFechaDatePicker.Value = DateTime.Now.AddDays(1);
        }

        private void borrarFechasBtn_Click(object sender, EventArgs e)
        {
            borrarFechas();
        }

        private void hotelesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (hotelesListView.SelectedItems.Count <= 0)
                return;

            model.HotelSeleccionado = (Hotel)hotelesListView.SelectedItems[0].Tag;
        }

        private bool HotelYaFueAgregado(Hotel Hotel)
        {
            return model.Itinerario.HotelesSeleccionados.Any(reservaHotel => reservaHotel.Hotel.Equals(Hotel)); //Mejor sería usar Exists, que any
        }

        private void agregarProductoBtn_Click(object sender, EventArgs e)
        {
            if (model.HotelSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un hotel", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            model.HotelSeleccionado.FechaDesde = model.DesdeFechaSeleccionada;
            model.HotelSeleccionado.FechaHasta = model.HastaFechaSeleccionada;
            if (HotelYaFueAgregado(model.HotelSeleccionado))
            {

                MessageBox.Show("El Hotel seleccionado ya fue agregado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ReservaHotel reservaHotel = new ReservaHotel(model.HotelSeleccionado);
            reservaHotel.CantidadAdultos = model.AdultosEnBusqueda;
            reservaHotel.CantidadMenores = model.MenoresEnBusqueda;
            reservaHotel.CantidadInfantes = model.InfantesEnBusqueda;

            model.Itinerario?.AgregarReservaHotel(reservaHotel);
            poblarProductosAgregados();
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void quitarHotelBtn_Click(object sender, EventArgs e)
        {
            if (model.HotelAgregadoSeleccionado == null)
                return;

            model.Itinerario?.QuitarReservaHotel(model.HotelAgregadoSeleccionado);
            poblarProductosAgregados();
        }

        private void hotelesAgregadosListView_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (hotelesAgregadosListView.SelectedItems.Count <= 0)
                return;

            model.HotelAgregadoSeleccionado = (ReservaHotel)hotelesAgregadosListView.SelectedItems[0].Tag;
        }

        private void cantidadAdultosNumeric_ValueChanged(object sender, EventArgs e)
        {
            aplicarFiltrosBtn.Enabled = cantidadAdultosNumeric.Value > 0;
        }
    }
}
