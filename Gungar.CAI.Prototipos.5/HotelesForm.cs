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
    public partial class HotelesForm : Form
    {
        public HotelesForm()
        {
            InitializeComponent();
        }
        Itinerario? itinerario;

        const string FORMATO_FECHA = "yyyy'-'MM'-'dd'T'HH':'mm";

        bool esConsulta = false;

        int nroProductoAAgregar = 0;


        public static List<string[]> hoteles = new List<string[]>
        {
             new string[4] { "Hilton", "Av. Cordoba 2122, Mendoza","4","104" },
             new string[4] { "Sheraton", "Cabildo 1554, Mendoza", "5","35" },
             new string[4] { "Once", "San Martin 436, Mendoza", "2", "4" },
             new string[4] { "Trump Tower", "San Martin 1315, Mendoza", "4", "420" },
             new string[4] { "Qué? alojamiento", "Juncal 2662, Mendoza", "5", "69" },
             new string[4] { "Jet Smart Hoteles", "Saenz Peña 751, Mendoza", "2", "14" },
        };
        private void HotelesForm_Load(object sender, EventArgs e)
        {
            itinerario = Form1.itinerarioEnCurso;
            if (itinerario == null)
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

        private void aplicarFiltrosBtn_Click(object sender, EventArgs e)
        {
            poblarHoteles();
        }
    }
}
