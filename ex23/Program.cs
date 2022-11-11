// //напишите программу, которая на вход принимает число А и выдает сумму чисел от 1 до А
// //7 -28
// //4- 10
// Console.Clear();
// Console.Write("введите число: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// // int sumOfNumbers = SumOfNumbers(numberA);
// // Console.Write($"сумма чисел от 1 до {numberA} -> {sumOfNumbers} ");
// // int SumOfNumbers (int num)
// // {
// //     int sum = 0;
// //     while(num > 0)
// //     {
// //         sum = sum + num;
// //         num--;
// //     }
// //     return sum;
// // }
// //метод через for
// int sumOfNumbers = SumOfNumbers(numberA);
// Console.Write($"сумма чисел от 1 до {numberA} -> {sumOfNumbers} ");
// int SumOfNumbers (int num)
// {
//     int sum = default;
//     for (int i = 1; i <= num; i++)
//     {
//         sum = sum + i;
//     }
    
//     return sum;
// }

//задача 26: напишите программу, которая на вход принимает число и выдает количество цифр в числе
//456 - 3

// Console.Clear();
// Console.Write("введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// while(count < number)
// {
//     number = number / 10;
//     count ++;
// }
// Console.Write($"в числе {number} - {count} цифр ");

// Console.Clear();
// Console.Write("введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int countDigit = CountDigit(number);
// Console.Write($"количество цифр в числе {number} - > {countDigit} ");

// int CountDigit(int num)
// {
//     int count = 0;
//     while(count < num)
//     {
//         num = num / 10;
//         count ++;
//     }
//     return count;
// }

//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Clear();
Console.Write("введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int degreeOfNumbers = DegreeOfNumbersWhile(numberA, numberB);
Console.WriteLine($"число {numberA} в степени {numberB} -> {degreeOfNumbers}");

//degree = 3*3*3+3*3
// int DegreeOfNumbersFor (int numA, int numB)
// {
//     int degree = default;3

//     for (int i = 1; i <= numB; i++)
//     {
//         degree = numA * numA;
//     }
//     return degree;
// } 

int DegreeOfNumbersWhile (int numA, int numB)
{
    int degree = 1;
    int counter = 1;
    while (counter <= numB)
    {
        degree = degree * numA;
        counter++;
    }
    return degree;
} 
