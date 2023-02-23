// Задача № 15 Напишите программу которая принимает на вход цифру, 
//обозначающую день недели и проверяет является ли этот день выходным

Console.Write("Введите число: ");
string userInput1 = Console.ReadLine() ?? "";
int day = int.Parse(userInput1);

//выходные дни 6 7 13 14 20 21 27 28

if (day % 7 == 0)
Console.Write("да");
else if (day == 6 || day == 13 || day == 20 || day == 27)
Console.Write("да");
else
Console.Write("нет");
