// void SumNumb(int numb)
// {
//     int res = 0;
//     for (int i = 1; i <= numb; i++)
//         res += i;
//     Console.WriteLine($"Your sum from 1 to {numb} is {res}");
// }

// Console.Write("Enter the number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// SumNumb(num);
// ---------------------------------------------------------------


// void NumbInDec(int num)
// {
//     int count = 0;
//     while (num != 0)
//     {
//         num /= 10;
//         count++;
//     }
//     Console.WriteLine($"Count of num {count}");
// }

// Console.Write("Enter the number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// NumbInDec(num);
// ----------------------------------------------------------

// My method 
// void SumNumb(int numb)
// {
//     int res = 1;
//     for (int i = 1; i <= numb; i++)
//         res *= i;
//     Console.WriteLine($"Your sum from 1 to {numb} is {res}");
// }

// Console.Write("Enter the number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// SumNumb(num);


// From seminar
// void Fact(int n)
// {
//     if (n == 1)
//     {
//         Console.WriteLine($"Your composition is 1");
//     }
//     else
//     {
//         double res = 1;
//         for (int i = 1; i <= n; i++)
//         {
//             res *= i;
//         }
//         Console.WriteLine($"Your composition is {res}");
//     }
// }

// Console.Write("Enter the number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Fact(num);
// --------------------------------------------------------------

// void Odd(int num)
// {
//     for (int i = 1; i <= num; i += 2)
//     {
//         Console.Write(i + " ");
//     }
//     Console.WriteLine();
//     for (int j = 2; j <= num; j += 2)
//     {
//         Console.Write(j + " ");
//     }
// }

// Console.Write("Enter the number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Odd(num);
// ---------------------------------------------------------------

// int[] CreateRandomArray()
// {
//     int[] array = new int[8];
//     for (int i = 0; i < 8; i++)
//     {
//         array[i] = new Random().Next(0, 2);
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

// ShowArray(CreateRandomArray());