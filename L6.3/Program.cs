/* В первых n строчках дан список стран и городов каждой страны. Затем, в следующих m
строчках, даны произвольные названия городов. Для каждого города укажите, в какой стране он
находится. */

int index =0;

var cituCountry = new Dictionary<string, string> 
{ 
    ["Краснодар"]  = "Россия" ,
    ["Шанхай"] = "Китай",
    ["Дели"] = "Индия",
    ["Стамбул"] = "Турция",
    ["Одесса"] = "Украина",
};

List<string> cities = new() { "Краснодар" , "Шанхай" , "Дели" , "Стамбул" , "Одесса" };
cities.Sort();
Console.WriteLine("Список стран.");
Console.WriteLine();
foreach (var item in cituCountry)
{
    Console.WriteLine(item.Value);
}
Console.WriteLine();
Console.WriteLine("Выберите город");
Console.WriteLine();

foreach (var item in cities)
{
    index++;
    Console.WriteLine(index + " " + item);
}
Console.WriteLine();
Console.WriteLine("Введите номер города");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
foreach (var item in cituCountry)
{
    if (item.Key == cities[number - 1])
    {
        Console.WriteLine($"Город: {item.Key} находится в {item.Value}");
    }
}