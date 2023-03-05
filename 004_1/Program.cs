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
    int length = array.GetLength(0) < array.GetLength(1) ? array.GetLength(0) : array.GetLength(1);
    // Расшифровка записи сверху: если количество строк меньше количества столбцов, то задаем length равным количеству строк.
    // Иначе  length равно количеству столбцов.
    // if (array.GetLength(0) < array.GetLength(1)) { length = array.GetLength(0); }
    // else { length = array.GetLength(1); }
    int sum = 0;
    for (int i = 0; i < length; i++)
    {
        sum = sum + array[i, i]; // sum  += array[i, i];
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
