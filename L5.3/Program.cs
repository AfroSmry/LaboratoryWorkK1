/* Выполнить обработку элементов прямоугольной матрицы a, имеющей n строк и m
столбцов. Найти наименьший элемент столбца матрицы a, для которого сумма
абсолютных значений элементов максимальна. */

Random random = new();

int numberN = 2;
int numberM = 4;

int summ0 = 0;
int summ1 = 0;

int[,] arrayA = new int[numberN, numberM];
int[] arrayFirst = new int[numberM];
int[] arraySecond = new int[numberM];

for (int i = 0; i < numberN; i++)
{
    for (int j = 0; j < numberM; j++)
    {
        arrayA[i, j] = random.Next(1, 20);
        
        if (i<1)
        {
            arrayFirst[j] = arrayA[i, j];
            summ0 += arrayFirst[j];
        }
        if (i>0)
        {
            arraySecond[j] = arrayA[i, j];
            summ1 += arraySecond[j];
        }
        Console.Write(arrayA[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine(summ0);
Console.WriteLine(summ1);

if (summ0 > summ1)
{
    var minFirst = arrayFirst.Cast<int>().AsParallel().WithExecutionMode(ParallelExecutionMode.ForceParallelism);
    Console.WriteLine("Минимальное число первого столбца = " + minFirst.Min());
}
else

if (summ1 > summ0)
{
    var minSecond = arraySecond.Cast<int>().AsParallel().WithExecutionMode(ParallelExecutionMode.ForceParallelism);
    Console.WriteLine("Минимальное число второго столбца = " + minSecond.Min());
}
else
if (summ0 == summ1)
{
    var minFirst = arrayFirst.Cast<int>().AsParallel().WithExecutionMode(ParallelExecutionMode.ForceParallelism);
    var minSecond = arrayFirst.Cast<int>().AsParallel().WithExecutionMode(ParallelExecutionMode.ForceParallelism);
    int firstResult = minFirst.Min();
    int secondResult = minSecond.Min();

    if (firstResult < secondResult)
    {
        Console.WriteLine("Минимальное число первого столбца = " + firstResult);
    }

    if (firstResult > secondResult)
    {
        Console.WriteLine("Минимальное число второго столбца = " + secondResult);
    }

    if (firstResult == secondResult)
    {
        Console.WriteLine("\n\nЭто было маловероятно, но случилось следующее: \nСумма значений столбцов матрицы равны." +
            " \nСумма чисел первого столбца: {0} \nСумма чисел второго столбца: {1} \nНаименьшие значения обоих столбцов равны: {2} -- {3}", summ0, summ1 , firstResult, secondResult);
    }
}