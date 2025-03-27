using GeometricShapesHomework;

TwoDimensionalCoordinate pointA = new(0, 0);
TwoDimensionalCoordinate pointB = new(0, 10);
TwoDimensionalSide sideAB = new(pointA, pointB);
Console.WriteLine(sideAB.Length); //10