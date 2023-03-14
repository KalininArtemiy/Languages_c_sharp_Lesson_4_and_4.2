string From_Ten_code_to_twice_code(int num)
{
  string result = "";
  while(num > 0)
  {
    result =  num % 2 + result ;
    num = num / 2;
  }
  return result;
}

Console.WriteLine(From_Ten_code_to_twice_code(int.Parse(Console.ReadLine())));

