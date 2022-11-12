// E02 В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

// Вводим параметры для создания матрицы
Console.Write("Введите количество строк матрицы: ");
int row = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов матрицы: ");
int column = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();

int[,] matrix = new int[row, column];

// Создаем матрицу.
Console.WriteLine();
Console.WriteLine("Исходная матрица: ");
for (int i =0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        matrix[i, j] = new Random().Next(10, 100);
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

// Находим минимальный элемент.
int minElement = matrix[0, 0];
int minRowIndex = -1;
int minColumnIndex = -1;

for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        if (matrix[i, j] < minElement)
        {
            minElement = matrix[i, j];
            minRowIndex = i;
            minColumnIndex = j;
        }
    }
}
Console.WriteLine($"Минимальное значение: {minElement}\n");

// Создаем матрицу без строки и столбца, 
// на пересечении которых минимальный элемент.
int[,] matrix2 = new int[row-1, column-1];
int iTemp;
int jTemp;

for (int i = 0; i < row - 1; i++)
{
    if (i >= minRowIndex)
        iTemp = i + 1;
    else
        iTemp = i;
    for (int j = 0; j < column - 1; j++)
    {
        if (j >= minColumnIndex)
            jTemp = j + 1;
        else
            jTemp = j;
        matrix2[i, j] = matrix[iTemp, jTemp];
        Console.Write($"{matrix2[i, j]} ");
    }
    Console.WriteLine();
} 