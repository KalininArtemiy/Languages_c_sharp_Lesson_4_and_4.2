// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.
int[] Mass(int size, int from, int to)
{
  int[] arr = new int[size];
  for(int i = 0; i < size; i++)
  {
    arr[i] = new Random().Next(from, to);
  }
  return arr;
}
void PrintMass(int[] arr)
{
  for (int i = 0; i < arr.Length; i++)
  {
    Console.Write($"{arr[i]} ");
  }
  Console.WriteLine();
}


void findN(int[] array, int n)
{
  for (int i = 0; i < array.Length; i++)
  {
    if(array[i] == n)
    {
      Console.WriteLine( "Yes");
      return;
    };
  }
  Console.WriteLine("No");
}
int[] new_arr = Mass(10, -10, 10);
PrintMass(new_arr);
int num = 4;
Console.WriteLine(num);
findN(new_arr, num);