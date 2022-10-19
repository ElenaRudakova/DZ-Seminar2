//  Напишите программу, которая принимает
//  на вход трёхзначное число и на выходе 
//  показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Трехзначное число");
int number_1=Convert.ToInt32(Console.ReadLine());

int number_2=(number_1/10)%10;

Console.WriteLine(number_2);