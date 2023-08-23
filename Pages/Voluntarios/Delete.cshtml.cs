using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using conexaoemacao.Data;
using conexaoemacao.Models;

namespace conexaoemacao.Pages.Voluntarios
{
    public class DeleteModel : PageModel
    {
        private readonly conexaoemacao.Data.ConexaoEmAcaoContext _context;

        public DeleteModel(conexaoemacao.Data.ConexaoEmAcaoContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Voluntario Voluntario { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Voluntarios == null)
            {
                return NotFound();
            }

            var voluntario = await _context.Voluntarios.FirstOrDefaultAsync(m => m.Id == id);

            if (voluntario == null)
            {
                return NotFound();
            }
            else 
            {
                Voluntario = voluntario;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Voluntarios == null)
            {
                return NotFound();
            }
            var voluntario = await _context.Voluntarios.FindAsync(id);

            if (voluntario != null)
            {
                Voluntario = voluntario;
                _context.Voluntarios.Remove(Voluntario);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
