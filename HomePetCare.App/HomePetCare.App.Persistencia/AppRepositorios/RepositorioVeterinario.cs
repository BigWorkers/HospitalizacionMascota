using System.Collections.Generic;
using System.Linq;
using HomePetCare.App.Dominio;


namespace HomePetCare.App.Persistencia
{
    public class RepositorioVeterinario : IRepositorioVeterinario
    {
        // Referente al contexto del Veterinario
        private readonly AppContext _appContext;

        //Metodo constructor utiliza dependencias para indicar contexto a usar

        public RepositorioVeterinario(AppContext appContext)
        {
            _appContext=appContext;
        }
        Veterinario IRepositorioVeterinario.AddVeterinario(Veterinario veterinario)
        {
            var veterinarioAdicionado=_appContext.Veterinarios.Add(veterinario);
            _appContext.SaveChanges();
            return veterinarioAdicionado.Entity;
        }
        void IRepositorioVeterinario.DeleteVeterinario(int IdPersona)
        {
            var veterinarioEncontrado=_appContext.Veterinarios.FirstOrDefault(p => p.Id==IdPersona);
            if (veterinarioEncontrado==null)
            return;
            _appContext.Veterinarios.Remove(veterinarioEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<Veterinario> IRepositorioVeterinario.GetAllVeterinario()
        {
            return _appContext.Veterinarios;
        }
        Veterinario IRepositorioVeterinario.GetVeterinario(int IdPersona)
        {
            return _appContext.Veterinarios.FirstOrDefault(p => p.Id==IdPersona);
        }
        Veterinario IRepositorioVeterinario.UpdateVeterinario(Veterinario veterinario)
        {
            var veterinarioEncontrado=_appContext.Veterinarios.FirstOrDefault(p => p.Id==veterinario.Id);
            if (veterinarioEncontrado != null)
            {
                veterinarioEncontrado.IdPersona=veterinario.IdPersona;
                veterinarioEncontrado.Nombres=veterinario.Nombres;
                veterinarioEncontrado.Apellidos=veterinario.Apellidos;
                veterinarioEncontrado.Direccion=veterinario.Direccion;
                veterinarioEncontrado.Telefono=veterinario.Telefono;
                veterinarioEncontrado.TarjetaProfesional=veterinario.TarjetaProfesional;
                
                _appContext.SaveChanges();
            }

            return veterinarioEncontrado;

         }
    }
}