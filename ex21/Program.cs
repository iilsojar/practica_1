﻿//напишите программу, которая принимает на вход число N и выдает таблицу квадратов чисел от 1 до N

Console.Clear();
Console.Write("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int a = 1;

string InSqare (int num)
{
    return $"{num}     {num * num}";
}
while(a <= number)
{
    Console.WriteLine(InSqare(a));
    a++;
}



