// Задача 2. Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.


Console.Write("Input a number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 >= num2)
    Console.WriteLine("Max = " + num1);
else
    Console.WriteLine("Max = " + num2);
