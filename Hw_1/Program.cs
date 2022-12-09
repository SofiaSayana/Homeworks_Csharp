// Задача 2. Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.

/*
Console.Write("Input a number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 >= num2)
    Console.WriteLine("Max = " + num1);
else
    Console.WriteLine("Max = " + num2);
*/

// Задача 4. Напишите программу, которая принимает на вход три числа  и выдает максимальное из этих чисел.


Console.Write("Input a number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;
if(num2 > max)
    max = num2;
    if(num3 > max)
        max = num3;

Console.WriteLine("Наибольшее число " + max);

