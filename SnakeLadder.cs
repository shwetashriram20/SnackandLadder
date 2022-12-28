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
            int position = 0;
            int currentPosition = 0;
            int endPosition = 100;
            int startposition = 0;
            const int NoPlay = 0;
            const int ladder = 1;
            const int snake = 2;
            int temp = 0;
           
            while (currentPosition < endPosition)
            {
                Random random = new Random();
                int die = random.Next(1, 6); 
                int move = random.Next(3);   
                switch (move)
                {
                    case NoPlay:
                        position = 0;
                        break;
                    case ladder:
                        position = die;
                        break;
                    case snake:
                        if (currentPosition > 0)
                        {
                            position = 0;
                            currentPosition = currentPosition - die;
                            if (currentPosition < 0)
                            {
                                currentPosition = startposition;
                            }
                        }
                        else
                        {
                            currentPosition = startposition;
                        }
                        break;
                }

                currentPosition += (position);
                if (currentPosition <= 100)
                {
                    Console.WriteLine("die::{0}option::{1} position::{2}", die, move, currentPosition);
                    temp = currentPosition;
                }


                if (endPosition < currentPosition)
                {
                    while (temp < endPosition)
                    {
                        Random random1 = new Random();
                        int die1 = random.Next(1, 6); 
                        int move1 = random.Next(3);   
                        switch (move1)
                        {
                            case NoPlay:
                                position = 0;
                                break;
                            case ladder:
                                if (temp + die1 == endPosition)
                                {
                                    position = die1;
                                }
                                else
                                {
                                    position = 0;
                                }
                                break;
                            case snake:
                                position = 0;
                                break;
                        }
                        temp += (position);
                        if (temp == endPosition)
                        {
                            Console.WriteLine("die::{0} option::{1} position::{2}", die1, move1, temp);
                        }
                    }

                }
            }
        }


    }
}

                       