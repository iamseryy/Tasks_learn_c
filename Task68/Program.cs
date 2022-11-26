// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29



int paramM = (int) GetInputNumber("\nEnter an integer greater than zero m: ", IsValidNumber);
int paramN = (int) GetInputNumber("\nEnter an integer greater than zero n: ", IsValidNumber);

Console.WriteLine($"\n m = {paramM}, n = {paramN} -> A({paramM}, {paramN}) = {A(paramM, paramN)}\n");




// ************* methods section ***************

long A(long m, long n)
{
    if(m == 0) return n + 1;
    else 
        if(m > 0 && n == 0) return A(m - 1, 1);
        else return A(m - 1, A(m, n - 1));
}

int GetInputNumber(string inputText, IsValid isValid)
{
    string? data;
    
    do
    {
        Console.Write(inputText);
        data = Console.ReadLine();
    }
    while(!isValid(data));

    return Convert.ToInt32(data); ; 
}

bool IsValidNumber(string? data)
{
    if (!(int.TryParse(data, out int number) && number > -1))
    {
        Console.Write("\nError! It's should be not a negative integer\n");
        return false;
    }

    return true;
}

delegate bool IsValid(string? num);