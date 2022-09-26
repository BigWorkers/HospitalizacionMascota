using System;
namespace HomePetCare.App.Dominio
// reporte visita domiciliaria mascota (Perro)
{
    public class VisitaDomiciliaria
    {
        // Datos unicos de salud de la mascota (Perro)
        public int Id {get; set;}
        public string Temperatura {get; set;}
        public string Peso {get; set;}
        public string FrecuenciaRespiratoria {get; set;}
        public string FrecuenciaCardiaca {get; set;}
        public string EstadoDeAnimo {get; set;}
        public string FechaVisita {get; set;}
        
    }
}