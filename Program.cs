//Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите число 1:");
int Number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2:");
int Number2 = Convert.ToInt32(Console.ReadLine());
if (Number1 > Number2)
{
    Console.WriteLine("Большее число - " + Number1);
    Console.WriteLine("Меньшее число - " + Number2);
}
else
{
    Console.WriteLine("Большее число - " + Number2);
    Console.WriteLine("Меньшее число - " + Number1);
}

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите число 1:");
int Num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2:");
int Num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3:");
int Num3 = Convert.ToInt32(Console.ReadLine());
int max = Num1;
if (Num2 > max)
{
    max = Num2;
}
if (Num3 > max)
{
    max = Num3;
}
Console.WriteLine("Максимальное число = " + max);

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число:");
int Number = Convert.ToInt32(Console.ReadLine());
if ( Number % 2 == 0)
{
     Console.WriteLine("Число чётное");
}
else
{
     Console.WriteLine("Число нечётное");
}

// Задача 8: Напишите программу, которая на вход принимает число (N > 0), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
N = Math.Abs(N);
int N2 = 1;
while (N2 <= N)
{
    if (N2 % 2 == 0)
    {
            Console.Write(N2 + ",");
    }
    N2 = N2 + 1;
}
