// 2. Задайте двумерный массив размера m на n,
//    каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
//    Выведите полученный массив на экран. 

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassSimple(int row, int column)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = i + j;
            // row = 0, column = 0, mean = 0 + 0 = 0
            // row = 0, column = 1, mean = 0 + 1 = 1
            // row = 0, column = 2, mean = 0 + 2 = 2
            // row = 0, column = 3, mean = 0 + 3 = 3

            // row = 1, column = 0, mean = 1 + 0 = 1
            // row = 1, column = 1, mean = 1 + 1 = 2
            // row = 1, column = 2, mean = 1 + 2 = 3
            // row = 1, column = 3, mean = 1 + 3 = 4

    return arr;
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassSimple(row, column);
Print(arr_1);
