using Microsoft.EntityFrameworkCore;
using SmartSchool.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.API.Data
{
    public class SmartContext : DbContext
    {
        //passando as configurações do connection string

        public SmartContext(DbContextOptions<SmartContext> options) : base(options)
        {

        }
        public DbSet<Aluno> Alunos  { get; set; }

        public DbSet<Professor> Professores { get; set; }

        public DbSet<Disciplina> Disciplinas { get; set; }

        public DbSet<AlunoDisciplina> AlunosDisciplinas { get; set; }

        //para fazer o relacionamento

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AlunoDisciplina>()
                 .HasKey(AD => new { AD.AlunoId, AD.DisciplinaId });
        }
    }
}
