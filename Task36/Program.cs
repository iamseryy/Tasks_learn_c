// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0





int arraySize = (int) GetInputNumber("\nEnter array size: ", IsValidSize);
double arrayMin = GetInputNumber("\nEnter array min element: ", IsValidItem);
double arrayMax = GetInputNumber("\nEnter array max element: ", IsValidItem, arrayMin);
double[] arr = GetRandomArray(arraySize, arrayMin, arrayMax);

PrintArray(arr);
Console.Write($" -> {Math.Round(GetSumOddPositionNumber(arr), 2).ToString().Replace(',', '.')}\n");



// ************* methods section ***************

double GetSumOddPositionNumber(double[] array)
{
    double sumOddPositionNumber = 0;

    for (int i = 1; i < array.Length; i+=2)
    {
        sumOddPositionNumber += array[i];
    }

    return sumOddPositionNumber;
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