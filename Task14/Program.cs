// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да



int number = GetInputNumber();

Console.WriteLine($"{number} -> {(RemainderDivision(number, 7) == 0 && RemainderDivision(number, 23) == 0 ? "yes" : "no")}");

// ************* methods section ***************
int GetInputNumber()
{
    Console.Write("\nEnter an integer: ");
    int num = Convert.ToInt32(Console.ReadLine());

    return(num);
}


int RemainderDivision(int num1, int num2)
{
    return num1 % num2;
}