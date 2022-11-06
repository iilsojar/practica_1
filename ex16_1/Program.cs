//напишите программу, которая на вход принимает два числа и проверяет является ли одно квадратом второго
//5, 25 - да
//-4, 16 - да
//8 , 9 - нет

// Console.Clear();
// Console.Write("введите первое число: ");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите второе число: ");
// int numB = Convert.ToInt32(Console.ReadLine()); 

// if((numA == numB * numB) || (numB == numA * numA))
// {
//     Console.WriteLine("YES");
// }
//     else
// {
//     Console.WriteLine("NO");
// }

//METHOD

int MultipleNumber(int num1, int num2)
{
    int result = 1;
    if((num1 == num2 * num2) || (num2 == num1 * num1)) result = 0;
    return result;
}
Console.Write("введите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine()); 
int result1 = MultipleNumber(numA, numB);
if(result1 == 0)
    {
        Console.WriteLine("YES");
    } 
    else 
    {
        Console.WriteLine("NO");
    }


