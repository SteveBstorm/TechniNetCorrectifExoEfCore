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

            //builder.HasKey(x => x.Id);
            //builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.HasIndex(nameof(Film.Title)).IsUnique();

            builder.Property(nameof(Film.Title))
                   .HasColumnType("VARCHAR(100)")
                   .IsRequired();

            //builder.Property(nameof(Film.Realisator))
            //       .HasColumnType("VARCHAR(100)")
            //       .IsRequired();

            //builder.Property(nameof(Film.MainActor))
            //       .HasColumnType("VARCHAR(100)")
            //       .IsRequired();

            builder.Property(nameof(Film.Genre))
                   .HasColumnType("VARCHAR(100)")
                   .IsRequired();

            

            builder.HasCheckConstraint("CK_ReleaseYear", "ReleaseYear > 1975");

            builder.HasData(
                new Film
                {
                    Id = 1,
                    Title = "Star Wars : Un nouvel espoir",
                    ReleaseYear = 1977,
                    Genre = "Science-Fiction",
                    RealisatorId = 10
                },
                new Film
                {
                    Id = 2,
                    Title = "Star Wars : L'empire contre-attaque",
                    ReleaseYear = 1980,
                    Genre = "Science-Fiction",
                    RealisatorId = 10
                },
                new Film
                {
                    Id = 3,
                    Title = "Star Wars : Le retour du Jedi",
                    ReleaseYear = 1983,
                    Genre = "Science-Fiction",
                    RealisatorId = 10
                },
                new Film
                {
                    Id = 4,
                    Title = "Hooligans",
                    ReleaseYear = 2005,
                    Genre = "Société",
                    RealisatorId = 8
                },
                new Film
                {
                    Id = 5,
                    Title = "LOTR - La communauté de l'anneau",
                    ReleaseYear = 2001,
                    Genre = "Heroic-Fantasy",
                    RealisatorId = 9
                },
                new Film
                {
                    Id = 6,
                    Title = "LOTR - Les deux tours",
                    ReleaseYear = 2002,
                    Genre = "Heroic-Fantasy",
                    RealisatorId = 9
                },
                new Film
                {
                    Id = 7,
                    Title = "LOTR - Le retour du roi",
                    ReleaseYear = 2003,
                    Genre = "Heroic-Fantasy",
                    RealisatorId = 9
                });
        }
    }
}
