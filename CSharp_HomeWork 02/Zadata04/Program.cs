﻿// See https://aka.ms/new-console-template for more information
/*Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.
568 => 5,6,8
8 => 8
9542 => 9,5,4,2
*/ 

Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
{
while (N > 0)
{
int currentDigit = N % 10;
N /= 10;
if (N > 0)
{
Console.Write(currentDigit + ",");
}
else
{
Console.WriteLine(currentDigit);
}
}
}


