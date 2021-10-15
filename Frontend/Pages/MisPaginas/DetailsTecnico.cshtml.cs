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
    public class DetailsTecnicoModel : PageModel
    {
        private readonly IRepositorioTecnico RepositorioTecnico;
        
        public Tecnico Tecnico {set; get;}

        public DetailsTecnicoModel()
        {
            this.RepositorioTecnico = new RepositorioTecnico(new AgroNuevo.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int TecnicoId)
        {
            Tecnico = RepositorioTecnico.GetTecnico(TecnicoId);
            if(Tecnico==null)
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
