// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
// сумма отрицательных равна -20.
int[] Mas(int size, int from, int to)
{
  int[] arr = new int[size];
  for (int i = 0; i < size; i ++)
  {
    arr[i] = new Random().Next(from, to);
  }
  return arr;
}
void PrintMas(int[] arr)
{
  int size = arr.Length;
  for (int i = 0; i < size; i ++)
  {
    Console.Write($"{arr[i]} ");
  }
  Console.WriteLine();
}


void SumPosNeg(int[] arr)
{
  int sum_pos = 0;
  int sum_neg = 0;
  for(int i = 0; i < arr.Length; i++)
  {
    if(arr[i] > 0) sum_pos = sum_pos + arr[i];
    else sum_neg = sum_neg +  arr[i];
  }
  Console.WriteLine(sum_pos);
  Console.WriteLine(sum_neg);
}
int[] arr = Mas(int.Parse(Console.ReadLine()), 
int.Parse(Console.ReadLine()), 
int.Parse(Console.ReadLine()));
PrintMas(arr);
SumPosNeg(arr);
