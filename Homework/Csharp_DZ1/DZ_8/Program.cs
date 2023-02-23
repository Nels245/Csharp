// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите целое число: ");
string userInput1 = Console.ReadLine() ?? "";
int num1 = int.Parse(userInput1);

int count = 2;
while (count <= num1)
{
    if (count % 2 == 0)
    {
        Console.Write(count + " ");
    }
    count += 1;
}
    
