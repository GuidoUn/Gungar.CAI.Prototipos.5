using Gungar.CAI.Prototipos._5.Entidades.DeItinerario;
using Gungar.CAI.Prototipos._5.Forms.MenuPrincipal;

namespace Gungar.CAI.Prototipos._5
{
    public partial class MenuPrincipalForm : Form
    {
        MenuPrincipalFormModel model;

        public MenuPrincipalForm()
        {
            InitializeComponent();
            model = new();
        }

        private void nuevoItinerarioBtn_Click(object sender, EventArgs e)
        {
            MenuItinerarioForm menuItinerarioForm = new(model.GenerarNuevoItinerario());
            menuItinerarioForm.ShowDialog();
        }

        private void continuarItinerarioBtn_Click(object sender, EventArgs e)
        {
            SeleccionItinerarioForm seleccionItinerarioForm = new();
            seleccionItinerarioForm.ShowDialog();
        }

        private void consultarVuelosBtn_Click(object sender, EventArgs e)
        {
            VuelosForm vuelosForm = new(null);
            vuelosForm.ShowDialog();
        }

        private void consultarHotelesBtn_Click(object sender, EventArgs e)
        {
            HotelesForm hotelesForm = new(null);
            hotelesForm.ShowDialog();
        }

        private void salirDelSistemaBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}