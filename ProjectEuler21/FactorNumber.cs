using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler21
{
    internal class FactorNumber
    {
        public int Number { get; set; } = 0;
        public List<int> Divisors { get; set; } = new List<int>();
        public int SumOfDivisors { get; set; } = 0;
        public bool IsAmicable { get; set; } = false;
        public FactorNumber? AmicablePair { get; set; } = null;

        public void GetDivisors()
        {
            for (int i = 1; i <= Number / 2; i++)
            {
                if (Number % i == 0)
                {
                    Divisors.Add(i);
                }
            }
            SumOfDivisors = Divisors.Sum();
            FactorNumber possibleAmicablePair = new FactorNumber();
            possibleAmicablePair.Number = SumOfDivisors;
            for (int i = 1; i <= possibleAmicablePair.Number / 2; i++)
            {
                if (possibleAmicablePair.Number % i == 0)
                {
                    possibleAmicablePair.Divisors.Add(i);
                }
            }
            possibleAmicablePair.SumOfDivisors = possibleAmicablePair.Divisors.Sum();
            if ((Number == possibleAmicablePair.SumOfDivisors && possibleAmicablePair.Number == SumOfDivisors) && Number != possibleAmicablePair.Number)
            {
                AmicablePair = possibleAmicablePair;
                IsAmicable = true;
            }
        }

        public void reset()
        {
            Number = 0;
            Divisors.Clear();
            SumOfDivisors = 0;
            IsAmicable = false;
            AmicablePair = null;
        }
        
        public FactorNumber()
        {

        }
    }
}
