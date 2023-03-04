public class Metods
{
   public static int Input(string msg)
  {
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
  }

  public static int[,] CreateMatrix(int rows, int columns)
  {
    return new int[rows, columns];
  }

  public static void FillRandom(int[,] matrix, int minValue = 1, int maxValue = 100)
  {
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
      for (int j = 0; j < columns; j++)
      {
        matrix[i, j] = new Random().Next(minValue, maxValue);
      }
    }
  }
  public static void Printing(int[,] matrix)
  {
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
      for (int j = 0; j < columns; j++)
      {
        Console.Write($"{matrix[i, j]} ");
      }
      Console.WriteLine();
    }
  }
public static void AverageAriphmetic(int[,]matrix)
{
  int rows = matrix.GetLength(0);
  int columns = matrix.GetLength(1);
  Console.WriteLine("Среднее арифметическое каждого столбца: ");
  for (int i = 0; i < rows; i++)
  {
    double ariphm = 0;
    for (int j = 0; j < columns; j++)
    {
      ariphm += matrix[i,j]; 
    }
    double result = ariphm/rows;
    Console.Write($"{result}; ");
  }
}
}