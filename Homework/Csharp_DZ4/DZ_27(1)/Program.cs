﻿// Задача 27: Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.

//Console.Clear();

string num = Console.ReadLine() ?? ""; 
int lennum = num.Length;

int i = 0;
int sum = 0;
while(i < lennum)
{
    sum = sum + num[i];
    Console.WriteLine($"{sum} = {sum} + {num[i]}");//для наглядности
    i++;
}
Console.WriteLine($"{num} -> {sum}");
//Сломана переменная суммирования, почему то изначально принимает значение не 0, а 48 + i
//Что я только не делал, от преезапуска программы до создания нового репозитория, всё тщетно, 
//Таже история и в онлайн компилятор, гугл не помог, что я делаю не так?)

//Результат компиляции 
//123
//49 = 49 + 1
//99 = 99 + 2
//150 = 150 + 3
//123 -> 150