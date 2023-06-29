// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
int[] GetRandomArr(int size, int minVal, int maxVal)
{
    int[] arr = new int[size] ;
    for (int i = 0 ; i < size ; i++)
    {
        arr[i] = new Random().Next(minVal, maxVal +1) ;
    }
    return arr ;
}
int EvenNum(int[] array)
{
        int Sum = 0 ;
        for(int i = 1 ; i < array.Length; i = i+2)
        {
        Sum = Sum + array[i] ;
        }
    return Sum ;
}
int[] Array = GetRandomArr(5, -100, 100);
Console.WriteLine(string.Join(", ", Array));
Console.WriteLine(EvenNum(Array));