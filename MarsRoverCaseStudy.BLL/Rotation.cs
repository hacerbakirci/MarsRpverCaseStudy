using System;
using System.Collections.Generic;

namespace MarsRoverCaseStudy.BLL
{
    public class Rotation : IRotation
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Direction Position { get; set; }

        public Rotation()
        {
            X = 0;
            Y = 0;
            Position = Direction.N;
        }
        public void MoveByInstruction(List<int> points, string moves)
        {
            foreach (var item in moves)
            {
                switch (item)
                {
                    case 'M':
                        MoveForward();
                        break;
                    case 'L':
                        MoveLeft();
                        break;
                    case 'R':
                        MoveRight();
                        break;
                    default:
                        Console.WriteLine($"Wrong Position {item}");
                        break;
                }
            }


            if (X < 0 || X > points[0] || Y < 0 || Y > points[1])
            {
                throw new ArgumentException($"Positions are out of range");
            }
        }

        public void MoveForward()
        {
            switch (Position)
            {
                case Direction.N:
                    Y += 1;
                    break;
                case Direction.S:
                    Y -= 1;
                    break;
                case Direction.E:
                    X += 1;
                    break;
                case Direction.W:
                    X -= 1;
                    break;
                default:
                    break;
            }
        }

        public void MoveLeft()
        {
            switch (Position)
            {
                case Direction.N:
                    Position = Direction.W;
                    break;
                case Direction.S:
                    Position = Direction.E;
                    break;
                case Direction.E:
                    Position = Direction.N;
                    break;
                case Direction.W:
                    Position = Direction.S;
                    break;
                default:
                    break;
            }
        }

        public void MoveRight()
        {
            switch (Position)
            {
                case Direction.N:
                    Position = Direction.E;
                    break;
                case Direction.S:
                    Position = Direction.W;
                    break;
                case Direction.E:
                    Position = Direction.S;
                    break;
                case Direction.W:
                    Position = Direction.N;
                    break;
                default:
                    break;
            }
        }
    }
}
