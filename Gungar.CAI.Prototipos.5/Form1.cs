namespace Gungar.CAI.Prototipos._5
{
    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();
        GestionProductosItinerarioForm gestionProductosItinerarioForm = new GestionProductosItinerarioForm("0", true);
        AgregarDatosForm agregarDatosForm = new AgregarDatosForm();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //form2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form2.ShowDialog();
        }

        private void consultarDisponibilidadBtn_Click(object sender, EventArgs e)
        {
            gestionProductosItinerarioForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            agregarDatosForm.ShowDialog();
        }
    }
}