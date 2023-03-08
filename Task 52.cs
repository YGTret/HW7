int[,] GetMatrix(int rows, int cols, int minValue, int maxValue)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < rows; i++) 
    {

        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
             
        }
             

    }
    return matrix;  
}

int[,] resultMatrix = GetMatrix(3, 4, 0, 10);

void PrintMatrix(int[,] matr) 
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
PrintMatrix(resultMatrix);

for (int i = 0; i < resultMatrix.GetLength(1); i++)
{
    double result = 0.0;
    for (int m = 0; m < resultMatrix.GetLength(0); m++)
    {
        result = result + resultMatrix[m, i];
    }

    result = result / resultMatrix.GetLength(0);
    Console.WriteLine(result);
}

