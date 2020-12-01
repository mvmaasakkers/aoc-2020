using System;
using System.IO;
using System.Linq;

namespace Day01
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = File.ReadAllLines("Input/part1.txt").Select(i => int.Parse(i)).ToList();
            
            Console.Write("Part 1: ");
            Console.WriteLine(new Part1().Calculate(data));

            Console.Write("Part 2: ");
            Console.WriteLine(new Part2().Calculate(data));
        }
    }
}
