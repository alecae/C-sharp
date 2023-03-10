using System;
using System.Collections.Generic;
using System.Diagnostics;
using static System.Console;

namespace Snake
{
    class Program
    {
        static void Main()
        {
            WindowHeight = 20;
            WindowWidth = 40;

            var rand = new Random();

            var score = 5;

            var tete = new Pixel(WindowWidth / 2, WindowHeight / 2, ConsoleColor.Red);
            var pomme = new Pixel(rand.Next(1, WindowWidth - 2), rand.Next(1, WindowHeight - 2), ConsoleColor.Blue);

            var corps = new List<Pixel>();

            var currentMovement = Direction.Right;

            var gameover = false;

            while (true)
            {
                Clear();

                gameover |= (tete.XPos == WindowWidth - 1 || tete.XPos == 0 || tete.YPos == WindowHeight - 1 || tete.YPos == 0);

                Border();

                if (pomme.XPos == tete.XPos && pomme.YPos == tete.YPos)
                {
                    score++;
                    pomme = new Pixel(rand.Next(1, WindowWidth - 2), rand.Next(1, WindowHeight - 2), ConsoleColor.Blue);
                }

                for (int i = 0; i < corps.Count; i++)
                {
                    DrawPixel(corps[i]);
                    gameover |= (corps[i].XPos == tete.XPos && corps[i].YPos == tete.YPos);
                }

                if (gameover)
                {
                    break;
                }

                DrawPixel(tete);
                DrawPixel(pomme);

                var sw = Stopwatch.StartNew();
                while (sw.ElapsedMilliseconds <= 500)
                {
                    currentMovement = ReadMovement(currentMovement);
                }

                corps.Add(new Pixel(tete.XPos, tete.YPos, ConsoleColor.Green));

                switch (currentMovement)
                {
                    case Direction.Up:
                        tete.YPos--;
                        break;
                    case Direction.Down:
                        tete.YPos++;
                        break;
                    case Direction.Left:
                        tete.XPos--;
                        break;
                    case Direction.Right:
                        tete.XPos++;
                        break;
                }

                if (corps.Count > score)
                {
                    corps.RemoveAt(0);
                }
            }
            SetCursorPosition(WindowWidth / 5, WindowHeight / 2);
            WriteLine($"Game over, Score: {score - 5}");
            SetCursorPosition(WindowWidth / 5, WindowHeight / 2 + 1);
            ReadKey();
        }

        static Direction ReadMovement(Direction mouvement)
        {
            if (KeyAvailable)
            {
                var key = ReadKey(true).Key;

                if (key == ConsoleKey.UpArrow && mouvement != Direction.Down)
                {
                    mouvement = Direction.Up;
                }
                else if (key == ConsoleKey.DownArrow && mouvement != Direction.Up)
                {
                    mouvement = Direction.Down;
                }
                else if (key == ConsoleKey.LeftArrow && mouvement != Direction.Right)
                {
                    mouvement = Direction.Left;
                }
                else if (key == ConsoleKey.RightArrow && mouvement != Direction.Left)
                {
                    mouvement = Direction.Right;
                }
            }

            return mouvement;
        }

        static void DrawPixel(Pixel pixel)
        {
            SetCursorPosition(pixel.XPos, pixel.YPos);
            ForegroundColor = pixel.ScreenColor;
            Write("■");
            SetCursorPosition(0, 0);
        }

        static void Border()
        {
            for (int i = 0; i < WindowWidth; i++)
            {
                SetCursorPosition(i, 0);
                Write("■");

                SetCursorPosition(i, WindowHeight - 1);
                Write("■");
            }

            for (int i = 0; i < WindowHeight; i++)
            {
                SetCursorPosition(0, i);
                Write("■");

                SetCursorPosition(WindowWidth - 1, i);
                Write("■");
            }
        }

        struct Pixel
        {
            public Pixel(int xPos, int yPos, ConsoleColor color)
            {
                XPos = xPos;
                YPos = yPos;
                ScreenColor = color;
            }
            public int XPos { get; set; }
            public int YPos { get; set; }
            public ConsoleColor ScreenColor { get; set; }
        }

        enum Direction
        {
            Up,
            Down,
            Right,
            Left
        }
    }
}