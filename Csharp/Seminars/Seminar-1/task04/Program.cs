//Напишите программу которая на вход принимает 3 значное число
//а на выходе будет показывать последнюю цифру числа

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int LastNumber = number % 10;
Console.WriteLine(LastNumber);