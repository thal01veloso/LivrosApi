using System.Reflection.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using livrariaApi.models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace livrariaApi.context
{
    public class LivroDbContext: DbContext
    {
        public LivroDbContext(DbContextOptions<LivroDbContext> options)
        : base(options)
    {
    }

    public DbSet<Livro> livros { get; set; } = null!;
    public DbSet<Assunto> Assuntos { get; set; } = null!;
    public DbSet<Autor> Autores { get; set; } = null!;
    public DbSet<LivroAutor> LivroAutores { get; set; } = null!;
    public DbSet<LivroAssunto> LivroAssuntos { get; set; } = null!;
    protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<LivroAssunto>()
        .HasKey(la => new { la.LivroId, la.AssuntoId });

    modelBuilder.Entity<LivroAssunto>()
        .HasOne(la => la.Assunto)
        .WithMany(a => a.LivroAssuntos)
        .HasForeignKey(la => la.AssuntoId);

    modelBuilder.Entity<LivroAssunto>()
        .HasOne(la => la.Livro)
        .WithMany(l => l.LivroAssuntos)
        .HasForeignKey(la => la.LivroId);

    modelBuilder.Entity<LivroAutor>()
        .HasKey(la => new { la.LivroId, la.AutorId });

    modelBuilder.Entity<LivroAutor>()
        .HasOne(la => la.Autor)
        .WithMany(a => a.LivroAutores)
        .HasForeignKey(la => la.AutorId);

    modelBuilder.Entity<LivroAutor>()
        .HasOne(la => la.Livro)
        .WithMany(l => l.LivroAutores)
        .HasForeignKey(la => la.LivroId);

    base.OnModelCreating(modelBuilder);
}

    }
}