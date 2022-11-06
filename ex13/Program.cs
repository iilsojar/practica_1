//напишите программу, которая выводит случайное трехзначное число и 
//удаляет вторую цифру этого числа
//456->46;
//782->72;
//918->98

Console.Clear();
int number = new Random(). Next(100, 1000);
Console.WriteLine($"случайное число = {number}");
int firstnumber = number / 100;
int thirdnumber = number % 10;
int result = firstnumber * 10 + thirdnumber;

Console.WriteLine(result);
