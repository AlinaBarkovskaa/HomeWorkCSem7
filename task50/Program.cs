void InputmArray(int[,] matrix)
 {
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
       for(int j = 0; j < matrix.GetLength(1); j++)
       {
          matrix[i, j] = new Random().Next(0, 21);
           Console.Write($"{matrix[i, j]} \t");
       }
        Console.WriteLine();
    }
 } 
void searchElementPositions (int[,] matrix, int number1, int number2)
{
   if(number1 > matrix.GetLength(0) || number2 > matrix.GetLength(1))
     {
         Console.WriteLine("Tакой позиции в массиве нет");
     }else
     {
             
       Console.WriteLine($"значение элемента {number1} строки и {number2} столбца = {matrix[number1-1,number2-1]}");
     }
 }
  
Console.Clear();
Console.WriteLine("Введите размер матрицы: ");
string[] numbers = Console.ReadLine().Split(" ");
int[,] matrix = new int[int.Parse(numbers[0]), int.Parse(numbers[1])];
InputmArray(matrix);
Console.WriteLine("Введите позицию элемента n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию элемента m: ");
int m = Convert.ToInt32(Console.ReadLine());
searchElementPositions(matrix, n, m);