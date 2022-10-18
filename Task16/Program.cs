// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет


double number1 = GetInputNumber("\nInput a first number: ");
double number2 = GetInputNumber("Input a second number: ");

Console.WriteLine($"\n{number1}, {number2} -> {(IsSquare(number1, number2) ? "yes" : "no")}");



// ************* methods section ***************
double GetInputNumber(string inputText)
{
    Console.Write(inputText);
    double num = Convert.ToDouble(Console.ReadLine());
    return(num);
}

bool IsSquare(double num1, double num2)
{
    return num1 * num1 == num2 || num2 * num2 == num1;
}