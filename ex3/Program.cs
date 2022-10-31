// напишиет программу, которая будет выдавать название дня недели по номеру

// Console.Write("введите число по количеству дней в неделе: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if(number ==1) Console.WriteLine("Понедельник");
// if(number ==2) Console.WriteLine("Вторник");
// if(number ==3) Console.WriteLine("Среда");
// if(number ==4) Console.WriteLine("Четверг");
// if(number ==5) Console.WriteLine("Пятница");
// if(number ==6) Console.WriteLine("Суббота");
// if(number ==7) Console.WriteLine("Воскресенье");
// if((number < 1) || (number > 7)) Console.WriteLine("Введите число от 1 до 7 еще раз");

Console.Write("введите число по количеству дней в неделе: ");
int number = Convert.ToInt32(Console.ReadLine());
switch(number)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thusday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine("enter number from 1 to 7 one more time");
        break;
}
