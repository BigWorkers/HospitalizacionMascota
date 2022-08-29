using System;
namespace HomePetCare.App.Dominio
{
    public class Mascota
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public int AnoNacimiento { get; set; }
        public string? Color { get; set; }
        public string? EstadoSalud { set; get; }

        public VeterinarioDomiciliario Medico { get; set; }
        /// Relacion entre veterinario mascota
        public PropietarioMascota DeuñoPerro { get; set; }
        /// Relacion entre dueño mascota
        public ReporteVisita Reporte { get; set; }
        /// Relacion entre mascota y Reporte visita

    }
}
