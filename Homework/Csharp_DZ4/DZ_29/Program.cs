// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.Clear();

int [] array = new int[8]; 
FillArray(array);
PrintArray(array);

//Логика ------------------------------------------

void FillArray(int [] array) 
{
    int i = 0;
    int len = array.Length;
    while(i < len)
    {
        array[i] = new Random().Next(0,10);
        i++;    
    }
}

void PrintArray(int [] array) //выводим массив
{
    int i = 0;
    int len = array.Length;
    while (i < len)
    {
        Console.Write(array[i] + " ");
        i++;
    }
}

