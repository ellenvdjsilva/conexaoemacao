using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using conexaoemacao.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace conexaoemacao.Data
{
    public class ConexaoEmAcaoContext : IdentityDbContext<AppUser>
    {
        public ConexaoEmAcaoContext(DbContextOptions<ConexaoEmAcaoContext> options): base(options){ }
        public DbSet<Vaga>? Vagas { get; set; }
        public  DbSet<Voluntario>? Voluntarios { get; set;}
        public DbSet<Ong>? Ongs { get; set; }
        public DbSet<Candidatura>? Candidaturas { get; set;}
        public DbSet<Endereco>? Enderecos { get; set; }


    }
}
