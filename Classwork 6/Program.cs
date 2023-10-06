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
// -------------------------------------------------------


// int[] ReverseArray(int[] array)
// {
//     int sizeArr = array.Length;
//     for (int i = 0; i < sizeArr / 2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[sizeArr - 1 - i];
//         array[sizeArr - 1 - i] = temp;
//     }
//     return array;
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
// ShowArray(ReverseArray(newArray));

// -----------------------------------------------------------


// bool IsTriangle(int a, int b, int c)
// {
//     return a + b > c && a + c > b && b + c > a;
// }



// Console.Write("Input first part: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second part: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input third part: ");
// int c = Convert.ToInt32(Console.ReadLine());


// if (IsTriangle(a, b, c))
// {
//     Console.WriteLine("triangle can be alive");
// }
// else
// {
//     Console.WriteLine("You died!");
// }


// -------------------------------------------------------------


// int BinaryNumber(int Decimal)
// {
//     int result = 0;
//     int power = 0;
//     while (Decimal > 0)
//     {
//         result += Decimal % 2 * Convert.ToInt32(Math.Pow(10, power));
//         power++;
//         Decimal /= 2;
//     }
//     return result;
// }
// ---------------------------------------------------------------------


// void PrintFibonachi(int n, int firstnumfib, int secondnumfib)
// {
//     int[] fibnum = new int[n];
//     fibnum[0] = firstnumfib;
//     fibnum[1] = secondnumfib;
//     Console.Write(fibnum[0] + " ");
//     Console.Write(fibnum[1] + " ");
//     for (int i = 2; i < n; i++)
//     {
//         fibnum[i] = fibnum[i - 1] + fibnum[i - 2];
//         Console.Write(fibnum[i] + " ");
//     }
// }

// Console.Write("Enter n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter first num: ");
// int firstnumfib = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter second num: ");
// int secondnumfib = Convert.ToInt32(Console.ReadLine());


// if (n >= 0 && firstnumfib < secondnumfib)
// {
//     PrintFibonachi(n, firstnumfib, secondnumfib);
// }
// else
// {
//     Console.WriteLine("Error!");
// }

// -----------------------------------------

int FindMaxValue(int[] array)
{
    int max = array[0];
    int index = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
            index = i;
        }
    }
    int[] temp = new int[array.Length - 1];
    for (int j = 0; j < index - 1; j++)
    {
        temp[j] = array[j];
    }
    for (int k = index; k < array.Length; k++)
    {
        temp[k] = array[k + 1];
    }
    array = temp;
    return max;
}

Console.Write("Enter min of array: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter max of array: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter size: ");
int size = Convert.ToInt32(Console.ReadLine());


int[] newArray = CreateArray(min, max, size);
ShowArray(newArray);
Console.WriteLine($"{FindMaxValue(newArray)}");
Console.WriteLine($"{FindMaxValue(newArray)}");