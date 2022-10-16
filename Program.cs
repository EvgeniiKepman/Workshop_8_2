// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка (нумерация строк начинается с 1)

Console.Clear();

Console.WriteLine("Введите колличество строк: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите колличество рядов: ");
int n = int.Parse(Console.ReadLine());

int[,] matrix = new int[m, n];

Console.WriteLine("Задан массив: ");

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(-9, 9);
        Console.Write($"{matrix[i, j]} ");
    }
Console.WriteLine();
}

int minSumm = 0;
int summ = Summ(matrix, 0);
for (int i = 1; i < matrix.GetLength(0); i++)
{
  int buff = Summ(matrix, i);
  if (summ > buff)
  {
    summ = buff;
    minSumm = i;
  }
}

int Summ(int[,] matrix, int i)
{
  int summ = matrix[i,0];
  for (int j = 1; j < matrix.GetLength(1); j++)
  {
    summ += matrix[i,j];
  }
  return summ;
}

Console.WriteLine($"{minSumm + 1} - строкa с наименьшей суммой элементов = {summ}");
