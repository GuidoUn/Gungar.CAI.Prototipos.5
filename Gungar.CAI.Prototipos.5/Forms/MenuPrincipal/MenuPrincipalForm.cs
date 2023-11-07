using Gungar.CAI.Prototipos._5.Entidades.DeItinerario;
using Gungar.CAI.Prototipos._5.Forms.MenuPrincipal;
using Gungar.CAI.Prototipos._5.Modulos;

namespace Gungar.CAI.Prototipos._5
{
    public partial class MenuPrincipalForm : Form
    {
        MenuPrincipalFormModel model;

        public MenuPrincipalForm()
        {
            InitializeComponent();
        }

        private void MenuPrincipalForm_Load(object sender, EventArgs e)
        {
            model = new();
        }

        private void nuevoItinerarioBtn_Click(object sender, EventArgs e)
        {
            model.GenerarNuevoItinerario();
            MenuItinerarioForm menuItinerarioForm = new();
            menuItinerarioForm.ShowDialog();
        }

        private void continuarItinerarioBtn_Click(object sender, EventArgs e)
        {
            SeleccionItinerarioForm seleccionItinerarioForm = new();
            seleccionItinerarioForm.ShowDialog();
        }

        private void consultarVuelosBtn_Click(object sender, EventArgs e)
        {
            VentasModulo.VaciarItinerarioSeleccionado();
            VuelosForm vuelosForm = new();
            vuelosForm.ShowDialog();
        }

        private void consultarHotelesBtn_Click(object sender, EventArgs e)
        {
            VentasModulo.VaciarItinerarioSeleccionado();
            HotelesForm hotelesForm = new();
            hotelesForm.ShowDialog();
        }

        private void salirDelSistemaBtn_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}