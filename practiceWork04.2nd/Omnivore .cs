using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceWork04._2nd
{
    class Omnivore:Animal
    {
        public override string Type => "Всеядное";

        public override double CalculateFoodQuantity()
        {
            return 1.5; //расчет кол-ва пищи для Omnivore
        }
    }
}
