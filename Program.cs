using System;
/* ЗАДАЧА 2
    Напишите программу, которая на вход принимает два числа и выдает,
какое число больше, а какое меньше*/

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число");
int b = int.Parse(Console.ReadLine());
int max = a;

if(a == b){Console.WriteLine(max);}
if(a < b){max = b; Console.WriteLine(max);} else{Console.WriteLine(max);}
