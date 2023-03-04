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

  public static void FindInMatrix( int [,]matrix, int posRow, int posCol)
  {
    int findedNumber = -1;
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
      for (int j = 0; j < columns; j++)
      {
        if (posRow == i & posCol == j)
      {
        findedNumber = matrix[i,j];
      }
      }
    }
      if (findedNumber >=0) 
      Console.Write($"искомое число: {findedNumber}");
      else
      Console.WriteLine("такого числа в массиве нет!");
  }
}