// Задача 10. Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.

/*
int ShowSecondNumber(int num)
{
    int ed = num % 10;
    int sot = num / 100;

   // int result = sot * 10 + ed;
   // return result;
   return sot * 10 + ed;
}

Console.Write("Input a three-digit number: ");
int Num = ShowSecondNumber(int num);

Console.WriteLine($"New version of a number {num} is {Num}");
*/

// Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


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


