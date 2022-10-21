// Задача 22: Напишите программу, которая принимает на вход число (N) 
// и выдает таблицу квадратов чисел от 1 до N.



int n = GetInputNumber("\nN: ");

Console.Write($"Square table from 1 to {n}:\n");

for (int i = 1; i < n + 1; i++)
{
    Console.WriteLine($"{i, 4} {i * i, 4}");
} 



// ************* methods section ***************
int GetInputNumber(string inputText)
{
    int num;

    while(true)
    {
        Console.Write(inputText);
        num = Convert.ToInt32(Console.ReadLine()); 
        
        if (IsValid(num)) 
        {
            break;
        }
    }

    return(num);
}

bool IsValid(int num)
{
    if(num < 2)
    {
        Console.Write("\nError! It's should be integer number more then 1 ");
        return false;
    }

    return true;
}
