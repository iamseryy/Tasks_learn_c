// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125



int n = GetInputNumber("\nN: ");

Console.WriteLine($"\n{n} ->");
PrintCubeTable(n);


// ************* methods section ***************
void PrintCubeTable(int num)
{
    for (int i = 1; i < num + 1; i++)
    {
        Console.WriteLine($"{i, 6} | {i * i * i, 1}");
    } 
}


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
    if(num < 1)
    {
        Console.Write("\nError! It's should be integer number more then zero ");
        return false;
    }

    return true;
}
