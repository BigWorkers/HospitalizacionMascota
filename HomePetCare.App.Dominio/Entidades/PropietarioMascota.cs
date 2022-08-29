using System;
namespace HomePetCare.App.Dominio
{
    public class PropietarioMascota
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Documento { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
    }
}