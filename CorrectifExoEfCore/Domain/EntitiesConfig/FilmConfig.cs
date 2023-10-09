using CorrectifExoEfCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectifExoEfCore.Domain.EntitiesConfig
{
    public class FilmConfig : IEntityTypeConfiguration<Film>
    {
        public void Configure(EntityTypeBuilder<Film> builder)
        {
            builder.ToTable("Film");

            builder.HasIndex(nameof(Film.Title)).IsUnique();

            builder.Property(nameof(Film.Title))
                   .HasColumnType("VARCHAR(100)")
                   .IsRequired();

            builder.Property(nameof(Film.Realisator))
                   .HasColumnType("VARCHAR(100)")
                   .IsRequired();

            builder.Property(nameof(Film.MainActor))
                   .HasColumnType("VARCHAR(100)")
                   .IsRequired();

            builder.Property(nameof(Film.Genre))
                   .HasColumnType("VARCHAR(100)")
                   .IsRequired();

            builder.HasCheckConstraint("CK_ReleaseYear", "ReleaseYear > 1975");
        }
    }
}
