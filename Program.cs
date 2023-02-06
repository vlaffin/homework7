// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//Console.WriteLine("Здравствуйте,это первая задача №47, она выведет массив с вещественными числами ");

//  double[,] GenerateMaterialArray()
//  {
//      System.Console.WriteLine("Введите количество строк массива: ");
//      int line = int.Parse(Console.ReadLine());
//      System.Console.WriteLine("Введите количество столбцов массива: ");
//      int column = int.Parse(Console.ReadLine());
//      double[,] array = new double[line, column];

//      Random random = new Random();

//      for (int i = 0; i < array.GetLength(0); i++)
//          for (int j = 0; j < array.GetLength(1); j++)
//              array[i, j] = random.NextDouble() * random.Next(-100, 100);

//      return array;
//  }

//  void PrintArray(double[,] array)
//  {
//      for (int i = 0; i < array.GetLength(0); i++)
//      {
//          for (int j = 0; j < array.GetLength(1); j++)
//              Console.Write(Math.Round(array[i, j], 3) + ", ");
//          Console.WriteLine();
//      }
//  }

//  double[,] array = GenerateMaterialArray();
//  PrintArray(array);

//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Console.WriteLine("Здравствуйте,это вторая задача №50, она покажет есть ли элемент который вы ищете в массиве ");

//  int[,] GenerateIntegerArray(int n, int m)
//  {
//      Console.Write("Введите строку:");
//      int indexLine = int.Parse(Console.ReadLine());
//      Console.Write("Введите столбец:");
//      int indexColumn = int.Parse(Console.ReadLine());
//      Random random = new Random();
//      int[,] array = new int[n, m];
//      for (int i = 0; i < array.GetLength(0); i++)
//      {
//          for (int j = 0; j < array.GetLength(1); j++)
//          {
//              array[i, j] = random.Next(10, 99);
//              Console.Write($"{array[i, j]} ");
//          }
//          Console.WriteLine();
//      }
//      if (indexLine < 0 | indexLine > array.GetLength(0) | indexColumn < 0 | indexColumn > array.GetLength(1))
//      {
//          Console.WriteLine("Такого элемента в массиве нет, попробуйте другие значения!");
//      }
//      else
//      {
//          Console.WriteLine($"Значение элемента массива = {array[indexLine, indexColumn]}");
//      }
//      return array;
//  }
//  int[,] array = GenerateIntegerArray(3, 4);


// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Console.WriteLine("Здравствуйте,это третья задача №52, она найдёт среднее арифметическое элементов в каждом столбце");
// Console.Write("эта задача давалась максимально  не легко, пришлось лезть в доп источники)))");

// int[,] MiddleSum()
// {
//     Console.WriteLine("Введите количество строк массива: ");
//     int line = int.Parse(Console.ReadLine());
//     Console.WriteLine("Введите количество столбцов массива: ");
//     int column = int.Parse(Console.ReadLine());
//     int[,] array = new int[line, column];
//     double[] sum = new double[column];
//     double middle = 0;
//     Random random = new Random();

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = random.Next(100);

//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }

//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         for (int j = 0; j < array.GetLength(0); j++)
//         {
//             sum[i] = sum[i] + array[j, i];
//         }
//     }
//     Console.WriteLine("средние арифмитические в каждой колонке равны:");
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         middle = sum[i] / array.GetLength(0);
//         Console.Write(Math.Round(middle, 3) + "  ");
//     }
//     return array;
// }

// MiddleSum();
