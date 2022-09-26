using System;
namespace HomePetCare.App.Dominio
// Modela una persona general en el sistema (Propietario Mascota y Veterinario)
{
    public class Persona
    {
        // Identificador unico de cada persona
    public int Id {get;set;}
    public string IdPersona {get;set;}
    public string Nombres {get;set;}
    public string Apellidos {get;set;}
    public string Direccion {get;set;}
    public string Telefono {get;set;}
    }
}