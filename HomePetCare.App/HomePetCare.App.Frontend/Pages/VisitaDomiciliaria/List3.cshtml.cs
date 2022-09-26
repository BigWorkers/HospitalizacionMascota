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
    public class List3Model : PageModel
    {
        private readonly IRepositorioVisitaDomiciliaria repositorioVisitaDomiciliaria;
        public IEnumerable<VisitaDomiciliaria> VisitasDomiciliaria {get; set;}
        
        public List3Model()
        {
            this.repositorioVisitaDomiciliaria=new RepositorioVisitaDomiciliaria(new HomePetCare.App.Persistencia.AppContext());
        }
        public void OnGet(string filtroBusqueda)
        {
            VisitasDomiciliaria = repositorioVisitaDomiciliaria.GetAllVisitaDomiciliaria();
        }
    }
}

