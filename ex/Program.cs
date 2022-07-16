void Ex_001()
{
    //Напишите программу, которая выводит третью цифру заданного числа 
    //или сообщает, что третьей цифры нет.

    Console.WriteLine ("Введите число:");
    int number = Convert.ToInt32(Console.ReadLine());
    int i = Math.Abs (number);

    while(i >= 999)
    {
        i /= 10;
    }

    int result = i;
    string resultText = Convert.ToString(result);
        if (resultText.Length > 2)
        {
        Console.WriteLine("третья цифра -> " + resultText[2]);
        }
        else 
        {
        Console.WriteLine("-> третьей цифры нет");
        }
}

void Ex_002()
{
    //Напишите программу, которая принимает на вход цифру, 
    //обозначающую день недели, и проверяет, является ли этот день выходным.

    Console.Write("Введи цифру, обозначающую день недели (от 1 до 7): ");
    int dayNumber = Convert.ToInt32(Console.ReadLine());

    if (dayNumber == 6 || dayNumber == 7) 
    {
    Console.WriteLine("этот день выходной");
    }
    else if (dayNumber < 1 || dayNumber > 7) {
        Console.WriteLine("данные введены неверно");
    }
    else Console.WriteLine("этот день не выходной");
}

//Ex_001();
Ex_002();