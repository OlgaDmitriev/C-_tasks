Console.Write("Введите номер дня недели: ");
int x = Convert.ToInt32(Console.ReadLine());

if (x == 1)
{
    Console.WriteLine("Понедельник");
}
else if (x==2)
{
    Console.Write("Вторник");
}
else if (x==3)
{
    Console.Write("Среда");
}
else if (x==4)
{
    Console.Write("Четверг");
}
else if (x==5)
{
    Console.Write("Пятница");
}
else if (x==6)
{
    Console.Write("Суббота");
}
else if (x==7)
{
    Console.Write("Воскресенье");
}
else 
{
    Console.Write("Такого дня не существует");
}