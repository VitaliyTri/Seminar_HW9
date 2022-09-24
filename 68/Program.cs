// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int AkkermanFunction(int startNumber, int finishNumber)
{
    if (startNumber == 0) return (finishNumber + 1);

    if (startNumber > 0 && finishNumber == 0) return AkkermanFunction(startNumber - 1, 1);

    return AkkermanFunction(startNumber - 1, AkkermanFunction(startNumber, finishNumber - 1));
}
AkkermanFunction(m, n);
Console.WriteLine($"A({m},{n}) = {AkkermanFunction(m, n)}");