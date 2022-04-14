/* В первых n строчках дан список стран и городов каждой страны. Затем, в следующих m
строчках, даны произвольные названия городов. Для каждого города укажите, в какой стране он
находится. */

/* Альтернативное решение через ввод назвния города 
 string.Equals("строка 1","строка 2", System.StringComparison.CurrentCultureIgnoreCase)
*/

int index =0;
List<string> cities = new ();

var cituCountry = new Dictionary<string, List<string>> 
{ 
    ["Россия"]  = new List<string> { "Краснодар", "Воронеж", "Пенза", "Ростов", "Тула" },
    ["Китай"] = new List<string> { "Шанхай", "Пекин", "Харбин", "Чанчжоу", "Лиян" },
    ["Индия"] = new List<string> { "Мумбаи", "Бангалор", "Дели", "Лакхнау", "Тхана" },
    ["Турция"] = new List<string> { "Антальяв", "Битез", "Далян", "Стамбул", "Гечек" },
    ["Украина"] = new List<string> { "Киев", "Харьков", "Донецк", "Днепр", "Одесса" },
};

Console.WriteLine("Список стран.");
Console.WriteLine();

foreach (var item in cituCountry)
{
    Console.WriteLine(item.Key);
}

foreach (var item in cituCountry)
{
    for (int i = 0; i < item.Value.Count; i++)
    {
        cities.Add(item.Value[i]);
    }    
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
    for (int i = 0; i < item.Value.Count; i++)
    {
        if (cities[number - 1] == item.Value[i])
        {
            Console.WriteLine($"Город: {item.Value[i]}  находится в {item.Key}");
        }
    }        
}