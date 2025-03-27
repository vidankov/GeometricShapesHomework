using GeometricShapesHomework;

/*
 * Пункт 2 ТЗ:
 * "Вычисление площади фигуры без знания типа фигуры на этапе компиляции (compile-time)."
 * -- Решение поставленной задачи достигается благодаря интерфейсу IGeometricShape<T> и свойству Square,
 * -- обращаясь к которому не нужно обладать информацией о типе конкретной фигуры.
 */

TwoDimensionalSide sideA = new(new(0, 0), new(0, 5));
TwoDimensionalSide sideB = new(new(0, 0), new(5, 0));
TwoDimensionalSide sideC = new(new(0, 5), new(5, 0));

IGeometricShape<TwoDimensionalSide> geometricShape1 = new Triangle(sideA, sideB, sideC);
IGeometricShape<TwoDimensionalSide> geometricShape2 = new Circle(sideA);

Console.WriteLine(geometricShape1.Square);
Console.WriteLine(geometricShape2.Square);