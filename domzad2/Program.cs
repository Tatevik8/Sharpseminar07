// **Задача 50.** Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 
//-> такого числа в массиве нет

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}


int[,] GenerateMatrix(int str, int column)
{
    int[,] matrix = new int[str, column];
    Random rand = new Random();
    for (int i = 0; i < str; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i, j] = rand.Next(-10, 11);
        }
    }
    return matrix;
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


void FindNumber(int[,] matr, int str, int column)
{
    if (str < matr.GetLength(0) && column < matr.GetLength(0))
    {
        Console.WriteLine($"Элемент матрицы с позицией [{str},{column}] = {matr[str, column]}.");
    }
    else
    {
        Console.WriteLine($"Элемента матрицы с позицией [{str},{column}] нет.");
    }
}


int[,] matrix = GenerateMatrix(4, 4);
int m = ReadInt("Введите номер строки матрицы, начиная с 0, только целые, положительные числа: m = ");
int n = ReadInt("Введите номер столбца матрицы, начиная с 0, только целые, положительные числа: n = ");
PrintMatrix(matrix);
FindNumber(matrix, m, n);