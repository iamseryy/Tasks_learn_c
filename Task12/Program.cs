// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно


int number1 = GetInputNumber("\nInput a first integer: ");
int number2 = GetInputNumber("Input a second integer: ");

int remainderDivision = RemainderDivision(number1, number2);

Console.WriteLine($"\n{number1}, {number2} -> {(remainderDivision > 0 ? $"not a multiple, remainder {remainderDivision}" :  "multiple")}");


// ************* methods section ***************
int GetInputNumber(string inputText)
{
    Console.Write(inputText);
    int num = Convert.ToInt32(Console.ReadLine());
    return(num);
}

int RemainderDivision(int num1, int num2)
{
    return num1 % num2;
}
