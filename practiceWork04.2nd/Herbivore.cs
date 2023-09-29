using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceWork04._2nd
{
    class Herbivore : Animal
    {
        public override string Type => "Травоядное";

        public override double CalculateFoodQuantity()
        {
            return 1.0; // Пример расчета количества пищи для травоядного
        }
    }
}
