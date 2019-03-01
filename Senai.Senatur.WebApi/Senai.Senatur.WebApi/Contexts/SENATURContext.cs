using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Senai.Senatur.WebApi.Domains
{
    public partial class SENATURContext : DbContext
    {
        public SENATURContext()
        {
        }

        public SENATURContext(DbContextOptions<SENATURContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Pacotes> Pacotes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=.\\SqlExpress; initial catalog=SENAI_SENATUR_MANHA;user id=sa;pwd=132 ");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pacotes>(entity =>
            {
                entity.HasKey(e => e.Pacoteid);

                entity.ToTable("PACOTES");

                entity.Property(e => e.Pacoteid).HasColumnName("PACOTEID");

                entity.Property(e => e.Ativo)
                    .IsRequired()
                    .HasColumnName("ATIVO")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Cidade)
                    .IsRequired()
                    .HasColumnName("CIDADE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DataIda)
                    .HasColumnName("DATA_IDA")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataVolta)
                    .HasColumnName("DATA_VOLTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnName("DESCRICAO")
                    .HasColumnType("text");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("NOME")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Valor)
                    .HasColumnName("VALOR")
                    .HasColumnType("decimal(18, 0)");
            });
        }
    }
}
