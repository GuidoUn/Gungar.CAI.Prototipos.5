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
        Itinerario? itinerario;

        AgregarDatosForm agregarDatosForm;

        GestionProductosItinerarioForm gestionProductosItinerarioForm;

        public MenuItinerarioForm(int idItinerario)
        {
            InitializeComponent();

            itinerario = Form1.itinerarios.FirstOrDefault(itinerario => itinerario.itinerarioId == idItinerario);
            agregarDatosForm = new AgregarDatosForm(itinerario.itinerarioId);
            gestionProductosItinerarioForm = new GestionProductosItinerarioForm(itinerario.itinerarioId, true);
        }

        private void refrescar()
        {
            estadoLabel.Text = itinerario.estado.ToString();

            gestionarItinerarioBox.Enabled = itinerario.estado == Estado.Presupuesto;
        }

        private void MenuItinerarioForm_Load(object sender, EventArgs e)
        {
            itinerarioSeleccionadoLabel.Text = $"{itinerario.cliente.nombre} ({itinerario.itinerarioId})";
            refrescar();
        }

        private void gestionarProductosBtn_Click(object sender, EventArgs e)
        {
            gestionProductosItinerarioForm.ShowDialog();
        }

        private void agregarPasajerosBtn_Click(object sender, EventArgs e)
        {
            agregarDatosForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (itinerario.estado == Estado.Presupuesto)
            {
                itinerario.estado = Estado.Prereserva;
            }
            else
            {
                itinerario.estado = Estado.Presupuesto;
            }
            refrescar();
        }

        private void salirBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
