// E03 Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента.

// Вводим параметры для создания матрицы

Console.WriteLine("Введите размер трехмерной матрицы");
Console.Write("Введите первый размер матрицы: ");
int x = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второй размер матрицы: ");
int y = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите третий размер матрицы: ");
int z = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();

// Создаем массив из неповторяемых чисел.
int minBorder = 10;
int maxBorder = 100;
int[,,] matrix = new int[x, y, z];
Random rand = new Random();
int temp = 0;
int[] array = new int[x*y*z];
if (x*y*z > maxBorder - minBorder) // Если условие выполняется, то одно или более чисел повторяются.
{
    Console.WriteLine("Размер матрицы больше количества неповторяемых двузначных чисел");
}
else
{
    for (int m = 0; m < x*y*z; m++)
    {
        while (array.Contains(temp))    // Если число уже есть в массиве, то снова запускаем рандом.
        {
            temp = rand.Next(minBorder, maxBorder);
        }
        array[m] = temp;
    }         

// Заполняем трехмерный массив и выводим построчно.
    int count = 0;                    
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {            
                matrix[i, j, k] = array[count];
                count++;
                Console.WriteLine($"matrix[{i}, {j}, {k}] = {matrix[i, j, k]}");
            }
        }
    }
}