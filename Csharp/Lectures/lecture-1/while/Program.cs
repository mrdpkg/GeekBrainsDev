﻿Console.Clear();

int xa = 40, ya = 1,
    xb = 1, yb = 40,
    xc = 80, yc = 40;

Console.SetCursorPosition(xa,ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb,yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc,yc);
Console.WriteLine("+");

int x = xa, y = ya;
int count = 0;
while (count < 5000)
{
    int randomNumber = new Random().Next(0,3);

    if(randomNumber == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if(randomNumber == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if(randomNumber == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    
    Console.SetCursorPosition(x,y);
    Console.WriteLine("+");
    count++;
}