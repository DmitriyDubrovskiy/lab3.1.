using System;

class Rectangle
{
    private double side1;
    private double side2;

    // Конструктор класу Rectangle
    public Rectangle(double side1, double side2)
    {
        this.side1 = side1;
        this.side2 = side2;
    }

    // Метод для обчислення площі прямокутника
    public double CalculateArea()
    {
        return side1 * side2;
    }

    // Метод для обчислення периметру прямокутника
    public double CalculatePerimeter()
    {
        return 2 * (side1 + side2);
    }

    // Властивість для отримання площі прямокутника
    public double Area
    {
        get { return CalculateArea(); }
    }

    // Властивість для отримання периметру прямокутника
    public double Perimeter
    {
        get { return CalculatePerimeter(); }
    }
}
