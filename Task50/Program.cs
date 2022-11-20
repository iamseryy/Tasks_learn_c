// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента
// в массиве нет



Random random = new Random();

double[,] randomMatrix = CreateMatrix(random.Next(1, 11), random.Next(1, 11));
Console.WriteLine();
PrintMatrix(randomMatrix);
int m = GetInputNumber("\nEnter matrix row position m: ", IsValidNumber);
int n = GetInputNumber("\nEnter matrix column position n: ", IsValidNumber);

Console.Write($"\n {m}, {n} -> ");
Console.Write($"{(FindMatrixItem(randomMatrix, m, n, out double? matrixItem) ? matrixItem : "Matrix Item is absent")}");
Console.WriteLine();

// ************* methods section ***************

bool FindMatrixItem(double[,] matrix, int rowPosition, int columnPosition, out double? matrixItem) 
{
    if(rowPosition - 1 >= matrix.GetLength(0) || columnPosition - 1 >= matrix.GetLength(1))
    {
        matrixItem = null; 
        return(false);
    }

    matrixItem = matrix[rowPosition - 1, columnPosition - 1];
    return true;
}

double[,] CreateMatrix(int rows, int columns)
{
    double[,] matrix = new double[rows, columns];
    Random random = new Random();
    
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(random.NextDouble() * 200 - 100, 1);
        }
    }

    return matrix;
}


void PrintMatrix(double[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 7}{(j < matrix.GetLength(1) - 1 ? " |" : "")}");   
        }

        Console.WriteLine(" |");
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