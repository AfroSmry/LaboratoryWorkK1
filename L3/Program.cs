/*. Дана строка, состоящая из слов. Преобразовать строку, перенося слова с повторяющимися символами в конец этой строки, 
    оставляя только один символ в каждой последовательности подряд идущих одинаковых символов. */
using System.Text.RegularExpressions;


/*
string enterString = ("ссылаться на кого-то.");
char cha = ' ';

for (int i = 0; i < enterString.Length; i++)
{
    if (enterString[i] == cha)
    {
        
    }
}*/

string pattern = @"\b(\w+?)\s\1\b";

string str = "Мама авТо гриБ Яблоко яБлоко ябЛоко яблОко яблоКо яблокО";

foreach (Match match in Regex.Matches(str, pattern, RegexOptions.IgnoreCase))
    Console.WriteLine("{0} (duplicates '{1}') at position {2}",
                      match.Value, match.Groups[1].Value, match.Index);