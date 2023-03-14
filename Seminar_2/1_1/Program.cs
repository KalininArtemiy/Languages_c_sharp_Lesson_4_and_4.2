
void Is_trungle(int a, int b, int c)
{
  if(a < b + c && b < a + c && c < a + b) 
  Console.WriteLine("Yes");
  else 
  Console.WriteLine("No");
}
Console.WriteLine("Enter a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter b");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Enter c");
int c = int.Parse(Console.ReadLine());
Is_trungle(a,b,c);