using System;
namespace HomePetCare.App.Dominio
{
    public class ReporteVisita
    {
        public int Id { get; set; }
        public int Temperatura { get; set; }
        public int Peso { get; set; }
        public int FrecuenciaRespiratoria { get; set; }
        public int FrecuenciaCardiaca { get; set; }
        public string? EstadoDeAnimo { get; set; }
        public int FechaVisita { get; set; }

        public VeterinarioDomiciliario Medico { get; set; }
        /// Relacion entre veterinario reporte
        public Recomendaciones Recomendacion { get; set; }
        /// Relacion entre reporte y recomendacion
        public Formula Formulas { get; set; }
        /// Relacion entre reporte y formula

    }
}