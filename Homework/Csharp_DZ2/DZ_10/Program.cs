//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Write("Введите трёхзначное число: ");
string userInput1 = Console.ReadLine() ?? "";

int num1 = int.Parse(userInput1);
int secondnum = (num1 / 10) % 10;

Console.WriteLine(secondnum);