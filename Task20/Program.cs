// Задача 20: Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.

// A(3, 6); B(2, 1) -> 5,09
// A(7, -5); B(1, -1) -> 7,21

Console.Write("\nEnter A point coordinates");
int aX = GetInputNumber("\nX: ");
int aY = GetInputNumber("\nY: ");

Console.Write("\nEnter B point coordinates");
int bX = GetInputNumber("\nX: ");
int bY = GetInputNumber("\nY: ");

Console.Write($"\nA({aX}, {aY}); B({bX}, {bY}) -> {GetDistance(aX, aY, bX, bY)}\n");



// ************* methods section ***************
int GetInputNumber(string inputText)
{
    int num;

    Console.Write(inputText);
    num = Convert.ToInt32(Console.ReadLine()); 

    return(num);
}

double GetDistance(int x1, int y1, int x2, int y2)
{
    return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)), 2, MidpointRounding.ToZero);
}