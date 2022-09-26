using System.Collections.Generic;
using System.Linq;
using HomePetCare.App.Dominio;


namespace HomePetCare.App.Persistencia
{
    public class RepositorioVisitaDomiciliaria : IRepositorioVisitaDomiciliaria
    {
        // Referente al contexto del Reporte Visita
        private readonly AppContext _appContext;

        //Metodo constructor utiliza dependencias para indicar contexto a usar

        public RepositorioVisitaDomiciliaria (AppContext appContext)
        {
            _appContext=appContext;
        }
        VisitaDomiciliaria IRepositorioVisitaDomiciliaria.AddVisitaDomiciliaria(VisitaDomiciliaria visitaDomiciliaria)
        {
            var visitaDomiciliariaAdicionado=_appContext.VisitasDomiciliaria.Add(visitaDomiciliaria);
            _appContext.SaveChanges();
            return visitaDomiciliariaAdicionado.Entity;
        }
        void IRepositorioVisitaDomiciliaria.DeleteVisitaDomiciliaria(int IdVisitaDomiciliaria)
        {
            var visitaDomiciliariaEncontrado=_appContext.VisitasDomiciliaria.FirstOrDefault(p => p.Id==IdVisitaDomiciliaria);
            if (visitaDomiciliariaEncontrado==null)
            return;
            _appContext.VisitasDomiciliaria.Remove(visitaDomiciliariaEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<VisitaDomiciliaria> IRepositorioVisitaDomiciliaria.GetAllVisitaDomiciliaria()
        {
            return _appContext.VisitasDomiciliaria;
        }
        VisitaDomiciliaria IRepositorioVisitaDomiciliaria.GetVisitaDomiciliaria(int IdVisitaDomiciliaria)
        {
            return _appContext.VisitasDomiciliaria.FirstOrDefault(p => p.Id==IdVisitaDomiciliaria);
        }
        VisitaDomiciliaria IRepositorioVisitaDomiciliaria.UpdateVisitaDomiciliaria(VisitaDomiciliaria visitaDomiciliaria)
        {
            var visitaDomiciliariaEncontrado=_appContext.VisitasDomiciliaria.FirstOrDefault(p => p.Id==visitaDomiciliaria.Id);
            if (visitaDomiciliariaEncontrado != null)
            {
                visitaDomiciliariaEncontrado.Temperatura=visitaDomiciliaria.Temperatura;
                visitaDomiciliariaEncontrado.Peso=visitaDomiciliaria.Peso;
                visitaDomiciliariaEncontrado.FrecuenciaRespiratoria=visitaDomiciliaria.FrecuenciaRespiratoria;
                visitaDomiciliariaEncontrado.FrecuenciaCardiaca=visitaDomiciliaria.FrecuenciaCardiaca;
                visitaDomiciliariaEncontrado.EstadoDeAnimo=visitaDomiciliaria.EstadoDeAnimo;
                visitaDomiciliariaEncontrado.FechaVisita=visitaDomiciliaria.FechaVisita;
                

                _appContext.SaveChanges();
            }

            return visitaDomiciliariaEncontrado;

         }
    }
}