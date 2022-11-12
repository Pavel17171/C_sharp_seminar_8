// E01 Найти произведение двух матриц.

// Вводим параметры для создания матриц
Console.Write("Введите количество строк первой матрицы: ");
int row1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов первой матрицы: ");
int column1 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();
Console.Write("Введите количество строк второй матрицы: ");
int row2 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов второй матрицы: ");
int column2 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();

int[,] matrix1 = new int[row1, column1];
int[,] matrix2 = new int[row2, column2];
int[,] matrix3 = new int[row1, column2];

if (column1 == row2)   // Проверка на выполнение условия умножения матриц
{
    // Границы заполнения матриц рандомными числами.
    Console.Write("Введите нижнюю границу рандомного заполнения матриц: ");
    int minBorder = int.Parse(Console.ReadLine() ?? "0");
    Console.Write("Введите верхнюю границу рандомного заполнения матриц: ");
    int maxBorder = int.Parse(Console.ReadLine() ?? "0");

// Создаем первую матрицу.
    Console.WriteLine();
    Console.WriteLine("Первая матрица: ");
    for (int i =0; i < row1; i++)
    {
        for (int j = 0; j < column1; j++)
        {
            matrix1[i, j] = new Random().Next(minBorder, maxBorder);
            Console.Write($"{matrix1[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

// Создаем вторую матрицу.
    Console.WriteLine("Вторая матрица: ");
    for (int i =0; i < row2; i++)
    {
        for (int j = 0; j < column2; j++)
        {
            matrix2[i, j] = new Random().Next(minBorder, maxBorder);
            Console.Write($"{matrix2[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

// Производим умножение первой матрицы на вторую.
    Console.WriteLine("Результат произведения матриц: ");    
    for (int i = 0; i < row1; i++)
    {
        for (int j = 0; j < column2; j++)
        {
            int temp = 0;
            for (int k = 0; k < column1; k++)
            {
                temp += matrix1[i, k] * matrix2[k, j];
            }
            matrix3[i, j] = temp;
            Console.Write($"{matrix3[i, j]} ");
        }
        Console.WriteLine();
    }
}
else
{
    Console.WriteLine("Матрицы для перемножения не совместимы!");
}