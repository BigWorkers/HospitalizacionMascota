using System;
using HomePetCare.App.Dominio;
using HomePetCare.App.Persistencia;

namespace HomePetCare.App.Consola
{
    class Program
    {
        private static IRepositorioMascota _repoMascota = new RepositorioMascota(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World EF!");
            //AddMascota();
            BuscarMascota(1);
        }
        private static void AddMascota()
        {
            var mascota = new Mascota  // Se inserta informacion de la Mascota
            {
                Nombre = "Douglas",
                Color = "Amarillo",
                Raza = "Golden Retriever",
                EstadoSalud ="Bueno",
                FechaNacimiento = new DateTime(2020,04,18)
  
            };
            _repoMascota.AddMascota(mascota);
        }
        private static void BuscarMascota(int IdMascota)
        {
            var mascota = _repoMascota.GetMascota(IdMascota);
            Console.WriteLine(mascota.Nombre+" "+mascota.Color);
        }
    }
}
