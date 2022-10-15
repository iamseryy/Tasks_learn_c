// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Input positive integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

string evenNumbers;

if (num > 1) 
{
    evenNumbers = $"Even numbers between 1 and {num}:";
    int count = 2;

    while (count <= num)
    {
        evenNumbers = $"{evenNumbers} {count},";
        count += 2;
    }

    evenNumbers = evenNumbers.TrimEnd(',');
}
else
{
    evenNumbers = $"There are not even numbers between 1 and {num}";
}

Console.WriteLine(evenNumbers);