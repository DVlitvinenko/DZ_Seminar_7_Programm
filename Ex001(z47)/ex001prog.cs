// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
public class ex001prog
{
  public static void ex001()
  {
  //задать массив
  double [,] matrix = Metods.CreateMatrix(
                      Metods.Input("Введите количество строк: "),
                      Metods.Input("Введите количество столбцов: ")); 
  //заполнить рандомно вещественнными
  Metods.FillRandom(matrix);
  //вывести массив
  Metods.Printing(matrix);
  }
}