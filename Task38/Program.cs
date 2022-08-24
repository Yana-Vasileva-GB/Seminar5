// Домашняя задача 38:
// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = new double[5];
for (int i = 0; i < 5; i++)
{
    array[i] = Math.Round((new Random().NextDouble()), 2);
}
double maxNumber = array[0];
for (int j = 0; j < 5; j++)
{
    if (maxNumber < array[j])
        maxNumber = array[j];
}
double minNumber = array[0];
for (int m = 0; m < 5; m++)
{
    if (minNumber > array[m])
        minNumber = array[m];
}
double result = maxNumber - minNumber;
Console.WriteLine($"Разница между максимальным ({maxNumber}) и минимальным ({minNumber}) элементами массива [{String.Join("; ", array)}] составляет {result}");
