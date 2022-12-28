using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackandLadder
{
    public class SnakeLadder
    {
        public static void Gamestart()
        {
            int startposition = 0;
            Random random = new Random();
            int dice = random.Next(1, 6);
            int move = random.Next(3);
            const int NoPlay = 0;
            const int snake = 1;
            const int ladder = 2;
            switch (move)
            {
                case NoPlay:
                    break;
                case snake:
                    startposition = dice;
                    break;
                case ladder:
                    startposition = startposition - dice;
                    break;
            }
            Console.WriteLine("dice::{0},option::{1},position::{2}", dice, move, startposition);
        }
    }
}
