namespace Gungar.CAI.Prototipos._5
{
    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();
        //NuevoItinerarioForm nuevoItinerarioForm = new NuevoItinerarioForm();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            form2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form2.ShowDialog();
        }

        private void nuevoItinerarioBtn_Click(object sender, EventArgs e)
        {
            //nuevoItinerarioForm.ShowDialog();
        }
    }
}