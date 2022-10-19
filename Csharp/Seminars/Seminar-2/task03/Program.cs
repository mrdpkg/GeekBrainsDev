// Программа проверяет любое число на палиндромом. 
Console.Clear();

// Console.WriteLine("Введите число: ");

// int number = int.Parse(Console.ReadLine() ?? "0");
// int CopyNumber = number;
// int reverse = 0;

// while (CopyNumber > 0)
// {
//     int digit = CopyNumber % 10;
//     reverse = reverse * 10;
//     reverse = reverse + digit;
//     CopyNumber = CopyNumber / 10;
// }
// if(number == reverse)
// {
//     Console.WriteLine("Polindrom");
// }
// else
// {
//     Console.WriteLine("Not Polindrom");
// }


Console.WriteLine("Введите число: ");

int number = int.Parse(Console.ReadLine() ?? "0");
int CopyNumber = number;
int reverse = 0;

while (CopyNumber > 0)
{
    int digit = CopyNumber % 10;
    reverse = reverse * 10 + CopyNumber % 10;
    CopyNumber/= 10;
}
if(number == reverse)
{
    Console.WriteLine("Polindrom");
}
else
{
    Console.WriteLine("Not Polindrom");
}

