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
    public class EditarTecnicoModel : PageModel
    {
        private readonly IRepositorioTecnico repositorioTecnico;
        [BindProperty]

        public Tecnico Tecnico {set; get;}

        public EditarTecnicoModel()
        {
            this.repositorioTecnico = new RepositorioTecnico(new AgroNuevo.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int? TecnicoId)
        {
            if (TecnicoId.HasValue)
            {
                Tecnico = repositorioTecnico.GetTecnico(TecnicoId.Value);
            }
            else 
            {
                Tecnico = new Tecnico();
            }
            if (Tecnico == null)
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
            if (Tecnico.Id>0)
            {
                Tecnico= repositorioTecnico.UpdateTecnico(Tecnico);
            }
            else
            {
                repositorioTecnico.AddTecnico(Tecnico);
            }
            return Page();
        }        
        
    }
}
