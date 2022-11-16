// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.




double a = GetInputNumber("\nEnter side of a triangle a: ", IsValidItem);
double b = GetInputNumber("\nEnter side of a triangle b: ", IsValidItem);
double c = GetInputNumber("\nEnter side of a triangle c: ", IsValidItem);

bool triangleExists = CheckSideOfTriangle(a, b, c) 
                        && CheckSideOfTriangle(b, c, a) 
                        && CheckSideOfTriangle(c, a, b);

Console.WriteLine(triangleExists ? "\nSuch a triangle exists" : "\nSuch a triangle not exists");


// ************* methods section ***************

bool CheckSideOfTriangle(double a1, double a2, double a3)
{
    return a1 < a2 + a3;
} 

double GetInputNumber(string inputText, IsValid isValid)
{
    string? data;
    
    do
    {
        Console.Write(inputText);
        data = Console.ReadLine();
    }
    while(!isValid(data));

    return Convert.ToDouble(data); ; 
}

bool IsValidItem(string? data)
{
    if (!(double.TryParse(data, out double number) && number > 0))
    {
        Console.Write("\nError! It's should be positive number\n");
        return false;
    }

    return true;
}

delegate bool IsValid(string? num);
