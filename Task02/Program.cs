Console.WriteLine("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = number2 * number2;

if(number3 == number1)            
{
    Console.WriteLine("Является ");
}
else
{
    Console.WriteLine("Не Является ");
}

/*
Console.Write("Введите число 1: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int number2 = int.Parse(Console.ReadLine());

if(number2 * number2 == number1)
{
    Console.WriteLine($"Число {number1} являеется квадратом {number2}");
}
else
{
    Console.WriteLine($"Число {number1} не являеется квадратом {number2}");
}
*/
