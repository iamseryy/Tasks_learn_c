// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)




double b1 = GetInputNumber("\nEnter b1: ", IsValidTerm);
double k1 = GetInputNumber("\nEnter k1: ", IsValidTerm);
double b2 = GetInputNumber("\nEnter b2: ", IsValidTerm);
double k2 = GetInputNumber("\nEnter k2: ", IsValidTerm, k1);

double x = Math.Round(GetCoordinateX(b1, k1, b2, k2), 1);
double y = Math.Round(GetCoordinateY(b1, k1, x), 1);

Console.Write($"\nb1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}; {y})");


// ************* methods section ***************

double GetCoordinateX(double termB1, double termK1, double termB2, double termK2)
{
    return (termB2 - termB1) / (termK1 - termK2);
}

double GetCoordinateY(double termB1, double termK1, double xCoordinate)
{
    return termK1 * xCoordinate + termB1;
}

double GetInputNumber(string inputText, IsValid isValid, double? term = null)
{
    string? data;
    
    do
    {
        Console.Write(inputText);
        data = Console.ReadLine();
    }
    while(!isValid(data, term));

    return Convert.ToDouble(data); ; 
}

bool IsValidTerm(string? data, double? term = null)
{
    if (!double.TryParse(data, out double number))
    {
        Console.Write("\nError! It's should be number\n");
        return false;
    }

    if (term != null && term == number)
    {
        Console.Write($"\nError! It's should be not equal k1 = {term}, as lines are parallel\n");
        return false;
    }

    return true;
}

delegate bool IsValid(string? num, double? term = null);