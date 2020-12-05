using System;
using System.IO;
using System.Linq;

namespace Day05
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = File.ReadAllText("Input/part1.txt")
                .Split(new string[] {"\r\n", "\n"}, StringSplitOptions.None)
                .Select(t => t).ToList();
            var day05 = new Day05(data);
            
            Console.Write("Part 1: ");
            Console.WriteLine(day05.ComputePart1());
            Console.Write("Part 2: ");
            Console.WriteLine(day05.ComputePart2());
        }
    }
}
