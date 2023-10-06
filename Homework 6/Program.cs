// CONST
int[] CreateArray(int min, int max, int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
// ------------------------------------------------------

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
// void NumbersGreaterThan0(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= 0)
//         {
//             count++;
//         }
//     }
//     Console.WriteLine($"Count of numbers greater than zero is {count}");
// }

// Console.Write("Enter min of array: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter max of array: ");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter size: ");
// int size = Convert.ToInt32(Console.ReadLine());


// int[] newArray = CreateArray(min, max, size);
// ShowArray(newArray);
// Console.WriteLine();
// NumbersGreaterThan0(newArray);
// ----------------------------------------------------------------------------

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// void IntersectionPoint(int b1, int k1, int b2, int k2)
// {
//     int x = 0;
//     int y = 0;
//     if (k1 == k2)
//     {
//         Console.WriteLine("Straight lines are parallel");
//     }
//     else
//     {
//         x = (b2 - b1) / (k1 - k2);
//         y = (k1 * x) + b1;
//         Console.WriteLine($"Intersection point is ({x}, {y})");
//     }
// }

// Console.Write("Enter b1: ");
// int b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter k1: ");
// int k1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter b2: ");
// int b2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter k2: ");
// int k2 = Convert.ToInt32(Console.ReadLine());

// IntersectionPoint(b1, k1, b2, k2);