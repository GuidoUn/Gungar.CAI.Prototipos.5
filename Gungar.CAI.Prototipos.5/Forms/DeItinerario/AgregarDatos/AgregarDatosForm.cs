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
using Gungar.CAI.Prototipos._5.Forms.DeItinerario.AgregarDatos;
using Gungar.CAI.Prototipos._5.Forms.DeItinerario.MenuItinerario;
using Gungar.CAI.Prototipos._5.Modulos;

namespace Gungar.CAI.Prototipos._5
{
    public partial class AgregarDatosForm : Form
    {
        AgregarDatosFormModel model;

        public AgregarDatosForm()
        {
            InitializeComponent();
        }

        private void AgregarDatosForm_Load(object sender, EventArgs e)
        {
            model = new AgregarDatosFormModel(VentasModulo.ItinerarioSeleccionado);

            HashSet<Pasajero> pasajerosUnicos = new HashSet<Pasajero>();

            model.GetProductosAgregados(model.Itinerario.ItinerarioId).ForEach(producto =>
            {
                producto.Pasajeros.ForEach(pasajero => pasajerosUnicos.Add(pasajero));
            });
            model.PasajerosItinerario = new List<Pasajero>(pasajerosUnicos);

            fechaNacDatePicker.MaxDate = DateTime.Today;

            itinerarioLabel.Text = $"{model.Itinerario?.Cliente?.Nombre} ({model.Itinerario?.ItinerarioId})";
            evaluarTextosDeSeleccion();
            poblarListaPasajeroPorProducto();
            PoblarPasajerosItinerario();
            poblarProductosAgregados();
        }

        private void poblarProductosAgregados()
        {
            productosAgregadosListView.Items.Clear();
            foreach (var reservaHotel in model.Itinerario.HotelesSeleccionados)
            {
                var item = new ListViewItem();
                item.Text = reservaHotel.Hotel.CodigoOferta;
                item.SubItems.Add("Hotel - " + reservaHotel.Hotel.Disponibilidad.Nombre);
                item.SubItems.Add(Constantes.Ciudades[reservaHotel.Hotel.CodigoCiudad]);
                item.SubItems.Add(reservaHotel.Hotel.FechaDesde.ToString(Constantes.FORMATO_FECHA_CORTA));
                item.SubItems.Add(reservaHotel.Hotel.FechaHasta.ToString(Constantes.FORMATO_FECHA_CORTA));
                item.SubItems.Add(reservaHotel.Hotel.Disponibilidad.Tarifa.ToString()); // TODO: Calcular precio total en base a la cantidad de noches (TODO: calcular la cant de noches)
                item.SubItems.Add($"A({reservaHotel.CantidadAdultos}), M({reservaHotel.CantidadMenores}), I({reservaHotel.CantidadInfantes})");
                item.SubItems.Add(reservaHotel.Hotel.NombreHotel);
                item.SubItems.Add($"{reservaHotel.Hotel.Calificacion} Estrella{(reservaHotel.Hotel.Calificacion != 1 ? "s" : "")}");

                item.Tag = reservaHotel;

                productosAgregadosListView.Items.Add(item);
            }

            model.Itinerario.VuelosAgregados.ForEach(reservaVuelo =>
                {
                    var item = new ListViewItem();
                    item.Text = reservaVuelo.Vuelo.CodigoOferta;
                    item.SubItems.Add("Vuelo");
                    item.SubItems.Add(reservaVuelo.Vuelo.Origen + " - " + reservaVuelo.Vuelo.Destino);
                    item.SubItems.Add(reservaVuelo.Vuelo.FechaSalida.ToString(Constantes.FORMATO_FECHA_LARGA));
                    item.SubItems.Add(reservaVuelo.Vuelo.FechaArribo.ToString(Constantes.FORMATO_FECHA_LARGA));
                    item.SubItems.Add(reservaVuelo.PrecioTotal.ToString());
                    item.SubItems.Add($"A({reservaVuelo.CantidadAdultos}), M({reservaVuelo.CantidadMenores}), I({reservaVuelo.CantidadInfantes})");
                    item.SubItems.Add(Constantes.Aerolineas[reservaVuelo.Vuelo.Aerolinea]);
                    item.SubItems.Add(Constantes.Clases[reservaVuelo.Clase]);

                    item.Tag = reservaVuelo;

                    productosAgregadosListView.Items.Add(item);
                });
        }

        private void poblarListaPasajeroPorProducto()
        {
            pasajerosProductoListView.Items.Clear();

            List<IReservaProducto> reservaProductos = model.GetProductosAgregados(model.Itinerario.ItinerarioId);

            reservaProductos.ForEach(reservaProducto =>
            {
                reservaProducto.Pasajeros.ForEach(pasajero =>
                {
                    var item = new ListViewItem();
                    item.Text = reservaProducto is ReservaHotel reservaHotel ? reservaHotel.Hotel.CodigoOferta : reservaProducto is ReservaVuelo reservaVuelo ? reservaVuelo.Vuelo.CodigoOferta : "";

                    item.SubItems.Add(pasajero.Documento);
                    item.SubItems.Add(pasajero.Nombre);
                    item.SubItems.Add(pasajero.Apellido);
                    item.SubItems.Add(pasajero.FechaNacimiento.ToString(Constantes.FORMATO_FECHA_CORTA));
                    item.Tag = pasajero;

                    pasajerosProductoListView.Items.Add(item);
                });
            });
        }

        private void PoblarPasajerosItinerario()
        {
            pasajerosItinerarioListView.Items.Clear();

            model.PasajerosItinerario.ForEach(pasajero =>
            {
                var item = new ListViewItem();
                item.Text = pasajero.Nombre;
                item.SubItems.Add(pasajero.Apellido);
                item.SubItems.Add(pasajero.Documento);
                item.SubItems.Add(pasajero.FechaNacimiento.ToString(Constantes.FORMATO_FECHA_CORTA));
                item.Tag = pasajero;
                pasajerosItinerarioListView.Items.Add(item);

            });
        }

        private void vaciarCampos()
        {
            nombreTextBox.Text = "";
            apellidoTextBox.Text = "";
            DNITextBox.Text = "";
            fechaNacDatePicker.Value = new DateTime(2023, 06, 3);
        }

        private void agregarPasajeroBtn_Click(object sender, EventArgs e)
        {
            if (!Validador.ValidarCampoRequerido(nombreTextBox, "Nombre")) return;
            if (!Validador.ValidarCampoRequerido(apellidoTextBox, "Apellido")) return;
            if (!Validador.ValidarCampoRequerido(DNITextBox, "Documento")) return;

            if (model.PasajerosItinerario.Any(pasajero => pasajero.Documento == DNITextBox.Text) && !model.EditandoPasajero)
            {
                MessageBox.Show("El pasajero ya ha sido agregado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (model.PasajerosItinerario.Any(pasajero => pasajero.Documento == model.PasajeroItinerarioSeleccionado?.Documento) && model.EditandoPasajero)
            {
                var PasajeroAModificar = model.PasajerosItinerario.Find(pasajero => pasajero.Documento == model.PasajeroItinerarioSeleccionado?.Documento);
                PasajeroAModificar.Documento = DNITextBox.Text;
                PasajeroAModificar.Apellido = apellidoTextBox.Text;
                PasajeroAModificar.Nombre = nombreTextBox.Text;
                PasajeroAModificar.FechaNacimiento = fechaNacDatePicker.Value;
                model.EditandoPasajero = false;
                editarPasajeroBtn.Text = "Editar";
            }
            else
            {
                Pasajero nuevoPasajero = new Pasajero(nombreTextBox.Text, apellidoTextBox.Text, DNITextBox.Text, fechaNacDatePicker.Value);
                model.PasajerosItinerario.Add(nuevoPasajero);
            }

            poblarListaPasajeroPorProducto();
            vaciarCampos();
            PoblarPasajerosItinerario();
            evaluarTextosDeSeleccion();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void quitarAsignacionBtn_Click(object sender, EventArgs e)
        {
            model.ProductoSeleccionado.Pasajeros.Remove(model.PasajeroProductoSeleccionado);
            model.PasajeroProductoSeleccionado = null;
            evaluarTextosDeSeleccion();
            poblarListaPasajeroPorProducto();
            evaluarVisibilidadBtns();
        }

        private void evaluarTextosDeSeleccion()
        {
            if (model.PasajeroItinerarioSeleccionado == null)
            {
                pasajeroLabel.Text = "Ningun pasajero seleccionado";

            }
            if (model.ProductoSeleccionado == null)
            {
                productoLabel.Text = "Ningun producto seleccionado";
            }
        }

        private void evaluarVisibilidadBtns()
        {
            quitarAsignacionBtn.Enabled = model.PasajeroProductoSeleccionado != null;
            editarPasajeroBtn.Enabled = model.PasajeroItinerarioSeleccionado != null;
            eliminarPasajeroBtn.Enabled = model.PasajeroItinerarioSeleccionado != null;

            asignarBtn.Enabled = model.PasajeroItinerarioSeleccionado != null && model.ProductoSeleccionado != null;
        }

        private void confirmarBtn_Click(object sender, EventArgs e)
        {
            if (!model.TodosLosProductosTienenPasajeros())
            {
                MessageBox.Show("Todos los productos tienen que tener asignados al menos UN pasajero", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            if (!model.ConcidenPasajerosConProductos(model.Itinerario.ItinerarioId))
            {
                MessageBox.Show("La edad de los pasajeros añadidos deben coincidir con los seleccionados", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            DialogResult confirmar = MessageBox.Show("Desea confirmar la prereserva?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (confirmar == DialogResult.OK)
            {
                model.Itinerario.GenerarPrereserva();
                Close();
            }
        }

        private void productosAgregadosListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (productosAgregadosListView.SelectedItems.Count == 0) return;
            model.ProductoSeleccionado = (IReservaProducto)productosAgregadosListView.SelectedItems[0].Tag;
            if (model.ProductoSeleccionado is ReservaHotel reservaHotel)
            {
                productoLabel.Text = reservaHotel.Hotel.Disponibilidad.Nombre;
            }
            else if (model.ProductoSeleccionado is ReservaVuelo reservaVuelo)
            {
                productoLabel.Text = reservaVuelo.Vuelo.CodigoOferta;
            }
            poblarListaPasajeroPorProducto();
            evaluarVisibilidadBtns();
            evaluarTextosDeSeleccion();
        }

        private bool PasajeroYaSeAgregoAlProductoSeleccionado(Pasajero pasajero)
        {
            return model.ProductoSeleccionado.Pasajeros.Contains(pasajero);
        }

        private void asignarBtn_Click(object sender, EventArgs e)
        {
            if (model.PasajeroItinerarioSeleccionado == null || model.ProductoSeleccionado == null || PasajeroYaSeAgregoAlProductoSeleccionado(model.PasajeroItinerarioSeleccionado)) return;
            model.ProductoSeleccionado.Pasajeros.Add(model.PasajeroItinerarioSeleccionado);
            model.PasajeroItinerarioSeleccionado = null;
            poblarListaPasajeroPorProducto();
            evaluarVisibilidadBtns();
            evaluarTextosDeSeleccion();
        }

        private void pasajerosItinerarioListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pasajerosItinerarioListView.SelectedItems.Count == 0)
            {
                return;
            }

            model.PasajeroItinerarioSeleccionado = (Pasajero)pasajerosItinerarioListView.SelectedItems[0].Tag;
            pasajeroLabel.Text = model.PasajeroItinerarioSeleccionado.Documento;
            evaluarVisibilidadBtns();
            evaluarTextosDeSeleccion();
        }

        private void pasajerosProductoListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pasajerosProductoListView.SelectedItems.Count == 0)
            {
                return;
            }
            model.PasajeroProductoSeleccionado = (Pasajero)pasajerosProductoListView.SelectedItems[0].Tag;

            evaluarVisibilidadBtns();
            evaluarTextosDeSeleccion();
        }

        private void editarPasajeroBtn_Click(object sender, EventArgs e)
        {
            if (model.PasajeroItinerarioSeleccionado == null) return;

            model.EditandoPasajero = !model.EditandoPasajero;
            if (model.EditandoPasajero)
            {
                editarPasajeroBtn.Text = "Cancelar Edicion";
                vaciarCampos();
            }
            else
            {
                editarPasajeroBtn.Text = "Editar";
            }
            nombreTextBox.Text = model.PasajeroItinerarioSeleccionado.Nombre;
            apellidoTextBox.Text = model.PasajeroItinerarioSeleccionado.Apellido;
            DNITextBox.Text = model.PasajeroItinerarioSeleccionado.Documento;

            fechaNacDatePicker.Value = model.PasajeroItinerarioSeleccionado.FechaNacimiento;
            evaluarTextosDeSeleccion();
        }

        private void eliminarPasajeroBtn_Click(object sender, EventArgs e)
        {
            if (model.PasajeroItinerarioSeleccionado == null) return;

            model.PasajerosItinerario.Remove(model.PasajeroItinerarioSeleccionado);
            model.EliminarPasajeroSeleccionadoDeTodosLosProductos();
            poblarListaPasajeroPorProducto();
            PoblarPasajerosItinerario();
            model.PasajeroItinerarioSeleccionado = null;
        }

        private void nombreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ' ')
            {
                e.Handled = true; // Evita que se escriban números y caracteres especiales
            }
        }

        private void apellidoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ' ')
            {
                e.Handled = true; // Evita que se escriban números y caracteres especiales
            }
        }

        private void documentoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true; // Evita que se escriban caracteres especiales
            }
        }
    }
}
