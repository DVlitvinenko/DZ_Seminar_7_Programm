public class Metods
{
  public static int Input(string msg)
  {
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
  }

  public static double[,] CreateMatrix(int rows, int columns)
  {
    return new double[rows, columns];
  }

  public static void FillRandom(double[,] matrix, int minValue = 1, int maxValue = 100)
  {
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
      for (int j = 0; j < columns; j++)
      {
        matrix[i, j] = new Random().NextDouble() +
                      new Random().Next(minValue, maxValue);
      }
    }
  }
  public static void Printing(double[,] matrix)
  {
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
      for (int j = 0; j < columns; j++)
      {
        Console.Write($"{matrix[i, j]:f1} ");
      }
      Console.WriteLine();
    }
  }
}

