using Gungar.CAI.Prototipos._5.Entidades.Oferta;
using Gungar.CAI.Prototipos._5;
using System.Linq;

public class FiltrosVuelos
{
    public string? origen;
    public string? destino;
    public int cantidadAdultos;
    public int cantidadMenores;
    public int cantidadInfantes;
    public DateTime? fechaSalida;
    public int? precioMinimo;
    public int? precioMaximo;

    public FiltrosVuelos(string origen, string destino, int cantidadAdultos, int cantidadMenores, int cantidadInfantes)
    {
        this.cantidadAdultos = cantidadAdultos;
        this.cantidadMenores = cantidadMenores;
        this.cantidadInfantes = cantidadInfantes;
        this.origen = origen;
        this.destino = destino;
    }

    public FiltrosVuelos(string origen, string destino, int cantidadAdultos, int cantidadMenores, int cantidadInfantes, DateTime? fechaSalida, int? precioMinimo, int? precioMaximo)
    {
        this.cantidadAdultos = cantidadAdultos;
        this.cantidadMenores = cantidadMenores;
        this.cantidadInfantes = cantidadInfantes;
        this.origen = origen;
        this.destino = destino;
        this.fechaSalida = fechaSalida;
        this.precioMinimo = precioMinimo;
        this.precioMaximo = precioMaximo;
    }
}

public static class VuelosModel
{
    public static List<OfertaVuelo> ofertaVuelos { get; private set; } = new List<OfertaVuelo>();

    public static List<OfertaVuelo> getVuelos(string origen, string destino, int cantidadAdultos, int cantidadMenores, int cantidadInfantes, char clase, DateTime? fechaSalida = null, int? precioMinimo = null, int? precioMaximo = null)
    {
        List<OfertaVuelo> vuelosFiltrados = ofertaVuelos.Where(vuelo =>
         {
             if (origen != "" && OfertaVuelo.Ciudades[vuelo.Origen].ToLower() != origen.ToLower())
                 return false;
             if (destino != "" && OfertaVuelo.Ciudades[vuelo.Destino].ToLower() != destino.ToLower())
                 return false;
             if (!vuelo.Tarifas.Exists(tarifa => tarifa.Clase == clase))
                 return false;

             return true;
         }
         ).ToList();

        return vuelosFiltrados;
    }

    public static void CargaInicial()
    {
        List<OfertaVuelo>? ofertaVuelosEnAlmacen = DataBase.LeerVuelos();
        if (ofertaVuelosEnAlmacen != null)
        {
            ofertaVuelos = ofertaVuelosEnAlmacen;
        }
    }

    public static void GuardarDatos()
    {
        DataBase.GuardarVuelos(ofertaVuelos);
    }
}