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
    public class IndexModel : PageModel
    {
        private readonly conexaoemacao.Data.ConexaoEmAcaoContext _context;

        public IndexModel(conexaoemacao.Data.ConexaoEmAcaoContext context)
        {
            _context = context;
        }

        public IList<Voluntario> Voluntario { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Voluntarios != null)
            {
                Voluntario = await _context.Voluntarios.ToListAsync();
            }
        }
    }
}
