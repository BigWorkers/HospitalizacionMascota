using System.Collections.Generic;
using System.Linq;
using HomePetCare.App.Dominio;


namespace HomePetCare.App.Persistencia
{
    public class RepositorioPropietarioMascota : IRepositorioPropietarioMascota
    {
        // Referente al contexto del Propietario de la Mascota
        private readonly AppContext _appContext;

        //Metodo constructor utiliza dependencias para indicar contexto a usar

        public RepositorioPropietarioMascota(AppContext appContext)
        {
            _appContext=appContext;
        }
        PropietarioMascota IRepositorioPropietarioMascota.AddPropietarioMascota(PropietarioMascota propietarioMascota)
        {
            var propietarioMascotaAdicionado=_appContext.PropietarioMascotas.Add(propietarioMascota);
            _appContext.SaveChanges();
            return propietarioMascotaAdicionado.Entity;
        }
        void IRepositorioPropietarioMascota.DeletePropietarioMascota(int IdPersona)
        {
            var propietarioMascotaEncontrado=_appContext.PropietarioMascotas.FirstOrDefault(p => p.Id==IdPersona);
            if (propietarioMascotaEncontrado==null)
            return;
            _appContext.PropietarioMascotas.Remove(propietarioMascotaEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<PropietarioMascota> IRepositorioPropietarioMascota.GetAllPropietarioMascota()
        {
            return _appContext.PropietarioMascotas;
        }
        PropietarioMascota IRepositorioPropietarioMascota.GetPropietarioMascota(int IdPersona)
        {
            return _appContext.PropietarioMascotas.FirstOrDefault(p => p.Id==IdPersona);
        }
        PropietarioMascota IRepositorioPropietarioMascota.UpdatePropietarioMascota(PropietarioMascota propietarioMascota)
        {
            var propietarioMascotaEncontrado=_appContext.PropietarioMascotas.FirstOrDefault(p => p.Id==propietarioMascota.Id);
            if (propietarioMascotaEncontrado != null)
            {
                propietarioMascotaEncontrado.IdPersona=propietarioMascota.IdPersona;
                propietarioMascotaEncontrado.Nombres=propietarioMascota.Nombres;
                propietarioMascotaEncontrado.Apellidos=propietarioMascota.Apellidos;
                propietarioMascotaEncontrado.Direccion=propietarioMascota.Direccion;
                propietarioMascotaEncontrado.Telefono=propietarioMascota.Telefono;
                
              

                _appContext.SaveChanges();
            }

            return propietarioMascotaEncontrado;

         }
    }
}