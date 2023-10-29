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
using Gungar.CAI.Prototipos._5.Forms.DeItinerario.MenuItinerario;

namespace Gungar.CAI.Prototipos._5
{
    public partial class MenuItinerarioForm : Form
    {
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

            //clienteForm = new ClienteForm(itinerario);
            itinerarioSeleccionadoLabel.Text = $"{itinerario.ItinerarioId}";
        }

        private void refrescar()
        {
            poblarListaPasajeros();
            poblarItinerario();
            poblarHotelesAgregados();
            estadoLabel.Text = model.Itinerario?.Estado.ToString();
            nombreYApellidoLabel.Text = $"{model.Itinerario?.Cliente?.Nombre} {model.Itinerario?.Cliente?.Apellido}";
            /*if (itinerario.estado == Estado.Cancelada)
            {
                confirmacionBox.Enabled = false;
                gestionarItinerarioBox.Enabled = false;
                cancelarReservaBtn.Enabled = false;
                return;
            }*/
            confirmacionBox.Enabled = !(model.Itinerario?.HotelesSeleccionados.Count == 0 || model.Itinerario?.Estado == Estado.Pagada);
            gestionarItinerarioBox.Enabled = model?.Itinerario?.Estado == Estado.Presupuesto;
        }

        private void MenuItinerarioForm_Load(object sender, EventArgs e)
        {
            itinerarioSeleccionadoLabel.Text = $"{model.Itinerario.ItinerarioId}";
            nombreYApellidoLabel.Text = $"{model.Itinerario?.Cliente?.Nombre} {model.Itinerario?.Cliente?.Apellido}";
            refrescar();
            poblarListaPasajeros();
        }

        public void poblarListaPasajeros()
        {
            pasajerosListView.Items.Clear();

            foreach (var pasajero in model.Itinerario.Pasajeros)
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
            // TODO: Agregar los productos
            //productosAgregadosListView.Items.Clear();
            //foreach (var producto in model.Itinerario.)
            //{
            //    var item = new ListViewItem();
            //    item.Text = producto[0];
            //    item.SubItems.Add(producto[1]);
            //    item.SubItems.Add(producto[2]);
            //    item.SubItems.Add(producto[3]);
            //    item.SubItems.Add(producto[4]);
            //    item.SubItems.Add(producto[5]);
            //    item.SubItems.Add(producto[6]);
            //    item.Tag = producto;

            //    productosAgregadosListView.Items.Add(item);
            //}
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
            foreach (var reservaHotel in model.Itinerario.HotelesSeleccionados)
            {
                var item = new ListViewItem();
                item.Text = reservaHotel.Hotel.Disponibilidad.Nombre;
                item.SubItems.Add(OfertaHotel.CodigoACiudad[reservaHotel.Hotel.CodigoCiudad]);
                item.SubItems.Add(reservaHotel.Hotel.Disponibilidad.Fecha.ToString());
                item.SubItems.Add(reservaHotel.Hotel.Disponibilidad.Fecha.ToString());
                item.SubItems.Add("$ " + HotelesModel.ObtenerPrecioTotal(model.Itinerario.Hoteles).ToString());
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
