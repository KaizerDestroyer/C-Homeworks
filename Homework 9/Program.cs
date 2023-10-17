// Задайте значение N. Напишите программу, которая
// выведет все натуральные числа в промежутке от 1 до N.

// void ShowNumbers(int n)
// {
//     Console.Write($"{n} ");
//     if (n > 1) ShowNumbers(n - 1);
// }

// ShowNumbers(5);
// ---------------------------------------------------

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int ShowValuesSum(int n, int m)
// {
//     if (n > m)
//     {
//         return ShowValuesSum(n, m + 1) + m;
//     }
//     return n;
// }

// int result = ShowValuesSum(10, 5);
// Console.WriteLine(result);
