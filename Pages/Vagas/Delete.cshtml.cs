using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using conexaoemacao.Data;
using conexaoemacao.Models;

namespace conexaoemacao.Pages.Vagas
{
    public class DeleteModel : PageModel
    {
        private readonly conexaoemacao.Data.ConexaoEmAcaoContext _context;

        public DeleteModel(conexaoemacao.Data.ConexaoEmAcaoContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Vaga Vaga { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Vagas == null)
            {
                return NotFound();
            }

            var vaga = await _context.Vagas.FirstOrDefaultAsync(m => m.Id == id);

            if (vaga == null)
            {
                return NotFound();
            }
            else 
            {
                Vaga = vaga;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Vagas == null)
            {
                return NotFound();
            }
            var vaga = await _context.Vagas.FindAsync(id);

            if (vaga != null)
            {
                Vaga = vaga;
                _context.Vagas.Remove(Vaga);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
