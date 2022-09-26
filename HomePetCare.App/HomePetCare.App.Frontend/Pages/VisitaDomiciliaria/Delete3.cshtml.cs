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
    public class Delete3Model : PageModel
    {
       private readonly IRepositorioVisitaDomiciliaria repositorioVisitaDomiciliaria;
        [BindProperty]
        public VisitaDomiciliaria VisitaDomiciliaria {get;set;}
        
        public Delete3Model()
        {
            this.repositorioVisitaDomiciliaria = new RepositorioVisitaDomiciliaria(new HomePetCare.App.Persistencia.AppContext());;
            }
                public IActionResult OnGet(int? visitaDomiciliariaId)
                {
                    if (visitaDomiciliariaId.HasValue)
                    {
                    VisitaDomiciliaria= repositorioVisitaDomiciliaria.GetVisitaDomiciliaria(visitaDomiciliariaId.Value);
                    }
                    if(VisitaDomiciliaria==null)
                    {
                        return RedirectToPage("./NotFound");
                    }
                    else
                    {
                        return Page();
                    }
                    
                }
                public IActionResult OnPost()
                {
                    if(!ModelState.IsValid)
                    {
                        return Page();
                    }
                    if (VisitaDomiciliaria.Id>0)
                    {
                     repositorioVisitaDomiciliaria.DeleteVisitaDomiciliaria(VisitaDomiciliaria.Id);
                    }
                    else
                    {
                        repositorioVisitaDomiciliaria.AddVisitaDomiciliaria(VisitaDomiciliaria);
                    }
                    return Page();
                }
        }
}