// Домашняя задача 34:
// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int[4];
for (int i = 0; i < 4; i++)
{
    array[i] = new Random().Next(100, 1000);
}
Console.WriteLine($"[{String.Join("; ", array)}]");
int evenNumber = 0;
for (int j = 0; j < 4; j++)
{
    if (array[j] % 2 == 0)
        evenNumber++;
}
Console.WriteLine($"Массив содержит {evenNumber} чётных числа");
