﻿// Вид 1
void Method1()
{
    Console.WriteLine("Автор...");
}
//Method1();

// Вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method21(msg: "Вечер добрый",count: 5);
// Method21(count: 2, msg: "Привет");


// Вид 3

int Method3()
{
    return DateTime.Now.Year;
}
// int year = Method3();
// Console.WriteLine(year);

// Вид 4
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while(i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i=0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "q");
//Console.WriteLine(res);


// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         System.Console.WriteLine($"{i} x {j} = {i*j}");
//     }
//     System.Console.WriteLine();
// }


//==============Работа с текстом==========
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы “к” заменить большими “К”, а большие “С” заменить
// маленькими “с”.

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

//string s = "qwerty"
//            012
// s [3] = r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for(int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '|');

// 


//Упорядочить массив
int[] array = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
//PrintArray(array);

void SelectionSort(int[] collection)
{
    int length = collection.Length;
    for(int i = 0; i < length-1; i++)
    {
        int minPosition = i;
        for(int j = i + 1; j < length; j++)
        {
            if(collection[j] < collection[minPosition]) minPosition = j;
        }
        int temporary = collection[i];
        collection[i] = collection[minPosition];
        collection[minPosition] = temporary;
    }
}
PrintArray(array);
SelectionSort(array);
PrintArray(array);