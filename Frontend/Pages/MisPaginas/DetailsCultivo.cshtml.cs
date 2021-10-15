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
    public class DetailsCultivoModel : PageModel
    {
        private readonly IRepositorioCultivos RepositorioCultivos;
        
        public Cultivos Cultivos {set; get;}

        public DetailsCultivoModel()
        {
            this.RepositorioCultivos = new RepositorioCultivos(new AgroNuevo.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int CultivosId)
        {
            Cultivos = RepositorioCultivos.GetCultivos(CultivosId);
            if(Cultivos==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            {
                return Page();
            }
        }
        
    }
}
