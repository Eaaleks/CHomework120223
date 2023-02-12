/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

int[] InitArray() //создаем функцию InitArray. Обозначаем, что это массив
{
    int[] result = new int[4];//массив result состоит из 12 элементов
    Random rnd = new Random();

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(0, 99); //создаем рандомный массив из 12 элементов, каждый элекмент. Минимальное значение элемента 100, максимальное 999
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
int OddNumberSum = 0;
int GetOddNumber(int[]array) //Создаем функцию GetOddNumber для массива array.Возвращаем только нечетные элементы массива.
{
   
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]%2!=0)
        OddNumberSum += array[i]; //OddNumberSum = OddNumberSum+array[i]. Ставим перед счетчиком. 
            result++;
           
    }
    return result;

    
}

int[] array = InitArray(); //обьявляем массив array. Обьявляем,  что InitArray - это массив array. Таким образом будет определен array.
PrintArray(array);//Распечатываем массив PrintArray(строка 19)
GetOddNumber(array);//Подставляем результат функции GetOddNumber
Console.WriteLine(OddNumberSum);//если просто хочется вывести результат на консоль
