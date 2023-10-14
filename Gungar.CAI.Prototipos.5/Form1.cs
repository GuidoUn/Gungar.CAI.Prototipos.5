namespace Gungar.CAI.Prototipos._5
{
    public interface IMyInterface
    {
        string MyMethod(int param);
    }
    public partial class Form1 : Form
    {
        GestionProductosItinerarioForm consultarProductosForm = new GestionProductosItinerarioForm(-1, true);
        CrearItinerarioForm crearItinerarioForm;
        SeleccionItinerarioForm seleccionItinerarioForm;

        //const string FORMATO_FECHA = "yyyy-MM-dd";

        public static List<Itinerario> itinerarios = new List<Itinerario> {
            new Itinerario(new Cliente("Pedro", "Martinez", "1193692693"),new DateTime(2023, 05, 17)),
            new Itinerario(new Cliente("Diego", "Maradona", "1245325433"),new DateTime(2023, 06, 1)),
            new Itinerario(new Cliente("Lionel", "Messi",  "32213573"), new DateTime(2023, 06, 3))
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void consultarDisponibilidadBtn_Click(object sender, EventArgs e)
        {
            consultarProductosForm.ShowDialog();
        }

        private void continuarItinerarioBtn_Click(object sender, EventArgs e)
        {
            seleccionItinerarioForm = new SeleccionItinerarioForm();
            seleccionItinerarioForm.ShowDialog();
        }

        private void nuevoItinerarioBtn_Click(object sender, EventArgs e)
        {
            crearItinerarioForm = new CrearItinerarioForm();
            crearItinerarioForm.ShowDialog();
        }
    }
}