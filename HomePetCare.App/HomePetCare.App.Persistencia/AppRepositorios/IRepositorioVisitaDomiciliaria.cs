using System;
using System.Collections.Generic;
using System.Linq;
using HomePetCare.App.Dominio;

namespace HomePetCare.App.Persistencia
{
    public interface IRepositorioVisitaDomiciliaria
    {
        IEnumerable<VisitaDomiciliaria> GetAllVisitaDomiciliaria();
        VisitaDomiciliaria AddVisitaDomiciliaria(VisitaDomiciliaria visitaDomiciliaria);
        VisitaDomiciliaria UpdateVisitaDomiciliaria(VisitaDomiciliaria visitaDomiciliaria);
        void DeleteVisitaDomiciliaria(int IdVisitaDomiciliaria);
        VisitaDomiciliaria GetVisitaDomiciliaria(int IdVisitaDomiciliaria);
    }
}