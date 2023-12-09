// Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

void ShowTheNumbers (int m, int n) {
    if (n < m) return;
    Console.Write(m + " ");
    ShowTheNumbers(m + 1, n);
}

Console.Write("Введите минимальное значение: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int n = Convert.ToInt32(Console.ReadLine());

ShowTheNumbers(m, n);