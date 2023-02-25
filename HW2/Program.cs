//Решение без функции

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int result = 0;

// while (number > 0)
// {
//     result += number % 10;
//     number = number / 10;
// }

// System.Console.WriteLine(result);



//-----------------------------------------------------------------------------------



// Решение с примененим функции
int Text(string message) 
{
    Console.Write(message);
    string startText = Console.ReadLine();
    int result = int.Parse(startText);
    return result;
}

int Sum (int number)
{
   int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number = number /10;
    }

    return result;
}

int number = Text("Введите число: ");

Console.WriteLine($"Сумма всех чисел ровна {Sum(number)}");

