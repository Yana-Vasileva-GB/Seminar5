﻿// Домашняя задача 36:
// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[4];
for (int i = 0; i < 4; i++)
{
    array[i] = new Random().Next(100);
}
int oddSum = 0;
for (int j = 1; j < 4; j += 2)
{
    oddSum = array[j] + oddSum;
}
Console.WriteLine(
    $"Cумма элементов массива [{String.Join("; ", array)}], стоящих на нечётных позициях, составляет {oddSum}"
);
