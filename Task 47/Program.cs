// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

class Program
{
    static void Main()
    {
        // Запрос у пользователя размера массива m и n
        Console.Write("Введите количество строк: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите количество столбцов: ");
        int n = int.Parse(Console.ReadLine());

        // Создаем двумерный массив
        double[,] array = new double[m, n];

        // Создаем генератор случайных чисел
        Random random = new Random();

        // Заполняем массив случайными вещественными числами
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = random.NextDouble();
            }
        }

        // Вывод массива 
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
