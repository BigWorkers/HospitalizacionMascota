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
    public class Details1Model : PageModel
    {
        private readonly IRepositorioPropietarioMascota repositorioPropietarioMascota;

        public PropietarioMascota PropietarioMascota {get;set;}
        
        public Details1Model()
        {
            this.repositorioPropietarioMascota = new RepositorioPropietarioMascota(new HomePetCare.App.Persistencia.AppContext());
            }
                public IActionResult OnGet(int propietarioMascotaId)
                {
                    PropietarioMascota= repositorioPropietarioMascota.GetPropietarioMascota(propietarioMascotaId);
                    if(PropietarioMascota==null)
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