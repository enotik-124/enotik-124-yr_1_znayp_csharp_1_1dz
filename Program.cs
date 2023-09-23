// <Ctrl+K>, <Ctrl+C>, чтобы "закомментировать" блок кода, и <Ctrl+K>, <Ctrl+U> - чтобы "раскомментировать" его.

//                                                         Задача 4: 
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.WriteLine("Введите числa: ");
double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
double c = Convert.ToDouble(Console.ReadLine());
double max;
    if (a > b)
    {
        max = a;
    }
    else
    {
        max = b;
    }
 
    if (c > max)
    {
        max = c;
    }

Console.WriteLine($"Максимальное значение: {max}");
