// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.

// [3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6] -> positive = 29 , negative = -20



double[] arr = GetRandomArray(12, -9, 9);

GetExtendedSum(arr, out double posSum, out double negSum);

string positive = $"positive = {Math.Round(posSum, 2).ToString().Replace(',', '.')}"; 
string negative = $"negative = {Math.Round(negSum, 2).ToString().Replace(',', '.')}"; 

PrintArray(arr);
Console.Write($" -> {positive} , {negative}\n");



// ************* methods section ***************

void GetExtendedSum(double[] array, out double positiveSum, out double negativeSum)
{
    positiveSum = 0;
    negativeSum = 0;

    foreach (var item in array)
    {
        positiveSum = positiveSum + (item > 0 ? item : 0);
        negativeSum = negativeSum + (item < 0 ? item : 0);
    }
}

double[] GetRandomArray(int size, double min, double max)
{
    double[] array = new double[size];

    Random random = new Random();

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(random.NextDouble() * (max - min) + min, 2);
    }

    return array;
}


void PrintArray(double[] array)
{
    Console.Write("\n[");
    
    for(int i = 0; i < array.Length - 1; i++)
    {
           Console.Write($"{array[i].ToString().Replace(',', '.')}, ");
    }
    
    Console.Write($"{array[array.Length - 1].ToString().Replace(',', '.')}]");
}
