using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLaddersLibrary
{
    public class Player
    {
        readonly Random _random = new Random();

        public string Name { get; set; }
        public Token Token { get; set; } = new Token();

        public int Roll()
        {
            return _random.Next(1, 7);
        }

        public void Move(int number)
        {
            this.Token.Move(number);
        }

        public bool Wins => Token.Position == 100;
    }
}
