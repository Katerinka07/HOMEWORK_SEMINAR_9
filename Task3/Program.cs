/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()!);
}
int AckFunction(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return AckFunction(m - 1, 1);
    return AckFunction(m - 1, AckFunction(m, n - 1));
}
int num1 = InputNum("Введите целое число m: ");
int num2 = InputNum("Введите целое число n: ");
Console.WriteLine($"A({num1},{num2}) = {AckFunction(num1, num2)}");
