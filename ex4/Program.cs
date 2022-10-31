//напишите программу, которая на вход принимает число N и на выходе показывает все целые числа от -N до N
//4
//2

Console.Write("введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int a = -number;
while(a <= number)
{
    Console.Write($"{a} ");
    a++;
} 

