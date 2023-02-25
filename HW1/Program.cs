//Решение без функции

// Console.WriteLine("введите число: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число: ");
// int numberB = Convert.ToInt32(Console.ReadLine());

//    int multi = 1;
//     for (int i = 0; i < numberB; i++)
//     {
//         multi *= numberA;
//     }

// System.Console.WriteLine(multi);



//-----------------------------------------------------------------------------------



// Решение с примененим функции
int Text(string message) 
{
    Console.Write(message);
    string startText = Console.ReadLine();
    int result = int.Parse(startText);
    return result;
}

int Degree(int numberA, int numberB)
{
   int degree = 1;
    for (int i = 0; i < numberB; i++)
    {
        degree *= numberA;
    }

    return degree;
}

    int numberA = Text("Введите возводимое число: ");
    int numberB = Text("Введите степень для возведения числа А: ");

if (numberB < 0)
    {
        Console.WriteLine("Степень не может быть меньше нуля");
    }

else
{
    Console.WriteLine($"Число {numberA} в степени {numberB} равно {Degree(numberA, numberB)}");
}
