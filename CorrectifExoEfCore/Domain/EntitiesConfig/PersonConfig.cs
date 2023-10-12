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
    public class PersonConfig : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasData
                (
                    new Person
                    {
                        Id = 1,
                        Firstname = "Elijah",
                        Lastname = "Wood"
                    },
                    new Person
                    {
                        Id = 2,
                        Firstname = "Charlie",
                        Lastname = "Hunnam"
                    },
                    new Person
                    {
                        Id = 3,
                        Firstname = "Harisson",
                        Lastname = "Ford"
                    },
                    new Person
                    {
                        Id = 4,
                        Firstname = "Mark",
                        Lastname = "Hammil"
                    },
                    new Person
                    {
                        Id = 5,
                        Firstname = "Carrie",
                        Lastname = "Fisher"
                    },
                    new Person
                    {
                        Id = 6,
                        Firstname = "Vigo",
                        Lastname = "Mortensen"
                    },
                    new Person
                    {
                        Id = 7,
                        Firstname = "Orlando",
                        Lastname = "Bloom"
                    },
                    new Person
                    {
                        Id = 8,
                        Firstname = "Lexi",
                        Lastname = "Alexander"
                    },
                    new Person
                    {
                        Id = 9,
                        Firstname = "Peter",
                        Lastname = "Jackson"
                    },
                    new Person
                    {
                        Id = 10,
                        Firstname = "Georges",
                        Lastname = "Lucas"
                    }
                );
        }
    }
}
