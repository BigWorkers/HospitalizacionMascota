using System;
using System.Collections.Generic;
using System.Linq;
using HomePetCare.App.Dominio;

namespace HomePetCare.App.Persistencia
{
    public interface IRepositorioPropietarioMascota
    {
        IEnumerable<PropietarioMascota> GetAllPropietarioMascota();
        PropietarioMascota AddPropietarioMascota(PropietarioMascota propietarioMascota);
        PropietarioMascota UpdatePropietarioMascota(PropietarioMascota propietarioMascota);
        void DeletePropietarioMascota(int IdPropietarioMascota);
        PropietarioMascota GetPropietarioMascota(int IdPropietarioMascota);
    }
}