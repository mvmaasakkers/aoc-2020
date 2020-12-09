using System;
using System.IO;
using System.Linq;

namespace Day09
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = File.ReadAllText("Input/part1.txt")
                .Split(new string[] {"\r\n", "\n"}, StringSplitOptions.RemoveEmptyEntries)
                .Select(t => long.Parse(t.Trim())).ToList();
            var today = new Day09(data);
            
            Console.Write("Part 1: ");
            var p1 = today.ComputePart1(25);
            Console.WriteLine(p1);
            Console.Write("Part 2: ");
            Console.WriteLine(today.ComputePart2(p1));
        }
    }
}