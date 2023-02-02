// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Enter count: ");
int N = Convert.ToInt32(Console.ReadLine());

int a = N / 10000;
int b = N % 10;

int c = N / 1000;
int d = c % 10;

int e = N / 10;
int f = e % 10;

if (a == b && d == f)
{
    Console.WriteLine($"число {N} является палиндромом");
}
else
{
    Console.WriteLine($"число {N} не является палиндромом");
}

// Console.WriteLine(a);
// Console.WriteLine(b);
// Console.WriteLine(c);
// Console.WriteLine(d);
// Console.WriteLine(e);
// Console.WriteLine(f);

