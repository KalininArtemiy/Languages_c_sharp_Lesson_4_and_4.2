int[] Mas(int size, int from, int to)
{
  int[] arr = new int[size];
  for(int i = 0; i < size; i++)
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

void Revers(int[] arr)
{
  int size = arr.Length;
  for (int i = 0; i < size / 2; i++)
  {
    (arr[i], arr[size - i - 1]) = (arr[size - i - 1], arr[i]);
  }
  
}
int[] arr = Mas(int.Parse(Console.ReadLine()), 
int.Parse(Console.ReadLine()), 
int.Parse(Console.ReadLine()));
PrintMas(arr);
Revers(arr);
PrintMas(arr);