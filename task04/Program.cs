﻿// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7

Console.WriteLine ("Введите первое число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите второе число b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите третье число c: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a>b && a>c)
        Console.WriteLine($"Max = {a}");
else if (a<b && c<b)
        Console.WriteLine($"Max = {b}");
else 
    Console.WriteLine($"Max = {c}");

    