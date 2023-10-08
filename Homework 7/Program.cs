// CONST
int[,] Create2dArray(int min, int max, int row, int col)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}



// ПЕРВАЯ ЗАДАЧА
// double[,] Create2dArray(double min, double max, int row, int col)
// {
//     double[,] array = new double[row, col];
//     Random random = new Random();

//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < col; j++)
//         {
//             double randomValue = random.NextDouble() * (max - min) + min;
//             array[i, j] = Math.Round(randomValue, 2);
//         }
//     }

//     return array;
// }

// void Show2dArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("Enter number of rows in array: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number of columns in array: ");
// int col = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter min value in array: ");
// double min = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Enter max value in array: ");
// double max = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine();
// double[,] array = Create2dArray(min, max, row, col);
// Show2dArray(array);
// -----------------------------------------------------------------


// ВТОРАЯ ЗАДАЧА 

// void ValueOfPosition(int[,] array, int row, int col)
// {
//     if (row < array.GetLength(0) && col < array.GetLength(1))
//     {
//         Console.WriteLine(array[row, col]);
//     }
//     else
//     {
//         Console.WriteLine("Такого значения нет.");
//     }
// }

// Console.WriteLine("Enter number of rows in array: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number of col in array: ");
// int col = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter min value in array: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter max value in array: ");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// int[,] array = Create2dArray(min, max, row, col);
// Show2dArray(array);
// Console.WriteLine();
// Console.WriteLine("Enter row in array: ");
// int row1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter col in array: ");
// int col1 = Convert.ToInt32(Console.ReadLine());
// ValueOfPosition(array, row1, col1);
// ----------------------------------------------------------



// ТРЕТЬЯ ЗАДАЧА

// void ArithmeticMean(int[,] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         for (int j = 0; j < array.GetLength(0); j++)
//         {
//             sum += array[j, i];
//         }
//         double result = (double)sum / array.GetLength(0);
//         result = Math.Round(result, 2);
//         Console.WriteLine($"Arithmetic of {i} column is {result}");
//     }
// }

// Console.WriteLine("Enter number of rows in array: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number of col in array: ");
// int col = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter min value in array: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter max value in array: ");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// int[,] array = Create2dArray(min, max, row, col);
// Show2dArray(array);
// Console.WriteLine();
// ArithmeticMean(array);