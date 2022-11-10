// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]





int arraySize = GetInputNumber("\nEnter array size: ", IsValidNumber);
PrintArray(GetRandomArray(arraySize));


// ************* methods section ***************

int[] GetRandomArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10000, 10000);
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
    
    Console.Write($"{array[array.Length - 1]}]\n");
}



int GetInputNumber(string inputText, IsValid isValid)
{
    string? data;
    
    do
    {
        Console.Write(inputText);
        data = Console.ReadLine();
    }
    while(!isValid(data));

    return Convert.ToInt32(data); ; 
}

bool IsValidNumber(string? data)
{
    if (!(int.TryParse(data, out int number) && number > 0))
    {
        Console.Write("\nError! It's should be natural number\n");
        return false;
    }

    return true;
}

delegate bool IsValid(string? num);
