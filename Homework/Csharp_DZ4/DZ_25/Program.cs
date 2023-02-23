//Задача 25: Напишите цикл, который принимает на вход 
//два числа (A и B) и возводит число A в натуральную степень B.

Console.Clear();

int a = int.Parse(Console.ReadLine() ?? ""); //2
int b = int.Parse(Console.ReadLine() ?? ""); //4

int num = a;

for( int i = 1; i < b; i++)
{
    num = num * a;
}

Console.Write($"{a}, {b} -> {num}");