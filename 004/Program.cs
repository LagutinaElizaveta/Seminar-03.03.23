// Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0), (1,1) и т.д.)

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
// Метод нахождения суммы элементов массива
int SumElement(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                sum = sum + array[i, j]; // sum  += array[i, j];
            }
        }
    }
    return sum;
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
Console.WriteLine();
// Нахождение суммы элементов
// int sum = SumElement(array);
// Вывод резульата
Console.WriteLine($"Сумма элементов по главной диагонали равна {SumElement(array)}");
