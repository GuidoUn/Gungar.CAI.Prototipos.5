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
using Gungar.CAI.Prototipos._5.Entidades;
using Gungar.CAI.Prototipos._5.Entidades.DeItinerario;
using Gungar.CAI.Prototipos._5.Entidades.DeItinerario.Reservas;
using Gungar.CAI.Prototipos._5.Modulos;

namespace Gungar.CAI.Prototipos._5
{
    public partial class AgregarDatosForm : Form
    {
        Itinerario? itinerario;

        Pasajero? pasajeroItinerarioSeleccionado;

        Pasajero? pasajeroProductoSeleccionado;

        List<Pasajero> pasajerosItinerario;

        bool editandoPasajero = false;



        //ReservaHotel hotelSeleccionado;

        IReservaProducto productoSeleccionado;


        public AgregarDatosForm(Itinerario itinerario, bool esPreReserva)
        {
            InitializeComponent();
            this.itinerario = itinerario;
            HashSet<Pasajero> pasajerosUnicos = new HashSet<Pasajero>();

            VentasModulo.GetProductosAgregados(itinerario.ItinerarioId).ForEach(producto =>
            {
                producto.Pasajeros.ForEach(pasajero => pasajerosUnicos.Add(pasajero));
            });
            pasajerosItinerario = new List<Pasajero>(pasajerosUnicos);


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
            pasajerosProductoListView.Items.Clear();

            List<IReservaProducto> reservaProductos = VentasModulo.GetProductosAgregados(itinerario.ItinerarioId); // TODO: Usar model

            reservaProductos.ForEach(reservaProducto =>
            {
                reservaProducto.Pasajeros.ForEach(pasajero =>
                {
                    var item = new ListViewItem();
                    item.Text = pasajero.Documento;

                    //item.Text = pasajero.Nombre;
                    //item.SubItems.Add(pasajero.Apellido);
                    //item.SubItems.Add(pasajero.Documento);
                    //item.SubItems.Add(pasajero.Email);
                    //item.SubItems.Add(pasajero.Telefono);
                    //item.SubItems.Add(pasajero.FechaNacimiento.ToString());
                    item.Tag = pasajero;

                    pasajerosProductoListView.Items.Add(item);
                });
            });
        }

        private void PoblarPasajerosItinerario()
        {
            pasajerosItinerarioListView.Items.Clear();

            pasajerosItinerario.ForEach(pasajero =>
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

        }

        private void poblarListaPasajeros()
        {
            pasajerosProductoListView.Items.Clear();
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
                item.Text = pasajero.Documento;
                item.Tag = pasajero;

                pasajerosProductoListView.Items.Add(item);
            }
        }

        private void AgregarDatosForm_Load(object sender, EventArgs e)
        {
            itinerarioLabel.Text = $"{itinerario?.Cliente?.Nombre} ({itinerario?.ItinerarioId})";
            evaluarTextosDeSeleccion();
            poblarListaPasajeros();
            PoblarPasajerosItinerario();
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

            if (pasajerosItinerario.Any(pasajero => pasajero.Documento == pasajeroItinerarioSeleccionado?.Documento) && editandoPasajero)
            {
                var PasajeroAModificar = pasajerosItinerario.Find(pasajero => pasajero.Documento == pasajeroItinerarioSeleccionado?.Documento);
                PasajeroAModificar.Email = emailTextBox.Text;
                PasajeroAModificar.Documento = DNITextBox.Text;
                PasajeroAModificar.Apellido = apellidoTextBox.Text;
                PasajeroAModificar.Telefono = telefonoTextBox.Text;
                PasajeroAModificar.Nombre = nombreTextBox.Text;
                PasajeroAModificar.FechaNacimiento = fechaNacDatePicker.Value.ToString(Constantes.FORMATO_FECHA_CORTA);
                editandoPasajero = false;
                editarPasajeroBtn.Text = "Editar";
            }
            else
            {
                Pasajero nuevoPasajero = new Pasajero(nombreTextBox.Text, apellidoTextBox.Text, DNITextBox.Text, emailTextBox.Text, telefonoTextBox.Text, fechaNacDatePicker.Value.ToString(Constantes.FORMATO_FECHA_CORTA));

                pasajerosItinerario.Add(nuevoPasajero);

            }



            poblarListaPasajeros();
            poblarListaTotalDePasajerosItinerario();
            vaciarCampos();
            PoblarPasajerosItinerario();
            evaluarTextosDeSeleccion();
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
            evaluarTextosDeSeleccion();
            poblarListaPasajeros();
            //poblarListaTotalDePasajerosItinerario();
            evaluarVisibilidadBtns();
        }

        private void evaluarTextosDeSeleccion()
        {
            if (pasajeroItinerarioSeleccionado == null)
            {
                pasajeroLabel.Text = "Ningun pasajero seleccionado";

            }
            if (productoSeleccionado == null)
            {
                productoLabel.Text = "Ningun producto seleccionado";

            }
        }
        private void evaluarVisibilidadBtns()
        {
            eliminarPasajeroBtn.Enabled = pasajeroProductoSeleccionado != null;
            editarPasajeroBtn.Enabled = pasajeroItinerarioSeleccionado != null;
            //asignarBtn.Enabled = pasajeroSeleccionado != null && hotelSeleccionado != null;
            asignarBtn.Enabled = pasajeroItinerarioSeleccionado != null && productoSeleccionado != null;
        }

        private void confirmarBtn_Click(object sender, EventArgs e)
        {
            DialogResult confirmar = MessageBox.Show("Desea confirmar la " + itinerario.tipoDeConfirmacion + "?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (confirmar == DialogResult.OK)
            {
                itinerario.GenerarPrereserva();
                this.Close();
            }

            
        }

        private void productosAgregadosListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (productosAgregadosListView.SelectedItems.Count == 0) return;
            //hotelSeleccionado = (ReservaHotel)productosAgregadosListView.SelectedItems[0].Tag;
            productoSeleccionado = (IReservaProducto)productosAgregadosListView.SelectedItems[0].Tag;
            if (productoSeleccionado is ReservaHotel reservaHotel)
            {
                productoLabel.Text = reservaHotel.Hotel.Disponibilidad.Nombre;

            }
            else if (productoSeleccionado is ReservaVuelo reservaVuelo)
            {
                productoLabel.Text = reservaVuelo.Vuelo.CodigoOferta;

            }
            poblarListaPasajeros();
            evaluarVisibilidadBtns();
            evaluarTextosDeSeleccion();
        }


        private bool PasajeroYaSeAgregoAlProductoSeleccionado(Pasajero pasajero)
        {
            return productoSeleccionado.Pasajeros.Contains(pasajero);
        }
        private void asignarBtn_Click(object sender, EventArgs e)
        {

            //if (pasajeroSeleccionado == null || hotelSeleccionado == null) return;
            if (pasajeroItinerarioSeleccionado == null || productoSeleccionado == null || PasajeroYaSeAgregoAlProductoSeleccionado(pasajeroItinerarioSeleccionado)) return;
            //hotelSeleccionado.Pasajeros.Add(pasajeroSeleccionado);
            productoSeleccionado.Pasajeros.Add(pasajeroItinerarioSeleccionado);
            pasajeroItinerarioSeleccionado = null;
            poblarListaPasajeros();
            evaluarVisibilidadBtns();
            evaluarTextosDeSeleccion();
        }


        private void pasajerosItinerarioListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pasajerosItinerarioListView.SelectedItems.Count == 0)
            {
                return;
            }

            pasajeroItinerarioSeleccionado = (Pasajero)pasajerosItinerarioListView.SelectedItems[0].Tag;
            pasajeroLabel.Text = pasajeroItinerarioSeleccionado.Documento;
            evaluarVisibilidadBtns();
            evaluarTextosDeSeleccion();

        }

        private void pasajerosProductoListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pasajerosProductoListView.SelectedItems.Count == 0)
            {
                return;
            }
            pasajeroProductoSeleccionado = (Pasajero)pasajerosProductoListView.SelectedItems[0].Tag;

            evaluarVisibilidadBtns();
            evaluarTextosDeSeleccion();

        }

        private void editarPasajeroBtn_Click(object sender, EventArgs e)
        {
            if (pasajeroItinerarioSeleccionado == null) return;

            editandoPasajero = !editandoPasajero;
            if (editandoPasajero)
            {
                editarPasajeroBtn.Text = "Cancelar Edicion";
                vaciarCampos();

            }
            else
            {
                editarPasajeroBtn.Text = "Editar";
            }
            nombreTextBox.Text = pasajeroItinerarioSeleccionado.Nombre;
            apellidoTextBox.Text = pasajeroItinerarioSeleccionado.Apellido;
            DNITextBox.Text = pasajeroItinerarioSeleccionado.Documento;
            emailTextBox.Text = pasajeroItinerarioSeleccionado.Email;
            telefonoTextBox.Text = pasajeroItinerarioSeleccionado.Telefono;
            fechaNacDatePicker.Text = pasajeroItinerarioSeleccionado.FechaNacimiento;
            evaluarTextosDeSeleccion();
        }


    }
}
