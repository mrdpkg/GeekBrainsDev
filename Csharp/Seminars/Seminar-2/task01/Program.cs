﻿// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0 

Console.WriteLine("Определение номера четверти плоскости");

Console.WriteLine("Введите первую координату: ");
int x =  int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите вторую координату: ");
int y =  int.Parse(Console.ReadLine() ?? "0");

if (x > 0 && y > 0)
{
    Console.WriteLine("Номер четверти - 1");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Номер четверти - 2");
    
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Номер четверти - 3");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Номер четверти - 4");
}
