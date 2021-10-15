using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio.Entidades;
using AgroNuevo.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Authorization;

namespace AgroNuevo.App.Frontend.Pages
{
    public class DetailsManoDeObraModel : PageModel
    {
        private readonly IRepositorioManoDeObra RepositorioManoDeObra;
        
        public ManoDeObra ManoDeObra {set; get;}

        public DetailsManoDeObraModel()
        {
            this.RepositorioManoDeObra = new RepositorioManoDeObra(new AgroNuevo.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int ManoDeObraId)
        {
            ManoDeObra = RepositorioManoDeObra.GetManoDeObra(ManoDeObraId);
            if(ManoDeObra==null)
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
