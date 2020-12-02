using System.Text.RegularExpressions;

namespace Day02
{
    public class Input
    {

        public Input(GroupCollection groups)
        {
            Min = int.Parse(groups["min"].Value);
            Max = int.Parse(groups["max"].Value);
            Char = char.Parse(groups["char"].Value);
            Password = groups["password"].Value;
        }
        
        public int Min { get; set; }
        public int Max { get; set; }
        public char Char { get; set; }
        public string Password { get; set; }
    }
}