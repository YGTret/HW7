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

Console.WriteLine("Введите ряд ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбец");
int cols = Convert.ToInt32(Console.ReadLine());

PrintMatrix(resultMatrix);

if (rows < resultMatrix.GetLength(0) && cols < resultMatrix.GetLength(1))
{
    Console.WriteLine(resultMatrix[rows,cols]);
}
else
{
    Console.WriteLine("Элемента с данными номерами ряда и колоннки - не существует ");
}