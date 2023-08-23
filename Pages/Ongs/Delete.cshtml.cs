using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using conexaoemacao.Data;
using conexaoemacao.Models;

namespace conexaoemacao.Pages.Ongs
{
    public class DeleteModel : PageModel
    {
        private readonly conexaoemacao.Data.ConexaoEmAcaoContext _context;

        public DeleteModel(conexaoemacao.Data.ConexaoEmAcaoContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Ong Ong { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Ongs == null)
            {
                return NotFound();
            }

            var ong = await _context.Ongs.FirstOrDefaultAsync(m => m.Id == id);

            if (ong == null)
            {
                return NotFound();
            }
            else 
            {
                Ong = ong;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Ongs == null)
            {
                return NotFound();
            }
            var ong = await _context.Ongs.FindAsync(id);

            if (ong != null)
            {
                Ong = ong;
                _context.Ongs.Remove(Ong);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
