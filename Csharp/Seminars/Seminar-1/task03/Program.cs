//Напишите программу которая на вход принимает число N и на выходе
//показывает все целые числа от -N до N

Console.WriteLine("Введите целое число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int numberNN = -numberN;
int i = numberNN;
while (i <= numberN)
{
    Console.Write($"{i}, ");
    i++;
}
