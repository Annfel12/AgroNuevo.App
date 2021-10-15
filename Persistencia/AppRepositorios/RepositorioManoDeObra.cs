using System;
using System.Collections.Generic;
using System.Linq;
using Dominio.Entidades;

namespace AgroNuevo.App.Persistencia.AppRepositorios
{
    public class RepositorioManoDeObra : IRepositorioManoDeObra
       
    
    {
        private readonly AppContext _appContext; 

        public RepositorioManoDeObra(AppContext appContext) 
        {
            _appContext = appContext;
        }   

                

        ManoDeObra IRepositorioManoDeObra.AddManoDeObra(ManoDeObra manoDeObra)
        {
            var manoDeObraAdicionada = _appContext.ManoDeObra.Add(manoDeObra);
            _appContext.SaveChanges();
            return manoDeObraAdicionada.Entity;
        }

        ManoDeObra IRepositorioManoDeObra.UpdateManoDeObra(ManoDeObra manoDeObra)
        {
            var manoDeObraEncontrada = _appContext.ManoDeObra.FirstOrDefault(c => c.Id == manoDeObra.Id);
            if (manoDeObraEncontrada!= null)
            {
                manoDeObraEncontrada.cargo = manoDeObra.cargo;
                manoDeObraEncontrada.salario  = manoDeObra.salario ;
                             
                _appContext.SaveChanges();                                        
            }
            return manoDeObraEncontrada;
                    
        }

        void IRepositorioManoDeObra.DeleteManoDeObra(int idManoDeObra )
        {
            var manoDeObraEncontrada = _appContext.ManoDeObra.FirstOrDefault(c => c.Id == idManoDeObra);
            if (manoDeObraEncontrada == null)
            return;
            _appContext.ManoDeObra.Remove(manoDeObraEncontrada);
            _appContext.SaveChanges();   
        }

        ManoDeObra IRepositorioManoDeObra.GetManoDeObra(int  idManoDeObra)
        {
            return _appContext.ManoDeObra.FirstOrDefault(c => c.Id == idManoDeObra);   
        }

        IEnumerable<ManoDeObra> IRepositorioManoDeObra.GetAllManoDeObra()
        {
            return _appContext.ManoDeObra;
        }
    }       
}