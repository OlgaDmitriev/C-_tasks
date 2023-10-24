System.Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int numberNegative = -number;
while(numberNegative <= number)
{
    System.Console.WriteLine($"{numberNegative}");
    numberNegative++;
}