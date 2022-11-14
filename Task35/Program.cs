// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите колличество элементов массива, значения которых лежат в отрезке [10, 99]

// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5




int arraySize = (int) GetInputNumber("\nEnter array size: ", IsValidSize);
double arrayMin = GetInputNumber("\nEnter array min element: ", IsValidItem);
double arrayMax = GetInputNumber("\nEnter array max element: ", IsValidItem, arrayMin);
double rangeMin = GetInputNumber("\nEnter range minimum: ", IsValidItem);
double rangeMax = GetInputNumber("\nEnter range maximum: ", IsValidItem, rangeMin);

double[] arr = GetRandomArray(arraySize, arrayMin, arrayMax);

PrintArray(arr);
Console.Write($" -> {GetRangeCount(arr, rangeMin, rangeMax)}\n");


// ************* methods section ***************

int GetRangeCount(double[] array, double min, double max)
{
    int count = 0;
    
    foreach (var item in array)
    {
        if(item >= min && item <= max)
        {
            count++;
        }
    }

    return count;
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

double GetInputNumber(string inputText, IsValid isValid, double? min = null)
{
    string? data;
    
    do
    {
        Console.Write(inputText);
        data = Console.ReadLine();
    }
    while(!isValid(data, min));

    return Convert.ToDouble(data); ; 
}

bool IsValidSize(string? data, double? min = null)
{
    if (!(int.TryParse(data, out int number) && number > 0))
    {
        Console.Write("\nError! It's should be natural number\n");
        return false;
    }

    return true;
}

bool IsValidItem(string? data, double? min = null)
{
    if (!double.TryParse(data, out double number))
    {
        Console.Write("\nError! It's should be number\n");
        return false;
    }

    if (min != null && min > number)
    {
        Console.Write($"\nError! It's should be more or equal {min}\n");
        return false;
    }

    return true;
}

delegate bool IsValid(string? num, double? min = null);