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
    public class editCultivosModel : PageModel
    {
        private readonly IRepositorioCultivos repositorioCultivos;
        [BindProperty]

        public Cultivos Cultivos {set; get;}

        public editCultivosModel()
        {
            this.repositorioCultivos = new RepositorioCultivos(new AgroNuevo.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int? CultivosId)
        {
            if (CultivosId.HasValue)
            {
                Cultivos = repositorioCultivos.GetCultivos(CultivosId.Value);
            }
            else 
            {
                Cultivos = new Cultivos();
            }
            if (Cultivos == null)
            {
                return RedirectToPage("./Notfound");                
            }
            else
            {
                return Page();
            }

        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (Cultivos.Id>0)
            {
                Cultivos= repositorioCultivos.UpdateCultivos(Cultivos);
            }
            else
            {
                repositorioCultivos.AddCultivos(Cultivos);
            }
            return Page();
        }        
        
    }
}
