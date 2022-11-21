// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



int matrixM = (int) GetInputNumber("\nEnter matrix row size m: ", IsValidNumber);
int matrixN = (int) GetInputNumber("\nEnter matrix column size n: ", IsValidNumber);
double[,] randomMatrix = CreateMatrix(matrixM, matrixN, -100, 100);

Console.WriteLine();
PrintMatrix(randomMatrix, 2);
Console.Write($"\nThe line with the minimum amount: {FindMinSumRow(randomMatrix)}");
Console.WriteLine();

// ************* methods section ***************

int FindMinSumRow(double[,] matrix) 
{
    double sum = 0;
    double min = 0;
    int row = 0;

     for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }

        if(i == 0 || min > sum)
        {
            row = i;
            min = sum;
        }

        sum = 0;
    }

    return row + 1;
}

double[,] CreateMatrix(int rows, int columns, double min, double max, int round = -1)
{
    double[,] matrix = new double[rows, columns];
    Random random = new Random();
    
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.NextDouble() * (max - min) + min;
            
            if(round > -1)
            {
                 matrix[i, j] = Math.Round(matrix[i, j], round);
            }
        }
    }

    return matrix;
}


void PrintMatrix(double[,] matrix, int round = -1)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if (round >= 0)
            {
                matrix[i, j] = Math.Round(matrix[i, j], round);
            }

            Console.Write($"{matrix[i, j], 10}{(j < matrix.GetLength(1) - 1 ? " |" : "")}");   
        }

        Console.WriteLine($" |");
    }
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