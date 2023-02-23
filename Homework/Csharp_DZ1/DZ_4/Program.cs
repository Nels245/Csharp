// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите первое целое число: ");
string userInput1 = Console.ReadLine() ?? "";
int num1 = int.Parse(userInput1);

Console.Write("Введите второе целое число: ");
string userInput2 = Console.ReadLine() ?? "";
int num2 = int.Parse(userInput2);

Console.Write("Введите третье целое число: ");
string userInput3 = Console.ReadLine() ?? "";
int num3 = int.Parse(userInput3);

if (num1 > num2)
{
    if (num1 > num3)
    {
        Console.WriteLine(num1 + " - максимальное число");
    }
    else
    {
        Console.WriteLine(num3 + " - максимальное число"); 
    }
}


else if (num2 > num1)
{
    if (num2 > num3)
    {
        Console.WriteLine(num2 + " - максимальное число");
    }
    else
    {
        Console.WriteLine(num3 + " - максимальное число"); 
    }
}

else if (num3 > num1)
{
    if (num3 > num2)
    {
        Console.WriteLine(num3 + " - максимальное число");
    }
    else
    {
        Console.WriteLine(num2 + " - максимальное число"); 
    }
}
