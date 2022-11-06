//метод максимальное число

Console.Clear();
int number = new Random(). Next(10, 100);
Console.WriteLine($"случайное число = {number}");
// int first = number / 10;
// int second = number % 10;
// if(first == second)
// {
//     Console.WriteLine("numbers are equal" );
// }
// else if(first > second)
// {
//     Console.Write(first );
// }
// else
// {
//     Console.WriteLine(second );
// }

int MaxDigit(int number) //название метода
{
    int first = number / 10; //тело
    int second = number % 10; //метода
    //if(first > second) return first; //если метод возвращает значение, то используем return
    //return second; //else не нужен
    if(first == second) return -1;
    return first > second ? first : second; //тернарный оператор
}

bool IsEqualDigits(int num1, int num2)
{
    return num1 == num2; 
}

int maxDigit = MaxDigit(number);
string result = maxDigit != -1 ? maxDigit.ToString(): "Цифры одинаковые"; 
Console.WriteLine($"наибольшая цифра случайного числа {number} => {result}");

