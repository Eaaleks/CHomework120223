/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

int[] InitArray() //создаем функцию InitArray. Обозначаем, что это массив
{
    int[] result = new int[12];//массив result состоит из 12 элементов
    Random rnd = new Random();

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(100, 999); //создаем рандомный массив из 12 элементов, каждый элекмент. Минимальное значение элемента 100, максимальное 999
    }

    return result;
}

void PrintArray(int[] array)//Создаем функцию PrintArray для массива array. Вывод массива array на консоль
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


int result = 0;
int GetEvenNumber(int[]array) //Создаем функцию GetEvenNumber для массива array.Возвращаем только четные элементы массива.
{
   
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]%2==0)
            result++;
    }
    return result;
}

int[] array = InitArray(); //обьявляем массив array. Обьявляем,  что InitArray - это массив array. Таким образом будет определен array.
PrintArray(array);//Распечатываем массив PrintArray(строка 19)
GetEvenNumber(array);//Подставляем результат функции GetEvenNumber
Console.WriteLine($"всего {array.Length} чисел, {result} из них чётные");

Console.WriteLine(result);//если просто хочется вывести результат на консоль