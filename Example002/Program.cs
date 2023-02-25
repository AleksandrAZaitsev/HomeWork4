// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120


int ReadInt(string promt)
{
    Console.WriteLine(promt);
    return Convert.ToInt32(Console.ReadLine());
}

int Factorial(int number)
{
    int result = 1;
    for (int i = 2; i <= number; i++)
    {
        result = result *i; //result *=1
    }
    return result;
}

// void main(string[] args)
// {
Console.WriteLine(Factorial(ReadInt("Enter a number:")));
// }

// main();