// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого
// столбца: 4,6; 5,6; 3,6; 3.


Random random = new Random();

int[,] randomMatrix = CreateMatrix(random.Next(1, 11), random.Next(1, 11), 1, 100);
Console.WriteLine();
PrintMatrix(randomMatrix);
PrintArray(GetColumnAverages(randomMatrix), 1);
Console.WriteLine();

// ************* methods section ***************



double[] GetColumnAverages(int[,] matrix) 
{
    double[] columnAverages = new double[matrix.GetLength(1)]; 

    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            columnAverages[j] += matrix[i, j];
        }

        columnAverages[j] /= matrix.GetLength(0);
        
    }
    
    return columnAverages;
}

int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random random = new Random();
    
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(min, max + 1);
        }
    }

    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 3}{(j < matrix.GetLength(1) - 1 ? " |" : "")}");   
        }

        Console.WriteLine(" |");
    }
}

void PrintArray(double[] array, int round = -1)
{
    Console.Write("\n[");
    
    for(int i = 0; i < array.Length - 1; i++)
    {
        if (round >= 0)
        {
            array[i] = Math.Round(array[i], round);
        }
        
        Console.Write($"{array[i].ToString().Replace(',', '.')}, ");  
    }
    
    if (round >= 0)
    {
        array[array.Length - 1] = Math.Round(array[array.Length - 1], round);
    }
    
    Console.Write($"{array[array.Length - 1].ToString().Replace(',', '.')}]");
}