// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.Clear() ;
double[] GetRandomArr(int size, double minVal, double maxVal)
{
    double[] arr = new double[size] ;
    for (int i = 0 ; i < size ; i++)
    {
        arr[i] = new Random().NextDouble() *(maxVal - minVal +1) + minVal;
    }
    return arr ;
}

void Diff(double [] array)
{   
    double max = array [0] ;
    double min = array [0];
    for(int i = 0 ; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    Console.WriteLine($"мин. Значение {min:f2}") ;
    Console.WriteLine($"макс. Значение {max:f2}") ;
    Console.WriteLine($"разница {max-min:f2}") ;
}


double[] Array = GetRandomArr(5, 0, 100);
Console.WriteLine(String.Join(", ", Array)) ;
Diff(Array) ;