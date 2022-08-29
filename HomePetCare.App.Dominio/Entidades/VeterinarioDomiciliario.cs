using System;
namespace HomePetCare.App.Dominio
{
    public class VeterinarioDomiciliario
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Telefono { get; set; }
        public int TarjetaProfesional { get; set; }
    }
}