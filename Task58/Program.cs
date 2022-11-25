// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



int matrixM1 = (int) GetInputNumber("\nEnter matrix1 row size m: ", IsValidNumber);
int matrixN1 = (int) GetInputNumber("\nEnter matrix1 column size n: ", IsValidNumber);
double[,] randomMatrix1 = CreateMatrix(matrixM1, matrixN1, -100, 100);

Console.WriteLine($"\nMatrix2 row size m: {matrixN1}");
int matrixN2 = (int) GetInputNumber("\nEnter matrix2 column size n: ", IsValidNumber);
double[,] randomMatrix2 = CreateMatrix(matrixN1, matrixN2, -100, 100);

Console.WriteLine("\nMatrix1");
PrintMatrix(randomMatrix1, 2);

Console.WriteLine("\nMatrix2");
PrintMatrix(randomMatrix2, 2);

Console.WriteLine("\nMatrix1 * Matrix2");
PrintMatrix(MultiplyMatrixs(randomMatrix1, randomMatrix2), 2);
Console.WriteLine();

// ************* methods section ***************

double[,] MultiplyMatrixs(double[,] matrix1, double[,] matrix2) 
{
    double[,] matrix = new double[matrix1.GetLength(0), matrix2.GetLength(1)];

    
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = 0;

            for(int k = 0; k < matrix1.GetLength(1); k++)
            {
                matrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
            
        }
    }

    return matrix;
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
            {   Console.WriteLine(i);
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