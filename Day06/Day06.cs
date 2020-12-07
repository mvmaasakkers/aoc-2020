using System;
using System.Collections.Generic;
using System.Linq;

namespace Day06
{
    public class Day06
    {
        private List<string> _input;


        public Day06(List<string> input)
        {
            _input = input;
        }

        public int ComputePart1()
        {
            return _input.Select(t => t.Replace("\r\n", string.Empty).Replace("\n", string.Empty).Distinct())
                .Sum(t => t.Count());
        }

        public int ComputePart2()
        {
            return _input.Select(g => g.Split("\n", StringSplitOptions.RemoveEmptyEntries)
                    .Select(p => p.ToCharArray())
                    .Aggregate<IEnumerable<char>>((prev, next) => prev.Intersect(next)).ToList())
                .Sum(t => t.Count);
            ;
        }
    }
}