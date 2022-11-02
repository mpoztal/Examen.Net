using Examen.Net.Clases;
using Examen.Net.Entidades;
using Examen.Net.Interfaces;

IDataService dataService = new DataService();
List<Municipio> municipios = dataService.GetMunicipios();

Console.WriteLine("----------------------LISTADO MUNICIPIOS-------------------------------");

foreach (Municipio municipio in municipios)
{
  
    Console.WriteLine($"{municipio.MunicipioId} {municipio.Nombre}");
}

Console.WriteLine("--------------------LISTADO PISOS Y MUNICIPIO AL QUE PERTENECEN---------------------------------");


List <PisoExtendido> pisos = dataService.GetPisos();

foreach (PisoExtendido piso in pisos)
{
    Console.WriteLine($"El piso {piso.NombrePiso}  está situado en el municipio de {piso.NombreMunicipio}");
}

Console.WriteLine("--------------------LISTADO ADOSADOS Y MUNICIPIO AL QUE PERTENECEN---------------------------------");


List<AdosadoExtendido> adosados = dataService.GetAdosados();

foreach (AdosadoExtendido adosado in adosados)
{
    Console.WriteLine($"El adosado {adosado.NombreAdosado}  está situado en el municipio de {adosado.NombreMunicipio}");
}

Console.WriteLine("--------------------LISTADO PISOS QUE PERTENECEN A CÁDIZ---------------------------------");


pisos = dataService.GetPisos("Cádiz");

foreach (PisoExtendido piso in pisos)
{
    Console.WriteLine($"El {piso.NombrePiso}  está situado en el municipio de {piso.NombreMunicipio}");
}


Console.WriteLine("--------------------LISTADO ADOSADOS QUE PERTENECEN A CÁDIZ---------------------------------");


adosados = dataService.GetAdosados("Cádiz");

foreach (AdosadoExtendido adosado in adosados)
{
    Console.WriteLine($"El {adosado.NombreAdosado}  está situado en el municipio de {adosado.NombreMunicipio}");
}

Console.WriteLine("--------------------LISTADO PISOS QUE TENGAN 3 O MAS HABITACIONES---------------------------------");


pisos = dataService.GetPisos( numeroHabitaciones: 3);

foreach (PisoExtendido piso in pisos)
{
    Console.WriteLine($"El {piso.NombrePiso} tiene {piso.NumeroHabitacionesPiso} habitaciones");
}

Console.WriteLine("--------------------LISTADO ADOSADOS QUE TENGAN 4 O MAS HABITACIONES---------------------------------");

adosados = dataService.GetAdosados(numeroHabitaciones: 4);

foreach (AdosadoExtendido adosado in adosados)
{
    Console.WriteLine($"El {adosado.NombreAdosado}  tiene {adosado.NumeroHabitacionesAdosado} habitaciones");
}

Console.WriteLine("--------------------LISTADO ADOSADOS QUE TENGAN PISCINA---------------------------------");

adosados = dataService.GetAdosados(true);

foreach (AdosadoExtendido adosado in adosados)
{
    Console.WriteLine($"El {adosado.NombreAdosado} tiene piscina");
}


Console.WriteLine("--------------------LISTADO PISOS QUE TENGAN 105 O MÁS METROS CUADRADOS---------------------------------");


pisos = dataService.GetPisos(tamaño: 105);

foreach (PisoExtendido piso in pisos)
{
    Console.WriteLine($"El {piso.NombrePiso} tiene {piso.TamañoPiso} metros cuadrados");
}

Console.WriteLine("--------------------LISTADO ADOSADOS QUE TENGAN 170 O MÁS METROS CUADRADOS---------------------------------");

adosados = dataService.GetAdosados(tamaño: 170);

foreach (AdosadoExtendido adosado in adosados)
{
    Console.WriteLine($"El {adosado.NombreAdosado}  tiene {adosado.TamañoAdosado}  metros cuadrados");
}
