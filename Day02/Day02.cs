using System;
using System.Collections.Generic;
using System.Linq;

namespace Day02
{
    public class Day02
    {
        private List<Input> _input;

        public Day02(List<Input> input)
        {
            _input = input;
        }

        public int ComputePart1()
        {
            return _input.Select(t => t).Where(t =>
                t.Password.Count(c => c == t.Char) >= t.Min &&
                t.Password.Count(c => c == t.Char) <= t.Max).ToList().Count;
        }

        public int ComputePart2()
        {
            return _input.Select(t => t)
                .Where(c => c.Password[c.Min - 1] == c.Char ^ c.Password[c.Max - 1] == c.Char).ToList().Count;
        }
    }
}