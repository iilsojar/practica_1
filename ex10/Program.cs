//задача2: даны два числа. показать большее и меньшее

// Console.Clear();
// Console.Write("введите первое число: ");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите второе число: ");
// int numB = Convert.ToInt32(Console.ReadLine());
// int max = numA;
// if(numB > numA) max = numB;
// int min= numA;
// if(numB < numA) min= numB;
// Console.WriteLine(max);
// Console.WriteLine(min);

//задача4: найти максимальное из трех чисел
// Console.Clear();
// Console.Write("введите первое число: ");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите второе число: ");
// int numB = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите третье число: ");
// int numC = Convert.ToInt32(Console.ReadLine());
// int max = numA;
// if(numB > max) max= numB;
// if(numC > max) max= numC;
// Console.WriteLine(max);

//задача 6: Выяснить является ли число четным
// Console.Clear();
// Console.Write("введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num % 2 == 0)
//     {
//         Console.WriteLine($"введенное вами число {num} является четным");
//     }
//         else
//             {
//                 Console.WriteLine($"введенное вами число {num} не является четным");
//             }

//задача 8: показать четные числа от 1 до N
Console.Clear();
Console.Write("введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = 1;
while (num1 <= num)
{
    num1++;
    Console.Write($"{num1} ");
}
