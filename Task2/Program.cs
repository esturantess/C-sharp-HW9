// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    else if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
    else return 0;
}

Random rand = new Random();
int M = rand.Next(0, 4);
int N = rand.Next(0, 4);
if (M >= 0 && N >= 0)
{
    Console.WriteLine($"Функция Аккермана с аргументами {M} и {N} = {Akkerman(M, N)}.");
}
else Console.WriteLine($"Нельзя вычислить функцию Аккермана, поскольку входные числа {M} и {N} меньше нуля.");