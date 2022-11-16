// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3



Console.Write("\nEnter numbers separated by spaces: ");

string? line = Console.ReadLine();

double[] numbers = GetNumbers(line?.Split(' '));

PrintArray(numbers);
Console.Write($" -> {(numbers.Length > 0 ? GetNumbersMoreZero(numbers) : 0)}\n");




// ************* methods section ***************

int GetNumbersMoreZero(double[] nums)
{
    int count = 0;
    
    foreach (var item in nums)
    {
        if (item > 0)
        {
            count++;
        }
    }

    return count;
}


double[] GetNumbers(string[]? data)
{
    if (data is null)
    {
        return new double[0];
    }

    double[] nums = new double[data.Length];
    int count = 0;

    foreach (var item in data)
    {
        if (double.TryParse(item, out double number))
        {
            nums[count++] = number; 
        }
    }

    Array.Resize(ref nums, count);

    return nums;
}

 
void PrintArray(double[] array)
{
    Console.Write("\n[");
    
    if(array.Length > 0) 
    {
        for(int i = 0; i < array.Length - 1; i++)
            {
                Console.Write($"{array[i].ToString().Replace(',', '.')}, ");
            }
            
            Console.Write($"{array[array.Length - 1].ToString().Replace(',', '.')}");
    }
    
    Console.Write("]");
}