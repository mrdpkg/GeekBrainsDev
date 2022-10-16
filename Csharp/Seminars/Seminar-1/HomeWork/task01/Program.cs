// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число: ");
int FirstNumber = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число: ");
int SecondNumber = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите третье число: ");
int ThirdNumber = int.Parse(Console.ReadLine()!);

int [] numbers = {FirstNumber, SecondNumber, ThirdNumber};
for (int i = 0; i < numbers.Length -1; i++)
    {
        int minposition = i;
        for (int j = i + 1; j < numbers.Length; j++)
        {
            if(numbers[j] < numbers[minposition]) minposition = j;
        }
        int temporary = numbers[i];
        numbers[i] = numbers[minposition];
        numbers[minposition] = temporary;
    }

Console.WriteLine();
Console.WriteLine($"{numbers[^1]} ");