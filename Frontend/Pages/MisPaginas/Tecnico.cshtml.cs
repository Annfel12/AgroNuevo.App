using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio.Entidades;
using AgroNuevo.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Authorization;
namespace Frontend.Pages
{
    public class TecnicoModel : PageModel
    {
        private readonly IRepositorioTecnico repositorioTecnico;

        public IEnumerable<Tecnico> Tecnico {get; set;}
        public TecnicoModel()
        {
            this.repositorioTecnico = new RepositorioTecnico(new AgroNuevo.App.Persistencia.AppContext());            
        }

        public void OnGet(string filtroBusqueda)     
        {
            Tecnico = repositorioTecnico.GetAllTecnico();
        }  
        
    }
}
