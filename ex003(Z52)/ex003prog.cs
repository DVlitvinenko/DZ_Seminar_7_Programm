// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом 
// столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
public class ex003prog
{
  public static void ex003()
  {
    // создание массива
    int [,]matrix = Metods.CreateMatrix(
        Metods.Input("Введите количество строк: "),
        Metods.Input("Введите количество столбцов: "));
    // заполнение массива рандомно
    Metods.FillRandom(matrix, 1, 100);
    // вывод массива
    Metods.Printing(matrix);
    // среднеее арифметическое столбцов
    Console.WriteLine();
    Metods.AverageAriphmetic(matrix);
  }
}