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

