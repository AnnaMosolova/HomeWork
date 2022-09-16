System.Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = a / 100 % 10;
System.Console.WriteLine($"{a}->{result}");

