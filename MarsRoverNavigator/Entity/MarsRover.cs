using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverNavigator.Entity
{
    public class MarsRover
    {
        public Position RoverPositon { get; set;} 

        private void TurnRight() {

           int nextDirection =  ((int)(this.RoverPositon.Direction) + 1) %4;

           this.RoverPositon.Direction =  (Directions)(nextDirection);
        }
        private void TurnLeft() {

            int nextDirection = ((int)(this.RoverPositon.Direction) -1);
              

            this.RoverPositon.Direction =
                 (Directions)(nextDirection < 0  ? nextDirection + 4 : nextDirection );

 
        }

        private void MoveForward(int maxX, int maxY) {

            switch (this.RoverPositon.Direction)
            {
                case Directions.N:
                    this.RoverPositon.Coordinate.Y += 1;
                    if (this.RoverPositon.Coordinate.Y > maxX) 
                        throw new Exception();
                    break;
                case Directions.S:
                    this.RoverPositon.Coordinate.Y -= 1;
                    if (this.RoverPositon.Coordinate.Y < 0)
                        throw new Exception();
                    break;
                case Directions.E:
                    this.RoverPositon.Coordinate.X += 1;
                    if(this.RoverPositon.Coordinate.X > maxY)
                        throw new Exception();
                    break;
                case Directions.W:
                    this.RoverPositon.Coordinate.X -= 1;
                    if (this.RoverPositon.Coordinate.X < 0) {
                        throw new Exception();
                    }
                    break;
                default:
                    break;
            }
 
        }

        public Position Navigate(char moveCommand, Plateau plateau) {

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
                    Console.WriteLine($"Invalid Character {moveCommand}");
                    break;
            }

 
            return this.RoverPositon;

        }

    }
}
