// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]



int arraySize = GetInputNumber("\nEnter array size: ", IsValidNumber);
PrintArray(GetRandomArray(arraySize));


// ************* methods section ***************

int[] GetRandomArray(int size)
{
    int[] array = new int[size];

    Random random = new Random();

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 2);
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
