//напишите программу, которая выводит третью цифру заданного числа 
//или сообщает что третьей цифры нет

//1234567

// int num = 1234567; //1234567 /10 = 123456; 123456 /10 = 12345; 12345 /10 = 1234; 1234/10 = 123;
// int res = 123 % 10; //получаем остаток от деления = 3
// int counter = 0;
// while(counter > 999) 
// {
    
// }

// напишите программу которая принимает на вход координаты точек Х и У
// и выдает номер четверти на плоскости в которой она находится

// 
Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter (x, y);
string result = quarter > 0 ? $"Указанные координаты соответсвуют четверти -> {quarter.ToString()}" 
                               : "введены не корректные координаты";
Console.WriteLine(result);

int Quarter (int xc, int yc)
{
if(xc > 0 && yc > 0) return 1;
if(xc < 0 && yc > 0) return 2;
if(xc < 0 && yc < 0) return 3;
if(xc > 0 && yc < 0) return 4;
return 0;
}
