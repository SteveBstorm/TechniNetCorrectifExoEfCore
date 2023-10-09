using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectifExoEfCore.Entities
{
    public class Film
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public string Realisator { get; set; }
        public string MainActor { get; set; }
        public string Genre { get; set; }
    }
}
