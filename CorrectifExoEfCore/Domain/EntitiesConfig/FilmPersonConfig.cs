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
    public class FilmPersonConfig : IEntityTypeConfiguration<FilmPerson>
    {
        public void Configure(EntityTypeBuilder<FilmPerson> builder)
        {
            builder.HasKey(nameof(FilmPerson.PersonId), nameof(FilmPerson.FilmId));

            builder.HasOne(x => x.Person)
                   .WithMany(x => x.AsActor)
                   .HasForeignKey(x => x.PersonId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.Film)
                   .WithMany(x => x.Casting)
                   .HasForeignKey(x => x.FilmId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasData
                (
                    new FilmPerson { FilmId = 1, PersonId = 3 },
                    new FilmPerson { FilmId = 1, PersonId = 4 },
                    new FilmPerson { FilmId = 1, PersonId = 5 },
                    new FilmPerson { FilmId = 2, PersonId = 3 },
                    new FilmPerson { FilmId = 2, PersonId = 4 },
                    new FilmPerson { FilmId = 2, PersonId = 5 },
                    new FilmPerson { FilmId = 3, PersonId = 3 },
                    new FilmPerson { FilmId = 3, PersonId = 4 },
                    new FilmPerson { FilmId = 3, PersonId = 5 },
                    new FilmPerson { FilmId = 4, PersonId = 1 },
                    new FilmPerson { FilmId = 4, PersonId = 2 },
                    new FilmPerson { FilmId = 5, PersonId = 1 },
                    new FilmPerson { FilmId = 5, PersonId = 6 },
                    new FilmPerson { FilmId = 5, PersonId = 7 },
                    new FilmPerson { FilmId = 6, PersonId = 1 },
                    new FilmPerson { FilmId = 6, PersonId = 6 },
                    new FilmPerson { FilmId = 6, PersonId = 7 },
                    new FilmPerson { FilmId = 7, PersonId = 1 },
                    new FilmPerson { FilmId = 7, PersonId = 6 },
                    new FilmPerson { FilmId = 7, PersonId = 7 }
                );
        }
    }
}
