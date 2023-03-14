void Fibonachi(int num)
{
  int a = 0;
  int b = 1;
  for( int i = 0; i < num; i++)
  {
    Console.Write(b + " ");
    (b,a) = (a,b+a);
  }
}
int num = 10;
Fibonachi(num);