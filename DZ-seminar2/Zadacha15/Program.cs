﻿// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число");
int number =Convert.ToInt32(Console.ReadLine());

    if (number==6||number==7)
{
    Console.WriteLine("Выходной");
}
    if (number==1||number<=5)
{
    Console.WriteLine("Будни");
} 
    if(number>7)
    {
        Console.WriteLine("Ошибка");
    }