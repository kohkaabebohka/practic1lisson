// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8


Console.WriteLine("введите число");

int S = Convert.ToInt32(Console.ReadLine());
int last_numb = S % 10;
Console.WriteLine (last_numb);