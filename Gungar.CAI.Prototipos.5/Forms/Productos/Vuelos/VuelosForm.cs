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
using Gungar.CAI.Prototipos._5.Entidades.DeItinerario.Reservas;
using Gungar.CAI.Prototipos._5.Entidades.Oferta;
using Gungar.CAI.Prototipos._5.Forms.Productos.Vuelos;
using Gungar.CAI.Prototipos._5.Modulos;

namespace Gungar.CAI.Prototipos._5
{
    public partial class VuelosForm : Form
    {
        VuelosFormModel model;

        public VuelosForm()
        {
            InitializeComponent();
        }

        private void VuelosForm_Load(object sender, EventArgs e)
        {
            model = new VuelosFormModel(VentasModulo.ItinerarioSeleccionado);

            if (model.EsConsulta)
            {
                titleLabel.Text = "Consulta disponibilidad de vuelos";
                itinerarioLabel.Text = "";
                modificarItinerarioBox.Visible = false;
            }
            else
            {
                itinerarioLabel.Text = model?.Itinerario?.Cliente?.GetNombreYApellido();
            }

            clasesCombo.SelectedItem = clasesCombo.Items[0];
            cantidadAdultosNumeric.Value = 1;

            idaDatePicker.MinDate = DateTime.Now;
            vueltaDatePicker.MinDate = DateTime.Now;

            desdePreciosNumeric.Text = "";
            hastaPreciosNumeric.Text = "";

            pasajerosEnBusquedaBox.Visible = false;

            borrarFechas();
            poblarVuelosAgregados();
            refrescar();
        }

        private void borrarFechas()
        {
            idaDatePicker.Format = DateTimePickerFormat.Custom;
            idaDatePicker.CustomFormat = " ";

            vueltaDatePicker.Format = DateTimePickerFormat.Custom;
            vueltaDatePicker.CustomFormat = " ";

            model.FechaIdaSeleccionada = null;
            model.FechaVueltaSeleccionada = null;
        }

        private void refrescar()
        {
            vueltaBox.Visible = !model.EsSoloIda;
            vueltaLabel.Visible = !model.EsSoloIda;
            vueltaDatePicker.Visible = !model.EsSoloIda;
            aplicarFiltrosBtn.Enabled = cantidadAdultosNumeric.Value > 0;
            agregarProductoBtn.Enabled = evaluarMostrarAgregarProducto();
            quitarProductoBtn.Enabled = vuelosAgregadosListView.SelectedItems.Count == 1;
        }

        private bool evaluarMostrarAgregarProducto()
        {
            if (vuelosIdaListView.SelectedItems.Count == 0)
                return false;
            if (soloIdaCheckBox.Checked)
                return true;
            return vuelosVueltaListView.SelectedItems.Count == 1;
        }

        private void poblarVuelos()
        {
            vuelosIdaListView.Items.Clear();
            vuelosVueltaListView.Items.Clear();
            int precioDesde = desdePreciosNumeric.Text == "" ? 0 : Decimal.ToInt32(desdePreciosNumeric.Value);
            int precioHasta = hastaPreciosNumeric.Text == "" ? 0 : Decimal.ToInt32(hastaPreciosNumeric.Value);

            List<OfertaVuelo> vuelosIdaDisponibles = model.GetVuelosDisponibles(origenText.Text, destinoText.Text, Decimal.ToInt32(cantidadAdultosNumeric.Value), Decimal.ToInt32(cantidadMenoresNumeric.Value), Decimal.ToInt32(cantidadInfantesNumeric.Value), clasesCombo.Text[0], model.FechaIdaSeleccionada, model.FechaIdaSeleccionada, precioDesde, precioHasta);

            vuelosIdaDisponibles.ForEach(vuelo =>
            {
                ListViewItem item = new ListViewItem();
                List<TarifaVuelo> tarifas = vuelo.Tarifas.Where(tarifa => tarifa.Clase == clasesCombo.Text[0]).ToList();

                item.Text = Constantes.Aerolineas[vuelo.Aerolinea];
                item.SubItems.Add(Constantes.Ciudades[vuelo.Origen]);
                item.SubItems.Add(Constantes.Ciudades[vuelo.Destino]);
                item.SubItems.Add(vuelo.FechaSalida.ToString(Constantes.FORMATO_FECHA_LARGA));
                item.SubItems.Add(vuelo.TiempoDeVuelo);
                item.SubItems.Add(Constantes.Clases[tarifas[0].Clase]);
                item.SubItems.Add(getStringPrecioDisponibilidad(tarifas[0]));
                item.SubItems.Add(getStringPrecioDisponibilidad(tarifas[1]));
                item.SubItems.Add(getStringPrecioDisponibilidad(tarifas[2]));
                item.Tag = vuelo;

                vuelosIdaListView.Items.Add(item);
            });

            if (!model.EsSoloIda && vuelosIdaDisponibles.Count > 0)
            {
                List<OfertaVuelo> vuelosVueltaDisponibles = model.GetVuelosDisponibles(destinoText.Text, origenText.Text, Decimal.ToInt32(cantidadAdultosNumeric.Value), Decimal.ToInt32(cantidadMenoresNumeric.Value), Decimal.ToInt32(cantidadInfantesNumeric.Value), clasesCombo.Text[0], model.FechaVueltaSeleccionada ?? model.FechaIdaSeleccionada, model.FechaVueltaSeleccionada ?? null, Decimal.ToInt32(desdePreciosNumeric.Value), Decimal.ToInt32(hastaPreciosNumeric.Value));

                vuelosVueltaDisponibles.ForEach(vuelo =>
                {
                    ListViewItem item = new ListViewItem();
                    List<TarifaVuelo> tarifas = vuelo.Tarifas.Where(tarifa => tarifa.Clase == clasesCombo.Text[0]).ToList();

                    item.Text = Constantes.Aerolineas[vuelo.Aerolinea];
                    item.SubItems.Add(Constantes.Ciudades[vuelo.Origen]);
                    item.SubItems.Add(Constantes.Ciudades[vuelo.Destino]);
                    item.SubItems.Add(vuelo.FechaSalida.ToString(Constantes.FORMATO_FECHA_LARGA));
                    item.SubItems.Add(vuelo.TiempoDeVuelo);
                    item.SubItems.Add(Constantes.Clases[tarifas[0].Clase]);
                    item.SubItems.Add(getStringPrecioDisponibilidad(tarifas[0]));
                    item.SubItems.Add(getStringPrecioDisponibilidad(tarifas[1]));
                    item.SubItems.Add(getStringPrecioDisponibilidad(tarifas[2]));
                    item.Tag = vuelo;

                    vuelosVueltaListView.Items.Add(item);
                });
            }
        }

        private void poblarVuelosAgregados()
        {
            vuelosAgregadosListView.Items.Clear();

            List<ReservaVuelo> vuelosAgregados = model.GetVuelosAgregados();

            vuelosAgregados.ForEach(vuelo =>
            {
                List<TarifaVuelo> tarifas = vuelo.Vuelo.Tarifas.Where(tarifa => tarifa.Clase == vuelo.Clase).ToList();

                ListViewItem item = new ListViewItem();
                item.Text = vuelo.Vuelo.FechaSalida.ToString(Constantes.FORMATO_FECHA_LARGA);
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

        private string getStringPrecioDisponibilidad(TarifaVuelo tarifa)
        {
            if (tarifa.Disponibilidad <= 0)
                return $"-";

            return $"${tarifa.Precio} ({tarifa.Disponibilidad})";
        }

        private void soloIdaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            model.EsSoloIda = soloIdaCheckBox.Checked;
            refrescar();
        }

        private void aplicarFiltrosBtn_Click(object sender, EventArgs e)
        {
            poblarVuelos();
            refrescar();
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

            model.ClaseEnBusqueda = clasesCombo.Text[0];
        }

        private void cantidadAdultosNumeric_ValueChanged(object sender, EventArgs e)
        {
            refrescar();
        }

        private void idaDatePicker_ValueChanged(object sender, EventArgs e)
        {
            idaDatePicker.Format = DateTimePickerFormat.Short;
            model.FechaIdaSeleccionada = idaDatePicker.Value;
        }

        private void vueltaDatePicker_ValueChanged(object sender, EventArgs e)
        {
            vueltaDatePicker.Format = DateTimePickerFormat.Short;
            model.FechaVueltaSeleccionada = vueltaDatePicker.Value;
        }

        private void borrarFechasBtn_Click(object sender, EventArgs e)
        {
            borrarFechas();
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void vuelosIdaListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            refrescar();
        }

        private void vuelosVueltaListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            refrescar();
        }

        private void vuelosAgregadosListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(vuelosAgregadosListView);
            refrescar();
        }

        private void agregarProductoBtn_Click(object sender, EventArgs e)
        {
            OfertaVuelo ofertaIda = (OfertaVuelo)vuelosIdaListView.SelectedItems[0].Tag;
            model.agregarVuelo(ofertaIda, model.ClaseEnBusqueda, model.AdultosEnBusqueda, model.MenoresEnBusqueda, model.InfantesEnBusqueda);
            if (!soloIdaCheckBox.Checked)
            {
                OfertaVuelo ofertaVuelta = (OfertaVuelo)vuelosVueltaListView.SelectedItems[0].Tag;
                model.agregarVuelo(ofertaVuelta, model.ClaseEnBusqueda, model.AdultosEnBusqueda, model.MenoresEnBusqueda, model.InfantesEnBusqueda);
            }
            vuelosIdaListView.SelectedItems.Clear();
            vuelosVueltaListView.SelectedItems.Clear();
            poblarVuelosAgregados();
            poblarVuelos();
            refrescar();
        }

        private void quitarProductoBtn_Click(object sender, EventArgs e)
        {
            model.quitarVuelo((ReservaVuelo)vuelosAgregadosListView.SelectedItems[0].Tag);
            poblarVuelosAgregados();
            poblarVuelos();
            refrescar();
        }
    }
}
