﻿namespace Gungar.CAI.Prototipos._5
{
    public partial class MenuPrincipalForm : Form
    {
        SeleccionItinerarioForm? seleccionItinerarioForm;
        MenuItinerarioForm? menuItinerarioForm;
        VuelosForm? vuelosForm;
        HotelesForm? hotelesForm;

        public static List<Itinerario> itinerarios = new List<Itinerario>();

        public MenuPrincipalForm()
        {
            InitializeComponent();
            itinerarios.AddRange(new Itinerario[]{
                new Itinerario(new Cliente("Pedro", "Martinez", "1193692693"), new DateTime(2023, 05, 17)),
                new Itinerario(new Cliente("Diego", "Maradona", "1245325433"), new DateTime(2023, 06, 1)),
                new Itinerario(new Cliente("Lionel", "Messi", "32213573"), new DateTime(2023, 06, 3))
            });
        }

        private void nuevoItinerarioBtn_Click(object sender, EventArgs e)
        {
            Itinerario nuevoItinerario = new Itinerario();
            itinerarios.Add(nuevoItinerario);
            menuItinerarioForm = new MenuItinerarioForm(nuevoItinerario);
            menuItinerarioForm.ShowDialog();
        }
        private void continuarItinerarioBtn_Click(object sender, EventArgs e)
        {
            seleccionItinerarioForm = new SeleccionItinerarioForm();
            seleccionItinerarioForm.ShowDialog();
        }

        private void consultarVuelosBtn_Click(object sender, EventArgs e)
        {
            vuelosForm = new VuelosForm(null);
            vuelosForm.ShowDialog();

        }

        private void consultarHotelesBtn_Click(object sender, EventArgs e)
        {
            hotelesForm = new HotelesForm(null);
            hotelesForm.ShowDialog();
        }
    }
}