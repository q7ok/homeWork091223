// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int FunctionAckermann (int n, int m) {
    if (n == 0) {
        return m + 1;
    } else if (n > 0 && m == 0) {
        return FunctionAckermann(n - 1, 1);
    } else {
        return FunctionAckermann(n - 1, FunctionAckermann(n, m - 1));
    }
}

Console.Write("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(FunctionAckermann(n, m));

