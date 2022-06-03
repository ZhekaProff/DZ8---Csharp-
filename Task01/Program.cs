// Найти произведение двух матриц

void FillMatrix( int[,] matrix) // Заполняем рандомными числами
{
    for ( int i = 0; i < matrix.GetLength(0); i++)
    {
        for ( int j = 0; j < matrix.GetLength(1) ; j++)
        {
            matrix[i, j] = new Random().Next(0,9); 
        }
    
    }


}

void PrintMatrix(int [,] matrix) // функция печати матрицы
{
    for ( int  i = 0; i < matrix.GetLength(0); i++)
    {
        for ( int j = 0; j < matrix.GetLength(1) ; j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
    Console.WriteLine();
    }
}

int Summa( int [,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
    }
    return sum;
}
Console.Clear();
int [,] matrix  = new int[2, 3];
int [,] matrix2 = new int[4, 2];

FillMatrix(matrix);
FillMatrix(matrix2);
PrintMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrix2);
Console.WriteLine($"Произведение двух матриц ровно: {Summa(matrix) * Summa(matrix2)} ");

