// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)



int m = (int) GetInputNumber("\nEnter 3D Array size m: ", IsValidNumber, 90);

int n;
if((int) (90 / m) == 1)
{
    n = 1;
    Console.WriteLine($"\n3D Array size n: {n}");
}
else
{
    n = (int) GetInputNumber("\nEnter 3D Array size n: ", IsValidNumber, 90 / m);
}


int p;
if((int) (90 / m / n) == 1)
{
    p = 1;
    Console.WriteLine($"\n3D Array size p: {p}");
}
else
{
    p = (int) GetInputNumber("\nEnter 3D Array size p: ", IsValidNumber, 90 / m / n);
}

int [,,] randomNumbers = Create3DArray(m, n, p, 10, 99);

Console.WriteLine("\nResult:");
Print3DArray(randomNumbers);
Console.WriteLine();



// ************* methods section ***************

void Print3DArray(int[,,] targetNumbers)
{
    int count = 0;

    for(int i = 0; i < targetNumbers.GetLength(0); i++)
    {
        for(int j = 0; j < targetNumbers.GetLength(1); j++)
        {
            for(int k = 0; k < targetNumbers.GetLength(2); k++)
            {
                Console.Write($"{targetNumbers[i, j, k]}({i, 2},{j, 2},{k, 2})   ");
                if(count++ == 3)
                {
                    Console.WriteLine();
                    count = 0;
                }
            }
        }
    }
}

int[,,] Create3DArray(int size1, int size2, int size3, int min, int max)
{
    int number;
    int[,,] numbers = new int[size1, size2, size3];
    Random random = new Random();
    
    for(int i = 0; i < numbers.GetLength(0); i++)
    {
        for(int j = 0; j < numbers.GetLength(1); j++)
        {
            for(int k = 0; k < numbers.GetLength(2); k++)
            {
                do 
                {
                    number = random.Next(min, max + 1);
                }
                while(FindNumber(number, numbers));

                numbers[i, j, k] = number;
            }
        }
    }

    return numbers;
}

bool FindNumber(int sourceNumber, int[,,] targetNumbers)
{
    for(int i = 0; i < targetNumbers.GetLength(0); i++)
    {
        for(int j = 0; j < targetNumbers.GetLength(1); j++)
        {
            for(int k = 0; k < targetNumbers.GetLength(2); k++)
            {
                if (targetNumbers[i, j, k] == sourceNumber)
                {
                    return true;
                }
            }
        }
    }

    return false;
}


int GetInputNumber(string inputText, IsValid isValid, int? max = null)
{
    string? data;
    
    do
    {
        Console.Write(inputText);
        data = Console.ReadLine();
    }
    while(!isValid(data, max));

    return Convert.ToInt32(data); ; 
}

bool IsValidNumber(string? data, int? max = null)
{
    if (!(int.TryParse(data, out int number) && number > 0))
    {
        Console.Write("\nError! It's should be natural number\n");
        return false;
    }

    if (max != null && max < number)
    {
        Console.Write($"\nError! It's should be less or equal {max}\n");
        return false;
    }

    return true;
}

delegate bool IsValid(string? num, int? max = null);