// E04 Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника.

Console.WriteLine("Введите количество строк: ");
int row = int.Parse(Console.ReadLine() ?? "0");

static int Factorial(int n)
{
    int mult = 1;
    for (int i = 1; i <= n; i++) 
    {
        mult *= i;
    }
    return mult;
}

for (int i = 0; i < row; i++)       
{
    for (int j = 0; j < row - i; j++)
    {
        Console.Write(" ");
    }
    for (int k = 0; k <= i; k++)
    {
        Console.Write($"{Factorial(i) / (Factorial(k) * Factorial (i - k))} ");
    }
    Console.WriteLine();
}