
using Examen.Net.Entidades;
using Examen.Net.Interfaces;

namespace Examen.Net.Clases
{
    public class LoadDataService : ILoadDataService
    {
        public List<Municipio> LoadMunicipios()
        {
            return new List<Municipio>

            {
                new Municipio
                {
                    MunicipioId = 1,
                    Nombre = "Cádiz",
                },

                new Municipio
                {
                    MunicipioId = 2,
                    Nombre = "Málaga",
                },

                new Municipio
                {
                    MunicipioId = 3,
                    Nombre = "Sevilla",
                },

                new Municipio
                {
                    MunicipioId = 4,
                    Nombre = "Almería",
                },

            };
        }



        public List<Piso> LoadPisos()
        {
            return new List<Piso>

            {
                new Piso
                {
                    MunicipioId = 1,
                    Tamaño = 90,
                    Nombre = "Piso1",
                    NumeroHabitaciones = 2,
                    NumeroBaños = 2,
                    NumeroPlanta = 2,

                },

                new Piso
                {
                    MunicipioId = 2,
                    Tamaño = 105,
                    Nombre = "Piso2",
                    NumeroHabitaciones = 4,
                    NumeroBaños = 2,
                    NumeroPlanta = 1,

                },

                new Piso
                {
                    MunicipioId = 3,
                    Tamaño = 85,
                    Nombre = "Piso3",
                    NumeroHabitaciones = 3,
                    NumeroBaños = 2,
                    NumeroPlanta = 3,

                },

                new Piso
                {
                    MunicipioId = 4,
                    Tamaño = 150,
                    Nombre = "Piso4",
                    NumeroHabitaciones = 5,
                    NumeroBaños = 2,
                    NumeroPlanta = 4,

                },



            };
        }


        public List<Adosado> LoadAdosado()
        {
            return new List<Adosado>
            {

                 new Adosado

                 {
                    MunicipioId = 1,
                    Tamaño = 160,
                    Nombre = "Adosado1",
                    NumeroHabitaciones = 3,
                    NumeroBaños = 3,
                    Piscina = true,

                 },

                 new Adosado

                 {
                    MunicipioId = 2,
                    Tamaño = 170,
                    Nombre = "Adosado2",
                    NumeroHabitaciones = 4,
                    NumeroBaños = 2,
                    Piscina = false,

                 },

                 new Adosado

                 {
                    MunicipioId = 3,
                    Tamaño = 180,
                    Nombre = "Adosado3",
                    NumeroHabitaciones = 5,
                    NumeroBaños = 3,
                    Piscina = true,

                 },

                  new Adosado

                 {
                    MunicipioId = 4,
                    Tamaño = 190,
                    Nombre = "Adosado4",
                    NumeroHabitaciones = 5,
                    NumeroBaños = 2,
                    Piscina = false,

                 },
            };
        }
    }
}
