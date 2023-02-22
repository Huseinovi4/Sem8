System.Console.WriteLine("Введите размер трехмерного массива:b,n,m:");
int b = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
int[,,] array3D = new int[b, n, m];
int[,,] copyArray = array3D;

void PrintArray(int[,,] matrix)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.WriteLine($"индекс:({i},{j},{k}) - число:{array3D[i, j, k]}");
      }
    }
  }
}


void FillArray(int[,,] matr)
{
  Random rand = new Random();
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      for (int k = 0; k < matr.GetLength(2); k++)
      {
        matr[i, j, k] = Convert.ToInt32(Console.ReadLine());
      }
    }
  }

}



FillArray(array3D);
PrintArray(array3D);

