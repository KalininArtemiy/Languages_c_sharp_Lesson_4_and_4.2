// положительные элементы замените на соответствующие отрицательные, и наоборот.
int[] Mass(int size, int from, int to)
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
  for(int i = 0; i < size; i++)
  {
    arr[i] = -arr[i];
  }
}
int [] new_arr = Mass(int.Parse(Console.ReadLine()),
int.Parse(Console.ReadLine()),
int.Parse(Console.ReadLine()));
PrintMas(new_arr);
Revers(new_arr);
PrintMas(new_arr);