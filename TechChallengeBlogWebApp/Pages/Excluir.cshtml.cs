using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TechChallengeBlogWebApp.Models;
using TechChallengeBlogWebApp.Services;

namespace TechChallengeBlogWebApp.Pages
{
    public class ExcluirModel : PageModel
    {
        private readonly BlogService _service;

        public ExcluirModel(BlogService service)
        {
            _service = service;
        }



        [BindProperty]
        public NoticiaModel NoticiaModel { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
                return NotFound();
            else
            {
                NoticiaModel = await _service.PesquisarNoticiaPorIdAsync(id.Value);
                if (NoticiaModel != null && NoticiaModel.Id > 0)
                    return Page();
                else
                    return NotFound();
            }
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
                return NotFound();

            NoticiaModel = await _service.PesquisarNoticiaPorIdAsync(id.Value);

            if (NoticiaModel != null)
                await _service.ExcluirAsync(id.Value);

            return RedirectToPage("./Index");
        }
    }
}
