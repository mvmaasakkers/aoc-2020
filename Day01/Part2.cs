using System.Collections.Generic;
using System.IO;

namespace Day01
{
    public class Part2
    {
        public int Calculate(List<int> numbers)
        {
            foreach (var numberLeft in numbers)
            {
                foreach (var numberMiddle in numbers)
                {
                    foreach (var numberRight in numbers)
                    {
                        if (numberLeft + numberMiddle + numberRight == 2020)
                        {
                            return numberLeft * numberMiddle * numberRight;
                        }
                    }
                }
            }

            return 0;
        }
    }
}