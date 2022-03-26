//С клавиатуры вводятся вещественные числа. Признак конца ввода – 0. Определить количество отрицательных и положительных чисел.


double [] doubleArray = new double[1];
int lees = 0;
int more = 0;

Console.WriteLine("Введите вещественные числа. Ввод дробной части производится через запятую.");

for (int i = 0; i <= doubleArray.Length; i++)
{

    double j = Convert.ToDouble(Console.ReadLine());


    if (j==0)
    {
        Console.WriteLine("Вы ввели число 0 , что означает конец ввода.");
        Console.WriteLine("Вы заполнили массив следующими значениями.");

        for (int z = 0; z< i; z++)
        {
            Console.WriteLine(doubleArray[z]);

            if (doubleArray[z] < 0) lees++;
            else if (doubleArray[z] > 0) more++;
        }

        Console.WriteLine("Положительных чисел");
        Console.WriteLine(more);
        Console.WriteLine("Отрицательных чисел");
        Console.WriteLine(lees);
        break;

    }
    else
        doubleArray [i] = j;
        Array.Resize (ref doubleArray, doubleArray.Length + 1);

}