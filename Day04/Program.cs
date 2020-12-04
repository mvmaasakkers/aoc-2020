using System;
using System.IO;
using System.Linq;

namespace Day04
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = File.ReadAllText("Input/part1.txt")
                .Split(new string[] {"\r\n\r\n", "\n\n"}, StringSplitOptions.None)
                .Select(t => t).ToList();
            var day04 = new Day04(data);
            
            Console.Write("Part 1: ");
            Console.WriteLine(day04.ComputePart1());
            Console.Write("Part 2: ");
            Console.WriteLine(day04.ComputePart2());
        }
    }
}