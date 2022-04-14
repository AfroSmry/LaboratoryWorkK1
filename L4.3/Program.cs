/* Дан вещественный массив x размера n(n=10). Удалить из него элементы, кратные двум (если
такие имеются) и расположить элементы массива по возрастанию. */
//Реализовать удаление индекса
Random random = new();
int deletNumb = 0;
List<double> listDouble = new();

Console.WriteLine("Список заполнен следующими числами");
for (int i = 0; i < 10; i++) {
    listDouble.Add(random.Next());
    Console.WriteLine(listDouble[i]);
}

Console.WriteLine("Удалены следующие числа, кратные 2.");
for (int i = 0; i < listDouble.Count; i++)
{
    if (listDouble[i] % 2 == 0)
    {
        listDouble.Remove(listDouble[i]);
        i--;
        deletNumb++;
    }
}

Console.WriteLine("Было удалено " + deletNumb + " Числа(ел)");
Console.WriteLine("Оставшиеся числа");
foreach (var numb in listDouble)
{
    Console.WriteLine(numb);
}

listDouble.Sort();
Console.WriteLine("Сортированные значения массива по возрвстанию.");
foreach (var numb in listDouble)
{
    Console.WriteLine(numb);
}