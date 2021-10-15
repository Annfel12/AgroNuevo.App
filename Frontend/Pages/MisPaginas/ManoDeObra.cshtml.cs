using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio.Entidades;
using AgroNuevo.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Authorization;

namespace AgroNuevo.Frontend.Pages
{
    public class ManoDeObraModel : PageModel
    {
        private readonly IRepositorioManoDeObra repositorioManoDeObra;

        public IEnumerable<ManoDeObra> ManoDeObra {get; set;}
        public ManoDeObraModel()
        {
            this.repositorioManoDeObra = new RepositorioManoDeObra(new AgroNuevo.App.Persistencia.AppContext());            
        }

        public void OnGet(string filtroBusqueda)     
        {
            ManoDeObra = repositorioManoDeObra.GetAllManoDeObra();
        }  
        
    }
}
