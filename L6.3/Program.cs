/* В первых n строчках дан список стран и городов каждой страны. Затем, в следующих m
строчках, даны произвольные названия городов. Для каждого города укажите, в какой стране он
находится. */

List<string> country = new () {"Россия", "Китай", "Индия", "Турция", "Украина"  };
List<string> cities = new() { "Краснодар", "Пекин", "Дели", "Стамбул", "Одесса" };
int index=0;

Console.WriteLine("");

foreach (string city in cities)
{
    index++;
    Console.WriteLine(index + " " + city);    
}

Console.WriteLine("Введите номер города, после чего будет выведена страна, в котором он находится.");

int numberCity = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(country[numberCity - 1]);