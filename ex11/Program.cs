// напишите программу, которая выводит случайное число из отреза 10 - 99 и показывает наибольшую цифру числа
//78 - 8
//12-2
//85-8
Console.Clear();
int number = new Random(). Next(10, 100);
Console.WriteLine(number);
int first = number / 10;
int second = number % 10;
if(first == second)
{
    Console.WriteLine("numbers are equal" );
}
else if(first > second)
{
    Console.Write(first );
}
else
{
    Console.WriteLine(second );
}

//что такое тернарный оператор?
int max = 0;
if(first  > second) max = first;

else max = second;
//тернарный оператор
int max = first > second ? first : second; 
//если первое число больше второго, то первое число больше,
//иначе  - больше второе
// знаки ? и : 

int MaxDigit(int number) //название метода
{
    int first = number / 10; //тело
    int second = number % 10; //метода
    if(first > second) return first; //если метод возвращает значение, то используем return
    return second; //else не нужен
}
