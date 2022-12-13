Console.WriteLine("введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];

void InputmArray(int[,] matrix)
 {
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
       for(int j = 0; j < matrix.GetLength(1); j++)
       {
          matrix[i, j] = new Random().Next(0, 10);
           Console.Write($"{matrix[i, j]} \t");
       }
        Console.WriteLine();
    }
 } 
 int[,] Transposition(int[,] matrix)
 {
   for(int i = matrix.GetLength(0) - 1; i >= 0; i--)
   {
       for (int j = 0; j < matrix.GetLength(1); j++)
       {
         Console.WriteLine(matrix[j ,i]);
       }
       Console.WriteLine();
   }
   return matrix;
 }
 void Print (int[,] matrix)
 {
   for(int i = 0; i < matrix.GetLength(0); i++)
    {
       for(int j = 0; j < matrix.GetLength(1); j++)
       {
           Console.Write($"{matrix[i, j]} \t");
       }
    }
 }
Console.Clear();
InputmArray(matrix);
Console.WriteLine();
Print(Transposition(matrix));
