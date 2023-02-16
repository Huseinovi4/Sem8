var array = new[] { 1,9,9,0,2,8,0,9 };
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
