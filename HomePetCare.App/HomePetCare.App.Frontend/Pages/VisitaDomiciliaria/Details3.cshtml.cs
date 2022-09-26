using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HomePetCare.App.Dominio;
using HomePetCare.App.Persistencia;

namespace HomePetCare.App.Frontend.Pages
{
    public class Details3Model : PageModel
    {
        private readonly IRepositorioVisitaDomiciliaria repositorioVisitaDomiciliaria;

        public VisitaDomiciliaria VisitaDomiciliaria {get;set;}
        
        public Details3Model()
        {
            this.repositorioVisitaDomiciliaria = new RepositorioVisitaDomiciliaria(new HomePetCare.App.Persistencia.AppContext());
            }
                public IActionResult OnGet(int visitaDomiciliariaId)
                {
                    VisitaDomiciliaria= repositorioVisitaDomiciliaria.GetVisitaDomiciliaria(visitaDomiciliariaId);
                    if(VisitaDomiciliaria==null)
                    {
                        return RedirectToPage("./NotFound");
                    }
                    else
                    {
                        return Page();
                    }
                    
                }
    }
}