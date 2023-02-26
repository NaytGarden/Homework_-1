using System;
/* ЗАДАЧА 2
    Напишите программу, которая на вход принимает два числа и выдает,
какое число больше, а какое меньше*/
/*
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число");
int b = int.Parse(Console.ReadLine());
int max = a;

if(a == b){Console.WriteLine(max);}
if(a < b){max = b; Console.WriteLine(max);} else{Console.WriteLine(max);}
*/


/* Задача 4: Напишите программу, которая принимает на вход три числа
и выдаёт максимальное из этих чисел.*/
/*
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число");
int c = int.Parse(Console.ReadLine());
int max = a;

if(a == b)
{   //max = a || max = b
    if(max == c)
    {max = c; Console.WriteLine(max);}
    else 
        {if(max > c){Console.WriteLine(max);} 
        else{max = c; Console.WriteLine(max);}}
}
else
{   if(max > b) 
        {if(max == c){Console.WriteLine(max);} 
        else {if(max > c){Console.WriteLine(max);}
        else {max = c; Console.WriteLine(max);}}}
    else 
        {max = b; if(max == c){Console.WriteLine(max);} 
        else {if(max > c){Console.WriteLine(max);}
            else{max = c; System.Console.WriteLine(max);}}}
}
*/


/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
 является ли число чётным (делится ли оно на два без остатка).*/
/*
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());
if(N % 2 == 0){Console.WriteLine("Число является четным");}
else{Console.WriteLine("Число не является четным");}*/



/*  Задача 8: Напишите программу, которая на вход принимает число (N),
а на выходе показывает все чётные числа от 1 до N.*/

Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());
for (int i = 0; i <= N; i++)
{if(i % 2 == 0){Console.WriteLine(i + " Четное число");}}