using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLaddersLibrary
{
    public class Board
    {
        private IDictionary<int, int> _snakesAndLadders = new Dictionary<int, int> {
                {2, 38},
                {7, 14},
                {8, 31},
                {15, 26},
                {16, 6},
                {21, 42},
                {28, 84},
                {36, 44},
                {46, 25},
                {49, 11},
                {51, 67},
                {62, 19},
                {64, 60},
                {71, 91},
                {74, 53},
                {78, 98},
                {87, 94},
                {89, 68},
                {92, 88},
                {95, 75},
                {99, 80}
        };

        
        public int checkPosition(int position)
        {
            return _snakesAndLadders.ContainsKey(position) ? _snakesAndLadders[position] : position;
        }
    }
}
