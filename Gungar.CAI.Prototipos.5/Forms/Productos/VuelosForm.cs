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

        public static List<string[]> vuelos = new List<string[]>
        {
             new string[6] { "FlyBondi", new DateTime(2023, 10, 17,6,0,0).ToString(FORMATO_FECHA),new DateTime(2023, 10, 17,7,10,0).ToString(FORMATO_FECHA),"01:10hs","$45","15" },
             new string[6] { "FlyBondi", new DateTime(2023, 10, 17,6,0,0).ToString(FORMATO_FECHA),new DateTime(2023, 10, 17,7,10,0).ToString(FORMATO_FECHA),"01:10hs","$50" ,"15"},
             new string[6] { "Aerolineas Argentina", new DateTime(2023, 10, 21,16,15,0).ToString(FORMATO_FECHA),new DateTime(2023, 10, 21,17,25,0).ToString(FORMATO_FECHA),"01:10hs","$70","15" },
             new string[6] { "Aerolineas Argentina", new DateTime(2023, 10, 21,16,15,0).ToString(FORMATO_FECHA),new DateTime(2023, 10, 21, 17, 25, 0).ToString(FORMATO_FECHA),"01:10hs","$75" ,"15"},
             new string[6] { "Jet Smart", new DateTime(2023, 10, 22,9,30,0).ToString(FORMATO_FECHA),new DateTime(2023, 10, 17,7,10,0).ToString(FORMATO_FECHA),"01:10hs","$59","15" },
             new string[6] { "Jet Smart", new DateTime(2023, 10, 22,10,50,0).ToString(FORMATO_FECHA),new DateTime(2023, 10, 22, 12, 10, 0).ToString(FORMATO_FECHA),"01:20hs","$69" ,"15"},
        };

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
            clasesCombo.SelectedIndex = 0;
            cantidadAdultosNumeric.Value = 1;
            refrescar();
        }

        private void poblarVuelos()
        {
            vuelosIdaListView.Items.Clear();
            vuelosVueltaListView.Items.Clear();
            foreach (var vuelo in VuelosModel.getVuelos(new FiltrosVuelos(origenText.Text, destinoText.Text, Decimal.ToInt32(cantidadAdultosNumeric.Value), Decimal.ToInt32(cantidadMenoresNumeric.Value), Decimal.ToInt32(cantidadInfantesNumeric.Value))))
            {
                var item = new ListViewItem();
                item.Text = OfertaVuelo.Aerolineas[vuelo.Aerolinea];
                item.SubItems.Add(OfertaVuelo.Ciudades[vuelo.Origen]);
                item.SubItems.Add(OfertaVuelo.Ciudades[vuelo.Destino]);
                item.SubItems.Add(vuelo.FechaSalida.ToString(FORMATO_FECHA));
                item.SubItems.Add(vuelo.FechaArribo.ToString(FORMATO_FECHA));
                item.SubItems.Add(vuelo.TiempoDeVuelo);
                item.SubItems.Add(vuelo.Tarifas[0].Precio.ToString());
                item.SubItems.Add(vuelo.Tarifas[1].Precio.ToString());
                item.SubItems.Add(vuelo.Tarifas[2].Precio.ToString());
                item.Tag = vuelo;

                vuelosIdaListView.Items.Add(item);
            }

            if (!esSoloIda)
            {

                foreach (var vuelo in VuelosModel.getVuelos(new FiltrosVuelos(destinoText.Text, origenText.Text, Decimal.ToInt32(cantidadAdultosNumeric.Value), Decimal.ToInt32(cantidadMenoresNumeric.Value), Decimal.ToInt32(cantidadInfantesNumeric.Value))))
                {
                    var item = new ListViewItem();
                    item.Text = OfertaVuelo.Aerolineas[vuelo.Aerolinea];
                    item.SubItems.Add(OfertaVuelo.Ciudades[vuelo.Origen]);
                    item.SubItems.Add(OfertaVuelo.Ciudades[vuelo.Destino]);
                    item.SubItems.Add(vuelo.FechaSalida.ToString(FORMATO_FECHA));
                    item.SubItems.Add(vuelo.FechaArribo.ToString(FORMATO_FECHA));
                    item.SubItems.Add(vuelo.TiempoDeVuelo);
                    item.SubItems.Add(vuelo.Tarifas[0].Precio.ToString());
                    item.SubItems.Add(vuelo.Tarifas[1].Precio.ToString());
                    item.SubItems.Add(vuelo.Tarifas[2].Precio.ToString());
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
    }
}
