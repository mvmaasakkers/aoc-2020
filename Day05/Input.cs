using System;

namespace Day05
{
    public class Input
    {
        public Input(string raw)
        {
            Row = Convert.ToInt32(raw.Substring(0, 7).Replace('B', '1').Replace('F', '0'), 2);
            Column = Convert.ToInt32(raw.Substring(7, 3).Replace('R', '1').Replace('L', '0'), 2);
        }
        public int Row { get; set; }
        
        public int Column { get; set; }
    }
}