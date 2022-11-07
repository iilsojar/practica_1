//сортировка массива по мин числу
//1. найти позицию минимального элемента,
//2. произвести обмен мин значения с неотсортированной частью массива,
//3. повторять пока есть неотсортированные части массива

Console.Clear();
int[] arr = {1, 4, 6, 9, 5, 3, 7, 8, 1, 1};

void PrintArray( int[] array)
{
    int count = array.Length;

    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        
        for(int j = i + 1; j < array.Length; j++)
        {
        if(array[j] < array[minPosition]) minPosition = j;
        }
    
        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}
PrintArray(arr);

SelectionSort(arr);
PrintArray(arr);