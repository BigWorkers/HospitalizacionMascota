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
    public class DeleteModel : PageModel
    {
        private readonly IRepositorioMascota repositorioMascota;
        [BindProperty]
        public Mascota Mascota {get;set;}
        
        public DeleteModel()
        {
            this.repositorioMascota = new RepositorioMascota(new HomePetCare.App.Persistencia.AppContext());;
            }
                public IActionResult OnGet(int? mascotaId)
                {
                    if (mascotaId.HasValue)
                    {
                    Mascota= repositorioMascota.GetMascota(mascotaId.Value);
                    }
                    if(Mascota==null)
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
                    if (Mascota.Id>0)
                    {
                     repositorioMascota.DeleteMascota(Mascota.Id);
                    }
                    else
                    {
                        repositorioMascota.AddMascota(Mascota);
                    }
                    return Page();
                }
        }
}