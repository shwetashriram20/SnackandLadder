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
            int startPosition = 0;
           
            Random random = new Random();

            int dice = random.Next(1, 6);


            Console.WriteLine("Snake and Ladder single player  : " + startPosition);
            

            Console.WriteLine("The Players dice number is  1 to 6 is : " + dice);

        }
    }
}
    

