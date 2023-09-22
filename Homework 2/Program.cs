// Задача 10 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// void Digit2(int num)
// {
//     if (num > 99 && num < 1000)
//     {
//         int secondDigit = (num / 10) % 10;
//         Console.WriteLine($"Second digit is {secondDigit}");
//     }
//     else
//     {
//         Console.WriteLine("Error");
//     }
// }

// Console.Write("Enter the number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Digit2(num);

// -------------------------------------------------------------------------------------------------------------

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// int ThirdDigit(int num)
// {
//     int thirdDigit = num % 10;
//     return thirdDigit;
// }

// Console.WriteLine("Enter the number");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num > 99)
// {
//     int Third = ThirdDigit(num);
//     Console.WriteLine(Third);
// }
// else
// {
//     Console.WriteLine("Третьей цифры нет");
// }

// ---------------------------------------------------------------------------------------

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// void CheckWeeknd(int number)
// {
//     if (number == 6 || number == 7)
//     {
//         Console.WriteLine("Yes");
//     }
//     else if (number <= 0 || number > 7)
//     {
//         Console.WriteLine("Invalid number");
//     }
//     else
//     {
//         Console.WriteLine("No");
//     }

// }

// Console.WriteLine("Input the day of week: ");
// int number = Convert.ToInt32(Console.ReadLine());

// CheckWeeknd(number);
