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
    public partial class CrearItinerarioForm : Form
    {
        string nombreNuevoPasajero;

        MenuItinerarioForm menuItinerarioForm;

        List<string[]>? itinerarios;

        public CrearItinerarioForm()
        {
            InitializeComponent();
            itinerarios = Form1.itinerarios;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void evaluarEstadoBtns()
        {
            continuarBtn.Enabled = nombreNuevoPasajero.Length > 0;
        }

        private void nuevoPasajeroText_TextChanged(object sender, EventArgs e)
        {
            nombreNuevoPasajero = nuevoPasajeroText.Text;
            evaluarEstadoBtns();
        }

        private void continuarBtn_Click(object sender, EventArgs e)
        {
            var item = new ListViewItem();

            int nuevoId = Int32.Parse(itinerarios[itinerarios.Count - 1][0]) + 1;

            string[] nuevoItinerario = new string[3] { nuevoId.ToString(), nombreNuevoPasajero, DateTime.Now.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss") };

            item.Text = nuevoItinerario[0];
            item.SubItems.Add(nuevoItinerario[1]);
            item.SubItems.Add(nuevoItinerario[2]);
            item.Tag = nuevoItinerario;

            itinerarios.Add(nuevoItinerario);
            //return nuevoItinerario;

            menuItinerarioForm = new MenuItinerarioForm(nuevoItinerario[0]);
            this.Visible = false;
            menuItinerarioForm.ShowDialog();
            this.Close();
        }
    }
}
