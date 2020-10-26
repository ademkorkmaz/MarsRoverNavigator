# MarsRoverNavigator
This project is about navigation Robotic Rovers landed by NASA on a rectangle Plateau.

## Overview
A rover's position and location is represented by a combination of x and y co-ordinates and a letter representing one of the four cardinal compass points. The plateau is divided up into a grid to simplify navigation. An example position might be 0, 0, N, which means the rover is in the bottom left corner and facing North.

### Built With
C#, .Net Core 3.1, NUnit 3.12 with Visual Studio 2019  

### Tests
Test Input

5 5
1 2 N
LMLMLMLMM

3 3 E
MMRMMRMRRM

Expected Output

1 3 N
5 1 E
