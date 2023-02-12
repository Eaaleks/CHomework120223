/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

Console.WriteLine("Введите размер массива:");
int n = Convert.ToInt32(Console.ReadLine()); // Задаём размер массива
int [] array  = new int[n];      // Создаём массив
Random rnd = new Random();      // Создание объекта для генерации чисел
for (int i = 0; i < n; i++)
    { array[i] = rnd.Next(-50, 50);  // Заполнение рандомами
    Console.Write($" {array[i]} ");
}
int min = 0;
int max = 0;
foreach (int i in array)  // Поиск максимального и минимального значения
{
    if (min > i) min = i;
    if (max < i) max = i;
}
Console.WriteLine($"\n Максимальный элемент: {max}\n Минимальный элемент: {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементом: {max-min}");

