//напишите программу которая на вход принимает два числа и выводит, является ли второе число кратным первому.
//если нет - то вывести остаток от деления
//34, 5 - нет, не кратно, остаток от деления 4
//16, 4  - кратно

Console.Clear();
Console.Write("введите первое число: ");

int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = number1 % number2;
if(number3 == 0)
{
    Console.WriteLine($"число {number1} кратно числу {number2}");
}
else
{
    Console.WriteLine($"число {number1} не кратно числу {number2} остаток от деления {number3}");
}