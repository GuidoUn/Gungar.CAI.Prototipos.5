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
    public partial class MenuItinerarioForm : Form
    {
        string[]? itinerario;
        public MenuItinerarioForm(string idItinerario)
        {
            InitializeComponent();

            itinerario = Form1.itinerarios.FirstOrDefault(itinerario => itinerario[0] == idItinerario);
        }

        private void MenuItinerarioForm_Load(object sender, EventArgs e)
        {
            itinerarioSeleccionadoLabel.Text = $"{itinerario[1]} ({itinerario[0]})";
        }

        private void salirBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gestionarProductosBtn_Click(object sender, EventArgs e)
        {
            GestionProductosItinerarioForm gestionProductosItinerarioForm = new GestionProductosItinerarioForm(itinerario[0], true);


            gestionProductosItinerarioForm.ShowDialog();
        }

        private void agregarPasajerosBtn_Click(object sender, EventArgs e)
        {
            AgregarDatosForm agregarDatosForm = new AgregarDatosForm(itinerario[0]);
            agregarDatosForm.ShowDialog();
        }
    }
}
