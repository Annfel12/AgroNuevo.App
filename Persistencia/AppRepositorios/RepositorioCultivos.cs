using System;
using System.Collections.Generic;
using System.Linq;
using Dominio.Entidades;

namespace AgroNuevo.App.Persistencia.AppRepositorios
{
    public class RepositorioCultivos: IRepositorioCultivos
    {
        private readonly AppContext _appContext; 

        public RepositorioCultivos(AppContext appContext) 
        {
            _appContext = appContext;
        }   

                

        Cultivos IRepositorioCultivos.AddCultivos(Cultivos cultivos)
        {
            var cultivosAdicionado = _appContext.Cultivos.Add(cultivos);
            _appContext.SaveChanges();
            return cultivosAdicionado.Entity;
        }

        Cultivos IRepositorioCultivos.UpdateCultivos(Cultivos cultivos)
        {
            var cultivosAdicionado = _appContext.Cultivos.FirstOrDefault(c => c.Id == cultivos.Id);
            if (cultivosAdicionado!= null)
            {
                cultivosAdicionado.cargo = cultivos.cargo;
                cultivosAdicionado.salario = cultivos.salario;
                

                _appContext.SaveChanges();                                        
            }
            return cultivosAdicionado;
                    
        }

        void IRepositorioCultivos.DeleteCultivos(int idManoDeObra )
        {
            var cultivosAdicionado = _appContext.Cultivos.FirstOrDefault(c => c.Id == idManoDeObra);
            if (cultivosAdicionado == null)
            return;
            _appContext.Cultivos.Remove(cultivosAdicionado);
            _appContext.SaveChanges();   
        }

        Cultivos IRepositorioCultivos.GetCultivos(int  idManoDeObra)
        {
            return _appContext.Cultivos.FirstOrDefault(c => c.Id == idManoDeObra);   
        }

        IEnumerable<Cultivos> IRepositorioCultivos.GetAllCultivos()
        {
            return _appContext.Cultivos;
        }
               
    }
}