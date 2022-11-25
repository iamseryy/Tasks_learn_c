// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


Random random = new Random();

double[,] randomMatrix = CreateMatrix(random.Next(3, 11), random.Next(3, 11), -100, 100);
Console.WriteLine("\nSource matrix");
PrintMatrix(randomMatrix, 2);
Console.WriteLine("\nSorted matrix");
PrintMatrix(QuickSortMatrixColumns(randomMatrix, SortDirection.DESC), 2);

// ************* methods section ***************

double[,] QuickSortMatrixColumns(double[,] matrix, SortDirection sortDirection = SortDirection.ASC) 
{
    int left = 0;
    int right = matrix.GetLength(1) - 1;
    
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        QuickSortMatrixColumn(matrix, i, left, right, sortDirection);
    }

    return matrix;
}

void QuickSortMatrixColumn(double[,] matrix, int currentRow, int left, int right, SortDirection sortDirection = SortDirection.ASC)
{
    if(matrix.GetLength(1) == 0 || left >= right)
    {
        return;
    }
    
    int i = left;
    int j = right;
    double pivot = matrix[currentRow, (int) (i + (j - i) / 2)];

    while(i <= j)
    {
        while((sortDirection == SortDirection.ASC && matrix[currentRow, i] < pivot) 
                || (sortDirection == SortDirection.DESC && matrix[currentRow, i] > pivot))
        {
            i++;
        }

        while((sortDirection == SortDirection.ASC && matrix[currentRow, j] > pivot) 
                || (sortDirection == SortDirection.DESC && matrix[currentRow, j] < pivot))
        {
            j--;
        }
       
        if(i <= j)
        {
            double temp = matrix[currentRow, i];
            matrix[currentRow, i] = matrix[currentRow, j];
            matrix[currentRow, j] = temp;
            i++;
            j--;
        }

        if(left < j)
        {
            QuickSortMatrixColumn(matrix, currentRow, left, j, sortDirection);
        }

        if(right > i)
        {
            QuickSortMatrixColumn(matrix, currentRow, i, right, sortDirection);
        }
    }
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
     
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if (round >= 0)
            {
                matrix[i, j] = Math.Round(matrix[i, j], round);
            }
            
            Console.Write($"{matrix[i, j], 8}");   
        }

        Console.WriteLine();
    }
}

enum SortDirection
{
    ASC,
    DESC
}