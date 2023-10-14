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
    public partial class GestionProductosItinerarioForm : Form
    {
        string[]? itinerario;

        const string FORMATO_FECHA = "yyyy'-'MM'-'dd'T'HH':'mm";

        bool esSoloIda = false;

        bool esVuelos = true;

        bool esConsulta = false;

        public static List<string[]> productos = new List<string[]>
        {
        };

        public static List<string[]> vuelos = new List<string[]>
        {
             new string[6] { "FlyBondi", new DateTime(2023, 10, 17,6,0,0).ToString(FORMATO_FECHA),new DateTime(2023, 10, 17,7,10,0).ToString(FORMATO_FECHA),"01:10hs","$45","15" },
             new string[6] { "FlyBondi", new DateTime(2023, 10, 17,6,0,0).ToString(FORMATO_FECHA),new DateTime(2023, 10, 17,7,10,0).ToString(FORMATO_FECHA),"01:10hs","$50" ,"15"},
             new string[6] { "Aerolineas Argentina", new DateTime(2023, 10, 21,16,15,0).ToString(FORMATO_FECHA),new DateTime(2023, 10, 21,17,25,0).ToString(FORMATO_FECHA),"01:10hs","$70","15" },
             new string[6] { "Aerolineas Argentina", new DateTime(2023, 10, 21,16,15,0).ToString(FORMATO_FECHA),new DateTime(2023, 10, 21, 17, 25, 0).ToString(FORMATO_FECHA),"01:10hs","$75" ,"15"},
             new string[6] { "Jet Smart", new DateTime(2023, 10, 22,9,30,0).ToString(FORMATO_FECHA),new DateTime(2023, 10, 17,7,10,0).ToString(FORMATO_FECHA),"01:10hs","$59","15" },
             new string[6] { "Jet Smart", new DateTime(2023, 10, 22,10,50,0).ToString(FORMATO_FECHA),new DateTime(2023, 10, 22, 12, 10, 0).ToString(FORMATO_FECHA),"01:20hs","$69" ,"15"},
        };

        public static List<string[]> hoteles = new List<string[]>
        {
             new string[4] { "Hilton", "Av. Cordoba 2122, Mendoza","4","104" },
             new string[4] { "Sheraton", "Cabildo 1554, Mendoza", "5","35" },
             new string[4] { "Once", "San Martin 436, Mendoza", "3","4" },
             new string[4] { "Trump Tower", "San Martin 1315, Mendoza", "4", "420" },
             new string[4] { "Qué? alojamiento", "Juncal 2662, Mendoza", "5", "69" },
             new string[4] { "Jet Smart Hoteles", "Saenz Peña 751, Mendoza", "2", "14" },
        };

        private void poblarVuelos()
        {
            vuelosIdaListView.Items.Clear();
            vuelosVueltaListView.Items.Clear();
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

        private void poblarHoteles()
        {
            hotelesListView.Items.Clear();
            foreach (var hotel in hoteles)
            {
                var item = new ListViewItem();
                item.Text = hotel[0];
                item.SubItems.Add(hotel[1]);
                item.SubItems.Add(hotel[2]);
                item.SubItems.Add(hotel[3]);
                item.Tag = hotel;

                hotelesListView.Items.Add(item);
            }
        }

        public GestionProductosItinerarioForm(string idItinerario, bool isNuevoItinerario)
        {
            InitializeComponent();
            itinerario = Form1.itinerarios.FirstOrDefault(itinerario => itinerario[0] == idItinerario);
            //itinerario[4] = isNuevoItinerario; 
            //TODO: Despues vamos a saber si es un nuevo itinerario o la continuacion de uno con el "Estado" dentro de la Clase "Itinerario"
            //TODO: Después Orquestamos el form según el estado (UX)

            if (idItinerario == "0")
            {
                esConsulta = true;

            }
        }

        private void GestionProductosItinerarioForm_Load(object sender, EventArgs e)
        {
            if (esConsulta)
            {
                titleLabel.Text = "Consulta disponibilidad de productos";
                itinerarioLabel.Text = "";
            }
            else
            {
                itinerarioLabel.Text = $"{itinerario[1]} ({itinerario[0]})";
            }


        }

        private void vuelosRadio_CheckedChanged(object sender, EventArgs e)
        {
            esVuelos = vuelosRadio.Checked;
            evaluarVisibilidadFiltros();
        }


        private void aplicarFiltrosBtn_Click(object sender, EventArgs e)
        {
            if (esVuelos)
            {
                poblarVuelos();
            }
            else
            {
                poblarHoteles();
            }
        }

        private void soloIdaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            esSoloIda = soloIdaCheckBox.Checked;
            evaluarVisibilidadFiltros();
        }

        private void evaluarVisibilidadFiltros()
        {
            soloIdaCheckBox.Visible = esVuelos;
            listasVuelosBox.Visible = esVuelos;
            listasHotelesBox.Visible = !esVuelos;
            origenLabel.Enabled = esVuelos;
            origenText.Enabled = esVuelos;

            vuelosVueltaBox.Visible = !esSoloIda;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
