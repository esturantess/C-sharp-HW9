// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int NaturalNumbersSum(int leftBorder, int rightBorder)
{
    if (leftBorder == rightBorder) return rightBorder;
    else
    {
        int sum = leftBorder + NaturalNumbersSum(leftBorder + 1, rightBorder);
        return sum;
    }
}

Random rand = new Random();
int leftBorder = rand.Next(1, 11);
int rightBorder = rand.Next(10, 15);

if (leftBorder < rightBorder)
{
    Console.WriteLine($"Сумма натуральных чисел в промежутке от {leftBorder} до {rightBorder} включительно = {NaturalNumbersSum(leftBorder, rightBorder)}.");
}
else if (leftBorder > rightBorder)
{
    Console.WriteLine($"Сумму натуральных чисел в промежутке от {leftBorder} до {rightBorder} вычислить невозможно, т.к. {leftBorder} больше {rightBorder}.");
}
else System.Console.WriteLine($"Сумма натуральных чисел в промежутке от {leftBorder} до {rightBorder} включительно: {leftBorder}.");