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
    public class EditManoDeObraModel : PageModel
    {
        private readonly IRepositorioManoDeObra repositorioManoDeObra;
        [BindProperty]

        public ManoDeObra ManoDeObra {set; get;}

        public EditManoDeObraModel()
        {
            this.repositorioManoDeObra = new RepositorioManoDeObra(new AgroNuevo.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int? ManoDeObraId)
        {
            if (ManoDeObraId.HasValue)
            {
                ManoDeObra = repositorioManoDeObra.GetManoDeObra(ManoDeObraId.Value);
            }
            else 
            {
                ManoDeObra = new ManoDeObra();
            }
            if (ManoDeObra == null)
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
            if (ManoDeObra.Id>0)
            {
                ManoDeObra= repositorioManoDeObra.UpdateManoDeObra(ManoDeObra);
            }
            else
            {
                repositorioManoDeObra.AddManoDeObra(ManoDeObra);
            }
            return Page();
        }        
        
    }
}
