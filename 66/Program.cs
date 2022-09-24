//  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int sum = 0;
int SumNumbers(int startNumber, int finishNumber)
{
    if (startNumber == finishNumber) return N;

    return (sum = startNumber + SumNumbers(startNumber + 1, finishNumber));
}
SumNumbers(M, N);
Console.WriteLine($"Сумма натуральных чисел от '{M}' до '{N}' равна {sum}");