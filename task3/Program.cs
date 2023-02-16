string text = "Частотный анализ – это один из методов криптоанализа, основывающийся на предположении о существовании нетривиального статистического распределения отдельных символов и их последовательностей как в открытом тексте, так и шифрованном тексте, которое с точностью до замены символов будет сохраняться в процессе шифрования и дешифрования.";
var array = text;
var group = array.GroupBy(i => i);
int count = 0;
foreach (var collection in group)
{
  if (collection.Count() == 1)
  {
    count++;
    Console.WriteLine($"Элемент {collection.Key} встречается ({collection.Count()}) раз. Частота {collection.Count()/(text.Length / 100)}%");
  }
  else
    Console.WriteLine($"Элемент {collection.Key} встречается ({collection.Count()}) раз. Частота {collection.Count()/(text.Length / 100)}%");
}

Console.ReadKey();