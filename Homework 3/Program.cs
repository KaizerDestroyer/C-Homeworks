// Решение первой задачи как нас учили
// 
// bool PalindromTest(int number)
// {
//     int firstnum = number % 10;
//     int lastnum = number / 10000;
//     int lastnum2 = (number / 10) % 10;
//     int firstnum2 = (number / 1000) % 10;
//     if (firstnum == lastnum && firstnum2 == lastnum2)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }

// Console.Write("Input num: ");
// int Palindrom = Convert.ToInt32(Console.ReadLine());

// if (Palindrom > 99999 || Palindrom < 10000)
// {
//     Console.WriteLine("Число не пятизначное");
//     Console.WriteLine("False");
// }
// else
// {
//     bool res = PalindromTest(Palindrom);
//     Console.WriteLine(res);
// }





// Альтернативное решение первой задачи
// public class Answer
// {
//     static bool IsPalindrome(int number){
//     if (number > 99999 || number < 10000)
// {
//     Console.WriteLine("Число не пятизначное");
//     return false;
// }
//     else
// {
//     int firstnum = number % 10;
//     int lastnum = number / 10000;
//     int lastnum2 = (number / 10) % 10;
//     int firstnum2 = (number / 1000) % 10;
//         if (firstnum == lastnum && firstnum2 == lastnum2)
//         {
//             return true;
//         }
//         else
//         {
//             return false;
//         }
// }

//     }

//   // Не удаляйте и не меняйте метод Main! 
//       static public void Main(string[] args) {
//         int number;

//         if (args.Length >= 1) {
//             number = int.Parse(args[0]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             number = 64546;
//         }



//         // Не удаляйте строки ниже
//         bool result = IsPalindrome(number);
//         System.Console.WriteLine($"{result}");
//     }
// }
// ----------------------------------------------------------------------------------------------

// Задача 3
// Как учили

// void ShowCube(int num)
// {
//     for (int i = 1; i <= num; i++)
//     {
//         int res = i * i * i;
//         Console.WriteLine($"{res}");
//     }
// }

// Console.Write("Enter number: ");
// int numb = Convert.ToInt32(Console.ReadLine());

// if (numb < 0)
//     numb *= 1;
// else if (numb == 0)
//     Console.WriteLine("0");
// ShowCube(numb);
// ----------------------------------------------------------

// Задача 2
// Как нас учили

// double Dist(int x1, int y1, int z1, int x2, int y2, int z2)
// {
//     int x = x2 - x1;
//     int y = y2 - y1;
//     int z = z2 - z1;
//     double res = Math.Round(Math.Sqrt(x * x + y * y + z * z), 2);
//     return res;
// }

// Console.WriteLine("Enter x1 point: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter x2 point: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter y1 point: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter y2 point: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter z1 point: ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter z2 point: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Distance beetween point is {Dist(x1, y1, z1, x2, y2, z2)}");





// Альтернативное решение
// using System;

// public class Answer
// {
//     private static double DistanceBetweenPoints(int[] pointA, int[] pointB)
//     {
//         if (pointA.Length != 3 || pointB.Length != 3)
//         {
//             throw new ArgumentException("Каждая точка должна иметь 3 координаты (x, y, z).");
//         }

//         int deltaX = pointB[0] - pointA[0];
//         int deltaY = pointB[1] - pointA[1];
//         int deltaZ = pointB[2] - pointA[2];

//         double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);

//         return distance;
//     }

//     public static void Main(string[] args)
//     {
//         int x1, x2, x3, y1, y2, y3;

//         if (args.Length >= 6)
//         {
//             x1 = int.Parse(args[0]);
//             x2 = int.Parse(args[1]);
//             x3 = int.Parse(args[2]);
//             y1 = int.Parse(args[3]);
//             y2 = int.Parse(args[4]);
//             y3 = int.Parse(args[5]);
//         }
//         else
//         {
//             // Здесь вы можете поменять значения для отправки кода на Выполнение
//             x1 = 3;
//             x2 = 6;
//             x3 = 8;
//             y1 = 2;
//             y2 = 1;
//             y3 = -7;
//         }

//         // Не удаляйте строки ниже
//         double result = DistanceBetweenPoints(new int[] { x1, x2, x3 }, new int[] { y1, y2, y3 });
//         Console.WriteLine($"{result:F2}");
//     }
// }








// Альтернативное решение
// using System;

// public class Answer
// {
//     static void ShowCube(int N)
//     {
//         for (int i = 1; i <= N; i++)
//         {
//             int res = i * i * i;
//             Console.WriteLine($"{res}");
//         }
//     }

//     // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args)
//     {
//         int N;

//         if (args.Length >= 1)
//         {
//             N = int.Parse(args[0]);
//         }
//         else
//         {
//             // Здесь вы можете поменять значения для отправки кода на Выполнение
//             N = 6;
//         }

//         // Не удаляйте строки ниже
//         ShowCube(N);
//     }
// }