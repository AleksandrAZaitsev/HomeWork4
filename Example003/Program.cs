// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void FillArray(int[] arr)
{
    Random rang = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rang.Next(0, 2);
    }
}

void PrintArray(int[] arr)
{
    System.Console.Write("[" + string.Join(", ",arr) + "]");
}

int[] array = new int[8];

FillArray(array);
PrintArray(array);

