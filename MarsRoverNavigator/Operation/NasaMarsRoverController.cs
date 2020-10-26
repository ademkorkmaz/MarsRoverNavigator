using MarsRoverNavigator.Entity;
using MarsRoverNavigator.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverNavigator.Operation
{
    public class NasaMarsRoverController
    {
        public Plateau MarsPlateau { get; set; }

        public  List<MarsRover> MarsRoverList { get; set; }
        public List<string> MoveCommandList { get; set; }
        public List<Position> MoveMarsRoversOnPlateau() {

            List<Position> roverFinalPostionList = new List<Position>();

            for (int i = 0; i < MarsRoverList.Count; i++)
            {
                foreach (char item in MoveCommandList[i])
                {
                    MarsRoverList[i].Navigate(item, MarsPlateau);
                }

                roverFinalPostionList.Add(MarsRoverList[i].RoverPositon);
            }

            return roverFinalPostionList;

        }

    }
}
