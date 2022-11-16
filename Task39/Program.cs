// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


int arraySize = (int) GetInputNumber("\nEnter array size: ", IsValidSize);
double arrayMin = GetInputNumber("\nEnter array min element: ", IsValidItem);
double arrayMax = GetInputNumber("\nEnter array max element: ", IsValidItem, arrayMin);
double[] arr = GetRandomArray(arraySize, arrayMin, arrayMax);

Console.WriteLine();
PrintArray(arr);
Console.Write(" -> ");
PrintArray(Flip(arr));
Console.WriteLine();



// ************* methods section ***************

double[] Flip(double[] array)
{
    double temp;

    for(int i = 0; i < array.Length / 2; i++)
    {
        temp = array[array.Length - i - 1];
        array[array.Length - i - 1] = array[i];
        array[i] = temp;
    }

    return array;
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