// Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
string userInput1 = Console.ReadLine() ?? "";
int num1 = int.Parse(userInput1);
int num2 = 0;

if (num1 > 99)
{
    if (num1 < 1000)
    {
    num2 = num1 % 10; // 543
    Console.WriteLine("Третья цифра числа " + num1 + " - " + num2);
    }
    else if (num1 < 10000)
    {
    num2 = (num1 / 10) % 10; // 5436
    Console.WriteLine("Третья цифра числа " + num1 + " - " + num2);        
    }
    else if (num1 < 100000)
    {
    num2 = (num1 / 100) % 10; // 54361
    Console.WriteLine("Третья цифра числа " + num1 + " - " + num2);        
    }
}
else
{
  Console.WriteLine("Третьей цифры нет");
}
