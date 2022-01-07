using System;
using System.Threading;

namespace Week2Day5Demo.Game
{
    internal class Ball
    {
        private static int xFactor = 3;
        private static int yFactor = 1;
        private char BallCharacter = (char)0x7F;
        private int _speedBrake;
        public Point Position { get; set; }

        public Ball(int x, int y)
        {
            Position = new Point(x, y);
            _speedBrake = 10;
        }

        //public void IncreaseSpeed(int value)
        public static Ball operator >>(Ball b, int value)
        {
            if (b._speedBrake - value <= 0)
                b._speedBrake = 0;
            else
                b._speedBrake -= value;
            return b;
        }

        //public void DecreaseSpeed(int value)
        public static Ball operator <<(Ball b, int value)
        {
            b._speedBrake += value;
            return b;
        }

        //public void MoveBall()
        public static Ball operator ++(Ball b)
        {
            int newX = b.Position.X + xFactor;
            int newY = b.Position.Y + yFactor;

            if (newX < 0 || newX > Console.WindowWidth)
                xFactor = -xFactor;

            if (newY < 0 || newY > Console.WindowHeight)
                yFactor = -yFactor;

            b.Position.X += xFactor;
            b.Position.Y += yFactor;

            return b;
        }

        public void Draw()
        {
            Console.SetCursorPosition(Position.X, Position.Y);
            Console.Write(BallCharacter);
            Console.SetCursorPosition(0, 0);
            Console.Write($"x:{Position.X:##} y:{Position.Y:##} speedBrake: {_speedBrake:###}               ");
            Thread.Sleep(_speedBrake);
        }

        internal void Clear()
        {
            Console.SetCursorPosition(Position.X, Position.Y);
            Console.Write(' ');
        }
    }
}