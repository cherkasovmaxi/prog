﻿//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введите трёхзначное число: ");
int a= int.Parse(Console.ReadLine());
int b=0;
b =a%100;
b=b/10;

Console.WriteLine("Ниже указана вторая цифра заданного числа");
Console.WriteLine(b);