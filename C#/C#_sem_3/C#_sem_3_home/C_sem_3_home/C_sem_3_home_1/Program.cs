
Console.WriteLine("Введите пятизначное число и нажмите Enter, чтобы узнать является ли оно палиндромом");
var a = Console.ReadLine();

try
{
    var cut1 = a.Substring(0, 1);
    var cut2 = a.Substring(1, 1);
    var cut3 = a.Substring(3, 1);
    var cut4 = a.Substring(4, 1);    

}
catch
{
    Console.WriteLine("Введеное число не является пятизначным");
  
}
if (cut1 == cut4 || cut2 == cut3)
{
    Console.WriteLine("Введёное число является палиндромом");
}
else
{
    Console.WriteLine("Введёное число не является палиндромом");
}