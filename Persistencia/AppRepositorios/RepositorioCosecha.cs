using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Dominio.Entidades;

namespace AgroNuevo.App.Persistencia.AppRepositorios
{
    public class RepositorioCosecha: IRepositorioCosecha
    {
        private readonly AppContext _appContext; 

        public RepositorioCosecha(AppContext appContext) 
        {
            _appContext = appContext;
        }   

                

        Cosecha IRepositorioCosecha.AddCosecha(Cosecha cosecha)
        {
            var CosechaAdicionado = _appContext.Cosecha.Add(cosecha);
            _appContext.SaveChanges();
            return CosechaAdicionado.Entity;
        }

        Cosecha IRepositorioCosecha.UpdateCosecha(Cosecha cosecha)
        {
            var CosechaAdicionado = _appContext.Cosecha.FirstOrDefault(c => c.Id == cosecha.Id);
            if (CosechaAdicionado!= null)
            {
                CosechaAdicionado.cargo = cosecha.cargo;
                CosechaAdicionado.salario = cosecha.salario;
                

                _appContext.SaveChanges();                                        
            }
            return CosechaAdicionado;
                    
        }

        void IRepositorioCosecha.DeleteCosecha(int idManoDeObra )
        {
            var CosechaAdicionado = _appContext.Cosecha.FirstOrDefault(c => c.Id == idManoDeObra);
            if (CosechaAdicionado == null)
            return;
            _appContext.Cosecha.Remove(CosechaAdicionado);
            _appContext.SaveChanges();   
        }

        Cosecha IRepositorioCosecha.GetCosecha(int  idManoDeObra)
        {
            return _appContext.Cosecha.FirstOrDefault(c => c.Id == idManoDeObra);   
        }

        IEnumerable<Cosecha> IRepositorioCosecha.GetAllCosecha()
        {
            return _appContext.Cosecha;
        }
               
    }
}