﻿//Меняем элементы текста на другие
//string s = "qwerty"
//            012
// s[3] // r

// string text = "– Я думаю, – сказал князь, улыбаясь, – что," +
//               " ежели бы вас послали вместо нашего милого Винценгероде," +
//               " вы бы взяли приступом согласие прусского короля." +
//               " Вы так красноречивы. Вы дадите мне чаю?";

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = " ";

//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }

// string newText = Replace(text, ' ', '|'); //меняем пробелы на вертикалные черточки

// Console.WriteLine(newText);
// Console.WriteLine();

// newText = Replace(newText, 'к', 'К'); // меняем маленькие к на большие К
// Console.WriteLine(newText);

int [] arr = {1,5,4,2,7,3,3,7,2,1,8,3};

void PrintArray(int[] array) //Вывод массива
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int [] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        
    
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);

//ДЗ - сделать упорядочивание в обратном порядке