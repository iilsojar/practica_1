//напишите программу, которая на вход принимает трехзначное число и на выходе показывает последнюю цифру этого числа

Console.Write("введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = number % 10;
Console.Write(number1);
if((number > 999) || (number <100))
{
    Console.Write("введите Трехзначное число еще раз!");
}