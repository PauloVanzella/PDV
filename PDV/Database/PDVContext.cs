using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PDV.Models
{
    public partial class PDVContext : DbContext
    {
        public PDVContext()
        {
        }

        public PDVContext(DbContextOptions<PDVContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Produto> Produto { get; set; }
        public virtual DbSet<Fornecedor> Fornecedor { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Configuracao> Configuracao { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Data Source=DESKTOP-NHQ7A3Q\\SQLEXPRESS;Initial Catalog=PDV;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .HasColumnName("ID")
                    .IsFixedLength();

                entity.Property(e => e.Senha)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Usuario");
            });
            modelBuilder.Entity<Produto>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id_Produto)
                    .HasMaxLength(10)
                    .HasColumnName("ID")
                    .IsFixedLength();

                entity.Property(e => e.Descricao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Descricao");

                entity.Property(e => e.Preco)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Preco");

                entity.Property(e => e.Quantidade)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Quantidade");

                entity.Property(e => e.Vencimento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Vencimento");

                entity.Property(e => e.Fornecedor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fornecedor");
            });
            modelBuilder.Entity<Fornecedor>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id_Fornecedor)
                    .HasMaxLength(10)
                    .HasColumnName("ID")
                    .IsFixedLength();

                entity.Property(e => e.RazaoSocial)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Descricao");

                entity.Property(e => e.CNPJ)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Preco");

            });
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id_Cliente)
                    .HasMaxLength(10)
                    .HasColumnName("Id_Cliente")
                    .IsFixedLength();

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nome");

                entity.Property(e => e.CPF)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CPF");

                entity.Property(e => e.DataNascimento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DataNascimento");

            });
            modelBuilder.Entity<Configuracao>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id_Configuracao)
                    .HasMaxLength(10)
                    .HasColumnName("Id_Configuracao")
                    .IsFixedLength();

                entity.Property(e => e.RazaoSocial)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RazaoSocial");

                entity.Property(e => e.CNPJ)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CNPJ");

                entity.Property(e => e.CPF)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CPF");

                entity.Property(e => e.InscricaoEstadual)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("InscricaoEstadual");

                entity.Property(e => e.Telefone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Telefone");
                
                entity.Property(e => e.CEP)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CEP");
                
                entity.Property(e => e.Endereco)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Endereco");
                
                entity.Property(e => e.CertificadoDigital)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CertificadoDigital");

                entity.Property(e => e.TipoCertificado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TipoCertificado");
                
                entity.Property(e => e.ManterCertificado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ManterCertificado");
                
                entity.Property(e => e.NumeroDeSerie)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NumeroDeSerie");
                
                entity.Property(e => e.PathCertificado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PathCertificado");
                
                entity.Property(e => e.SenhaCertificado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SenhaCertificado");
                
                entity.Property(e => e.FormaEmissao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FormaEmissao");

            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
