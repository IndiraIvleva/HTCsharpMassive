﻿/*Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

int n = new Random().Next(0, 10000);
Console.WriteLine($"Задано число - {n}");
int b = n;
if (n < 100)
{
    Console.WriteLine($"Третьей цифры числа {b} нет");
}
else
{
    while (n > 1000)
    {
        n = n / 10;     
    }
}
Console.WriteLine($"Третья цифра числа {b} - {n % 10}");

    