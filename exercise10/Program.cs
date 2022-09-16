//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

/* int n = new Random().Next(100,1000);

int result = n / 10 % 10;

System.Console.WriteLine($"{n}->{result}"); */


System.Console.WriteLine("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = n / 10 % 10;

System.Console.WriteLine($"{n}->{result}");