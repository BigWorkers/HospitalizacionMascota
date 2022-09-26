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
    public class Edit2Model : PageModel
    {
        private readonly IRepositorioVeterinario repositorioVeterinario;
        [BindProperty]
        public Veterinario Veterinario {get;set;}
        
        public Edit2Model()
        {
            this.repositorioVeterinario = new RepositorioVeterinario(new HomePetCare.App.Persistencia.AppContext());;
            }
                public IActionResult OnGet(int? veterinariosId)
                {
                    if (veterinariosId.HasValue)
                    {
                    Veterinario= repositorioVeterinario.GetVeterinario(veterinariosId.Value);
                    }
                    else
                    {
                        Veterinario = new Veterinario();
                    }
                   
                    if(Veterinario==null)
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
                    if (Veterinario.Id>0)
                    {
                    Veterinario = repositorioVeterinario.UpdateVeterinario(Veterinario);
                    }
                    else
                    {
                        repositorioVeterinario.AddVeterinario(Veterinario);
                    }
                    return Page();
                }
        }
}
