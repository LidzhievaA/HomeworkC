﻿// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//  4 -> да
// -3 -> нет

Console.WriteLine ("Введите  число: ");
int number = Convert.ToInt32(Console.ReadLine());

int n = number%2;
if (n == 0)
    Console.WriteLine("Является чётным");
else if (n==1)
        Console.WriteLine("Не является чётным");
