// Сформировать трехмерный массив не повторяющимися двузначными числами 
// показать его построчно на экран выводя индексы соответствующего элемента

Console.Clear();

void FillMatrix( int[, ,] matrix) // Заполняем рандомными числами
{
    for ( int  i = 0; i < matrix.GetLength(0); i++)
    {
        for ( int j = 0; j < matrix.GetLength(1); j++)
        {
            for ( int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = new Random().Next(10,20); 

            }
        }
    }    
}


void PrintMatrix(int [,,] matrix) // функция печати матрицы
{
    for ( int  i = 0; i < matrix.GetLength(0); i++)
    {
        for ( int j = 0; j < matrix.GetLength(1) ; j++)
        {
            for ( int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"Элемент[{i},{j},{k}] = {matrix[i, j, k]} ");
            }
        Console.WriteLine();
        }
    }
}

int[, ,] matrix = new int[2, 2, 2];
FillMatrix(matrix);
PrintMatrix(matrix);