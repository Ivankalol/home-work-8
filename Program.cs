// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2




// int[,] Create2DRandomArray(int rows, int columns,int minValue, int maxValue)
// {
// int[,] myArray = new int[rows, columns];
// for(int i = 0; i < rows;i++)
//     {
// for(int j = 0; j < columns;j++)
//         {
// myArray[i,j] = new Random().Next(minValue, maxValue +1);
//         }
//     }
// return myArray;
// }

// void Show2DArray(int [,] array)
// {
//      for(int i = 0; i < array.GetLength(0);i++)
//     {
//         for(int j = 0; j < array.GetLength(1);j++)
//         {
//            Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] ArraySorting(int [,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             for(int k = 0; k < array.GetLength(1)-1;k++)
//             {
//                 if(array[i,k] < array[i,k + 1])
//                 {
//                     int temp = array[i,k + 1];
//                     array[i,k + 1] = array[i,k];
//                     array[i,k] = temp;
//                 }  
//             }
//         }
//     }
//     return array;
// }


// Console.Write("Введите количество строк ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(rows, columns, minValue, maxValue);

// Show2DArray(myArray);

// myArray = ArraySorting(myArray);

// Show2DArray(myArray);



// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


// int[,] Create2DRandomArray(int rows, int columns,int minValue, int maxValue)
// {
// int[,] myArray = new int[rows, columns];
// for(int i = 0; i < rows;i++)
//     {
// for(int j = 0; j < columns;j++)
//         {
// myArray[i,j] = new Random().Next(minValue, maxValue +1);
//         }
//     }
// return myArray;
// }

// void Show2DArray(int [,] array)
// {
//      for(int i = 0; i < array.GetLength(0);i++)
//     {
//         for(int j = 0; j < array.GetLength(1);j++)
//         {
//            Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int ArrayMinSum(int[,] array)
// { 
//     int sum = 0;
//     int max = 0;
//     int line = 0;
//      for(int i = 0; i < array.GetLength(0); i++)
//     {
       
//         sum = 0;
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             sum = array[i,j] + sum;
//         }
//         if(max < sum)
//         {
//             max = sum;
//             line = i+1;
//         }
//     }
//     return line;
// }

// Console.Write("Введите количество строк ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(rows, columns, minValue, maxValue);
// Console.WriteLine("Array: ");
// Show2DArray(myArray);
// Console.WriteLine($"the largest sum of elements in a row -> {ArrayMinSum(myArray)}");



// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4            a1 b1 | c1 d1       a1*c1+b1*c2   a1*d1+b1*d2
// 3 2 | 3 3            a2 b2 | c2 d2       a2*c1+b2*c2   a2*d1+b2*d2
// Результирующая матрица будет:
// 18 20
// 15 18



// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int[,,] Create3DRandomArray(int rows, int columns, int kub, int minValue, int maxValue)
// {
// int[,,] myArray = new int[rows, columns,kub];
// for(int i = 0; i < rows;i++)
//     {
//         for(int j = 0; j < columns;j++)
//         {
//             for(int k = 0; k < kub;k++)
//             {
//             myArray[i,j,k] = new Random().Next(minValue, maxValue +1);
//             }
//         }
//     }
// return myArray;
// }

// void Show3DArray(int [,,] array)
// {
//      for(int i = 0; i < array.GetLength(0);i++)
//     {
//         for(int j = 0; j < array.GetLength(1);j++)
//         {
//             for(int k = 0; k < array.GetLength(2);k++)
//             {
//             Console.Write($"{array[i,j,k]}{(i,j,k)} ");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
   
// }

// Console.Write("Введите количество строк ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество  ");
// int kub = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,,] myArray = Create3DRandomArray(rows, columns, kub, minValue, maxValue);
// Show3DArray(myArray);



// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

int[,] nums = new int[size, size];

int num = 1;
int i = 0;
int j = 0;

while (num <= size * size)
{
 nums[i, j] = num;
 if (i <= j + 1 && i + j < size - 1)
 ++j;
 else if (i < j && i + j >= size - 1)
 ++i;
 else if (i >= j && i + j > size - 1)
 --j;
 else
 --i;
 ++num;
}

PrintArray(nums);

void PrintArray(int[,] array)
{
 for (int i = 0; i < array.GetLength(0); i++)
    {
 Console.Write("[ ");
 for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}