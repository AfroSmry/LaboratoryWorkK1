/* Дан вещественный массив x размера n(n=10). Удалить из него элементы, кратные двум (если
такие имеются) и расположить элементы массива по возрастанию. */

Random random = new();
int deletNumb = 0;
List<int> listInt = new();

Console.WriteLine("Список заполнен следующими числами");
for (int i = 0; i < 10; i++) { 
    listInt.Add(random.Next(1,10));
    Console.WriteLine(listInt[i]);
}

Console.WriteLine("Удалены следующие числа, кратные 2.");
for (int i = 0; i < listInt.Count; i++)
{
    if (listInt[i] % 2 == 0)
    {
        listInt.Remove(listInt[i]);
        i--;
        deletNumb++;
    }
}

Console.WriteLine("Было удалено " + deletNumb + " Числа");
Console.WriteLine("Оставшиеся числа");
foreach (var numb in listInt)
{
    Console.WriteLine(numb);
}

listInt.Sort();
Console.WriteLine("Сортированные значения массива по возрвстанию.");
foreach (var numb in listInt)
{
    Console.WriteLine(numb);
}
