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
    public class DetailsModel : PageModel
    {
        private readonly conexaoemacao.Data.ConexaoEmAcaoContext _context;

        public DetailsModel(conexaoemacao.Data.ConexaoEmAcaoContext context)
        {
            _context = context;
        }

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
    }
}
