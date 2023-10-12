using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectifExoEfCore.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string Lastname { get; set; }

        public string Firstname { get; set; }

        public List<Film> AsReal { get; set; }

        public List<FilmPerson> AsActor { get; set; }
    }
}
