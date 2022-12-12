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
 void arithmeticMeanElements(int[,] matrix)
 {
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
       int avarage = 0;
       for(int i = 0; i < matrix.GetLength(0); i++)
   {
       avarage = (avarage + matrix[i, j]);
   }
    avarage = avarage / n;
    Console.WriteLine($"среднее арифметическое элементов в столбце = {avarage} ");
    } 
 }
Console.Clear();
InputmArray(matrix);
arithmeticMeanElements(matrix);
