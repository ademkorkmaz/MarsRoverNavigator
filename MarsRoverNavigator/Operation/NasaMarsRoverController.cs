using MarsRoverNavigator.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverNavigator.Operation
{
    public class NasaMarsRoverController
    {
        public Plateau MarsPlateau { get; set; }

        public  MarsRover MarsPhotoRover { get; set; }

        public Position MoveMarsRoversOnPlateau(string MoveCommands) {
            

            foreach (var command in MoveCommands)
            {
                MarsPhotoRover.Navigate(command, MarsPlateau);
            }

            return MarsPhotoRover.RoverPositon;

        }

    }
}
