
using Examen.Net.Entidades;
using Examen.Net.Interfaces;

namespace Examen.Net.Clases
{
    public class DataService : IDataService
    {
        private List<Municipio> ListaMunicipios { get; set; }
        private List<Piso> ListaPisos { get; set; }
        private List<Adosado> ListaAdosado { get; set; }

        public DataService()

        {
            ILoadDataService loadDataService = new LoadDataService();

            ListaMunicipios = loadDataService.LoadMunicipios();

            ListaPisos = loadDataService.LoadPisos();

            ListaAdosado = loadDataService.LoadAdosado();
        }

        public List<Municipio> GetMunicipios()
        {
            return ListaMunicipios;
        }

        public List<PisoExtendido> GetPisos(string? nombreMunicipio = null, int numeroHabitaciones = 0)
        {
            var query = from p in ListaPisos
                        join m in ListaMunicipios on p.MunicipioId equals m.MunicipioId
                        where (string.IsNullOrEmpty(nombreMunicipio) || m.Nombre.Equals (nombreMunicipio)) 
                        && p.NumeroHabitaciones >= numeroHabitaciones
                        select new PisoExtendido

                        {
                            NombrePiso = p.Nombre,
                            NombreMunicipio = m.Nombre,
                            NumeroHabitacionesPiso = p.NumeroHabitaciones

                        };

            return query.ToList();
        }




        public List<AdosadoExtendido> GetAdosados(string? NombreMunicipio = null, int numeroHabitaciones = 0)
        {
            var query = from a in ListaAdosado
                        join m in ListaMunicipios on a.MunicipioId equals m.MunicipioId
                        where (string.IsNullOrEmpty(NombreMunicipio) || m.Nombre.Equals(NombreMunicipio))
                         && a.NumeroHabitaciones >= numeroHabitaciones
                        select new AdosadoExtendido

                        {
                            NombreAdosado = a.Nombre,
                            NombreMunicipio = m.Nombre,
                            NumeroHabitacionesAdosado = a.NumeroHabitaciones,

                        };

            return query.ToList();
        }


        public List<AdosadoExtendido> GetAdosados(bool piscina)
        {
            var query = from a in ListaAdosado
                        where a.Piscina.Equals(piscina) 
                        select new AdosadoExtendido

                        {
                            NombreAdosado = a.Nombre,
                            Piscina = a.Piscina,

                        };
            return query.ToList();
        }

        public List<PisoExtendido> GetPisos(int tamaño)
        {
            var query = from p in ListaPisos
                        where p.Tamaño >= 105
                       
                        select new PisoExtendido

                        {
                            NombrePiso = p.Nombre,
                            TamañoPiso = p.Tamaño,
                          
                        };

            return query.ToList();
        }

        public List<AdosadoExtendido> GetAdosados(int tamaño)
        {
            var query = from a in ListaAdosado
                        where a.Tamaño >= 170
                        select new AdosadoExtendido

                        {
                            NombreAdosado = a.Nombre,
                            TamañoAdosado = a.Tamaño,

                        };
            return query.ToList();
        }
    }


}
