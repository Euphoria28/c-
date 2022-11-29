//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Не использовать строки
//456 -> 5
//782 -> 8
//918 -> 1

Console.Write("Введите трехзначное число:");
int numbers = Convert.ToInt32(Console.ReadLine());
string stringnumbers = Convert.ToString(numbers);
Console.WriteLine("Вторая цифра числа > "+stringnumbers[1]);