using MarsRoverNavigator.Entity;
using MarsRoverNavigator.Operation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MarsRoverNavigator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mars Rover Navigator Program..");
            Console.WriteLine("You can enter Test Input..");

            List<int> maxPlatauePoints =
                Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            Plateau plateau = new Plateau() { MaxX = maxPlatauePoints[0], MaxY = maxPlatauePoints[1] };

            string[] startPosFirst = Console.ReadLine().Trim().Split(' ');
            Position positionFirst = null;

            if (startPosFirst != null && startPosFirst.Length == 3)
            {
                 positionFirst = new Position()
                {
                    Coordinate = new Coordinates
                    {
                        X = Convert.ToInt32(startPosFirst[0]),
                        Y = Convert.ToInt32(startPosFirst[1])
                    },            
                    Direction = (Directions)Enum.Parse(typeof(Directions), startPosFirst[2])
                };
    
            }

            string movesFirst = Console.ReadLine().ToUpper();
            MarsRover roverFirst = new MarsRover(positionFirst);

            string[] startPosSecond = Console.ReadLine().Trim().Split(' ');
            Position positionSecond = null;

            if (startPosSecond != null && startPosSecond.Length == 3)
            {
                positionSecond = new Position()
                {
                    Coordinate = new Coordinates
                    {
                        X = Convert.ToInt32(startPosSecond[0]),
                        Y = Convert.ToInt32(startPosSecond[1])
                    },
                    Direction = (Directions)Enum.Parse(typeof(Directions), startPosSecond[2])
                };
            }

            MarsRover roverSecond = new MarsRover(positionSecond);
            string movesSecond = Console.ReadLine().ToUpper();

            try
            {
                NasaMarsRoverController controller = new NasaMarsRoverController()
                {
                    MarsPlateau = plateau,
                    MarsRoverList = new List<MarsRover>() { roverFirst, roverSecond },
                    MoveCommandList = new List<string>() { movesFirst, movesSecond }
                };


                List<Position> curPositionList = controller.MoveMarsRoversOnPlateau();
                if (curPositionList != null && curPositionList.Count > 0)
                {
                    Position firstPosition = curPositionList[0];
                    Position secondPosition = curPositionList[1];
                    Console.WriteLine($"{firstPosition.Coordinate.X} {firstPosition.Coordinate.Y} {firstPosition.Direction.ToString()} \n" +
                $"{secondPosition.Coordinate.X} {secondPosition.Coordinate.Y} {secondPosition.Direction.ToString()}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
