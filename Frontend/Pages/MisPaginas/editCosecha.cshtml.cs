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
    public class editCosechaModel : PageModel
    {
        private readonly IRepositorioCosecha repositorioCosecha;
        [BindProperty]

        public Cosecha Cosecha {set; get;}

        public editCosechaModel()
        {
            this.repositorioCosecha = new RepositorioCosecha(new AgroNuevo.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int? CosechaId)
        {
            if (CosechaId.HasValue)
            {
                Cosecha = repositorioCosecha.GetCosecha(CosechaId.Value);
            }
            else 
            {
                Cosecha = new Cosecha();
            }
            if (Cosecha == null)
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
            if (Cosecha.Id>0)
            {
                Cosecha= repositorioCosecha.UpdateCosecha(Cosecha);
            }
            else
            {
                repositorioCosecha.AddCosecha(Cosecha);
            }
            return Page();
        }        
        
    }
}
