// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// bool Palindrom(string s)



// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*
double Distance(double xA, double yA, double zA, double xB, double yB, double zB)
{
    double catet1 = xB - xA;
    double catet2 = yB - yA;
    double catet3 = zB - zA;
    double result = Math.Sqrt(Math.Pow(catet1, 2) + Math.Pow(catet2, 2) + Math.Pow(catet3, 2));
    return result;
}
Console.Write("Введите значение х для точки A: ");
double xA = double.Parse(Console.ReadLine());

Console.Write("Введите значение y для точки A: ");
double yA = double.Parse(Console.ReadLine());

Console.Write("Введите значение z для точки A: ");
double zA = double.Parse(Console.ReadLine());

Console.Write("Введите значение х для точки B: ");
double xB = double.Parse(Console.ReadLine());

Console.Write("Введите значение y для точки B: ");
double yB = double.Parse(Console.ReadLine());

Console.Write("Введите значение z для точки B: ");
double zB = double.Parse(Console.ReadLine());

double result = Math.Round(Distance(xA, yA, zA, xB, yB, zB), 2);

Console.WriteLine("Расстояние между точками А и В: " + result);
*/

// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*
void Cube(int num)
{
    for (int i = 1; i <= num; i++)
    {
        double degree = Math.Pow(i, 3);
        Console.Write(degree + " ");
    }
}
Console.WriteLine("Введите целое число: ");
int number = int.Parse(Console.ReadLine());

Cube(number);
*/
