using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day5Demo.Game
{
    internal class BouncyBallGame
    {
        public void StartGame(int left, int top)
        {
            Console.CursorVisible = false;

            Ball b = new Ball(left, top);
            b.Draw();

            bool stopGame = false;

            do
            {
                b.Clear();
                b++;
                b.Draw();

                if (Console.KeyAvailable)
                {
                    var keyInfo = Console.ReadKey();

                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.Escape:
                            stopGame = true;
                            break;
                        case ConsoleKey.Add:
                            //b.IncreaseSpeed(1);
                            //b = b >> 1;
                            b >>= 1;
                            break;
                        case ConsoleKey.Subtract:
                            //b.DeceaseSpeed(1);
                            //b = b << 1;
                            b <<= 1;
                            break;
                        case ConsoleKey.Multiply:
                            //b.IncreaseSpeed(1);
                            //b = b >> 10;
                            b >>= 10;
                            break;
                        case ConsoleKey.Divide:
                            //b.DereaseSpeed(1);
                            //b = b << 10;
                            b <<= 10;
                            break;
                        default:
                            break;
                    }
                }
            } while (!stopGame);

            Console.CursorVisible = true;
        }
    }
}