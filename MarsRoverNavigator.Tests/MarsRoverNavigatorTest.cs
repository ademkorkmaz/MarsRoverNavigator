using MarsRoverNavigator.Entity;
using MarsRoverNavigator.Operation;
using NUnit.Framework;
using System.Collections.Generic;

namespace MarsRoverNavigator.Tests
{
    public class MarsRoverNavigatorTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]   
        public void TestScenarioFirstRover()
        {
            Plateau plateau = new Plateau() { MaxX = 5, MaxY = 5 };
            Position position = new Position()
            {
                Coordinate = new Coordinates { X = 1, Y = 2 },
                Direction = Directions.N
            };
            MarsRover rover = new MarsRover() { RoverPositon = position };
            string moves = "LMLMLMLMM";

            NasaMarsRoverController controller = new NasaMarsRoverController()
            {
                MarsPlateau = plateau,
                MarsRoverList = new List<MarsRover>() { rover },
                MoveCommandList = new List<string>() { moves }
            };

             
            List<Position> curPositionList = controller.MoveMarsRoversOnPlateau();
            if (curPositionList != null && curPositionList.Count > 0)
            {
                Position curPosition = curPositionList[0];

                string actualOutput = $"{curPosition.Coordinate.X} {curPosition.Coordinate.Y} {position.Direction.ToString()}";
                string expectedOutput = "1 3 N";

                Assert.AreEqual(expectedOutput, actualOutput);
            }


        }

        [Test]
        public void TestScenarioSecondRover()
        {
            Plateau plateau = new Plateau() { MaxX = 5, MaxY = 5 };
            Position position = new Position()
            {
                Coordinate = new Coordinates { X = 3, Y = 3},
                Direction = Directions.E
            };
            MarsRover rover = new MarsRover() { RoverPositon = position };
            string moves = "MMRMMRMRRM";

            NasaMarsRoverController controller = new NasaMarsRoverController()
            {
                MarsPlateau = plateau,
                MarsRoverList = new List<MarsRover>() { rover },
                MoveCommandList = new List<string>() { moves }
            };


            List<Position> curPositionList = controller.MoveMarsRoversOnPlateau();
            if (curPositionList != null && curPositionList.Count > 0)
            {
                Position curPosition = curPositionList[0];

                var actualOutput = $"{curPosition.Coordinate.X} {curPosition.Coordinate.Y} {position.Direction.ToString()}";
                var expectedOutput = "5 1 E";

                Assert.AreEqual(expectedOutput, actualOutput);
                 
            }
        }


        [Test]
        public void TestScenarioMultiple()
        {
            Plateau plateau = new Plateau() { MaxX = 5, MaxY = 5 };

            Position positionFirst = new Position()
            {
                Coordinate = new Coordinates { X = 1, Y = 2 },
                Direction = Directions.N
            };
            MarsRover roverFirst = new MarsRover() { RoverPositon = positionFirst };
            string movesFirst = "LMLMLMLMM";

            Position positionSecond = new Position()
            {
                Coordinate = new Coordinates { X = 3, Y = 3 },
                Direction = Directions.E
            };
            MarsRover roverSecond = new MarsRover() { RoverPositon = positionSecond };
            string movesSecond = "MMRMMRMRRM";



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

                string actualOutput =
                $"{firstPosition.Coordinate.X} {firstPosition.Coordinate.Y} {firstPosition.Direction.ToString()}\\n" +
                $"{secondPosition.Coordinate.X} {secondPosition.Coordinate.Y} {secondPosition.Direction.ToString()}";

                string expectedOutput = @"1 3 N\n5 1 E";

                Assert.AreEqual(expectedOutput, actualOutput);
            }
        }
    }
}