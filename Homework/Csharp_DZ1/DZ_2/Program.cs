// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите первое целое число: ");
string userInput1 = Console.ReadLine() ?? "";
int num1 = int.Parse(userInput1);

Console.Write("Введите второе целое число: ");
string userInput2 = Console.ReadLine() ?? "";
int num2 = int.Parse(userInput2);

if (num1 > num2)
{
    Console.WriteLine(num1 + " больше чем " + num2);
}
else
{
    Console.WriteLine(num2 + " больше чем " + num1);
}
