using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HomePetCare.App.Dominio;
using HomePetCare.App.Persistencia;
using Microsoft.AspNetCore.Authorization;

namespace HomePetCare.App.Frontend.Pages
{
    [Authorize]
    public class List1Model : PageModel
    {
        private readonly IRepositorioPropietarioMascota repositorioPropietarioMascota;
        public IEnumerable<PropietarioMascota> PropietarioMascotas{get; set;}
        
        public List1Model()
        {
            this.repositorioPropietarioMascota=new RepositorioPropietarioMascota(new HomePetCare.App.Persistencia.AppContext());
        }
        public void OnGet(string filtroBusqueda)
        {
            PropietarioMascotas = repositorioPropietarioMascota.GetAllPropietarioMascota();
        }
    }
}
