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
using Gungar.CAI.Prototipos._5.Modulos;

namespace Gungar.CAI.Prototipos._5
{
    public partial class MenuItinerarioForm : Form
    {
        MenuItinerarioFormModel model;

        public MenuItinerarioForm()
        {
            InitializeComponent();
        }

        private void MenuItinerarioForm_Load(object sender, EventArgs e)
        {
            model = new MenuItinerarioFormModel(VentasModulo.ItinerarioSeleccionado);

            model.AgregarDatosForm = new AgregarDatosForm(); // Hace falta? No sería mejor crear uno nuevo cada vez que apretan el botón? Total los datos los traemos de los módulos

            itinerarioSeleccionadoLabel.Text = $"{model.Itinerario.ItinerarioId}";

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

            cancelarReservaBtn.Enabled = !(model?.Itinerario?.Estado == Estado.Cancelada);

            generarPreReservaBtn.Enabled = model.puedePrereserva();
            generarReservaBtn.Enabled = model.PuedeReserva();
            faltaClienteLabel.Text = model.TieneCliente() ? "" : "* Debe agregar un cliente";
            faltaProductoLabel.Text = model.TieneProductos() ? "" : "* Debe agregar al menos un producto";
            gestionarItinerarioBox.Enabled = model?.Itinerario?.Estado == Estado.Presupuesto;
            abonadoLabel.Text = $"Itinerario Abonado: {(model?.Itinerario?.ItinerarioPagado == true ? "Si" : "No")}";
            precioTotalLabel.Text = $"Precio Total: ${model?.Itinerario?.CalcularPrecioTotal().ToString()}";
        }

        private void poblarListaPasajeros()
        {
            pasajerosListView.Items.Clear();

            List<IReservaProducto> ProductosSeleccionados = new List<IReservaProducto>();

            ProductosSeleccionados.AddRange(model.Itinerario.HotelesSeleccionados);
            ProductosSeleccionados.AddRange(model.Itinerario.VuelosAgregados);
            ProductosSeleccionados.ForEach(producto =>
            {
                producto.Pasajeros.ForEach(pasajero =>
                {
                    var item = new ListViewItem();

                    item.Text = producto is ReservaHotel reservaHotel ? reservaHotel.Hotel.CodigoOferta : producto is ReservaVuelo reservaVuelo ? reservaVuelo.Vuelo.CodigoOferta : "";
                    item.SubItems.Add(pasajero.Nombre + " " + pasajero.Apellido);
                    item.SubItems.Add(pasajero.FechaNacimiento.ToString(Constantes.FORMATO_FECHA_CORTA));
                    item.Tag = pasajero;
                    pasajerosListView.Items.Add(item);
                });
            });
        }

        private void hotelesBtn_Click(object sender, EventArgs e)
        {
            HotelesForm hotelesForm = new();
            hotelesForm.ShowDialog();
            refrescar();
        }

        private void generarPreReserva_Click(object sender, EventArgs e)
        {
            model?.AgregarDatosForm?.ShowDialog();
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
                model.AgregarDatosForm = new AgregarDatosForm();
                model.AgregarDatosForm.ShowDialog();
                refrescar();
            }

            DialogResult confirmar = MessageBox.Show("¿Estás seguro que deseas confirmar la reserva?", "Confirmar reserva", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (confirmar == DialogResult.OK)
            {
                model.GenerarReserva();
                refrescar();
            }
        }

        private void clienteBtn_Click(object sender, EventArgs e)
        {
            ClienteForm clienteForm = new();
            clienteForm.ShowDialog();
            refrescar();
        }

        private void cancelarReservaBtn_Click(object sender, EventArgs e)
        {
            DialogResult confirmar = MessageBox.Show("¿Estás seguro que deseas cancelar el itinerario?", "Cancelar itinerario", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (confirmar == DialogResult.OK)
            {
                model.CancelarItinerario();
                refrescar();
            }
        }

        private void vuelosBtn_Click(object sender, EventArgs e)
        {
            VuelosForm VuelosForm = new();
            VuelosForm.ShowDialog();
            refrescar();
        }

        private void poblarHotelesAgregados()
        {
            hotelesAgregadosListView.Items.Clear();
            model.Itinerario.HotelesSeleccionados.ForEach(reservaHotel =>
            {
                ListViewItem item = new ListViewItem();
                item.Text = reservaHotel.Hotel.CodigoOferta;
                item.SubItems.Add(reservaHotel.Hotel.Disponibilidad?.Nombre);
                item.SubItems.Add(Constantes.Ciudades[reservaHotel.Hotel.CodigoCiudad]);
                item.SubItems.Add(reservaHotel.Hotel.FechaDesde.ToString(Constantes.FORMATO_FECHA_CORTA));
                item.SubItems.Add(reservaHotel.Hotel.FechaHasta.ToString(Constantes.FORMATO_FECHA_CORTA));
                item.SubItems.Add("$ " + reservaHotel.PrecioTotal.ToString());
                item.SubItems.Add(reservaHotel.Hotel.NombreHotel);
                item.SubItems.Add(Constantes.CalificacionesInvertidas[reservaHotel.Hotel.Calificacion]);
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
                item.Text = vuelo.Vuelo.CodigoOferta;
                item.SubItems.Add(vuelo.Vuelo.FechaSalida.ToString(Constantes.FORMATO_FECHA_LARGA));
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
    }
}
