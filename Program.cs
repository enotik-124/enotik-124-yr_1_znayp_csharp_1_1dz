﻿// <Ctrl+K>, <Ctrl+C>, чтобы "закомментировать" блок кода, и <Ctrl+K>, <Ctrl+U> - чтобы "раскомментировать" его.


//                                                        Задача 2: 
//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

System.Console.WriteLine("Введите числa: ");
System.Console.Write("а = ");
double a = Convert.ToDouble(Console.ReadLine());
System.Console.Write("b = ");
double b = Convert.ToDouble(Console.ReadLine());

double max, min;
    if (a > b)
    {
        max = a;
    }
    else
    {
        max = b;
    }


        if (a < b)
    {
        min = a;
    }
    else
    {
        min = b;
    }
Console.WriteLine($"Максимальное значение: {max}");
Console.WriteLine($"Минимальное значение: {min}");

//                                                         Задача 4: 
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// System.Console.WriteLine("Введите числa: ");
//System.Console.Write("а = ");
// double a = Convert.ToDouble(Console.ReadLine());
//System.Console.Write("b = ");
// double b = Convert.ToDouble(Console.ReadLine());
//System.Console.Write("c = ");
// double c = Convert.ToDouble(Console.ReadLine());
// double max;
//     if (a > b)
//     {
//         max = a;
//     }
//     else
//     {
//         max = b;
//     }
 
//     if (c > max)
//     {
//         max = c;
//     }

// Console.WriteLine($"Максимальное значение: {max}");


