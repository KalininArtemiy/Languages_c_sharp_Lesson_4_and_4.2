double[] Mass(int size, double from, double to)
{
  double[] array = new double[size];
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = Math.Round(new Random().NextDouble() * (to - from) + from, 4);
  }
  return array;
}
void Print(double[] array)
{
  for(int i = 0; i < array.Length; i++)
  {
    Console.Write($"{array[i]} ");
  }
  Console.WriteLine();
}

double Count(double[] array)
{
  double max = array[0];
  double min = array[0];
  for(int i = 0; i < array.Length; i++)
  {
    if(array[i] > max)
    {
      max = array[i];
    }
    else if (array[i] < min)
    {
      min = array[i];
    }
  }
  double result = max - min;
  return result;
}



double[] new_array = Mass(int.Parse(Console.ReadLine()), 
double.Parse(Console.ReadLine()),
double.Parse(Console.ReadLine()));
Print(new_array);
Console.WriteLine();
Console.WriteLine(Count(new_array));
