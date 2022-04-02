/* Дан текстовый файл, представляющий собой запись арифметического выражения,
операндами которого являются однозначные числа. Число операций в выражении не больше
двух. Вычислить значение этого выражения и дописать его в конец этого файла. */

string path = @"D:\DotNET\laboratory work\LaboratoryWorkK1\L7.3\Ar.txt";
string arifm = "2+2*2";
string text;

using (StreamWriter writer = new StreamWriter(path, false))
{
    await writer.WriteLineAsync(arifm);
}

using (StreamReader reader = new StreamReader(path))
{
    text = await reader.ReadToEndAsync();
    Console.WriteLine(text);
}