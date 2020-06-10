using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TestAutismo.Models;
using TestAutismo.Services;

namespace TestAutismoUI.Pages.Containers
{
    public class ModificarNinioModel : PageModel
    {
        public IRepositoryNinios repository;
        [BindProperty]
        public Ninio Ninio { get; private set; }
        public ModificarNinioModel(IRepositoryNinios repository)
        {
            this.repository = repository;
        }
        public void OnGet(int id)
        {
            Ninio = repository.GetNinio(id);

        }
        public IActionResult OnPost(Ninio nini)
        {
            Ninio = repository.UpdateNinio(nini);
            return Redirect("/Containers/Ninios?Id="+ 1);
            
        }
    }
}
