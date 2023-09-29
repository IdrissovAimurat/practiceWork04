using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceWork04_3rd
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public override string ToString()
        {
            return $"{Title} by {Author}, {Year}";
        }
    }
}
