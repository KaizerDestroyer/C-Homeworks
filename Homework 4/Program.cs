// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// void Degree(int a, int b)
// {
//     int res = 1;
//     for (int i = 0; i < b; i++)
//     {
//         res *= a;
//     }
//     Console.WriteLine($"The {a} in degree {b} is {res}");
// }

// Console.Write("Enter the number: ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter the number: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Degree(a, b);
// -----------------------------------------------------------------------------------------------------------------------------------


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// void SumOfDigits(int num)
// {
//     int res = 0;
//     while (num != 0)
//     {
//         int lastdigit = num % 10;
//         res += lastdigit;
//         num /= 10;
//     }
//     Console.WriteLine(res);
// }

// Console.Write("Enter the number: ");
// int numb = Convert.ToInt32(Console.ReadLine());

// if (numb > 0)
// {
//     SumOfDigits(numb);
// }
// else
// {
//     numb *= (-1);
//     SumOfDigits(numb);
// }
// --------------------------------------------------------------------------------

// Задача 29: Напишите программу, которая задаёт массив из 10 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] FillArray(int num1, int num2, int num3, int num4, int num5, int num6, int num7, int num8, int num9, int num10)\

// int[] CreateArray()
// {
//     int[] array = new int[10];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 100);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.Write("]");
// }

// ShowArray(CreateArray());