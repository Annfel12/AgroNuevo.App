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
    public class CosechaModel : PageModel
    {
        private readonly IRepositorioCosecha repositorioCosecha;

        public IEnumerable<Cosecha> Cosecha {get; set;}
        public CosechaModel()
        {
            this.repositorioCosecha = new RepositorioCosecha(new AgroNuevo.App.Persistencia.AppContext());            
        }

        public void OnGet(string filtroBusqueda)     
        {
            Cosecha = repositorioCosecha.GetAllCosecha();
        }  
        
    }
}
