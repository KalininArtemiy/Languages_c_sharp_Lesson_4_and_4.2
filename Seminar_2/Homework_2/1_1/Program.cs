int Value ()
{
  Console.Write("How many symbols are you going write?");
  int num = int.Parse(Console.ReadLine());
  return num;
}


int[] enter_mass(int num)
{
  int[] arr = new int[num];
  for (int i=0; i < arr.Length; i++)
  {
    arr[i] = int.Parse(Console.ReadLine());
  }
  return arr;
}

void up_zero(int[] arr)
{
  int count = 0;
  for (int i=0; i < arr.Length; i++)
  {
    if( arr[i] > 0)
    {
      count = count +1;
    } 
  }
  Console.WriteLine(count);
}


void Print(int[] array)
{
  for(int i = 0; i < array.Length; i++)
  {
    Console.Write($"{array[i]} ");
  }
  Console.WriteLine();
}

int symbols = Value();
int[] new_arr = enter_mass(symbols);
Print(new_arr);
Console.WriteLine();
up_zero(new_arr);