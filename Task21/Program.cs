// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53



Console.Write("\nEnter A point coordinates");
int aX = GetInputNumber("\nX: ");
int aY = GetInputNumber("Y: ");
int aZ = GetInputNumber("Z: ");

Console.Write("\nEnter B point coordinates");
int bX = GetInputNumber("\nX: ");
int bY = GetInputNumber("Y: "); 
int bZ = GetInputNumber("Z: ");

Console.Write($"\nA({aX}, {aY}, {aZ}); B({bX}, {bY}, {bZ}) -> {GetDistance(aX, aY, aZ, bX, bY, bZ)}\n"); 



// ************* methods section ***************
double GetDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

    return Math.Round(distance, 2, MidpointRounding.ToZero);
}

int GetInputNumber(string inputText)
{
    int num;

    Console.Write(inputText);
    num = Convert.ToInt32(Console.ReadLine());

    return(num);
}