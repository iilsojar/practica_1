// напишите программу, которая на вход принимает число и выдет его квадрат 
//(число, умноженное на само себя)
// 4 -> 16
// -3 -> 9
// -7 -> 49

//решение: 1. на вход принимавет число
//         2. выдает его квадрат
//         3. вывод результата и его проверка 

// int number = Convert.ToInt32(Console.ReadLine());
// double number1 = 4.454;
// double number1 = Convert.ToDouble(Console.ReadLine();
// string str = "буквы цифры символы, строка любых символов";
// string str1 = Console.ReadLine();

Console.Write("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int square =  number *  number;
Console.WriteLine($"квадрат числа {number} = {square}");