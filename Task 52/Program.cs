// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using System;

public class Program
{
    public static void Main()
    {
        // Создаем и заполняем двумерный массив
        int[,] array = new int[,]
        {
        {1, 2, 3},
        {4, 5, 6},
        {7, 8, 9}
        };

        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        for (int j = 0; j < cols; j++)
        {
            float sum = 0;

            for (int i = 0; i < rows; i++)
            {
                sum += array[i, j];
            }

            float avg = sum / rows;
            Console.WriteLine("Столбец {0} среднее арифметическое: {1}", j + 1, avg);
        }
        // Вывод массива
        Console.WriteLine("Двумерный массив: ");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write("{0} ", array[i, j]);
            }

            Console.WriteLine();
        }
    }
}
