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
    public class DetailsModel : PageModel
    {
        private readonly conexaoemacao.Data.ConexaoEmAcaoContext _context;

        public DetailsModel(conexaoemacao.Data.ConexaoEmAcaoContext context)
        {
            _context = context;
        }

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
    }
}
