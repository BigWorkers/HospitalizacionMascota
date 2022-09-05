using System;
namespace HomePetCare.App.Dominio
//Modela al Propietario de la Mascota (Perro)
{
    public class PropietarioMascota : Persona
    {
        //Ciudad de residencia del dueño de la mascota (Perro)
        public string Ciudad {get; set;}
        // Correo electronico del dueño de la mascota (perro)
        public string Correo {get; set;}
    }
}