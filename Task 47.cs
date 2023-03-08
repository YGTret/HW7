double[,] GetMatrix(int rows, int cols, int minValue, int maxValue)
{
    double[,] matrix = new double[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = minValue + new Random().NextDouble() * maxValue;
        }
    }
    return matrix; 
}

void PrintMatrix(double[,] matr) 
{
    for (int i = 0; i < matr.GetLength(0); i++) 
    {
        for (int m = 0; m < matr.GetLength(1); m++) 
        {
            Console.Write(matr[i, m] + "\t"); 
        }
        Console.WriteLine();
    }
}


double[,] resultMatrix = GetMatrix(3,4,0,10);
PrintMatrix(resultMatrix);