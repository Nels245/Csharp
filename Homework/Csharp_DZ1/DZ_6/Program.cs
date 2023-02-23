// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
Console.Write("Введите целое число: ");
string userInput1 = Console.ReadLine() ?? "";
int num1 = int.Parse(userInput1);

if (num1 % 2 == 0)
{
    Console.WriteLine(num1 + " Чётное число");
}
else
{
    Console.WriteLine(num1 + " Нечётное число");
}