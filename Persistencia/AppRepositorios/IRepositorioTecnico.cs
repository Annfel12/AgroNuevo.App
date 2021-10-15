using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Dominio.Entidades;

namespace AgroNuevo.App.Persistencia.AppRepositorios
{
    public interface IRepositorioTecnico
    {
        IEnumerable<Tecnico> GetAllTecnico();

        Tecnico AddTecnico(Tecnico tecnico);

        Tecnico UpdateTecnico(Tecnico tecnico);

        void DeleteTecnico(int idTecnico);

        Tecnico GetTecnico(int  idTecnico);
         
    }
}