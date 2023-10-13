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

        public static List<string[]> productos = new List<string[]>
        {

        };

        public static List<string[]> vuelos = new List<string[]>
        {
             new string[5] { "FlyBondi", new DateTime(2023, 10, 17,6,0,0).ToString(FORMATO_FECHA),new DateTime(2023, 10, 17,7,10,0).ToString(FORMATO_FECHA),"01:10hs","$45" },
             new string[5] { "FlyBondi", new DateTime(2023, 10, 17,6,0,0).ToString(FORMATO_FECHA),new DateTime(2023, 10, 17,7,10,0).ToString(FORMATO_FECHA),"01:10hs","$50" },
             new string[5] { "Aerolineas Argentina", new DateTime(2023, 10, 21,16,15,0).ToString(FORMATO_FECHA),new DateTime(2023, 10, 21,17,25,0).ToString(FORMATO_FECHA),"01:10hs","$70" },
             new string[5] { "Aerolineas Argentina", new DateTime(2023, 10, 21,16,15,0).ToString(FORMATO_FECHA),new DateTime(2023, 10, 21, 17, 25, 0).ToString(FORMATO_FECHA),"01:10hs","$75" },
             new string[5] { "Jet Smart", new DateTime(2023, 10, 22,9,30,0).ToString(FORMATO_FECHA),new DateTime(2023, 10, 17,7,10,0).ToString(FORMATO_FECHA),"01:10hs","$59" },
             new string[5] { "Jet Smart", new DateTime(2023, 10, 22,10,50,0).ToString(FORMATO_FECHA),new DateTime(2023, 10, 22, 12, 10, 0).ToString(FORMATO_FECHA),"01:20hs","$69" },
        };

        public GestionProductosItinerarioForm(string idItinerario, bool isNuevoItinerario)
        {
            InitializeComponent();
            itinerario = Form2.itinerarios.FirstOrDefault(itinerario => itinerario[0] == idItinerario);
            //itinerario[4] = isNuevoItinerario; 
            //TODO: Despues vamos a saber si es un nuevo itinerario o la continuacion de uno con el "Estado" dentro de la Clase "Itinerario"
            //TODO: Después Orquestamos el form según el estado (UX)
        }

        private void GestionProductosItinerarioForm_Load(object sender, EventArgs e)
        {
            itinerarioLabel.Text = $"{itinerario[1]} ({itinerario[0]})";
        }

        private void vuelosRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (hotelesRadio.Checked)
            {
                origenLabel.Enabled = false;
                origenText.Enabled = false;
                return;
            }
            origenLabel.Enabled = true;
            origenText.Enabled = true;
        }


        private void aplicarFiltrosBtn_Click(object sender, EventArgs e)
        {
            foreach (var vuelo in vuelos)
            {
                var item = new ListViewItem();
                item.Text = vuelo[0];
                item.SubItems.Add(vuelo[1]);
                item.SubItems.Add(vuelo[2]);
                item.SubItems.Add(vuelo[3]);
                item.SubItems.Add(vuelo[4]);
                item.Tag = vuelo;

                //itinerariosListView.Items.Add(item);
            }
        }
    }
}
