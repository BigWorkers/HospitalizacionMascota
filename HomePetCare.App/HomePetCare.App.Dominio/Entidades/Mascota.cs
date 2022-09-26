using System;
// Modela a una Mascota (Perro)

namespace HomePetCare.App.Dominio
{
    public class Mascota
    {
        // Identificador unico de mascota (Perro)
        public int Id {get; set;}
        public string Nombre {get; set;}
        public DateTime FechaNacimiento {get; set;}
        public string Color {get; set;}
        public string Raza {get; set;}
        public string EstadoSalud {get; set;}
        public PropietarioMascota PropietarioMascota {get; set;}
        public Veterinario Veterinario{get; set;}
    }
}