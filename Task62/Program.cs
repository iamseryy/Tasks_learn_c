// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


PrintMatrix(GetSpiralMatrix(4, 4));


// ************* methods section ***************

int[,] GetSpiralMatrix(int row, int column)
{
    int rowStart = 0;
    int columnStart = 0;
    int rowFinish = row - 1;
    int columnFinish= column - 1;
    int value = 1;
    int[,] matrix = new int[row, column];
    int area = row * column;

    while (value <= area)
    {
        for(int j = columnStart; j <= columnFinish && value <= area; j++)
        {
            matrix[rowStart, j] = value++;
        }
        rowStart++;

        for(int i = rowStart; i <= rowFinish && value <= area; i++)
        {
            matrix[i, columnFinish] = value++;
        }
        columnFinish--;

        for(int j = columnFinish; j >= columnStart && value <= area; j--)
        {
            matrix[rowFinish, j] = value++;
        }
        rowFinish--;

        for(int i = rowFinish; i >= rowStart && value <= area; i--)
        {
            matrix[i, columnStart] = value++;
        }
        columnStart++;
    }

    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {    
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 4}");   
        }

        Console.WriteLine();
    }
}