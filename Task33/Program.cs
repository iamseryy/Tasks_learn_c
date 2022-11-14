// Задача 33: Задайте массив. Напишите программу, которая определяе, присутствует ли заданное число в массиве.

// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да



int arraySize = (int) GetInputNumber("\nEnter array size: ", IsValidSize);
double arrayMin = GetInputNumber("\nEnter array min element: ", IsValidItem);
double arrayMax = GetInputNumber("\nEnter array max element: ", IsValidItem, arrayMin);
double[] arr = GetRandomArray(arraySize, arrayMin, arrayMax);

double num = GetInputNumber("\nEnter desired number: ", IsValidItem);

Console.Write($"\n{num}; массив ");
PrintArray(arr);
Console.Write($" -> {(ExistNumber(arr, num) ? "да" : "нет")}");


// ************* methods section ***************

bool ExistNumber(double[] array, double numberToFind)
{
    foreach (var item in array)
    {
        if(item == numberToFind)
        {
            return true;
        }
    }

    return false;
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
    Console.Write("[");
    
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