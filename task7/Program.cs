// Написать программу, которая на вход принимает трехзначное число 
// и на выходе показывает последнюю цифру этого числа.

System.Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if(number >=100 && number <= 999)
{
    int digitlast = number % 10;
    System.Console.WriteLine(digitlast);
}
else
{
    System.Console.WriteLine("Вы ввели не трехзначное число");
}