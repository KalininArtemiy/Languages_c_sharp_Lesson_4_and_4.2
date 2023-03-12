
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
int Count(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] >= 10 && array[i] < 100)
    {
      count = count + 1;
    }
  }
  return count;
}



int[] new_arr = Mass(123, 10, 1000);
Print(new_arr);
Console.WriteLine(Count(new_arr));