using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using conexaoemacao.Data;
using conexaoemacao.Models;

namespace conexaoemacao.Pages.Voluntarios
{
    public class CreateModel : PageModel
    {
        private readonly conexaoemacao.Data.ConexaoEmAcaoContext _context;

        public CreateModel(conexaoemacao.Data.ConexaoEmAcaoContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Voluntario Voluntario { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Voluntarios == null || Voluntario == null)
            {
                return Page();
            }

            _context.Voluntarios.Add(Voluntario);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
