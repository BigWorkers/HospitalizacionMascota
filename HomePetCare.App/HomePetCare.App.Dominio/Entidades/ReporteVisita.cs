using System;
namespace HomePetCare.App.Dominio
// reporte visita domiciliaria mascota (Perro)
{
    public class ReporteVisita
    {
        // Datos unicos de salud de la mascota (Perro)
        public int Id {get; set;}
        public float Temperatura {get; set;}
        public float Peso {get; set;}
        public int FrecuenciaRespiratoria {get; set;}
        public int FrecuenciaCardiaca {get; set;}
        public string EstadoDeAnimo {get; set;}
        public DateTime FechaVisita {get; set;}
        public int IdVeterinario {get; set;}
    }
}