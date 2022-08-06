/*Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

Console.Write("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
for (int i = 0; i < size; i++)
{
    array[i] = new Random().NextDouble() * (5 + 2) - (2); // вещественные числа в интервале от -2 до 5
}

double Find_dif_max_min(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
        if (min > array[i]) min = array[i];
    }
    return max - min;
}

void PrintArray(double[] col)
{
    string text = String.Empty;
    for (int i = 0; i < col.Length; i++) text += $"{col[i]}; ";
    Console.Write(text);
}

PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {Find_dif_max_min(array)}");
