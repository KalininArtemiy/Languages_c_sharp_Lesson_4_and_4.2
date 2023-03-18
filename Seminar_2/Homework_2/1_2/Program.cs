void CrossLine(double b1, double k1, double b2, double k2)
{
  if (b1 == b2 && k1 == k2)
  {
    Console.WriteLine("They are similiar");
  }
  else if (k1 == k2)
  {
    Console.WriteLine("They are parallel");
  }
  else 
  {
    double cross_x = (b2 - b1)/(k1 - k2);
    double cross_y = (k1 * (b2 - b1))/(k2 - k1) + b1;
    Console.WriteLine($"cross_x = {cross_x}");
    Console.Write($"cross_y = {cross_y}");
  }
}

Console.WriteLine("enter b1");
int b1 = int.Parse(Console.ReadLine());
Console.WriteLine("enter k1");
int k1 = int.Parse(Console.ReadLine());
Console.WriteLine("enter b2");
int b2 = int.Parse(Console.ReadLine());
Console.WriteLine("enter k2");
int k2 = int.Parse(Console.ReadLine());
CrossLine (b1, k1, b2, k2);