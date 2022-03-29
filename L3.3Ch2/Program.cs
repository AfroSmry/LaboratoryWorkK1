/* Дан массив x целых чисел. Получить упорядоченную по возрастанию последовательность
из чисел, которые встречаются в данном массиве более двух раз(если такие имеются). */

Random random = new();
//Console.WriteLine("Введите количество элементов одномерного массива.");
int arrElements = 30;//Convert.ToInt32(Console.ReadLine());
List<int> listStart = new(arrElements);
List<int> listEnd = new();
int counter = 0;
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
    for (int j = i+1; j < listStart.Count; j++)
    {
        if (listStart[i] == listStart[j])
        {
            counter++;
            if (counter == 3)
            {
                listEnd.Add(listStart[i]);
                counter = 0;
            } 
            
        }

    }
}
counter = 0;
Console.WriteLine();
Console.WriteLine("Сортированные повторяющиеся элементы до удаления.");
foreach (var item in listEnd)
{
    Console.Write(item + " ");
}

for (int i = 0; i < listEnd.Count; i++)
{
    for (int j = 1; j < listEnd.Count; j++)
    {
        if (listEnd[i] == listEnd[j])
        {
            counter++;
            if (counter==2 )
            {
                listEnd.Remove(listEnd[j]);
                counter = 0;
                j--;
            }            
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
