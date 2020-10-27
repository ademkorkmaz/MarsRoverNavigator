using MarsRoverNavigator.Interface;
using System;
 

namespace MarsRoverNavigator.Entity
{
    public class MarsRover : IMarsRover
    {
        /* This is for Nasa Mars Rover object,
         * It has rover postion and navigation functions.
         */

        public Position RoverPositon { get; }
        public MarsRover(Position position)
        {
            this.RoverPositon = position;
        }

        private void TurnRight()
        {

            int nextDirection = ((int)(this.RoverPositon.Direction) + 1) % 4;

            this.RoverPositon.Direction = (Directions)(nextDirection);
        }
        private void TurnLeft()
        {

            int nextDirection = ((int)(this.RoverPositon.Direction) - 1);


            this.RoverPositon.Direction =
                 (Directions)(nextDirection < 0 ? nextDirection + 4 : nextDirection);

        }

        private void MoveForward(int maxX, int maxY)
        {

            switch (this.RoverPositon.Direction)
            {
                case Directions.N:
                    this.RoverPositon.Coordinate.Y += 1;
                    if (this.RoverPositon.Coordinate.Y > maxX)
                        throw new Exception("Rover reached limits the plateau On Y axis");
                    break;
                case Directions.S:
                    this.RoverPositon.Coordinate.Y -= 1;
                    if (this.RoverPositon.Coordinate.Y < 0)
                        throw new Exception("Rover reached limits the plateau  On Y axis");
                    break;
                case Directions.E:
                    this.RoverPositon.Coordinate.X += 1;
                    if (this.RoverPositon.Coordinate.X > maxY)
                        throw new Exception("Rover reached limits the plateau  On X axis");
                    break;
                case Directions.W:
                    this.RoverPositon.Coordinate.X -= 1;
                    if (this.RoverPositon.Coordinate.X < 0)
                    {
                        throw new Exception("Rover reached limits the plateau  On X axis");
                    }
                    break;
                default:
                    break;
            }

        }

        public Position Navigate(char moveCommand, Plateau plateau)
        {

            switch (moveCommand)
            {
                case 'M':
                    this.MoveForward(plateau.MaxX, plateau.MaxY);
                    break;
                case 'R':
                    this.TurnRight();
                    break;
                case 'L':
                    this.TurnLeft();
                    break;
                default:
                    Console.WriteLine($"Invalid Command {moveCommand}");
                    break;
            }


            return this.RoverPositon;

        }


    }
}
