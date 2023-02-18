// Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

int number = ReadInt("Введите число  "); 

if (number < 100 )   
{
    Console.WriteLine("третьей цыфры нет ");
}
else
{
    Console.WriteLine(InCenter(number)); 
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

 int InCenter(int a)
{
    while (a>=1000)
    {
        a= a / 10;
    }   
    a = a % 10;
    return a;
}

