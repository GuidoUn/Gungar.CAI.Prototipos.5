﻿using System;
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
                MessageBox.Show($"{nombreCampo} es un campo requerido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
                return false;
            }
            return true;
        }

        // Método para validar un campo numérico
        public static bool ValidarNumero(TextBox textBox, string nombreCampo)
        {
            if (!int.TryParse(textBox.Text, out _))
            {
                MessageBox.Show($"{nombreCampo} debe ser un número válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
                return false;
            }
            return true;
        }
    }
}
