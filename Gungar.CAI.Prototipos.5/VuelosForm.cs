using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gungar.CAI.Prototipos._5
{
    public partial class VuelosForm : Form
    {
        public VuelosForm()
        {
            InitializeComponent();
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
        bool esConsulta = false;
        bool esSoloIda = false;
        Itinerario itinerarioEnCurso;
        private void VuelosForm_Load(object sender, EventArgs e)
        {

            itinerarioEnCurso = MenuPrincipalForm.itinerarioEnCurso;

            if (itinerarioEnCurso == null)
            {




                titleLabel.Text = "Consulta disponibilidad de productos";
                itinerarioLabel.Text = "";
                modificarItinerarioBox.Visible = false;
            }
            else
            {
                itinerarioLabel.Text = $"{itinerarioEnCurso?.cliente?.nombre} ({itinerarioEnCurso?.itinerarioId})";
            }
            //evaluarVisibilidadFiltros();
            clasesCombo.SelectedIndex = 0;
        }

        private void poblarVuelos()
        {
            vuelosIdaListView.Items.Clear();
            //vuelosVueltaListView.Items.Clear();
            foreach (var vuelo in vuelos)
            {
                var item = new ListViewItem();
                item.Text = vuelo[0];
                item.SubItems.Add(vuelo[1]);
                item.SubItems.Add(vuelo[2]);
                item.SubItems.Add(vuelo[3]);
                item.SubItems.Add(vuelo[4]);
                item.SubItems.Add(vuelo[5]);
                item.Tag = vuelo;

                vuelosIdaListView.Items.Add(item);
            }

            foreach (var vuelo in vuelos)
            {
                var item = new ListViewItem();
                item.Text = vuelo[0];
                item.SubItems.Add(vuelo[1]);
                item.SubItems.Add(vuelo[2]);
                item.SubItems.Add(vuelo[3]);
                item.SubItems.Add(vuelo[4]);
                item.SubItems.Add(vuelo[5]);
                item.Tag = vuelo;


                vuelosVueltaListView.Items.Add(item);
            }
        }

        private void soloIdaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            esSoloIda = soloIdaCheckBox.Checked;
        }

        private void aplicarFiltrosBtn_Click(object sender, EventArgs e)
        {
            poblarVuelos();
        }

        private void clasesCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
