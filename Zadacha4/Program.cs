﻿//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int b = 0;
while(b<=a)
{
    if(b%2==0 && b!=0)
    {
        Console.Write(b + " ");
    }
    b++;
}