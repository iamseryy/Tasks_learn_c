// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98


int randomNumber = new Random().Next(100, 1000);
Console.WriteLine($"{randomNumber} -> {RemoveSecondDigit(randomNumber)}");



// ************* methods section ***************
int RemoveSecondDigit(int num)
{
    return ((int)(num / 100)) * 10 + num % 10;
}
