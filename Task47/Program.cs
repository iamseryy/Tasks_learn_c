// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9



int matrixM = (int) GetInputNumber("\nEnter matrix row size m: ", IsValidSize);
int matrixN = (int) GetInputNumber("\nEnter matrix column size n: ", IsValidSize);
double matrixMin = GetInputNumber("\nEnter matrix min element: ", IsValidItem);
double matrixMax = GetInputNumber("\nEnter matrix max element: ", IsValidItem, matrixMin);

 Console.WriteLine($"\nm = {matrixM}, n = {matrixN}.");
 PrintMatrix(CreateMatrix(matrixM, matrixN, matrixMin, matrixMax), 2);
 Console.WriteLine();

// ************* methods section ***************

double[,] CreateMatrix(int rows, int columns, double min, double max)
{
    double[,] matrix = new double[rows, columns];
    Random random = new Random();
    
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.NextDouble() * (max - min) + min;
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

        Console.WriteLine(" |");
    }
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