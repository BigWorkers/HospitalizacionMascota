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
    public class Edit1Model : PageModel
    {
      private readonly IRepositorioPropietarioMascota repositorioPropietarioMascota;
        [BindProperty]
        public PropietarioMascota PropietarioMascota {get;set;}
        
        public Edit1Model()
        {
            this.repositorioPropietarioMascota = new RepositorioPropietarioMascota(new HomePetCare.App.Persistencia.AppContext());;
            }
                public IActionResult OnGet(int? propietarioMascotaId)
                {
                    if (propietarioMascotaId.HasValue)
                    {
                    PropietarioMascota= repositorioPropietarioMascota.GetPropietarioMascota(propietarioMascotaId.Value);
                    }
                    else
                    {
                        PropietarioMascota = new PropietarioMascota();
                    }
                   
                    if(PropietarioMascota==null)
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
                    if (PropietarioMascota.Id>0)
                    {
                    PropietarioMascota = repositorioPropietarioMascota.UpdatePropietarioMascota(PropietarioMascota);
                    }
                    else
                    {
                        repositorioPropietarioMascota.AddPropietarioMascota(PropietarioMascota);
                    }
                    return Page();
                }
        }
}
