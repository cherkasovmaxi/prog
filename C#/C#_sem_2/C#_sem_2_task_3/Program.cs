\// Остаток от деления случайных чисел
Random rnd = new Random(); //генератор случ. чисел
int number1 = rnd.Next(10, 100); // случ. число от 10 до 100
Console.WriteLine(number1);
int number2 = rnd.Next(10, 100); // случ. число от 10 до 100
Console.WriteLine(number2);
int result = (number1%number2);
if (result==0)
{
 Console.WriteLine(number1);
 Console.WriteLine("Первое число кратно второму");
 Console.WriteLine(number2);  
}
else
Console.WriteLine("Остаток от деления");
Console.WriteLine(result);