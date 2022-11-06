//напишите программу, которая на вход принимает число и проверяет кратно ли оно 7 и 23
//14-нет
//46 - нет
//161 - да

// Console.Clear();
// Console.Write("введите число-знаменатель: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите первое число-делитель: "); //7
// int num1 = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("введите второе число-делитель: "); //23
// int num2 = Convert.ToInt32(Console.ReadLine());

// int result = num % num1;
// int result1 = num % num2;
// if ((result == 0) && (result1 == 0))
// {
//     Console.WriteLine("YES");
// }
// else
// {
//     Console.WriteLine("NO");
// }

int Check(int check, int arg1, int arg2)
{
    int result = 1;
    if((check % arg1 == 0) && (check % arg2 == 0)) result = 0;
    return result;
}

Console.Write("введите число-знаменатель: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("введите первое число-делитель: "); //7
int num1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("введите второе число-делитель: "); //23
int num2 = Convert.ToInt32(Console.ReadLine());
int result1 = Check(num, num1, num2);

if(result1 == 0)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}
