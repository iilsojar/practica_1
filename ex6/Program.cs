// how to find max from 9 numbers
Console.Clear();
int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;  
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int a1 = 4;
int a2 = 78;
int a3 = 78956;
int b1 = 45;
int b2 = 56;
int b3 = 3;
int c1 = 67;
int c2 = 6789;
int c3 = 1234;

int Max1 = Max(a1, b1, c1);
int Max2 = Max(b1, b2, b3);
int Max3 = Max(c1, c2, c3);
int max = Max (Max1, Max2, Max3);
Console.WriteLine(max);
