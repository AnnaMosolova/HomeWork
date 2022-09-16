
/*  Напишите программу, которая принимает на вход трёхзначное число и 
на выходе показывает вторую цифру этого числа.  */


/* int n = new Random().Next(100,1000);

int result = n / 10 % 10;

System.Console.WriteLine($"{n}->{result}"); */



/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
является ли этот день выходным. */
/* Console.Write ("Введите номер дня недели: ");
int day = Convert.ToInt32 (Console.ReadLine());

if ( day == 6) {
    System.Console.WriteLine("Выходной");
}
else if ( day == 6) {
    System.Console.WriteLine("Выходной");
}
    
else if ( day == 1){
    System.Console.WriteLine("рабочий день");
}
else if ( day == 2){
    System.Console.WriteLine("рабочий день");
}
else if ( day == 3){
    System.Console.WriteLine("рабочий день");
}
else if ( day == 4){
    System.Console.WriteLine("рабочий день");
}
else if ( day == 5){
    System.Console.WriteLine("рабочий день");
}
else {
    System.Console.WriteLine("Неверный день недели");
} */


 /* Напишите программу, которая выводит третью цифру заданного числа 
 ли сообщает, что третьей цифры нет.
645 -> 6
78 -> третьей цифры нет
32679 -> 6
75742979834 -> 8 */


//int n = new Random().Next(10,1000000000);

/* System.Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine()); */

System.Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = a / 100 % 10;

System.Console.WriteLine($"{a}->{result}");


/* int max = 9;
int d1 = a/100;

if (d1<=max){
    System.Console.WriteLine($"{a} -> {d1}");
        else  (d1 == 0 ){ 
        System.Console.WriteLine("{d1} -> третьей цифры нет");
        }    
}
  */







