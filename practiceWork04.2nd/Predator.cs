using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceWork04._2nd
{
    class Predator : Animal
    {
        public override string Type => "Хищник";

        public override double CalculateFoodQuantity()
        {
            return 2.0; // Пример расчета количества пищи для хищника
        }
    }
}
