using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gungar.CAI.Prototipos._5
{
    public static class Validador
    {
        // Método para validar que un campo TextBox no esté vacío
        public static bool ValidarCampoRequerido(TextBox textBox, string nombreCampo)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageBox.Show($"{nombreCampo} es un dato obligatorio. Por favor, verifique los datos ingresados.", "Formulario inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
                return false;
            }
            return true;
        }

        // Método para validar que una fecha desde sea anterior a una fecha hasta
        public static bool ValidarRangoDeFechas(DateTime FechaDesde, DateTime FechaHasta)
        {
            TimeSpan diferencia = FechaHasta.Date - FechaDesde.Date;
            int dias = diferencia.Days;

            if (dias <= 0)
            {
                MessageBox.Show("La fecha del campo 'Desde' debe ser anterior a la fecha del campo 'Hasta'", "Formulario inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
