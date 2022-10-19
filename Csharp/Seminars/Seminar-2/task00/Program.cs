// Дано число. Проверить кратно ли оно 7 и 23 

Console.WriteLine("Введите число: ");

int number = int.Parse(Console.ReadLine()!);

if (number % 7 == 0 && number % 23 == 0 )
{
    Console.WriteLine($"число {number} кратно 7 и 23");
}
else
{
    Console.WriteLine($"число {number} некратно 7 и 23");
}