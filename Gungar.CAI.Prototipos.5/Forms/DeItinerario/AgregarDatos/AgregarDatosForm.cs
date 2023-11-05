﻿using System;
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
        Itinerario? itinerario; // TODO: Mover al model

        Pasajero? pasajeroItinerarioSeleccionado;   // TODO: Mover al model

        Pasajero? pasajeroProductoSeleccionado; // TODO: Mover al model

        List<Pasajero> pasajerosItinerario; // TODO: Mover al model

        bool editandoPasajero = false; // TODO: Mover al model

        //ReservaHotel hotelSeleccionado;

        IReservaProducto productoSeleccionado;// TODO: Mover al model

        AgregarDatosFormModel model;



        public AgregarDatosForm(Itinerario itinerario, bool esPreReserva)
        {
            InitializeComponent();
            this.itinerario = itinerario;
            model = new AgregarDatosFormModel(itinerario);
            HashSet<Pasajero> pasajerosUnicos = new HashSet<Pasajero>();

            VentasModulo.GetProductosAgregados(itinerario.ItinerarioId).ForEach(producto => // TODO: Usar model
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
                item.Text = reservaHotel.Hotel.CodigoOferta;
                item.SubItems.Add( reservaHotel.Hotel.NombreHotel);
                item.SubItems.Add(reservaHotel.Hotel.Disponibilidad.Nombre);
                item.Tag = reservaHotel;

                productosAgregadosListView.Items.Add(item);
            }

            itinerario.VuelosAgregados.ForEach(reservaVuelo =>
            {
                var item = new ListViewItem();
                item.Text = reservaVuelo.Vuelo.CodigoOferta;
                item.SubItems.Add(reservaVuelo.Vuelo.Aerolinea);
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
            fechaNacDatePicker.Value = new DateTime(2023, 06, 3);
        }

        private void agregarPasajeroBtn_Click(object sender, EventArgs e)
        {
            if (pasajerosItinerario.Any(pasajero => pasajero.Documento == DNITextBox.Text) && !editandoPasajero)
            {
                MessageBox.Show("El pasajero ya ha sido agregado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (pasajerosItinerario.Any(pasajero => pasajero.Documento == pasajeroItinerarioSeleccionado?.Documento) && editandoPasajero)
            {
                var PasajeroAModificar = pasajerosItinerario.Find(pasajero => pasajero.Documento == pasajeroItinerarioSeleccionado?.Documento);
                PasajeroAModificar.Documento = DNITextBox.Text;
                PasajeroAModificar.Apellido = apellidoTextBox.Text;
                PasajeroAModificar.Nombre = nombreTextBox.Text;
                PasajeroAModificar.FechaNacimiento = fechaNacDatePicker.Value.ToString(Constantes.FORMATO_FECHA_CORTA);
                editandoPasajero = false;
                editarPasajeroBtn.Text = "Editar";
            }
            else
            {
                Pasajero nuevoPasajero = new Pasajero(nombreTextBox.Text, apellidoTextBox.Text, DNITextBox.Text, fechaNacDatePicker.Value.ToString(Constantes.FORMATO_FECHA_CORTA));

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

        private void quitarAsignacionBtn_Click(object sender, EventArgs e)
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
            quitarAsignacionBtn.Enabled = pasajeroProductoSeleccionado != null;
            editarPasajeroBtn.Enabled = pasajeroItinerarioSeleccionado != null;
            eliminarPasajeroBtn.Enabled = pasajeroItinerarioSeleccionado != null;

            //asignarBtn.Enabled = pasajeroSeleccionado != null && hotelSeleccionado != null;
            asignarBtn.Enabled = pasajeroItinerarioSeleccionado != null && productoSeleccionado != null;
        }

        private void confirmarBtn_Click(object sender, EventArgs e)
        {
            if (!model.TodosLosProductosTienenPasajeros())
            {
                MessageBox.Show("Todos los productos tienen que tener asignados al menos UN pasajero", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
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

            fechaNacDatePicker.Text = pasajeroItinerarioSeleccionado.FechaNacimiento;
            evaluarTextosDeSeleccion();
        }


        private void EliminarPasajeroDeTodosLosProductos(Pasajero pasajero)
        {
            VentasModulo.GetProductosAgregados(itinerario.ItinerarioId).ForEach(reservaProducto => // TODO: Usar model
            {
                reservaProducto.Pasajeros.Remove(pasajero);
            });

        }
        private void eliminarPasajeroBtn_Click(object sender, EventArgs e)
        {
            if (pasajeroItinerarioSeleccionado == null) return;
            pasajerosItinerario.Remove(pasajeroItinerarioSeleccionado);
            EliminarPasajeroDeTodosLosProductos(pasajeroItinerarioSeleccionado);
            poblarListaTotalDePasajerosItinerario();
            PoblarPasajerosItinerario();
        }
    }
}
