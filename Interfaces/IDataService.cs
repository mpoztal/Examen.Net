
using Examen.Net.Entidades;

namespace Examen.Net.Interfaces
{
    public interface IDataService
    {
        List<Municipio> GetMunicipios();
        List<PisoExtendido> GetPisos(string? nombreMunicipio = null, int numeroHabitaciones = 0);
        List<AdosadoExtendido> GetAdosados(string? NombreMunicipio = null, int numeroHabitaciones = 0);
        List<AdosadoExtendido> GetAdosados(bool piscina);
        List<PisoExtendido> GetPisos(int tamaño);
        List<AdosadoExtendido> GetAdosados(int tamaño);
    }
}
