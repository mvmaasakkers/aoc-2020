using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Day03
{
    class Program
    {
        static void Main(string[] args)
        {

            var data = File.ReadAllLines("Input/part1.txt").Select(t => t).ToList();
            var day03 = new Day03(data);
            
            Console.Write("Part 1: ");
            Console.WriteLine(day03.ComputePart1());
            Console.Write("Part 2: ");
            Console.WriteLine(day03.ComputePart2());
        }

        
    }
}
