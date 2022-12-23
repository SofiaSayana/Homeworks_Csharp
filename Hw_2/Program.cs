// Задача 10. Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.

/*
int ShowSecondNumber(int num)
{
    int a = num % 100;
    int b = a / 10;

    return b;
}

Console.Write("Input a three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
int newNum = ShowSecondNumber(num);

Console.WriteLine($"New version of a number {num} is {newNum}");
*/

// Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*
Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine());

int count = 0;
int num = number;

while (num > 0)
{
    num = num / 10;
    count++;
}

if (count < 3)
{
    Console.WriteLine("У числа нет третьей цифры");
}

else
{
    int[] array = new int[count];
    int index = array.Length - 1;

    while(number > 0)
    {
        array[index] = number%10;
        number = number/10;
        index--;
    }
    Console.WriteLine(array[2]);
}
*/

// Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*
bool Holiday(int num)
{
    if(num == 6 || num == 7)
    return true;
    else
    return false;
}
Console.WriteLine("Введите цифру от 1 до 7:");
int num = int.Parse(Console.ReadLine());

bool result = Holiday(num);

Console.WriteLine(result);
*/