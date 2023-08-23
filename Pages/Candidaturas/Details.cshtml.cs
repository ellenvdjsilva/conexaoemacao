using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using conexaoemacao.Data;
using conexaoemacao.Models;

namespace conexaoemacao.Pages.Candidaturas
{
    public class DetailsModel : PageModel
    {
        private readonly conexaoemacao.Data.ConexaoEmAcaoContext _context;

        public DetailsModel(conexaoemacao.Data.ConexaoEmAcaoContext context)
        {
            _context = context;
        }

      public Candidatura Candidatura { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Candidaturas == null)
            {
                return NotFound();
            }

            var candidatura = await _context.Candidaturas.FirstOrDefaultAsync(m => m.Id == id);
            if (candidatura == null)
            {
                return NotFound();
            }
            else 
            {
                Candidatura = candidatura;
            }
            return Page();
        }
    }
}
