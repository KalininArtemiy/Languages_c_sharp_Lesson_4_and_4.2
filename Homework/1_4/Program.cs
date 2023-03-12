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
int[] Result(int[] arr)
{
  int size = arr.Length;
  int half_size = size / 2 + size % 2;
  int[] new_arr = new int[half_size];
  for(int i = 0; i < size /2; i++)
  { 
    new_arr[i] = arr[i] * arr[size - i - 1];
  }
  if (size % 2 == 1)
  {
    new_arr[half_size - 1] = arr[size/2];
  }
  return new_arr;
}

int[] arr = Mass(int.Parse(Console.ReadLine()), 
int.Parse(Console.ReadLine()),
int.Parse(Console.ReadLine()));
Print(arr);
Console.WriteLine();
int[] result = Result(arr);
Print(result);