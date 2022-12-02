Console.WriteLine ("Первая и последняя цифра случайного трехзначного числа");

Random rnd = new Random();

int number = rnd.Next(100, 1000);

Console.WriteLine(number);

int firstPart = number/100;
int secondPart = number%10;

int result =(firstPart*10+secondPart);

Console.WriteLine(result);