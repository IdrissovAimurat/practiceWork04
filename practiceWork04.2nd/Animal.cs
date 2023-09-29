using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceWork04._2nd
{
    abstract class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public abstract string Type { get; }
        public abstract double CalculateFoodQuantity();
    }
}
