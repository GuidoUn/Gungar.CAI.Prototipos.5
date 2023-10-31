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
using Gungar.CAI.Prototipos._5.Forms.DeItinerario.MenuItinerario;

namespace Gungar.CAI.Prototipos._5
{
    public partial class MenuItinerarioForm : Form
    {
        const string FORMATO_FECHA = "yyyy'-'MM'-'dd'T'HH':'mm";

        MenuItinerarioFormModel model;

        ClienteForm? clienteForm;
        AgregarDatosForm? agregarDatosForm;
        VuelosForm? vuelosForm;
        HotelesForm? hotelesForm;

        public MenuItinerarioForm(Itinerario itinerario)
        {
            InitializeComponent();
            model = new MenuItinerarioFormModel(itinerario);
            // model.Itinerario.EvaluarVencimientoPrereserva(); TODO: Descomentar cuando querramos que a las 48hs venzan las prereservas     

            itinerarioSeleccionadoLabel.Text = $"{itinerario.ItinerarioId}";
        }

        private void MenuItinerarioForm_Load(object sender, EventArgs e)
        {
            itinerarioSeleccionadoLabel.Text = $"{model.Itinerario.ItinerarioId}";
            nombreYApellidoLabel.Text = $"{model.Itinerario?.Cliente?.Nombre} {model.Itinerario?.Cliente?.Apellido}";
            refrescar();
            poblarListaPasajeros();
        }

        private void refrescar()
        {
            poblarListaPasajeros();
            poblarHotelesAgregados();
            poblarVuelosAgregados();
            estadoLabel.Text = model.Itinerario?.Estado.ToString();
            nombreYApellidoLabel.Text = $"{model.Itinerario?.Cliente?.Nombre} {model.Itinerario?.Cliente?.Apellido}";
            /*if (itinerario.estado == Estado.Cancelada) // TODO: Gestionar itinerario cancelado
            {
                confirmacionBox.Enabled = false;
                gestionarItinerarioBox.Enabled = false;
                cancelarReservaBtn.Enabled = false;
                return;
            }*/
            generarPreReservaBtn.Enabled = model.puedePrereserva();
            generarReservaBtn.Enabled = model.PuedeReserva();
            gestionarItinerarioBox.Enabled = model?.Itinerario?.Estado == Estado.Presupuesto;
            abonadoLabel.Text = $"Itinerario Abonado: {(model?.Itinerario?.ItinerarioPagado == true ? "Si" : "No")}";
            precioTotalLabel.Text = $"Precio Total: ${model?.Itinerario?.CalcularPrecioTotal().ToString()}";
        }

        private void poblarListaPasajeros()
        {
            // TODO


            //pasajerosListView.Items.Clear();

            //model.Itinerario.Pasajeros.ForEach(pasajero =>
            //{
            //    var item = new ListViewItem();
            //    item.Text = pasajero.Nombre + " " + pasajero.Apellido;
            //    item.SubItems.Add(pasajero.FechaNacimiento.ToString());
            //    item.Tag = pasajero;

            //    pasajerosListView.Items.Add(item);
            //});
        }

        private void hotelesBtn_Click(object sender, EventArgs e)
        {
            hotelesForm = new HotelesForm(model.Itinerario);
            hotelesForm.ShowDialog();
            refrescar();
        }

        private void generarPreReserva_Click(object sender, EventArgs e)
        {
            agregarDatosForm = new AgregarDatosForm(model.Itinerario, true);

            agregarDatosForm.ShowDialog();
            refrescar();
        }

        private void salirBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void generarReservaBtn_Click(object sender, EventArgs e)
        {
            if (model.Itinerario.Estado == Estado.Presupuesto)
            {
                agregarDatosForm = new AgregarDatosForm(model.Itinerario, false);
                agregarDatosForm.ShowDialog();
                refrescar();
            }

            DialogResult confirmar = MessageBox.Show("Esta seguro de que desea confirmar la reserva?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (confirmar == DialogResult.OK)
            {
                model.GenerarReserva();
                refrescar();
            }
        }

        private void clienteBtn_Click(object sender, EventArgs e)
        {
            clienteForm = new ClienteForm(model.Itinerario);
            clienteForm.ShowDialog();
            refrescar();
        }

        private void cancelarReservaBtn_Click(object sender, EventArgs e)
        {
            DialogResult confirmar = MessageBox.Show("Esta seguro de que desea CANCELAR la reserva?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (confirmar == DialogResult.OK)
            {
                model.CancelarItinerario();
                refrescar();
            }
        }

        private void vuelosBtn_Click(object sender, EventArgs e)
        {
            vuelosForm = new VuelosForm(model.Itinerario);
            vuelosForm.ShowDialog();
            refrescar();
        }

        private void poblarHotelesAgregados()
        {
            hotelesAgregadosListView.Items.Clear();
            model.Itinerario.HotelesSeleccionados.ForEach(reservaHotel =>
            {
                ListViewItem item = new ListViewItem();
                item.Text = reservaHotel.Hotel.Disponibilidad?.Nombre;
                item.SubItems.Add(Constantes.Ciudades[reservaHotel.Hotel.CodigoCiudad]);
                item.SubItems.Add(reservaHotel.Hotel.Disponibilidad.Fecha.ToString());
                item.SubItems.Add(reservaHotel.Hotel.Disponibilidad.Fecha.ToString());
                item.SubItems.Add("$ " + AlmacenHoteles.ObtenerPrecioTotal(model.Itinerario.Hoteles).ToString());
                item.SubItems.Add(reservaHotel.Hotel.NombreHotel);
                item.SubItems.Add(reservaHotel.Hotel.Calificacion.ToString());
                item.Tag = reservaHotel;

                hotelesAgregadosListView.Items.Add(item);
            });
        }

        private void poblarVuelosAgregados()
        {
            vuelosAgregadosListView.Items.Clear();

            model.Itinerario.VuelosAgregados.ForEach(vuelo =>
            {
                List<TarifaVuelo> tarifas = vuelo.Vuelo.Tarifas.Where(tarifa => tarifa.Clase == vuelo.Clase).ToList();

                ListViewItem item = new ListViewItem();
                item.Text = vuelo.Vuelo.FechaSalida.ToString(FORMATO_FECHA);
                item.SubItems.Add(Constantes.Aerolineas[vuelo.Vuelo.Aerolinea]);
                item.SubItems.Add(Constantes.Ciudades[vuelo.Vuelo.Origen]);
                item.SubItems.Add(Constantes.Ciudades[vuelo.Vuelo.Destino]);
                item.SubItems.Add(Constantes.Clases[tarifas[0].Clase]);
                item.SubItems.Add($"A({vuelo.CantidadAdultos}), M({vuelo.CantidadMenores}), I({vuelo.CantidadInfantes})");
                item.SubItems.Add(vuelo.PrecioTotal.ToString());
                item.SubItems.Add(vuelo.Vuelo.TiempoDeVuelo);
                item.SubItems.Add(tarifas[0].Precio.ToString());
                item.SubItems.Add(tarifas[1].Precio.ToString());
                item.SubItems.Add(tarifas[2].Precio.ToString());
                item.Tag = vuelo;

                vuelosAgregadosListView.Items.Add(item);
            });
        }

        private void anularItinerarioBtn_Click(object sender, EventArgs e)
        {
            var confirmar = MessageBox.Show("¿Está seguro de que desea anular el itinerario?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (confirmar == DialogResult.OK)
            {
                // TODO: Anular itinerario...
            }
        }
    }
}
