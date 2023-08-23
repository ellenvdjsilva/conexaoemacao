using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using conexaoemacao.Data;
using conexaoemacao.Models;

namespace conexaoemacao.Pages.Candidaturas
{
    public class EditModel : PageModel
    {
        private readonly conexaoemacao.Data.ConexaoEmAcaoContext _context;

        public EditModel(conexaoemacao.Data.ConexaoEmAcaoContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Candidatura Candidatura { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Candidaturas == null)
            {
                return NotFound();
            }

            var candidatura =  await _context.Candidaturas.FirstOrDefaultAsync(m => m.Id == id);
            if (candidatura == null)
            {
                return NotFound();
            }
            Candidatura = candidatura;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Candidatura).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CandidaturaExists(Candidatura.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CandidaturaExists(int id)
        {
          return (_context.Candidaturas?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
