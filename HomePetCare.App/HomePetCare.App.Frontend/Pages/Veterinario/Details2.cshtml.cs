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
    public class Details2Model : PageModel
    {
        private readonly IRepositorioVeterinario repositorioVeterinario;

        public Veterinario Veterinario {get;set;}
        
        public Details2Model()
        {
            this.repositorioVeterinario = new RepositorioVeterinario(new HomePetCare.App.Persistencia.AppContext());
            }
                public IActionResult OnGet(int veterinariosId)
                {
                    Veterinario= repositorioVeterinario.GetVeterinario(veterinariosId);
                    if(Veterinario==null)
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
