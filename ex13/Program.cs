//напишите программу, которая выводит случайное трехзначное число и 
//удаляет вторую цифру этого числа
//456->46;
//782->72;
//918->98

// ПЕРВЫЙ СПОСОБ 
// Console.Clear();
// int number = new Random(). Next(100, 1000);
// Console.WriteLine($"случайное число = {number}");
// int firstnumber = number / 100;
// int thirdnumber = number % 10;
// int newnumber = firstnumber * 10 + thirdnumber;
// Console.WriteLine(newnumber);


//МЕТОД

Console.Clear();
int number = new Random(). Next(100, 1000);
Console.WriteLine($"случайное число = {number}");

int DeletSecondDigit (int num) //название метода
{        //тело метода
    int firstnumber = num / 100;
    int thirdnumber = num % 10;
    return firstnumber * 10 + thirdnumber;
}
int newnumber = DeletSecondDigit(number);
Console.WriteLine($"{newnumber}");
