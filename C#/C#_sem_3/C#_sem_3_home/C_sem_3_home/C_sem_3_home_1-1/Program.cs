﻿//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да


Console.WriteLine("Введите пятизначное число и нажмите Enter, чтобы узнать является ли оно палиндромом");

int n = int.Parse(Console.ReadLine()!);

if (n<100000 && n>9999 || n>-100000 && n<-9999)
{
int a = n/10000;
int b = n/1000; b=b%10;
int c = n%100; c=c/10;
int d = n%10;

if (a==d && b==c)
{
    Console.WriteLine("Введеное число является палиндромом");
}
else
{
    Console.WriteLine("Введеное число не является палиндромом");
}
}
else
{
    Console.WriteLine("Введеное число не является пятизначным");   
}
