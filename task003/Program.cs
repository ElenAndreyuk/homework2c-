// Соответствует ли цифра выходному дню
Console.WriteLine("Введите число от 1 до 7");
int day =Convert.ToInt32(Console.ReadLine());

if((day == 6) ^ (day == 7))
{
    Console.WriteLine("выходной");
}
if((day < 6) & (day > 0))
{
    Console.WriteLine("не выходной");
}
else
{
    Console.WriteLine("ошибка");
}