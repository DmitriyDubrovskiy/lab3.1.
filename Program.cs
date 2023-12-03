class Program
{
    static void Main()
    {
        // Запит введення довжин сторін від користувача
        Console.WriteLine("Введіть довжину першої сторони прямокутника:");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть довжину другої сторони прямокутника:");
        double side2 = Convert.ToDouble(Console.ReadLine());

        // Створення екземпляру класу Rectangle
        Rectangle rectangle = new Rectangle(side1, side2);

        // Виведення на екран периметру та площі прямокутника
        Console.WriteLine($"Периметр прямокутника: {rectangle.Perimeter}");
        Console.WriteLine($"Площа прямокутника: {rectangle.Area}");
    }
}