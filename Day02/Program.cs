using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Day02
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex r = new Regex(@"(?<min>[0-9]*)\-(?<max>[0-9]*) (?<char>[a-zA-Z]*): (?<password>[0-9a-zA-Z]*)");
            var data = File.ReadAllLines("Input/part1.txt").Select(s => new Input(r.Match(s).Groups)).ToList();

            var day02 = new Day02(data);
            
            Console.Write("Part 1: ");
            Console.WriteLine(day02.ComputePart1());
            Console.Write("Part 2: ");
            Console.WriteLine(day02.ComputePart2());
        }
    }
}