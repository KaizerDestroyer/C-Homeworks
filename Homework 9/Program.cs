// Задайте значение N. Напишите программу, которая
// выведет все натуральные числа в промежутке от 1 до N.

// void ShowNumbers(int n)
// {
//     Console.Write($"{n} ");
//     if (n > 1) ShowNumbers(n - 1);
// }

// ShowNumbers(5);
// ---------------------------------------------------

int ShowValuesSum(int n, int m)
{
    if (n > m)
    {
        return ShowValuesSum(n, m + 1) + m;
    }
    return n;
}

int result = ShowValuesSum(10, 5);
Console.WriteLine(result);