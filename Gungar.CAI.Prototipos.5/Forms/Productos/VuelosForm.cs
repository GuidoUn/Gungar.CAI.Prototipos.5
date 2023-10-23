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
    public partial class VuelosForm : Form
    {
        Itinerario? itinerario;
        bool esConsulta = false;
        bool esSoloIda = false;

        DateTime? fechaIdaSeleccionada = null;
        DateTime? fechaVueltaSeleccionada = null;

        public VuelosForm(Itinerario? itinerario)
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

        private void VuelosForm_Load(object sender, EventArgs e)
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
            clasesCombo.SelectedItem = clasesCombo.Items[0];
            cantidadAdultosNumeric.Value = 1;

            idaDatePicker.MinDate = DateTime.Now;
            vueltaDatePicker.MinDate = DateTime.Now;

            borrarFechas();

            refrescar();
        }

        private void borrarFechas()
        {
            idaDatePicker.Format = DateTimePickerFormat.Custom;
            idaDatePicker.CustomFormat = " ";

            vueltaDatePicker.Format = DateTimePickerFormat.Custom;
            vueltaDatePicker.CustomFormat = " ";
        }

        private void poblarVuelos()
        {
            vuelosIdaListView.Items.Clear();
            vuelosVueltaListView.Items.Clear();
            bool isEconomy = clasesCombo.SelectedIndex == 0;

            List<OfertaVuelo> vuelosIdaDisponibles = VuelosModel.getVuelos(origenText.Text, destinoText.Text, Decimal.ToInt32(cantidadAdultosNumeric.Value), Decimal.ToInt32(cantidadMenoresNumeric.Value), Decimal.ToInt32(cantidadInfantesNumeric.Value), clasesCombo.SelectedItem.ToString()[0], fechaIdaSeleccionada, fechaIdaSeleccionada, Decimal.ToInt32(desdePreciosNumeric.Value), Decimal.ToInt32(hastaPreciosNumeric.Value));

            foreach (OfertaVuelo vuelo in vuelosIdaDisponibles)
            {
                ListViewItem item = new ListViewItem();
                item.Text = OfertaVuelo.Aerolineas[vuelo.Aerolinea];
                item.SubItems.Add(OfertaVuelo.Ciudades[vuelo.Origen]);
                item.SubItems.Add(OfertaVuelo.Ciudades[vuelo.Destino]);
                item.SubItems.Add(vuelo.FechaSalida.ToString(FORMATO_FECHA));
                item.SubItems.Add(vuelo.TiempoDeVuelo);
                item.SubItems.Add(((OfertaVuelo.Clases)vuelo.Tarifas[isEconomy ? 0 : 3].Clase).ToString());
                item.SubItems.Add(vuelo.Tarifas[isEconomy ? 0 : 3].Disponibilidad.ToString());
                item.SubItems.Add(vuelo.Tarifas[isEconomy ? 0 : 3].Precio.ToString());
                item.SubItems.Add(vuelo.Tarifas[isEconomy ? 1 : 4].Precio.ToString());
                item.SubItems.Add(vuelo.Tarifas[isEconomy ? 2 : 5].Precio.ToString());
                item.Tag = vuelo;

                vuelosIdaListView.Items.Add(item);
            }

            if (!esSoloIda && vuelosIdaDisponibles.Count > 0)
            {
                List<OfertaVuelo> vuelosVueltaDisponibles = VuelosModel.getVuelos(destinoText.Text, origenText.Text, Decimal.ToInt32(cantidadAdultosNumeric.Value), Decimal.ToInt32(cantidadMenoresNumeric.Value), Decimal.ToInt32(cantidadInfantesNumeric.Value), clasesCombo.SelectedItem.ToString()[0], fechaVueltaSeleccionada ?? fechaIdaSeleccionada, fechaVueltaSeleccionada ?? null, Decimal.ToInt32(desdePreciosNumeric.Value), Decimal.ToInt32(hastaPreciosNumeric.Value));

                foreach (OfertaVuelo vuelo in vuelosVueltaDisponibles)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = OfertaVuelo.Aerolineas[vuelo.Aerolinea];
                    item.SubItems.Add(OfertaVuelo.Ciudades[vuelo.Origen]);
                    item.SubItems.Add(OfertaVuelo.Ciudades[vuelo.Destino]);
                    item.SubItems.Add(vuelo.FechaSalida.ToString(FORMATO_FECHA));
                    item.SubItems.Add(vuelo.TiempoDeVuelo);
                    item.SubItems.Add(((OfertaVuelo.Clases)vuelo.Tarifas[isEconomy ? 0 : 3].Clase).ToString());
                    item.SubItems.Add(vuelo.Tarifas[isEconomy ? 0 : 3].Disponibilidad.ToString());
                    item.SubItems.Add(vuelo.Tarifas[isEconomy ? 0 : 3].Precio.ToString());
                    item.SubItems.Add(vuelo.Tarifas[isEconomy ? 1 : 4].Precio.ToString());
                    item.SubItems.Add(vuelo.Tarifas[isEconomy ? 2 : 5].Precio.ToString());
                    item.Tag = vuelo;

                    vuelosVueltaListView.Items.Add(item);
                }
            }
        }

        private void soloIdaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            esSoloIda = soloIdaCheckBox.Checked;
            refrescar();
        }
        private void refrescar()
        {
            vueltaBox.Visible = !esSoloIda;
            vueltaLabel.Visible = !esSoloIda;
            vueltaDatePicker.Visible = !esSoloIda;
            aplicarFiltrosBtn.Enabled = cantidadAdultosNumeric.Value > 0;
        }

        private void aplicarFiltrosBtn_Click(object sender, EventArgs e)
        {
            poblarVuelos();
        }

        private void cantidadAdultosNumeric_ValueChanged(object sender, EventArgs e)
        {
            refrescar();
        }

        private void idaDatePicker_ValueChanged(object sender, EventArgs e)
        {
            idaDatePicker.Format = DateTimePickerFormat.Short;
            fechaIdaSeleccionada = idaDatePicker.Value;
        }

        private void vueltaDatePicker_ValueChanged(object sender, EventArgs e)
        {
            vueltaDatePicker.Format = DateTimePickerFormat.Short;
            fechaVueltaSeleccionada = vueltaDatePicker.Value;
        }

        private void borrarFechasBtn_Click(object sender, EventArgs e)
        {
            borrarFechas();
            fechaIdaSeleccionada = null;
            fechaVueltaSeleccionada = null;
        }
    }
}
