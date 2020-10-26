using MarsRoverNavigator.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverNavigator.Interface
{
    public interface IMarsRover
    {
      
        Position Navigate(char moveCommand, Plateau plateau);
    }
}
