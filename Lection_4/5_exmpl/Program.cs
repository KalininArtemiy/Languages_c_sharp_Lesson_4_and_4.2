// Factorial

int Fac (int n)
{
  if (n == 1) return 1;
  else return n * Fac(n-1);
}
Console.WriteLine(Fac(3));