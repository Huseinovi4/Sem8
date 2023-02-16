void Combination(int[] arr)
{
  var array = arr;
  var group = array.GroupBy(i => i);
  int count = 0;
  foreach (var collection in group)
  {
    if (collection.Count() == 1)
    {
      count++;
      Console.WriteLine($"Элемент {collection.Key} повторяется {collection.Count()} раз");
    }
    else
      Console.WriteLine($"Элемент {collection.Key} повторяется {collection.Count()} раз");
  }
  Console.ReadKey();
}

Console.WriteLine("Введите высоту массива n:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ширину массива m:");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
void FillArray(int[,] matr)
{
  Console.WriteLine("Заполните массив числами");
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      matr[i, j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}

int[] ConvertMass(int[,] mass)
{
  int[] returnToMass = new int[mass.GetLength(1) * mass.GetLength(0)];
  int count = 0;
  for (int i = 0; i < mass.GetLength(0); i++)
  {
    for (int j = 0; j < mass.GetLength(1); j++)
    {
      returnToMass[count] = mass[i, j];
      count++;
    }
  }
  return returnToMass;
}
FillArray(matrix);
int[] arrayMatrix = ConvertMass(matrix);
Combination(arrayMatrix);
