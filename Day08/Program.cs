using System;
using System.IO;
using System.Linq;

namespace Day08
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = File.ReadAllText("Input/part1.txt")
                .Split(new string[] {"\r\n", "\n"}, StringSplitOptions.RemoveEmptyEntries)
                .Select(t => t.Trim()).ToList();
            var today = new Day08(data);
            
            Console.Write("Part 1: ");
            Console.WriteLine(today.ComputePart1());
            Console.Write("Part 2: ");
            Console.WriteLine(today.ComputePart2());
        }
    }
}