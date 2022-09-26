using System.Collections.Generic;
using System.Linq;
using HomePetCare.App.Dominio;


namespace HomePetCare.App.Persistencia
{
    public class RepositorioMascota : IRepositorioMascota
    {
        // Referente al contexto de la Mascota
        private readonly AppContext _appContext;

        //Metodo constructor utiliza dependencias para indicar contexto a usar

        public RepositorioMascota(AppContext appContext)
        {
            _appContext=appContext;
        }
        Mascota IRepositorioMascota.AddMascota(Mascota mascota)
        {
            var mascotaAdicionado=_appContext.Mascotas.Add(mascota);
            _appContext.SaveChanges();
            return mascotaAdicionado.Entity;
        }
        void IRepositorioMascota.DeleteMascota(int IdMascota)
        {
            var mascotaEncontrado=_appContext.Mascotas.FirstOrDefault(p => p.Id==IdMascota);
            if (mascotaEncontrado==null)
            return;
            _appContext.Mascotas.Remove(mascotaEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<Mascota> IRepositorioMascota.GetAllMascotas()
        {
            return _appContext.Mascotas;
        }
        Mascota IRepositorioMascota.GetMascota(int IdMascota)
        {
            return _appContext.Mascotas.FirstOrDefault(p => p.Id==IdMascota);
        }
        Mascota IRepositorioMascota.UpdateMascota(Mascota mascota)
        {
            var mascotaEncontrado=_appContext.Mascotas.FirstOrDefault(p => p.Id==mascota.Id);
            if (mascotaEncontrado != null)
            {
                mascotaEncontrado.Nombre=mascota.Nombre;
                mascotaEncontrado.FechaNacimiento=mascota.FechaNacimiento;
                mascotaEncontrado.Color=mascota.Color;
                mascotaEncontrado.Raza=mascota.Raza;
                mascotaEncontrado.EstadoSalud=mascota.EstadoSalud;
                mascotaEncontrado.PropietarioMascota=mascota.PropietarioMascota;
                mascotaEncontrado.Veterinario=mascota.Veterinario;

                _appContext.SaveChanges();
            }

            return mascotaEncontrado;

         }
    }
}