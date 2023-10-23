Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int y = Convert.ToInt32(Console.ReadLine());
if (y*y == x)
{
    Console.WriteLine("Первое число является квадратом второго числа");
}
else
{
    Console.Write("Не является квадратом");
}
