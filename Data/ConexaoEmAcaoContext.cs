﻿using Microsoft.EntityFrameworkCore;
using conexaoemacao.Models;


namespace conexaoemacao.Data
{
    public class ConexaoEmAcaoContext : DbContext
    {
        public ConexaoEmAcaoContext(DbContextOptions<ConexaoEmAcaoContext> options): base(options){ }
        public DbSet<Vaga>? Vagas { get; set; }
        public  DbSet<Voluntario>? Voluntarios { get; set;}
        public DbSet<Ong>? Ongs { get; set; }
        public DbSet<Candidatura>? Candidaturas { get; set;}
        public DbSet<Endereco>? Enderecos { get; set; }


    }
}
