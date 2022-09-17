System.Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
 if (a < 100){
    System.Console.WriteLine("третьей цифры нет");
 }
 else{
    int result = a / 100 % 10;
    System.Console.WriteLine($"{a}-->{result}");
 }
