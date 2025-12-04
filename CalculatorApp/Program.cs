internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Добро пожаловать в калькулятор!");
        Console.WriteLine("Введите первое число:");
        double a = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Введите второе число:");
        double b = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Выберите операцию (+ или *):");
        char op = Console.ReadLine()[0];

        double result = op == '+' ? a + b : a * b;
        Console.WriteLine($"Результат: {a+b}");
    }
}