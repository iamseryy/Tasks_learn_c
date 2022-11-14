// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2





int arraySize = GetInputNumber("\nEnter array size: ", IsValidSize);
int arrayMin = GetInputNumber("\nEnter array min element: ", IsValidItem);
int arrayMax = GetInputNumber("\nEnter array max element: ", IsValidItem, arrayMin);
int[] arr = GetRandomArray(arraySize, arrayMin, arrayMax);

PrintArray(arr);
Console.Write($" -> {GetCountEvenNumber(arr)}\n");


// ************* methods section ***************

int GetCountEvenNumber(int[] array)
{
    int countEvenNumber = 0;

    foreach (var item in array)
    {
      if (item % 2 == 0)
      {
        countEvenNumber++;
      }
    }

    return countEvenNumber;
}


int[] GetRandomArray(int size, int min, int max)
{
    int[] array = new int[size];

    Random random = new Random();

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max + 1);
    }

    return array;
}

void PrintArray(int[] array)
{
    Console.Write("\n[");
    
    for(int i = 0; i < array.Length - 1; i++)
    {
           Console.Write($"{array[i]}, ");
    }
    
    Console.Write($"{array[array.Length - 1]}]");
}

int GetInputNumber(string inputText, IsValid isValid, int? min = null)
{
    string? data;
    
    do
    {
        Console.Write(inputText);
        data = Console.ReadLine();
    }
    while(!isValid(data, min));

    return Convert.ToInt32(data); ; 
}

bool IsValidSize(string? data, int? min = null)
{
    if (!(int.TryParse(data, out int number) && number > 0))
    {
        Console.Write("\nError! It's should be natural number\n");
        return false;
    }

    return true;
}

bool IsValidItem(string? data, int? min = null)
{
    if (!int.TryParse(data, out int number))
    {
        Console.Write("\nError! It's should be integer number\n");
        return false;
    }

    if (min != null && min > number)
    {
        Console.Write($"\nError! It's should be more or equal {min}\n");
        return false;
    }

    return true;
}

delegate bool IsValid(string? num, int? min = null);