﻿// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
int[]array = {0, 1, 1, 0, 0, 0, 1, 1};
int index = 0;
while(index < array.Length)
{
    Console.Write($" {array[index]} ");
    index++;
}

Console.WriteLine();