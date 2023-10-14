namespace Gungar.CAI.Prototipos._5
{
    public interface IMyInterface
    {
        string MyMethod(int param);
    }
    public partial class Form1 : Form
    {
        GestionProductosItinerarioForm gestionProductosItinerarioForm = new GestionProductosItinerarioForm("0", true);
        CrearItinerarioForm crearItinerarioForm = new CrearItinerarioForm();
        SeleccionItinerarioForm seleccionItinerarioForm = new SeleccionItinerarioForm();

        const string FORMATO_FECHA = "yyyy-MM-dd";

        public static List<string[]> itinerarios = new List<string[]> {
            new string[3] { "1", "Pedro Martinez", new DateTime(2023, 05, 17).ToString(FORMATO_FECHA) },
            new string[3] { "2", "Diego Maradona", new DateTime(2023, 06, 1).ToString(FORMATO_FECHA) },
            new string[3] { "3", "Lionel Messi", new DateTime(2023, 06, 3).ToString(FORMATO_FECHA) }
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