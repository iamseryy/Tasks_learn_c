//Задача 17: Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X <> 0 и Y <> 0 и выдает номер четверти плосости, в которой находится эта точка.



 Console.Write("\nEnter point coordinates");
int xCoordinate = GetInputNumber("\nX: ");
int yCoordinate = GetInputNumber("\nY: ");

Console.Write($"\nCoordinate plane number: {GetQuarterNum(xCoordinate, yCoordinate)}\n");



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
    if(num == 0 )
    {
        Console.Write("\nError! It's should not be zero!");
        return false;
    }

    return true;
}

int GetQuarterNum(int x, int y)
{
    switch (x, y)
    {
        case (> 0 , > 0): return 1;
        case (< 0 , > 0): return 2;
        case (< 0 , < 0): return 3;
        case (> 0 , < 0): return 4;
    }

    return(0);
}


