// Напишите программу, которая на вход принимает число, 
// возвращает индексы этого элемента в двумерном массиве или же указание, 
// что такого числа нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

int[,] FillMatrix(int rows, int cols)
{
    int[,] matr = new int[rows, cols];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matr[i, j] = rand.Next(0, 10);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void SearchNumber(int[,] matrix)
{
    int number = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == number)
            {
                System.Console.WriteLine($"{i}, {j}");
            }
            if (matrix[i, j] != number)
            {
                System.Console.WriteLine("Такого числа нет");
            }
        }
    }
}

int[,] matrix = FillMatrix(3, 3);
PrintMatrix(matrix);
System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
SearchNumber(matrix);




