using System.Collections.Generic;
using System.IO;

namespace Day01
{
    public class Part1
    {
        public int Calculate(List<int> numbers)
        {
            foreach (var numberLeft in numbers)
            {
                foreach (var numberRight in numbers)
                {
                    if (numberLeft + numberRight == 2020)
                    {
                        return numberLeft * numberRight;
                    }
                }
            }

            return 0;
        }
    }
}