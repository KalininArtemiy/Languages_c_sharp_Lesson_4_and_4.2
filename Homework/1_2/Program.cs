int[] Mass(int size, int from, int to)
{
  int[] array = new int[size];
  for (int i = 0; i < size; i++)
  {
    array[i] = new Random().Next(from, to);
  }
  return array;
}
void Print(int[] array)
{
  for(int i = 0; i < array.Length; i++)
  {
    Console.Write($"{array[i]} ");
  }
  Console.WriteLine();
}
int Sum(int[] array)
{
  int sum = 0;
  for (int i = 0; i < array.Length; i += 2)
  {
    sum += array[i];
  }
  return sum;
}
int[] arr = Mass(int.Parse(Console.ReadLine()), 
int.Parse(Console.ReadLine()),
int.Parse(Console.ReadLine()));
Print(arr);
Console.WriteLine();
Console.WriteLine(Sum(arr));