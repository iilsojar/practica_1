//напишите программу, которая на вход принимает координаты двух точек 
//и находит расстояние между ними в 2D пространстве

// Console.Clear();
// Console.Write("Введите координаты x1: ");
// double x1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координаты y1: ");
// double y1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координаты x2: ");
// double x2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координаты y2: ");
// double y2 = Convert.ToInt32(Console.ReadLine());

// double X = x2 - x1;
// double Y = y2 - y1;
// double Distance = Math.Sqrt(Math.Pow(X,2) + Math.Pow(Y, 2)); 
// double DistanceRound = Math.Round(Distance, 2, MidpointRounding.ToZero);
// Console.WriteLine($"расстояние между точками Х и У в 2D пространстве -> {DistanceRound}");

//Method

Console.Clear();
string phrase = "Введите координаты";
Console.Write($"{phrase} x1: ");
double x1 = Convert.ToInt32(Console.ReadLine());

Console.Write($"{phrase} y1: ");
double y1 = Convert.ToInt32(Console.ReadLine());

Console.Write($"{phrase} x2: ");
double x2 = Convert.ToInt32(Console.ReadLine());

Console.Write($"{phrase} y2: ");
double y2 = Convert.ToInt32(Console.ReadLine());

double Distance = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1), 2));
double DistanceRound = Math.Round(Distance, 2, MidpointRounding.ToZero);

Console.WriteLine($"расстояние между точками Х и У в 2D пространстве -> {DistanceRound}");