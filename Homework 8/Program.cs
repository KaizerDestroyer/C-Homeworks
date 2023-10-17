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

// Задача 1
// void SortMatrix(int[,] array)
// {
//     int rows = array.GetLength(0);
//     int cols = array.GetLength(1);
//     int[,] result = new int[rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         int[] row = new int[cols];
//         for (int j = 0; j < cols; j++)
//         {
//             row[j] = array[i, j];
//         }
//         Array.Sort(row);
//         for (int j = 0; j < cols; j++)
//         {
//             result[i, j] = row[j];
//         }
//     }
//     Show2dArray(result);
// }




// Console.WriteLine("Enter number of rows in array: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number of col in array: ");
// int col = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter min value in array: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter max value in array: ");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter first row: ");
// int[,] newArray = Create2dArray(min, max, row, col);
// Show2dArray(newArray);
// Console.WriteLine();
// SortMatrix(newArray);
// -----------------------------------------------------------

// Задача 2
// void SmallestSumOfRow(int[,] array)
// {
//     int rows = array.GetLength(0);
//     int smallestSum = int.MaxValue;
//     int smallestSumRow = -1;
//     int cols = array.GetLength(1);
//     for (int i = 0; i < rows; i++)
//     {
//         int rowSum = 0;
//         for (int j = 0; j < cols; j++)
//         {
//             rowSum += array[i, j];
//         }

//         if (rowSum < smallestSum)
//         {
//             smallestSum = rowSum;
//             smallestSumRow = i + 1;
//         }
//     }
//     Console.WriteLine($"Наименьшая сумма в строке {smallestSumRow}, сумма = {smallestSum}");

// }

// Console.WriteLine("Enter number of rows in array: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number of col in array: ");
// int col = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter min value in array: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter max value in array: ");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter first row: ");
// int[,] newArray = Create2dArray(min, max, row, col);
// Show2dArray(newArray);
// Console.WriteLine();
// SmallestSumOfRow(newArray);
// ------------------------------------------------------------------


