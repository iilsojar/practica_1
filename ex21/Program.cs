//напишите программу, которая принимает на вход число N и выдает таблицу квадратов чисел от 1 до N

Console.Clear();
Console.Write("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int a = 1;

while(a <= number)
{
    Console.WriteLine($"{a} ");
    a++;
}



