﻿/*Найти максимальное из трех чисел*/

int num1 = new Random().Next(99, 1000); ;
Console.WriteLine(num1);

int num2 = new Random().Next(99, 1000); ;
Console.WriteLine(num2);

int num3 = new Random().Next(99, 1000); ;
Console.WriteLine(num3);

int max = num1;

if (num2 > max) max = num2;
if (num3 > max) max = num3;

Console.Write("max = ");
Console.WriteLine(max);
