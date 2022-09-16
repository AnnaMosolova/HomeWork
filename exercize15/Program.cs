// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.Write ("Введите номер дня недели: ");
int day = Convert.ToInt32 (Console.ReadLine());

if ( day == 6) {
    System.Console.WriteLine("Выходной");
}
else if ( day == 7) {
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
}