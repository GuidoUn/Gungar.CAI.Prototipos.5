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
    public partial class HotelesForm : Form
    {
        Itinerario? itinerario;
        bool esConsulta = false;
        List<OfertaHotel> listaDeHotelesDisponibles;
        DateTime? hastaFechaSeleccionada = null;
        DateTime? desdeFechaSeleccionada = null;

        public HotelesForm(Itinerario? itinerario)
        {
            InitializeComponent();
            if (itinerario == null)
            {
                esConsulta = true;
            }
            else
            {
                this.itinerario = itinerario;
            }
        }

        const string FORMATO_FECHA = "yyyy'-'MM'-'dd'T'HH':'mm";

        int nroProductoAAgregar = 0;




        private void HotelesForm_Load(object sender, EventArgs e)
        {
            if (esConsulta)
            {
                titleLabel.Text = "Consulta disponibilidad de productos";
                itinerarioLabel.Text = "";
                modificarItinerarioBox.Visible = false;
            }
            else
            {
                itinerarioLabel.Text = $"{itinerario?.cliente?.nombre} ({itinerario?.itinerarioId})";
            }

            clasesCombo.SelectedIndex = 0;
        }
        private void poblarHoteles()
        {
            listaDeHotelesDisponibles = HotelesModel.getHoteles(destinoText.Text, Decimal.ToInt32(cantidadAdultosNumeric.Value), Decimal.ToInt32(cantidadMenoresNumeric.Value), Decimal.ToInt32(cantidadInfantesNumeric.Value), clasesCombo.SelectedItem.ToString(), desdeFechaSeleccionada, hastaFechaSeleccionada, desdePreciosNumeric.Value, hastaPreciosNumeric.Value);

            hotelesListView.Items.Clear();
            foreach (var hotel in listaDeHotelesDisponibles)
            {
                var item = new ListViewItem();
                item.Text = hotel.NombreHotel;
                item.SubItems.Add(hotel.Disponibilidad.First().Nombre);
                item.SubItems.Add(hotel.Disponibilidad.First().Capacidad.ToString());
                item.SubItems.Add(hotel.Direccion.Calle);
                item.SubItems.Add(hotel.Calificacion.ToString());
                item.SubItems.Add(hotel.CodigoCiudad);
                item.SubItems.Add(hotel.Disponibilidad.First().Tarifa.ToString());
                item.SubItems.Add(hotel.Disponibilidad.First().Fecha.ToString());
                item.SubItems.Add(hotel.Disponibilidad.First().CapacidadAdultos.ToString());
                item.SubItems.Add(hotel.Disponibilidad.First().CapacidadMenores.ToString());
                item.SubItems.Add(hotel.Disponibilidad.First().CapacidadInfantes.ToString());


                item.Tag = hotel;

                hotelesListView.Items.Add(item);
            }
        }

        private void aplicarFiltrosBtn_Click(object sender, EventArgs e)
        {
            poblarHoteles();
        }

        private void desdeFechaDatePicker_ValueChanged(object sender, EventArgs e)
        {
            desdeFechaDatePicker.Format = DateTimePickerFormat.Short;
            desdeFechaSeleccionada = desdeFechaDatePicker.Value;
        }

        private void hastaFechaDatePicker_ValueChanged(object sender, EventArgs e)
        {
            hastaFechaDatePicker.Format = DateTimePickerFormat.Short;
            hastaFechaSeleccionada = hastaFechaDatePicker.Value;
        }

        private void borrarFechasBtn_Click(object sender, EventArgs e)
        {
            desdeFechaDatePicker.Format = DateTimePickerFormat.Custom;
            desdeFechaDatePicker.CustomFormat = " ";
            desdeFechaSeleccionada = DateTime.MinValue;

            hastaFechaDatePicker.Format = DateTimePickerFormat.Custom;
            hastaFechaDatePicker.CustomFormat = " ";
            hastaFechaSeleccionada = DateTime.MaxValue;
        }
    }
}
