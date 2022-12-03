//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine ("Введите число и получите третью цифру заданного числа");
var str = Console.ReadLine();

try
{
    //var cut = str.Substring(2,1);
      //Console.WriteLine (cut);

      Console.WriteLine($"{str[2]}"); 
}
catchе
{
    Console.WriteLine ("Третьей цифры нет");
}