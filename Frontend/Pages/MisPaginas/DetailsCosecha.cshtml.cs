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
    public class DetailsCosechaModel : PageModel
    {
        private readonly IRepositorioCosecha RepositorioCosecha;
        
        public Cosecha Cosecha {set; get;}

        public DetailsCosechaModel()
        {
            this.RepositorioCosecha = new RepositorioCosecha(new AgroNuevo.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int CosechaId)
        {
            Cosecha = RepositorioCosecha.GetCosecha(CosechaId);
            if(Cosecha==null)
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
