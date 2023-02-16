// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

int[,] matrix = FillMatrix(3, 4);
PrintMatrix(matrix);

double[] sum = new double[matrix.GetLength(1)];
for (int i=0; i<matrix.GetLength(1); i++)
{
    for(int j=0; j<matrix.GetLength(0); j++)
    {
        sum[i] += matrix[j, i];
    }
}
System.Console.WriteLine();
for (int i=0; i<matrix.GetLength(1); i++)
{
    Console.Write(sum[i] / matrix.GetLength(0)  + " ");
}





