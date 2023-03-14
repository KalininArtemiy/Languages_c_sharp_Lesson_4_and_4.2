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
int Count(int[] arr)
{
  int count = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if(arr[i] % 2 == 0) 
    {
      count ++;
    }
  }
  return count;
}
int[] arr = Mass(int.Parse(Console.ReadLine()), 100, 1000);
Print(arr);
Console.WriteLine();
Console.WriteLine(Count(arr));