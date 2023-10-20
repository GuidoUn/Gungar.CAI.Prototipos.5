namespace Gungar.CAI.Prototipos._5
{
    public interface IMyInterface
    {
        string MyMethod(int param);
    }
    public partial class Form1 : Form
    {
        CrearItinerarioForm crearItinerarioForm;
        SeleccionItinerarioForm seleccionItinerarioForm;
        MenuItinerarioForm menuItinerarioForm;
        VuelosForm vuelosForm;
        HotelesForm hotelesForm;
        public static Itinerario itinerarioEnCurso;

        public static List<Itinerario> itinerarios = new List<Itinerario> {
            new Itinerario(new Cliente("Pedro", "Martinez", "1193692693"),new DateTime(2023, 05, 17)),
            new Itinerario(new Cliente("Diego", "Maradona", "1245325433"),new DateTime(2023, 06, 1)),
            new Itinerario(new Cliente("Lionel", "Messi",  "32213573"), new DateTime(2023, 06, 3))
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void continuarItinerarioBtn_Click(object sender, EventArgs e)
        {
            seleccionItinerarioForm = new SeleccionItinerarioForm();
            seleccionItinerarioForm.ShowDialog();
        }

        private void nuevoItinerarioBtn_Click(object sender, EventArgs e)
        {

            itinerarioEnCurso = new Itinerario();


            itinerarios.Add(itinerarioEnCurso);
            menuItinerarioForm = new MenuItinerarioForm(itinerarioEnCurso.itinerarioId);
            menuItinerarioForm.ShowDialog();
        }

        private void consultarVuelosBtn_Click(object sender, EventArgs e)
        {
            vuelosForm = new VuelosForm();
            vuelosForm.ShowDialog();

        }

        private void consultarHotelesBtn_Click(object sender, EventArgs e)
        {
            hotelesForm = new HotelesForm();
            hotelesForm.ShowDialog();
        }

        private void consultasBox_Enter(object sender, EventArgs e)
        {

        }
    }
}