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
        Itinerario? itinerario;

        const string FORMATO_FECHA = "yyyy'-'MM'-'dd'T'HH':'mm";

        bool esSoloIda = false;

        bool esVuelos = true;

        bool esConsulta = false;

        int nroProductoAAgregar = 0;

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
             new string[4] { "Once", "San Martin 436, Mendoza", "2", "4" },
             new string[4] { "Trump Tower", "San Martin 1315, Mendoza", "4", "420" },
             new string[4] { "Qué? alojamiento", "Juncal 2662, Mendoza", "5", "69" },
             new string[4] { "Jet Smart Hoteles", "Saenz Peña 751, Mendoza", "2", "14" },
        };

        public static List<string[]> productosItinerarios = new List<string[]>
        {
             new string[] { "Hotel", "Hilton", "2A, 1M", "Mendoza", "$710", "4 estrellas", "29/11/2023", "3/12/2023", "N/A", "N/A", "N/A" },
             new string[] { "Hotel", "Once", "2A, 1M", "Mendoza", "$310", "2 estrellas", "3/12/2023", "10/12/2023", "N/A", "N/A", "N/A" },
             new string[] { "Vuelo", "Aerolineas Argentinas", "2A, 1M", "AEP-MDZ", "$290", "Economy", "29/11/2023", "29/11/2023", "100", "90", "80" },
             new string[] { "Vuelo", "Aerolineas Argentinas", "2A, 1M", "MDZ-AEP", "$250", "Economy", "10/12/2023", "10/12/2023", "90", "70", "60" },
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

        private void poblarItinerario(string[] producto)
        {
            //itinerarioListView.Clear();
            //foreach (var producto in productosItinerarios)
            //{
            var item = new ListViewItem();
            item.Text = producto[0];
            item.SubItems.Add(producto[1]);
            item.SubItems.Add(producto[2]);
            item.SubItems.Add(producto[3]);
            item.SubItems.Add(producto[4]);
            item.SubItems.Add(producto[5]);
            item.SubItems.Add(producto[6]);
            item.SubItems.Add(producto[7]);
            item.SubItems.Add(producto[8]);
            item.SubItems.Add(producto[9]);
            item.SubItems.Add(producto[10]);
            item.Tag = producto;

            itinerarioListView.Items.Add(item);
            //}
            if (nroProductoAAgregar == 3)
            {
                nroProductoAAgregar = 0;
            }
            else
            {
                nroProductoAAgregar++;
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

        public GestionProductosItinerarioForm(int idItinerario, bool isNuevoItinerario)
        {
            InitializeComponent();
            itinerario = Form1.itinerarios.FirstOrDefault(itinerario => itinerario.itinerarioId == idItinerario);
            //TODO: Despues vamos a saber si es un nuevo itinerario o la continuacion de uno con el "Estado" dentro de la Clase "Itinerario"
            //TODO: Después Orquestamos el form según el estado (UX)

            if (idItinerario == -1)
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
                modificarItinerarioBox.Visible = false;
            }
            else
            {
                itinerarioLabel.Text = $"{itinerario.cliente.nombre} ({itinerario.itinerarioId})";
            }
            evaluarVisibilidadFiltros();
            clasesCombo.SelectedIndex = 0;
        }

        private void vuelosRadio_CheckedChanged(object sender, EventArgs e)
        {
            esVuelos = vuelosRadio.Checked;
            evaluarVisibilidadFiltros();
            if (!esVuelos)
            {
                clasesCombo.SelectedIndex = 0;
            }
            else
            {
                clasesCombo.SelectedIndex = 0;
            }
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

            if (!esVuelos)
            {
                claseLabel.Text = "Categoría:";
                clasesCombo.Items.Clear();
                clasesCombo.Items.AddRange(new string[] { "Todas", "5 estrellas", "4 estrellas", "3 estrellas", "2 estrellas", "1 estrella" });
            }
            else
            {
                claseLabel.Text = "Clase:";
                clasesCombo.Items.Clear();
                clasesCombo.Items.AddRange(new string[] { "Economy", "Premium", "Business", "First" });
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarProductoBtn_Click(object sender, EventArgs e)
        {
            poblarItinerario(productosItinerarios[nroProductoAAgregar]);
        }

        private void quitarProductoBtn_Click(object sender, EventArgs e)
        {
            if (itinerarioListView.Items.Count > 0)
            {
                itinerarioListView.Items.RemoveAt(itinerarioListView.Items.Count - 1);
            }

        }

        private void itinerarioListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
