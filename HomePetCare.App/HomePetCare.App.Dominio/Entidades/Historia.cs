using System;
using System.Collections.Generic;

// Modela la Historia clinica de la mascota (Perro)
namespace HomePetCare.App.Dominio
{
    public class Historia
    {
        // Identificador unico de la Historia
        public int Id {get; set;}
        // Fecha de creacion de la Historia
        public DateTime FechaInicial {get; set;}
        // Reporte de salud generado en la visita
        public List<ReporteVisita> ReporteVisita {get; set;}
    }

}