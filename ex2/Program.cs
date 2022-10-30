//напишите программу, которая на вход принимает два числа и проверяет,
//является ли первое число квадратом второго

// Console.Write("введите первое число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите второе число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// if (number == number1 * number1)
// {
//     Console.WriteLine($"первое число {number} является квадратом числа {number1}");
// }
// else
// {
//     Console.WriteLine($" число {number} не является квадратом числа {number1}");
// }

Console.Write("введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
int c = b * b;
if(a == c)
{
    Console.WriteLine($"первое число {a} является квадратом числа {b}");
}
else
{
    Console.WriteLine($" число {a} не является квадратом числа {b}");
}