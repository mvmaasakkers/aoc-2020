using System;
using System.Collections.Generic;
using System.Linq;

namespace Day03
{
    public class Day03
    {
        private List<string> _input;

        public Day03(List<string> input)
        {
            _input = input;
        }

        public Int64 ComputePart1()
        {
            var step = new Position(3, 1);
            return _checkSlope(step);
        }

        private Int64 _checkSlope(Position step)
        {
            var treesEncountered = 0;
            
            var currentPosition = new Position(0, 0);
            var maxY = _input.Count - 1;
            
            while (_isValidPosition(currentPosition))
            {
                switch (_getPositionChar(currentPosition))
                {
                    case ".":
                        break;
                    case "#":
                        treesEncountered++;
                        break;
                }
                currentPosition.Y += step.Y;
                currentPosition.X += step.X;
                if (currentPosition.Y < maxY && _input[currentPosition.Y].Length <= currentPosition.X)
                {
                    currentPosition.X -= _input[currentPosition.Y].Length;
                }
            }

            return treesEncountered;
        }

        private bool _isValidPosition(Position pos)
        {
            var maxY = _input.Count - 1;
            var maxX = _input[0].Length -1 ;

            if (pos.Y > maxY)
            {
                return false;
            }

            if (pos.X > maxX)
            {
                return false;
            }

            return true;
        }

        private string _getPositionChar(Position pos)
        {
            return _input[pos.Y][pos.X].ToString();
        }

        public Int64 ComputePart2()
        {
            var steps = new List<Position>
            {
                new Position(1, 1),
                new Position(3, 1),
                new Position(5, 1),
                new Position(7, 1),
                new Position(1, 2),
            };

            List<Int64> slopes = new List<Int64>();
            foreach (var step in steps)
            {
                slopes.Add(_checkSlope(step));
            }
            
            return slopes.Aggregate((total, next) => total * next);
        }
    }

    public class Position
    {
        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }
    }
}