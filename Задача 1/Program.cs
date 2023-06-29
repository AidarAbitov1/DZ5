// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

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
    int count = 0 ;
    foreach(var num in array)
    {
    if(num%2 == 0) count++ ;
    }
    return count ;
}

int[] Array = GetRandomArr(10, 100, 999) ;
Console.WriteLine(string.Join (", ", Array)) ;
Console.WriteLine(EvenNum(Array)) ;
