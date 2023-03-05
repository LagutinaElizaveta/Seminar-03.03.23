// Задайте двумерный массив. Найдите элементы,
// у которых оба индекса четные, и замените
// эти элементы на их квадраты

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
// Метод замены элементов массива
int[,] ChangeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 1 && j % 2 == 1)
            {
                array[i, j] = Convert.ToInt32(Math.Pow(array[i, j], 2)); //Здесь нужно не забыть поменять тип данных 'double', который возвращает операция возведения в степень на 'int' с помощью Convert.ToInt32
                // array[i, j] *= array[i, j] - это второй вариант записи, в котором нет необходимости в смене типа данных
            }
        }
    }
    return array;
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
// Замена элементов массива
ChangeArray(array);
// Вывод нового массива
PrintArray(array); // Или убрать 61-ю строку, а в 63-й написать: PrintArray(ChangeArray(array);)