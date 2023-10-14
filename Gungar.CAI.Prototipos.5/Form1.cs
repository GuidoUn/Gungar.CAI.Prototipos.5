namespace Gungar.CAI.Prototipos._5
{
    public interface IMyInterface
    {
        string MyMethod(int param);
    }
    public partial class Form1 : Form
    {
        GestionProductosItinerarioForm gestionProductosItinerarioForm = new GestionProductosItinerarioForm(-1, true);
        CrearItinerarioForm crearItinerarioForm = new CrearItinerarioForm();
        SeleccionItinerarioForm seleccionItinerarioForm = new SeleccionItinerarioForm();

        const string FORMATO_FECHA = "yyyy-MM-dd";

        public static List<Itinerario> itinerarios = new List<Itinerario> {
            new Itinerario(1,"Pedro Martinez",new DateTime(2023, 05, 17)),
            new Itinerario(2, "Diego Maradona", new DateTime(2023, 06, 1)),
            new Itinerario(3, "Lionel Messi", new DateTime(2023, 06, 3))
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
            gestionProductosItinerarioForm.ShowDialog();
        }

        private void continuarItinerarioBtn_Click(object sender, EventArgs e)
        {
            seleccionItinerarioForm.ShowDialog();
        }

        private void nuevoItinerarioBtn_Click(object sender, EventArgs e)
        {
            crearItinerarioForm.ShowDialog();
        }
    }
}