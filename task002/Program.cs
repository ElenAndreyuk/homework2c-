// Вывод третьей цифры из числа
Console.WriteLine("Введите число");
string numberString =Console.ReadLine();

int number =Convert.ToInt32(numberString);

if ((number < -99) ^ (number > 99))
{
    char third =numberString[2];
    Console.WriteLine(third);

}
else
{
    Console.WriteLine("Такой цифры нет");
}




