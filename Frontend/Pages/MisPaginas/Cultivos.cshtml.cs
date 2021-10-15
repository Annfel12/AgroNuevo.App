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
    public class CultivosModel : PageModel
    {
        private readonly IRepositorioCultivos repositorioCultivos;

        public IEnumerable<Cultivos> Cultivos {get; set;}
        public CultivosModel()
        {
            this.repositorioCultivos = new RepositorioCultivos(new AgroNuevo.App.Persistencia.AppContext());            
        }

        public void OnGet(string filtroBusqueda)     
        {
            Cultivos = repositorioCultivos.GetAllCultivos();
        }  
        
    }
}
