// Показывает вторую цифру из введенного трехзначного числа
Console.WriteLine("Введите трехзначное число ");
int number =Convert.ToInt32(Console.ReadLine());

if ((number > 99) & (number < 1000))
{
   int a = number / 10;
   int b = a % 10;
   Console.WriteLine(b);

}
else
Console.WriteLine("ошибка");



