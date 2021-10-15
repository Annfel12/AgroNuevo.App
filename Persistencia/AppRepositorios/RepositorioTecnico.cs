using System;
using System.Collections.Generic;
using System.Linq;
using Dominio.Entidades;

namespace AgroNuevo.App.Persistencia.AppRepositorios
{
    public class RepositorioTecnico : IRepositorioTecnico
    {
        private readonly AppContext _appContext; 

        public RepositorioTecnico(AppContext appContext) 
        {
            _appContext = appContext;
        }   

                

        Tecnico IRepositorioTecnico.AddTecnico(Tecnico tecnico)
        {
            var tecnicoAdicionado = _appContext.Tecnico.Add(tecnico);
            _appContext.SaveChanges();
            return tecnicoAdicionado.Entity;
        }

        Tecnico IRepositorioTecnico.UpdateTecnico(Tecnico tecnico)
        {
            var tecnicoAdicionado = _appContext.Tecnico.FirstOrDefault(c => c.Id == tecnico.Id);
            if (tecnicoAdicionado!= null)
            {
                tecnicoAdicionado.cargo = tecnico.cargo;
                tecnicoAdicionado.salario = tecnico.salario;
                

                _appContext.SaveChanges();                                        
            }
            return tecnicoAdicionado;
                    
        }

        void IRepositorioTecnico.DeleteTecnico(int idManoDeObra )
        {
            var tecnicoAdicionado = _appContext.Tecnico.FirstOrDefault(c => c.Id == idManoDeObra);
            if (tecnicoAdicionado == null)
            return;
            _appContext.Tecnico.Remove(tecnicoAdicionado);
            _appContext.SaveChanges();   
        }

        Tecnico IRepositorioTecnico.GetTecnico(int  idManoDeObra)
        {
            return _appContext.Tecnico.FirstOrDefault(c => c.Id == idManoDeObra);   
        }

        IEnumerable<Tecnico> IRepositorioTecnico.GetAllTecnico()
        {
            return _appContext.Tecnico;
        }
               
    }
}