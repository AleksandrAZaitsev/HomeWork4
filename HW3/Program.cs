//Решение без функции

// Console.WriteLine("Введите длину массива: ");
// int length = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите минимальное число для рандома: ");
// int minRandom = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите максимальное число для рандома: ");
// int maxRandom = Convert.ToInt32(Console.ReadLine());
   
// int[] array = new int[length];
// Random random = new Random();
// for (int i = 0; i < length; i++)
// {
//     array[i] = random.Next(minRandom,maxRandom);
// }

// System.Console.WriteLine("[" + string.Join(", ",array) + "]");


//-----------------------------------------------------------------------------------


// Решение с примененим функции
int Text(string message) 
{
    Console.Write(message);
    string startText = Console.ReadLine();
    int result = int.Parse(startText);
    return result;
}

int[] FillArray(int length, int minRandom, int maxRandom)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(minRandom, maxRandom);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[" + string.Join(", ",array) + "]");
}

int length = Text("Введите длину массива: ");
int minRandom = Text("Введите минимальное число для рандома: ");
int maxRandom = Text("Введите максимальное число для рандома: ");

int[] array = FillArray(length, minRandom, maxRandom);
PrintArray(array);