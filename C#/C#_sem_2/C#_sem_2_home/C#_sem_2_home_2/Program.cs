﻿//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine ("Введите число, нажмите Enter и получите третью цифру заданного числа");
string a = Console.ReadLine();

try
{
    string cut = a.Substring(2,1);
      Console.WriteLine (cut);  
}
catch
{
    Console.WriteLine ("Третьей цифры нет");
}