void FillArray (int [,] matrix)
{
  for(int i =0; i < matrix.GetLength(0);i++)
  {
    for(int j = 0; j < matrix.GetLength(1);j++)
    {
      matrix[i,j] = new Random().Next(1,100);
    }
  }
}
void PrintArray (int [,]arr)
{
  for(int i = 0; i < arr.GetLength(0);i++)
  {
    for(int j = 0; j < arr.GetLength(1);j++)
    {
      Console.Write(arr[i,j] + " ");
    }
    Console.WriteLine();
  }
}

System.Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] myArray = new int [n,m];
FillArray(myArray);
PrintArray(myArray);
Console.WriteLine();

void DeleteColAndRow(int[,]collection){
int x = 0;
int y = 0;
int minimal = collection[0, 0];

for (int i = 0; i < collection.GetLength(0); i++)
{
    for (int j = 0; j < collection.GetLength(1); j++)
    {
        if (collection[i, j] < minimal)
        {
            minimal = collection[i, j];
            x = i;
            y = j;
        }
    }
}
for (int i = 0; i < collection.GetLength(0); i++)
{
    for (int j = 0; j < collection.GetLength(1); j++)
    {
        if ((i == x) || (j == y))
            continue;
        else
            Console.Write(collection[i, j] + " ");
    }
    Console.WriteLine();
}
}

DeleteColAndRow(myArray);