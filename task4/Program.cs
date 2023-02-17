void FillArray(int[,] matrix)
{
  Random rand = new Random();
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = rand.Next(1, 100);
    }
  }
}
void PrintArray(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      Console.Write(matr[i, j] + " ");
    }
    System.Console.WriteLine();
  }
}
System.Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число l:");
int l = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число k:");
int k = Convert.ToInt32(Console.ReadLine());


int[,] matrixOne = new int[n, m];
int[,] matrixTwo = new int[l, k];
FillArray(matrixOne);
PrintArray(matrixOne);
System.Console.WriteLine();
FillArray(matrixTwo);
PrintArray(matrixTwo);
int[,] Multiplication(int[,] collectionOne, int[,] collectionTwo)
{
  int a;
  int b;
  if (collectionOne.GetLength(0) >= collectionTwo.GetLength(0))
  {
    a = collectionOne.GetLength(0);
  }
  else
  {
    a = collectionTwo.GetLength(0);
  }
  if (collectionOne.GetLength(1) >= collectionTwo.GetLength(1))
  {
    b = collectionOne.GetLength(1);
  }
  else
  {
    b = collectionTwo.GetLength(1);
  }
  int[,] returnArray = new int[a, b];
  for (int i = 0; i < returnArray.GetLength(0); i++)
  {
    for (int j = 0; j < returnArray.GetLength(1); j++)
    {
      returnArray[i, j] = collectionOne[i, j] * collectionTwo[i, j];
      if (collectionOne.GetLength(1) < collectionTwo.GetLength(1))
      {
        returnArray[i, j] = 1 * collectionTwo[i, j];
      }
      System.Console.Write(returnArray[i, j] + " ");
    }
    System.Console.WriteLine();
  }
  return returnArray;
}
System.Console.WriteLine();
int[,] Finish = Multiplication(matrixOne, matrixTwo);


