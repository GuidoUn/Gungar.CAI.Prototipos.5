using Gungar.CAI.Prototipos._5.Entidades.DeItinerario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gungar.CAI.Prototipos._5.Forms.Cliente
{
    public class ClienteFormModel
    {
        public Itinerario Itinerario { get; set; }

        public string? NombreNuevoCliente { get; set; }
        public string? ApellidoNuevoCliente { get; set; }
        public string? DocumentoNuevoCliente { get; set; }
        public string? EmailNuevoCliente { get; set; }
        public string? TelefonoNuevoCliente { get; set; }

        public ClienteFormModel(Itinerario itinerario)
        {
            Itinerario = itinerario;
            NombreNuevoCliente = itinerario?.Cliente?.Nombre;
            ApellidoNuevoCliente = itinerario?.Cliente?.Apellido;
            DocumentoNuevoCliente = itinerario?.Cliente?.Documento;
            EmailNuevoCliente = itinerario?.Cliente?.Email;
            TelefonoNuevoCliente = itinerario?.Cliente?.Telefono;
        }

        public void Continuar()
        {
            Entidades.DeItinerario.Cliente? cliente = Itinerario?.Cliente;
            if (cliente != null)
            {
                cliente.Nombre = NombreNuevoCliente ?? "";
                cliente.Apellido = ApellidoNuevoCliente ?? "";
                cliente.Documento = DocumentoNuevoCliente ?? "";
                cliente.Email = EmailNuevoCliente ?? "";
                cliente.Telefono = TelefonoNuevoCliente ?? "";
            }
            else
            {
                Entidades.DeItinerario.Cliente nuevoCliente = new Entidades.DeItinerario.Cliente(NombreNuevoCliente, ApellidoNuevoCliente, DocumentoNuevoCliente, EmailNuevoCliente, TelefonoNuevoCliente);

                Itinerario?.AsignarCliente(nuevoCliente);
            }
        }
    }
}
