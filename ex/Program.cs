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
    Console.WriteLine("Этот день выходной");
    }
    else if (dayNumber < 1 || dayNumber > 7) {
        Console.WriteLine("Данные введены неверно");
    }
    else Console.WriteLine("Этот день не выходной");

    if (dayNumber==1) Console.WriteLine("Понедельник");
    else if (dayNumber==2) Console.WriteLine("Вторник");
    else if (dayNumber==3) Console.WriteLine("Среда");
    else if (dayNumber==4) Console.WriteLine("Четверг");
    else if (dayNumber==5) Console.WriteLine("Пятница");
    else if (dayNumber==6) Console.WriteLine("Суббота");
    else if (dayNumber==7) Console.WriteLine("Воскресенье");
}

//Ex_001();
Ex_002();