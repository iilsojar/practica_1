//напишите программу которая по заданному номеру четверти определяет 
//диапазон возможных координат в этой четверти Х и У

// Console.Clear();
// Console.WriteLine("Введите номер четверти");
// int x = Convert.ToInt32(Console.ReadLine());
// if(x == 1)
// {
//     Console.WriteLine("диапазон возможных координат в плоскости от Х > 0, Y > 0");
// }
// if(x == 2)
// {
//     Console.WriteLine("диапазон возможных координат в плоскости от Х < 0, Y > 0");
// }
// if(x == 3)
// {
//     Console.WriteLine("диапазон возможных координат в плоскости от Х < 0, Y < 0");
// }
// if(x == 4)
// {
//     Console.WriteLine("диапазон возможных координат в плоскости от Х > 0, Y < 0");
// }
// if(x < 1 || x > 4);
// {
//     Console.WriteLine("такой четверти не существует");
// }

//попробуем через метод

Console.Clear();
Console.WriteLine("Введите номер четверти:");
string x = Console.ReadLine();

string RangeCoordinate (string xa)
{
    string phrase = "диапазон возможных координат в плоскости";
    if(xa == "1") return $"{phrase} от Х > 0, Y > 0";
    if(xa == "2") return $"{phrase} от Х < 0, Y > 0";
    if(xa == "3") return $"{phrase} от Х < 0, Y < 0";
    if(xa == "4") return $"{phrase} от Х > 0, Y < 0";
    return "неверные данные";
}
string range = RangeCoordinate (x); 
Console.WriteLine(range);


// int quarter = Quarter (x, y);
// string result = quarter > 0 ? $"Указанные координаты соответсвуют четверти -> {quarter.ToString()}" 
//                                : "введены не корректные координаты";
// Console.WriteLine(result);

// int Quarter (int xc, int yc)
// {
// if(xc > 0 && yc > 0) return 1;
// if(xc < 0 && yc > 0) return 2;
// if(xc < 0 && yc < 0) return 3;
// if(xc > 0 && yc < 0) return 4;
// return 0;
// }

