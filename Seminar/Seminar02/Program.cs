﻿// Задачка № 9
//Вывод случайного числа из отрезка [10:99]
Console.Clear(); //очистка консоли

int num = new Random().Next(10,100); //вызов числа из диапазона с 10 до 99 (100 не вкл)
int a1 = num / 10; //находим первую цифру числа
int a2 = num % 10; //находим последнюю цифру числа
int max = a1;
if(max < a2)
a2 = max;

Console.WriteLine($"Максимальная цифра в числе {num} это {max}");
