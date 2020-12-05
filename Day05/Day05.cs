using System;
using System.Collections.Generic;
using System.Linq;

namespace Day05
{
    public class Day05
    {
        private List<string> _input;


        public Day05(List<string> input)
        {
            _input = input;
        }

        public int ComputePart1()
        {
            return _input.Select(t => new Input(t)).Select(t => (t.Row * 8) + t.Column).Max();
        }

        public int ComputePart2()
        {
            var ids = _input.Select(t => new Input(t)).Select(t => (t.Row * 8) + t.Column).OrderBy(t => t).ToList();
            for (int i = 0; i < ids.Count; i++)
            {
                if (ids[i + 1] - ids[i] != 1)
                {
                    return ids[i]+1;
                }
            }
            return 0;
        }
    }
}