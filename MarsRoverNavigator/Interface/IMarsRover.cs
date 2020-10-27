using MarsRoverNavigator.Entity;


namespace MarsRoverNavigator.Interface
{
    public interface IMarsRover
    {
      
        Position Navigate(char moveCommand, Plateau plateau);
    }
}
