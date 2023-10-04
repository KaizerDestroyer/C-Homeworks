// // CONST
// int[] CreateRandomArray(int min, int max, int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }
// ----------------------------------------------

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// void EvenNumbOfArray(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//         {
//             count++;
//         }
//     }
//     Console.WriteLine($"Count of even numbers is {count}");
// }


// Console.Write("Enter min of array: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter max of array: ");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter size: ");
// int size = Convert.ToInt32(Console.ReadLine());


// int[] newArray = CreateRandomArray(min, max, size);
// ShowArray(newArray);
// EvenNumbOfArray(newArray);
// Console.WriteLine("Зачем нам постоянный промежуток, когда мы можем задавать его любым, надеюсь не сочтете за ошибку)");

// ------------------------------------------------------------------------------------------------------------------------------

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// void SumOfOdd(int[] array)
// {
//     int OddNums = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i % 2 != 0)
//         {
//             OddNums += array[i];
//         }
//     }
//     Console.WriteLine($"Sum of odd elements is {OddNums}");
// }

// Console.Write("Enter min of array: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter max of array: ");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter size: ");
// int size = Convert.ToInt32(Console.ReadLine());


// int[] newArray = CreateRandomArray(min, max, size);
// ShowArray(newArray);
// SumOfOdd(newArray);

//----------------------------------------------------------------------------------------------------------------

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// double[] CreateRandomArray(double min, double max, int size)
// {
//     Random random = new Random();
//     double[] array = new double[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = random.NextDouble() * (max - min) + min;
//     }
//     return array;
// }

// void ShowArray(double[] array)
// {
//     Console.WriteLine("Array elements:");
//     foreach (double item in array)
//     {
//         Console.Write(item.ToString("F2") + " ");
//     }
// }


// double SearchOfMax(double[] array)
// {
//     double Maximum = array[0];
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (array[i] > Maximum)
//             Maximum = array[i];
//     }
//     return Maximum;
// }

// double SearchOfMin(double[] array)
// {
//     double Minimum = array[0];
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (array[i] < Minimum)
//             Minimum = array[i];
//     }
//     return Minimum;
// }


// void DiffOfMaxAndMin(double max, double min)
// {
//     double result = max - min;
//     Console.WriteLine($"The diff btw the maximum and minimum is {result:F2}");
// }

// Console.Write("Enter min of array: ");
// double min = Convert.ToDouble(Console.ReadLine());
// Console.Write("Enter max of array: ");
// double max = Convert.ToDouble(Console.ReadLine());
// Console.Write("Enter size: ");
// int size = Convert.ToInt32(Console.ReadLine());


// double[] newArray = CreateRandomArray(min, max, size);
// ShowArray(newArray);


// double maxElement = SearchOfMax(newArray);
// double minElement = SearchOfMin(newArray);
// DiffOfMaxAndMin(maxElement, minElement);
