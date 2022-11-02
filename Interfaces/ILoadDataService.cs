
using Examen.Net.Entidades;

namespace Examen.Net.Interfaces
{
    public interface ILoadDataService
    {
        List<Municipio> LoadMunicipios();
        List<Piso> LoadPisos();
        List<Adosado> LoadAdosado();
    }
}
