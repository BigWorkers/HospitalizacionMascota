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
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioMascota repositorioMascota;

        public Mascota Mascota {get;set;}
        
        public DetailsModel()
        {
            this.repositorioMascota = new RepositorioMascota(new HomePetCare.App.Persistencia.AppContext());
            }
                public IActionResult OnGet(int mascotaId)
                {
                    Mascota= repositorioMascota.GetMascota(mascotaId);
                    if(Mascota==null)
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