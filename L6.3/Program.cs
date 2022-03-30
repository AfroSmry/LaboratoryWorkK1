/* В первых n строчках дан список стран и городов каждой страны. Затем, в следующих m
строчках, даны произвольные названия городов. Для каждого города укажите, в какой стране он
находится. */

List<string> country = new () {"Россия", "Китай", "Индия", "Турция", "Украина"  };
List<string> citiesRus = new() { "Краснодар", "Воронеж", "Пенза", "Ростов", "Тула" };
List<string> citiesChi = new() { "Шанхай", "Пекин", "Харбин", "Чанчжоу", "Лиян" };
List<string> citiesInd = new() { "Мумбаи", "Бангалор", "Дели", "Лакхнау", "Тхана" };
List<string> citiesTur = new() { "Антальяв", "Битез", "Далян", "Стамбул", "Гечек" };
List<string> citiesUkr = new() { "Киев", "Харьков", "Донецк", "Днепр", "Одесса" };
int index=0;

Console.WriteLine("");

foreach (string city in citiesRus)
{
    index++;
    Console.WriteLine(index + " " + city);    
}

foreach (string city in citiesChi)
{
    index++;
    Console.WriteLine(index + " " + city);
}

foreach (string city in citiesInd)
{
    index++;
    Console.WriteLine(index + " " + city);
}

foreach (string city in citiesTur)
{
    index++;
    Console.WriteLine(index + " " + city);
}

foreach (string city in citiesUkr)
{
    index++;
    Console.WriteLine(index + " " + city);
}

Console.WriteLine("Введите номер города, после чего будет выведена страна, в которой он находится.");

int numberCity = Convert.ToInt32(Console.ReadLine());

if (numberCity-1 <= 4)
{
    Console.WriteLine(country[0]);
}

if (numberCity - 1 > 4 & numberCity - 1 <= 9)
{
    Console.WriteLine(country[1]);
}
if (numberCity - 1 > 9 & numberCity - 1 <= 14)
{
    Console.WriteLine(country[2]);
}
if (numberCity - 1 > 14 & numberCity - 1 <= 19)
{
    Console.WriteLine(country[3]);
}
if (numberCity - 1 > 19 & numberCity - 1 <= 24)
{
    Console.WriteLine(country[4]);
}
