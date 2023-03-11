// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}


double[,] GenerateMatrix(int m, int n)
{
    double[,] matrix = new double[m, n];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = Math.Round(rand.NextDouble()*10, 2);
        }
    }
    return matrix;
}


void PrintMatrix(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}


int m = ReadInt("Введите количество строк матрицы: m = ");
int n = ReadInt("Введите количество столбцов матрицы: n = ");
var myMatrix = (GenerateMatrix(m, n));
PrintMatrix(myMatrix);