string[,] table = new string[2,5];
table[1,2] = "word";

for (int rows = 0; rows < 2; rows++)
{
  for (int col = 0; col < 5; col++)
  {
    Console.WriteLine($"-{table[rows, col]}-");
  }
}
