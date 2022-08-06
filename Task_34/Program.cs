/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

Console.WriteLine("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int count = 0;
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(100,1000);
    if (array[i] % 2 == 0) count++;
}

void PrintArray(int[] col)
    {
        int count = col.Length;
        int position = 0;
        while (position < count)
            {
                Console.Write($"{col[position]} ");
                position++;
            }
    }

PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве: {count}");