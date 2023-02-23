
int number = Convert.ToInt32(Console.ReadLine());


for (int y = 0; y < number; y++)
{
  for (int q = 0; q < number - y; q++)
  {
    System.Console.Write("   ");
  }
  int num = 1;
  for (int x = 0; x <= y; x++)
  {
    System.Console.Write("   {0:D} ", num);
    num = num * (y - x) / (x + 1);
  }
  System.Console.WriteLine();
  System.Console.WriteLine();
}
System.Console.WriteLine();