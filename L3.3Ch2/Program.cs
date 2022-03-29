/* Дан массив x целых чисел. Получить упорядоченную по возрастанию последовательность
из чисел, которые встречаются в данном массиве более двух раз(если такие имеются). */

Random random = new();
int arrElements = random.Next(10, 50);
List<int> listStart = new(arrElements);
List<int> listEnd = new();
int counter;
Console.WriteLine("Значения внесенные в список.");

// Заполнение списка.
for (int i = 0; i < arrElements; i++)
{
    listStart.Add(random.Next(1,10));
    Console.Write(listStart[i] + " ");
}
//Поиск совпадений
for (int i = 0; i < listStart.Count; i++)
{
    counter = 0;
    for (int j = 0; j < listStart.Count; j++)
    {
        if (listStart[i] == listStart[j])
        {
            counter++;            
        }

    }
    if (counter > 2)
    {
        bool check = true;
        for (int k = 0; check && k < listEnd.Count; k++)
        {
            if (listEnd[k] == listStart[i])
            {
                check = false;
            }
        }
        if (check)
        {
            listEnd.Add(listStart[i]);
        }
    }
}
Console.WriteLine();
Console.WriteLine("Сортированные повторяющиеся элементы.");
listEnd.Sort();
foreach (var item in listEnd)
{
    Console.Write(item + " ");
}