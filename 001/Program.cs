// Задайте двумерный массив размером m x n,
// заполненный случайными числами

// Ввод параметров массива
Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int colums = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента массива: ");
int minValue = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента массива: ");
int maxValue = int.Parse(Console.ReadLine());

// Метод создания массива
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
// Метод вывода массива
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
// Заполнение массива
int[,] array = GetArray(rows, colums, minValue, maxValue);
// Вывод массива
PrintArray(array);