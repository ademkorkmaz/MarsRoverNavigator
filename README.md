# MarsRoverNavigator
This project is about navigation Robotic Rovers landed by NASA on a rectangle Plateau.

## Overview
A rover's position and location is represented by a combination of x and y co-ordinates and a letter representing one of the four cardinal compass points. The plateau is divided up into a grid to simplify navigation. An example position might be 0, 0, N, which means the rover is in the bottom left corner and facing North.

## Input: 
The first line of input is the upper-right coordinates of the plateau, the lower-left coordinates are assumed to be 0,0.
The rest of the input is information pertaining to the rovers that have been deployed. Each rover has two lines of input. The first line gives the rover's position, and the second line is a series of instructions telling the rover how to explore the plateau.
The position is made up of two integers and a letter separated by spaces, corresponding to the x and y co-ordinates and the rover's orientation.
Each rover will be finished sequentially, which means that the second rover won't start to move until the first one has finished moving.
## Output:
The output for each rover should be its final co-ordinates and heading.

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
## License
Copyright © Adem KORKMAZ 
