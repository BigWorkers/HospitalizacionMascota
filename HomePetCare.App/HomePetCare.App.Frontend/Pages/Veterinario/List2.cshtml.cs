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
    
    public class List2Model : PageModel
    {
        private readonly IRepositorioVeterinario repositorioVeterinario;
        public IEnumerable<Veterinario> veterinarios {get; set;}
        
        public List2Model()
        {
            this.repositorioVeterinario=new RepositorioVeterinario(new HomePetCare.App.Persistencia.AppContext());
        }
        public void OnGet(string filtroBusqueda)
        {
            veterinarios = repositorioVeterinario.GetAllVeterinario();
        }
    }
}

