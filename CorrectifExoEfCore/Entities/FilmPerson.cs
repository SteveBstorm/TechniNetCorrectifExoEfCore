using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectifExoEfCore.Entities
{
    public class FilmPerson
    {
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public int FilmId { get; set; }
        public Film Film { get; set; }


    }
}
