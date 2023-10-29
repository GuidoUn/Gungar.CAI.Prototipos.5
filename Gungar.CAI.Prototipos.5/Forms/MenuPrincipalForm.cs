using Gungar.CAI.Prototipos._5.Entidades.DeItinerario;
using Gungar.CAI.Prototipos._5.Forms;

namespace Gungar.CAI.Prototipos._5
{
    public partial class MenuPrincipalForm : Form
    {
        SeleccionItinerarioForm? seleccionItinerarioForm;
        MenuItinerarioForm? menuItinerarioForm;
        VuelosForm? vuelosForm;
        HotelesForm? hotelesForm;

        public MenuPrincipalForm()
        {
            InitializeComponent();
        }

        private void nuevoItinerarioBtn_Click(object sender, EventArgs e)
        {
            menuItinerarioForm = new MenuItinerarioForm(MenuPrincipalFormModel.GenerarNuevoItinerario());
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

        private void salirDelSistemaBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}